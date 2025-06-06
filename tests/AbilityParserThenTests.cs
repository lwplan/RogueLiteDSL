using DSLApp1.Dsl;
using DSLApp1.Model;
using Pidgin;
using Xunit;

namespace DSLApp1.Tests.Dsl
{
    public class AbilityParserThenTests
    {
        [Fact]
        public void Parses_Effect_List_With_Then()
        {
            const string src = "Ability: Deals Physical(5) Water damage then Applies Vulnerability to (150%) Electrical damage for 3 turns";
            var tokens = DslTokenizer.Tokenize(src);
            var ability = DslParsers.AbilityParser.ParseOrThrow(tokens);

            Assert.Equal(2, ability.Effects.Count);
            Assert.IsType<DamageEffectIR>(ability.Effects[0]);
            Assert.IsType<ModifierEffectIR>(ability.Effects[1]);
        }
    }
}
