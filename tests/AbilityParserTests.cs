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
            Assert.Equal(Role.Artillery, ability.RoleCompatibilities[0]);

            Assert.Equal(Targetability.Enemies, ability.Targeting.Targetability);
            Assert.Equal(2, ability.Targeting.TargetMechanics.Count);

            /* ── TARGET-MECHANIC DETAILS ────────────────────────────────── */

            Assert.Collection(ability.Targeting.TargetMechanics,
                m =>
                {
                    Assert.Equal(TargetMechanicType.MultiHit, m.TargetMechanicType);
                    Assert.Equal(6, m.Value);
                },
                m =>
                {
                    Assert.Equal(TargetMechanicType.Random, m.TargetMechanicType);
                });

            /* ── DAMAGE EFFECT ──────────────────────────────────────────── */

            var dmg = Assert.IsType<DamageEffectIR>(ability.Effects.Single());

            // Your current DamageEffectIR discards element & power.
            // When you extend the record, assert them here:
            //   Assert.Equal(Element.Fire, dmg.Element);
            //   Assert.Equal(6f,           dmg.Power);

            Assert.Equal(Subject.Target, dmg.Subject); 
        }
    }
}
