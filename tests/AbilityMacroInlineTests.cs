using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DSLApp1.Dsl;
using Pidgin;
using Xunit;
using Xunit.Abstractions;

namespace DSLApp1.Tests.Dsl
{
    /// <summary>
    /// Allows testing DSL strings with inline macro definitions. This mirrors
    /// the CSV-based test but lets developers experiment with problematic
    /// inputs directly in code.
    /// </summary>
    public class AbilityMacroInlineTests
    {
        private readonly ITestOutputHelper _output;

        public AbilityMacroInlineTests(ITestOutputHelper output) => _output = output;

        private static readonly List<MacroDefinition> Macros = new()
        {
            new MacroDefinition(
                "@Weakness",
                "Debuff(X) to Resistance",
                new Dictionary<string, List<int>> { ["X"] = new() { 4, 6, 7, 9, 10 } },
                "Debuff",
                "Downgrade Resistance by a fixed amount"
            )
        };

        [Fact]
        public void Parses_LightRay_Macro_From_Code()
        {
            const string dsl = "Ability : Deals Physical(5) Light damage then Applies @Weakness[I] for 3 turns";

            var expanded = Regex.Replace(
                dsl,
                @"@\w+\[[IVXLCDM]+\]",
                m => MacroExpander.Expand(m.Value, Macros));
            _output.WriteLine($"Expanded: {expanded}");

            var tokens = DslTokenizer.Tokenize(expanded);
            _output.WriteLine(string.Join(" | ", tokens.Select(t => t.Text)));

            var result = DslParsers.HexParser.Parse(tokens);
            if (!result.Success)
            {
                _output.WriteLine(result.ToString());
            }

            Assert.True(result.Success, "Light ray should parse successfully after macro expansion");
        }
    }
}
