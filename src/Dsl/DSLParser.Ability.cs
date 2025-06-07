using System.Runtime.InteropServices;
using DSLApp1.Dsl;
using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;



namespace DSLApp1.Dsl;

public abstract record EffectIR(
    Subject Subject,
    EffectType EffectType
);


public record AbilityIR(
    List<EffectIR> Effects,
    Targeting Targeting,
    List<Compatibility> RoleCompatibilities,
    List<SideEffectsIR> PostEffects,
    Condition? When
);

public static partial class DslParsers
{
    // Charges clause
    public static Parser<Token, Duration> ChargesClauseParser =>
        Try(
            from _ in Tok.Charges
            from duration in DurationParser
            from _then in Tok.Then.Optional()
            select duration
        );

    // Immediate effects (one max)
    public static Parser<Token, List<EffectIR>> EffectsClauseParser =>
        OneOf(
                InvokeEffectParser.Cast<EffectIR>(),
                DamageEffectParser.Cast<EffectIR>(),
                HealsEffectParser.Cast<EffectIR>(),
                InflictsEffectParser.Cast<EffectIR>(),
                AppliesEffectParser.Cast<EffectIR>()
            ).Separated(Tok.Then)
            .Select(ValidateEffectChain);

    private static List<EffectIR> ValidateEffectChain(IEnumerable<EffectIR> effects)
    {
        var effectList = effects.ToList();
        if (effectList.Count > 1)
        {
            for (int i = 1; i < effectList.Count; i++)
            {
                if (effectList[i] is not ModifierEffectIR)
                    throw new Exception(
                        $"Effect at position {i + 1} must be a ModifierEffectIR (e.g., Applies, Inflicts). Found: {effectList[i].GetType().Name}");
            }
        }
        return effectList;
    }


    // Side effects (optional)
    public static Parser<Token, SideEffectsIR> SideEffectsClauseParser =>
        Try(SideEffectsParser);

    // Miss clause (optional)
    public static Parser<Token, Condition> MissClauseParser =>
        from _ in Tok.Miss
        from cond in ConditionParser
        select cond;

    // Full Ability parser
    public static Parser<Token, AbilityIR> AbilityParser =>
        from _ability in Tok.Ability
        from role in Try(
            from _lparen in Tok.LParen
            from role in RoleParser
            from _rparen in Tok.RParen
            select role
        ).Optional()
        from _colon in Tok.Colon

        // Optional clauses in order
        from charges in ChargesClauseParser.Optional()
        from targeting in TargetingParser.Optional()
        from effects in EffectsClauseParser.Optional()
        from sideEffects in SideEffectsClauseParser.Optional()
        from miss in MissClauseParser.Optional()

        // Split effects into immediate and modifiers
        let immediateEffect =
            effects.HasValue
                ? effects.Value.FirstOrDefault(e => e is not ModifierEffectIR)
                : null

        let modifierEffects =
            effects.HasValue
                ? effects.Value.Where(e => e is ModifierEffectIR).ToList()
                : new List<EffectIR>()

        select new AbilityIR(
            immediateEffect != null
                ? new List<EffectIR> { immediateEffect }.Concat(modifierEffects).ToList()
                : modifierEffects,

            targeting.GetValueOrDefault(new Targeting(AutoTargetingStrategy.UserSelected, TargetType.Single, TargetSide.Enemy)),

            role.HasValue ? new List<Compatibility> { role.Value } : new List<Compatibility>(),

            sideEffects.HasValue
                ? new List<SideEffectsIR> { sideEffects.Value }
                : new List<SideEffectsIR>(),

            miss.GetValueOrDefault()
        );

}
