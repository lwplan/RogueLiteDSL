using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DSLApp1.Dsl;
using Components.Root;
using Xunit;

namespace DSLApp1.Tests
{
    public class MacroCsvExpansionTests
    {
        private static readonly List<MacroDefinition> Macros = LoadMacros();

        private static List<MacroDefinition> LoadMacros()
        {
            var csvPath = Path.Combine(AppContext.BaseDirectory, "TestData", "macros.csv");
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
            var argPattern = new Regex(@"(?<name>\w+)#\((?<values>[\d,\s]+)\)");
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

        public static IEnumerable<object[]> MacroData()
        {
            var romans = new[] { "I", "II", "III", "IV", "V" };
            foreach (var macro in Macros)
            {
                if (!macro.IndexArgs.TryGetValue("X", out var values))
                    continue;
                for (int i = 0; i < values.Count && i < romans.Length; i++)
                {
                    var input = $"{macro.Name}[{romans[i]}]";
                    var expected = macro.Template.Replace("X", values[i].ToString());
                    yield return new object[] { input, expected };
                }
            }
        }

        [Theory]
        [MemberData(nameof(MacroData))]
        public void Macros_FromCsv_Expand_Correctly(string input, string expected)
        {
            var result = MacroExpander.Expand(input, Macros);
            Assert.Equal(expected, result);
        }
    }
}
