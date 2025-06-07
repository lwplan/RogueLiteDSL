using System.Linq;
using DSLApp1.Dsl;
using Pidgin;
using Xunit;

namespace DSLApp1.Tests.Dsl
{
    public class OutfitParserTests
    {
        [Fact]
        public void Parses_Basic_Outfit_Equips()
        {
            const string text = "Outfit : Equips Buff(6) to Defense and Buff(6) to Resistance";
            var tokens = DslTokenizer.Tokenize(text);
            var outfit = DslParsers.OutfitParser.ParseOrThrow(tokens);
            Assert.Single(outfit.Effects);
            var applies = Assert.IsType<AppliesModifierIR>(outfit.Effects[0].Modifier);
            Assert.Equal(2, applies.Mechanics.Count);
        }
    }
}
