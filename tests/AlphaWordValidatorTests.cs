using System.Collections.Generic;
using DSLApp1.Dsl;
using Xunit;

namespace DSLApp1.Tests
{
    public class AlphaWordValidatorTests
    {
        private static readonly List<MacroDefinition> Macros = new()
        {
            new MacroDefinition("@Burn", "", new Dictionary<string, List<int>>(), "", ""),
            new MacroDefinition("@Slow", "", new Dictionary<string, List<int>>(), "", "")
        };

        [Fact]
        public void Validator_Ignores_Known_Keywords_And_Macros()
        {
            const string text = "Ability : Deals Fire damage then Applies @Slow[I]";
            var result = AlphaWordValidator.FindUnknownWords(text, Macros);
            Assert.Empty(result);
        }

        [Fact]
        public void Validator_Flags_Unknown_Macro()
        {
            const string text = "Ability : Deals Fire damage then @Unknown[I]";
            var result = AlphaWordValidator.FindUnknownWords(text, Macros);
            Assert.Contains("@Unknown", result);
        }

        [Fact]
        public void Validator_Flags_Unknown_Keyword()
        {
            const string text = "Ability : Deals Fire gibberish damage";
            var result = AlphaWordValidator.FindUnknownWords(text, Macros);
            Assert.Contains("gibberish", result);
        }
    }
}
