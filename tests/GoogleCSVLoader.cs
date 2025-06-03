using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Core;
using DSLApp1.Tests;

namespace DSLApp1.Tests
{
    using System.Text;
    using ConsoleApp3.Core;
}

namespace Components.Root
{
    public class GoogleCsvLoader
    {
        private readonly string sheetId;
        private static readonly HttpClient httpClient = new();

        public GoogleCsvLoader(string sheetId)
        {
            this.sheetId = sheetId;
        }
        
        private static string GetCachePath(string sheetId, string sheetName)
        {
            var baseDir = Path.Combine(Path.GetTempPath(), "google_sheet_cache", sheetId);
            Directory.CreateDirectory(baseDir); // safe to call repeatedly
            return Path.Combine(baseDir, $"{sheetName}.csv");
        }
        
        private string GetSheetUrl(string sheetName)
        {
            return $"https://docs.google.com/spreadsheets/d/{sheetId}/gviz/tq?tqx=out:csv&sheet={sheetName}";
        }

        public async Task<List<string[]>> LoadCsvLines(string sheetName, bool useCache = false)
        {
            var cacheFile = GetCachePath(sheetId, sheetName);

            if (useCache && File.Exists(cacheFile))
            {
                Log.Info($"[GoogleCsvLoader] Loading sheet '{sheetName}' from cache: {cacheFile}");
                var cached = await File.ReadAllLinesAsync(cacheFile);
                return cached
                    .Where(l => !string.IsNullOrWhiteSpace(l))
                    .Select(ParseCsvLine)
                    .ToList();
            }

            var url = GetSheetUrl(sheetName);
            Log.Info($"[GoogleCsvLoader] Fetching sheet: {sheetName} ({url})");

            HttpResponseMessage response;
            try
            {
                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0");
                response = await httpClient.GetAsync(url);
            }
            catch (Exception ex)
            {
                Log.Error($"[GoogleCsvLoader] Network error for sheet '{sheetName}': {ex.Message}");
                throw;
            }

            if (!response.IsSuccessStatusCode)
            {
                Log.Error($"[GoogleCsvLoader] Sheet fetch failed: {sheetName} — HTTP {(int)response.StatusCode} {response.ReasonPhrase}");
                throw new HttpRequestException($"Google Sheet fetch failed: {sheetName} — HTTP {response.StatusCode}");
            }

            var content = await response.Content.ReadAsStringAsync();

            // Save to cache
            if (useCache)
            {
                try
                {
                    await File.WriteAllTextAsync(cacheFile, content);
                    Log.Info($"[GoogleCsvLoader] Cached '{sheetName}' to {cacheFile}");
                }
                catch (Exception ex)
                {
                    Log.Warning($"[GoogleCsvLoader] Failed to write cache for '{sheetName}': {ex.Message}");
                }
            }

            var lines = content.Split('\n').Where(l => !string.IsNullOrWhiteSpace(l)).ToList();

            return lines.Select(ParseCsvLine).ToList();
        }


        public async Task<List<Dictionary<string, string>>> LoadCsvRecords(string sheetName)
        {
            var lines = await LoadCsvLines(sheetName);
            if (lines.Count < 2)
            {
                Log.Warning($"[GoogleCsvLoader] Sheet '{sheetName}' has fewer than 2 rows — skipping");
                return new List<Dictionary<string, string>>();
            }

            var headers = lines[0];
            var records = new List<Dictionary<string, string>>();

            for (int i = 1; i < lines.Count; i++)
            {
                var values = lines[i];

                if (values.Length != headers.Length)
                {
                    Log.Warning($"[GoogleCsvLoader] Row {i + 1} in sheet '{sheetName}' has {values.Length} fields (expected {headers.Length}) — skipping");
                    continue;
                }

                try
                {
                    var record = headers.Zip(values, (h, v) => new { h, v })
                        .ToDictionary(x => x.h.Trim(), x => x.v.Trim());
                    records.Add(record);
                }
                catch (Exception ex)
                {
                    Log.Error($"[GoogleCsvLoader] Error parsing row {i + 1} in sheet '{sheetName}': {ex.Message}");
                    throw;
                }
            }

            Log.Info($"[GoogleCsvLoader] Parsed {records.Count} valid record(s) from sheet '{sheetName}'");
            return records;
        }

        public static string[] ParseCsvLine(string line)
        {
            var values = new List<string>();
            var current = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (c == '"')
                {
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        current.Append('"');
                        i++;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {
                    values.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }

            values.Add(current.ToString());
            return values.ToArray();
        }
    }
}
