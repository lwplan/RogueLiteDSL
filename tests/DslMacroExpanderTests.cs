using System;
using System.Collections.Generic;
using Xunit;
using DSLApp1.Dsl;

namespace DSLApp1.Tests
{
    public class DslMacroExpanderTests
    {
        private readonly List<MacroDefinition> _macros = new()
        {
            new MacroDefinition(
                "@Burn",
                "Deals Fire Physical(X#[4,6,7,9,10]) damage",
                new Dictionary<string, List<int>> { ["X"] = new() { 4, 6, 7, 9, 10 } },
                "Debuff",
                "Deals Fire damage"
            ),
            new MacroDefinition(
                "@Frozen",
                "Deals Ice Physical(X#[4,6,7,9,10]) damage",
                new Dictionary<string, List<int>> { ["X"] = new() { 4, 6, 7, 9, 10 } },
                "Debuff",
                "Deals Ice damage"
            ),
            new MacroDefinition(
                "@Strength",
                "Buff(X#[4,6,7,9,10]) to Attack",
                new Dictionary<string, List<int>> { ["X"] = new() { 4, 6, 7, 9, 10 } },
                "Buff",
                "Enhances Attack by a fixed amount"
            ),
            new MacroDefinition(
                "@Disintegrate",
                "Deals Ether Magical(X#[4,6,7,9,10]) damage",
                new Dictionary<string, List<int>> { ["X"] = new() { 4, 6, 7, 9, 10 } },
                "Debuff",
                "Deals Ether Damage"
            )
        };

        [Theory]
        [InlineData("@Burn[30]", "Deals Fire Physical(30) damage")]
        [InlineData("@Strength[10]", "Buff(10) to Attack")]
        [InlineData("@Frozen[IV]", "Deals Ice Physical(6) damage")]
        [InlineData("@Disintegrate[II]", "Deals Ether Magical(6) damage")]
        public void ExpandMacros_KnownMacros_ExpandsCorrectly(string input, string expected)
        {
            var result = DslMacroExpander.ExpandMacros(input, _macros);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ExpandMacros_ThrowsOnUnknownMacro()
        {
            var input = "@UnknownMacro[5]";
            var ex = Assert.Throws<Exception>(() => DslMacroExpander.ExpandMacros(input, _macros));
            Assert.Contains("Unknown macro", ex.Message);
        }

        [Theory]
        [InlineData("[IV]", "[4]")]
        [InlineData("[IV,VI]", "[4,6]")]
        public void ExpandMacros_ConvertsRomanNumeralsInBrackets(string input, string expected)
        {
            var transformed = DslMacroExpander.ExpandMacros($"@Burn{input}", _macros);
            Assert.Contains(expected, transformed);
        }
    }

    public record MacroDefinition(
        string Name,
        string Template,
        Dictionary<string, List<int>> IndexMap,
        string Category,
        string Tooltip
    );

    public static class DslMacroExpander
    {
        public static string ExpandMacros(string input, List<MacroDefinition> macros)
        {
            var match = System.Text.RegularExpressions.Regex.Match(input, "@\\w+\\[(.*?)\\]");
            if (!match.Success)
                throw new Exception("Invalid macro format");

            var macroName = match.Groups["name"].Value;
            var rawArg = match.Groups[1].Value;
            var numericArg = RomanToInt(rawArg);

            var macro = macros.Find(m => m.Name == macroName);
            if (macro == null)
                throw new Exception($"Unknown macro: {macroName}");

            string result = macro.Template;
            foreach (var kv in macro.IndexMap)
            {
                var indexValues = kv.Value;
                if (int.TryParse(numericArg, out int idx) && idx > 0 && idx <= indexValues.Count)
                {
                    var replacement = indexValues[idx - 1];
                    result = result.Replace($"{kv.Key}#[{string.Join(",", indexValues)}]", replacement.ToString());
                }
                else
                {
                    result = result.Replace($"{kv.Key}#[{string.Join(",", indexValues)}]", rawArg);
                }
            }
            return result;
        }

        private static string RomanToInt(string input)
        {
            if (int.TryParse(input, out _))
                return input;

            var map = new Dictionary<char, int>
            {
                ['I'] = 1, ['V'] = 5, ['X'] = 10, ['L'] = 50, ['C'] = 100,
                ['D'] = 500, ['M'] = 1000
            };
            int total = 0;
            int prev = 0;

            foreach (var c in input.ToUpper())
            {
                if (!map.TryGetValue(c, out int val))
                    throw new Exception($"Invalid Roman numeral: {input}");

                if (val > prev)
                {
                    total += val - 2 * prev;
                }
                else
                {
                    total += val;
                }
                prev = val;
            }

            return total.ToString();
        }
    }
}
