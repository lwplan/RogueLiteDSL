using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Components.Root;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using DSLApp1.Dsl;
using Pidgin;
using Xunit;
using Xunit.Abstractions;
using System.Text.RegularExpressions;

namespace DSLApp1.Tests.Dsl
{
    /// <summary>
    /// Reads <c>TestData/abilities.csv</c> and checks each ProposedDSL line
    /// against the DSL parser.  Lines flagged <c>Pass</c> must parse while
    /// entries marked <c>Fail</c> must not.  The <c>Fail</c> cases are only
    /// evaluated when the <c>TEST_FAILS</c> environment variable is set to
    /// <c>1</c>.
    /// </summary>
    public sealed class AbilityDslCsvTests
    {
        
        private readonly ITestOutputHelper _output;
        private static readonly Task<List<object[]>> CachedRows = LoadRows();
        private static readonly List<MacroDefinition> Macros = LoadMacros();

        public AbilityDslCsvTests(ITestOutputHelper output) => _output = output;

        private static string GetTestDataPath(string fileName)
        {
            // When tests are executed with '--no-build' the working directory
            // contains a copied TestData folder under bin/Debug/netX.Y.  This
            // causes stale data to be used if abilities.csv was modified after
            // the previous build.  To ensure the latest changes are read we
            // resolve the path relative to the project directory instead of the
            // output directory.

            var projectDir = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
            return Path.Combine(projectDir, "TestData", fileName);
        }

        public static async Task<List<object[]>> LoadRows()
        {
            var csvPath = GetTestDataPath("abilities.csv");
            using var reader = new StreamReader(csvPath);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null,
                MissingFieldFound = null,
            };
            using var csv = new CsvReader(reader, config);
            var records = csv.GetRecords<AbilityRow>().ToList();

            return records.Select(r => new object[] { r }).ToList();
        }

        private static List<MacroDefinition> LoadMacros()
        {
            var csvPath = GetTestDataPath("macros.csv");
            if (!File.Exists(csvPath))
                throw new FileNotFoundException("macros.csv not found", csvPath);

            var lines = File.ReadAllLines(csvPath)
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .ToArray();
            if (lines.Length == 0)
                return new();

            var headers = GoogleCsvLoader.ParseCsvLine(lines[0]);
            var records = new List<Dictionary<string, string>>();
            for (int i = 1; i < lines.Length; i++)
            {
                var values = GoogleCsvLoader.ParseCsvLine(lines[i]);
                var record = headers.Zip(values, (h, v) => new { h, v })
                    .ToDictionary(x => x.h.Trim(), x => x.v.Trim());
                records.Add(record);
            }

            var macros = new List<MacroDefinition>();
            var argPattern = new Regex(@"(?<name>\w+)#\[(?<values>[\d,\s]+)\]");
            foreach (var record in records)
            {
                if (!record.TryGetValue("@Keyword[X]", out var rawKeyword) ||
                    !record.TryGetValue("macro", out var macroBody))
                    continue;

                record.TryGetValue("Class", out var macroClass);
                record.TryGetValue("Tool Tip", out var tooltip);

                var indexArgs = new Dictionary<string, List<int>>();
                string template = macroBody;
                foreach (Match m in argPattern.Matches(macroBody))
                {
                    var argName = m.Groups["name"].Value;
                    var values = m.Groups["values"].Value
                        .Split(',')
                        .Select(v => int.TryParse(v.Trim(), out var n) ? n : -1)
                        .Where(n => n >= 0)
                        .ToList();

                    indexArgs[argName] = values;
                    template = template.Replace(m.Value, argName);
                }

                var nameMatch = Regex.Match(rawKeyword, @"@(?<name>\w+)\[\w+\]");
                if (!nameMatch.Success) continue;

                var name = "@" + nameMatch.Groups["name"].Value;
                macros.Add(new MacroDefinition(name, template, indexArgs, macroClass ?? "", tooltip ?? ""));
            }
            return macros;
        }

        public record AbilityRow
        {
            public string Name { get; set; } = string.Empty;
            public string Test { get; set; } = string.Empty;
            public string? Legacy { get; set; }
            [Name("Syntax Check")]
            public string SyntaxCheck { get; set; } = string.Empty;
            public string ProposedDSL { get; set; } = string.Empty;
        }

        public static IEnumerable<object[]> CsvRows()
        {
            return CachedRows.Result;
        }

        [Theory]
        [MemberData(nameof(CsvRows))]
        public void Csv_ProposedDsl_Matches_CurrentGrammar(AbilityRow row)
        {
            // skip rows explicitly marked as Unimplemented
            if (string.Equals(row.Test, "Unimplemented", StringComparison.OrdinalIgnoreCase))
                return;

            var expanded = Regex.Replace(
                row.ProposedDSL,
                @"@\w+\[[IVXLCDM]+\]",
                m => MacroExpander.Expand(m.Value, Macros));

            var tokens = DslTokenizer.Tokenize(expanded);
            var result = DslParsers.HexParser.Parse(tokens);

            if (string.Equals(row.Test, "Pass", StringComparison.OrdinalIgnoreCase))
            {
                Assert.True(result.Success, $"Expected '{row.Name}' to parse successfully, but it failed.");
            }
            else if (string.Equals(row.Test, "Fail", StringComparison.OrdinalIgnoreCase))
            {
                Assert.False(result.Success, $"Expected '{row.Name}' to fail parsing, but it succeeded.");
            }
            else
            {
                // if the status is neither Pass nor Fail, write it for diagnostic purposes
                _output.WriteLine($"Unknown test status '{row.Test}' for row '{row.Name}'");
            }
        }
    }
}
