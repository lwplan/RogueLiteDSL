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
                "Deals Fire Physical(X) damage",
                new Dictionary<string, List<int>> { ["X"] = new() { 4, 6, 7, 9, 10 } },
                "Debuff",
                "Deals Fire damage"
            ),
            new MacroDefinition(
                "@Frozen",
                "Deals Ice Physical(X) damage",
                new Dictionary<string, List<int>> { ["X"] = new() { 4, 6, 7, 9, 10 } },
                "Debuff",
                "Deals Ice damage"
            ),
            new MacroDefinition(
                "@Strength",
                "Buff(X) to Attack",
                new Dictionary<string, List<int>> { ["X"] = new() { 4, 6, 7, 9, 10 } },
                "Buff",
                "Enhances Attack by a fixed amount"
            ),
            new MacroDefinition(
                "@Disintegrate",
                "Deals Ether Magical(X) damage",
                new Dictionary<string, List<int>> { ["X"] = new() { 4, 6, 7, 9, 10 } },
                "Debuff",
                "Deals Ether Damage"
            )
        };

        [Theory]
        [InlineData("@Burn[IV]", "Deals Fire Physical(9) damage")]
        [InlineData("@Strength[II]", "Buff(6) to Attack")]
        [InlineData("@Frozen[I]", "Deals Ice Physical(4) damage")]
        [InlineData("@Disintegrate[V]", "Deals Ether Magical(10) damage")]
        public void ExpandMacros_KnownMacros_ExpandsCorrectly(string input, string expected)
        {
            var result = MacroExpander.Expand(input, _macros);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ExpandMacros_ThrowsOnUnknownMacro()
        {
            var input = "@UnknownMacro[5]";
            var result = MacroExpander.Expand(input, _macros);
            Assert.Equal(input, result);
        }

        [Theory]
        [InlineData("@Burn[X]", "Deals Fire Physical(X) damage")]
        [InlineData("Random text", "Random text")]
        public void ExpandMacros_Ignores_NonMatchingInput(string input, string expected)
        {
            var result = MacroExpander.Expand(input, _macros);
            Assert.Equal(expected, result);
        }
    }

}
