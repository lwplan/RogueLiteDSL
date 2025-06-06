using System;
using System.Linq;

namespace DSLApp1.Dsl
{
    public static class AbilityExtensions
    {
        public static AbilityIR Lint(this AbilityIR ability)
        {
            var immediates = ability.Effects
                .Where(e => e.EffectType != EffectType.Modifier)
                .ToList();

            if (immediates.Count > 1)
                throw new Exception("Ability may contain at most one immediate effect");

            if (immediates.Count == 1 && ability.Effects.IndexOf(immediates[0]) != 0)
                throw new Exception("Immediate effect must appear before modifier effects");

            return ability;
        }
    }
}
