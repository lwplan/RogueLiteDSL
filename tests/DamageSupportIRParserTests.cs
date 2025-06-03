using DSLApp1.Dsl;
using Pidgin;
using Xunit;

namespace DSLApp1.Tests
{
    public class DamageSupportIrParserTests
    {
        private static DamageSupportIR Parse(string text)
        {
            var tokens = DslTokenizer.Tokenize(text);
            var result = DslParsers.DamageSupportIRParser.ParseOrThrow(tokens);
            return Assert.IsType<DamageSupportIR>(result);
        }

        [Fact]
        public void Parses_Flat_DamageMechanic()
        {
            var result = Parse("Piercing(40)");

            Assert.Equal(DamageMechanicType.Piercing, result.Mechanic);
            Assert.Equal(40f, result.Value);
        }

        [Fact]
        public void Parses_Percent_DamageMechanic()
        {
            var result = Parse("Spiral(25%)");

            Assert.Equal(DamageMechanicType.Spiral, result.Mechanic);
            Assert.Equal(25f, result.Value);
        }

        [Fact]
        public void Fails_On_Missing_Paren()
        {
            var tokens = DslTokenizer.Tokenize("Piercing 25%");
            var result = DslParsers.DamageSupportIRParser.Parse(tokens);
            Assert.False(result.Success);
        }

        [Fact]
        public void Fails_On_Unknown_Mechanic()
        {
            var tokens = DslTokenizer.Tokenize("Explosive(15%)");
            var result = DslParsers.DamageSupportIRParser.Parse(tokens);
            Assert.False(result.Success);
        }
    }
}
