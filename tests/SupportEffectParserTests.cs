using DSLApp1.Dsl;

using System.Collections.Generic;
using Pidgin;
using Xunit;

namespace DSLApp1.Tests.Dsl
{
    public class SupportEffectParserTests
    {
        private static List<SupportEffectIR> ParseSupportEffects(string text)
        {
            var tokens = DslTokenizer.Tokenize($"Adds {text} to damage");
            var result = DslParsers.SupportEffectParser.ParseOrThrow(tokens);
            return result;
        }

        [Fact]
        public void Parses_Single_Damage_Mechanic()
        {
            var effects = ParseSupportEffects("Piercing(50)");
            var effect = Assert.Single(effects);
            var dmg = Assert.IsType<DamageSupportIR>(effect);

            Assert.Equal(DamageMechanicType.Piercing, dmg.Mechanic);
            Assert.Equal(50f, dmg.Value);
        }

        [Fact]
        public void Parses_Single_Element()
        {
            var effects = ParseSupportEffects("Fire");
            var effect = Assert.Single(effects);
            var elem = Assert.IsType<ElementSupportIR>(effect);

            Assert.Equal(Element.Fire, elem.Element);
        }

        [Fact]
        public void Parses_Multiple_Effects_From_Bracket_List()
        {
            var effects = ParseSupportEffects("[Fire, Piercing(25)]");
            Assert.Equal(2, effects.Count);

            Assert.IsType<ElementSupportIR>(effects[0]);
            Assert.IsType<DamageSupportIR>(effects[1]);

            var dmg = (DamageSupportIR)effects[1];
            Assert.Equal(DamageMechanicType.Piercing, dmg.Mechanic);
            Assert.Equal(25f, dmg.Value);
        }

        [Fact]
        public void Rejects_Invalid_Mechanic()
        {
            var tokens = DslTokenizer.Tokenize("Adds Grapple(30) to damage");
            var result = DslParsers.SupportEffectParser.Parse(tokens);
            Assert.False(result.Success);
        }

        [Fact]
        public void Rejects_Unsupported_Syntax()
        {
            var tokens = DslTokenizer.Tokenize("Adds Fire, Piercing(25) to damage"); // missing brackets
            var result = DslParsers.SupportEffectParser.Parse(tokens);
            Assert.False(result.Success);
        }
        
        [Fact]
        public void Parses_DamageMechanic_With_Percent()
        {
            var effects = ParseSupportEffects("Piercing(50%)");
            var effect = Assert.Single(effects);
            var dmg = Assert.IsType<DamageSupportIR>(effect);

            Assert.Equal(DamageMechanicType.Piercing, dmg.Mechanic);
            Assert.Equal(50f, dmg.Value);  // assuming all values are normalized as floats
        }

        [Fact]
        public void Parses_Bracketed_Effects_With_Percent()
        {
            var effects = ParseSupportEffects("[Fire, Spiral(25%)]");
            Assert.Equal(2, effects.Count);

            Assert.IsType<ElementSupportIR>(effects[0]);
            var spiral = Assert.IsType<DamageSupportIR>(effects[1]);

            Assert.Equal(DamageMechanicType.Spiral, spiral.Mechanic);
            Assert.Equal(25f, spiral.Value);
        }

    }
}
