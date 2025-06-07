using System.Globalization;
using System.Linq;
using DSLApp1.Dsl;
using DSLApp1.Model;
using Pidgin;
using Xunit;

namespace DSLApp1.Tests.Dsl
{
    public sealed class AbilityParserTests
    {
        /// <summary>
        /// “Cannonzade” golden-path line.
        /// Remove the Skip once <see cref="DslParsers.AbilityParser"/>
        /// understands Role + Targeting + Damage sections.
        /// </summary>
        [Fact]
        public void AbilityParser_Parses_Cannonzade()
        {
            const string src =
                "Ability (Artillery): Targets Enemies with [MultiHit(6), Random], " +
                "Deals Physical(6) Fire damage";


            var tokens = DslTokenizer.Tokenize(src);
            var ability = DslParsers.AbilityParser.ParseOrThrow(tokens);
            /* ── BASIC SHAPE ─────────────────────────────────────────────── */

            Assert.Single(ability.RoleCompatibilities);
            Assert.Equal(Compatibility.Artillery, ability.RoleCompatibilities[0]);


        }

        [Fact]
        public void AbilityParser_Parses_NoRole_WithColon()
        {
            const string src =
                "Ability : Deals Dark Physical(20) damage miss if roll < 80";

            var tokens = DslTokenizer.Tokenize(src);
            var ability = DslParsers.AbilityParser.ParseOrThrow(tokens);

            Assert.Empty(ability.RoleCompatibilities);
        }
    }
}
