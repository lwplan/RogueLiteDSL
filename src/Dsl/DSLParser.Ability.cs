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
    public static Parser<Token, EffectIR> ImmediateClauseParser =>
        Try(
            InvokeEffectParser.Cast<EffectIR>()
                .Or(DamageEffectParser.Cast<EffectIR>())
                .Or(HealsEffectParser.Cast<EffectIR>())
        );

    // Modifier effects (many allowed)
    public static Parser<Token, EffectIR> ModifierClauseParser =>
        Try(
            InflictsEffectParser.Cast<EffectIR>()
                .Or(AppliesEffectParser.Cast<EffectIR>())
        );

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
            from _colon in Tok.Colon
            select role
        ).Optional()

        // Optional clauses in order
        from charges in ChargesClauseParser.Optional()
        from targeting in TargetingParser.Optional()
        from immediate in ImmediateClauseParser.Optional()
        from modifiers in ModifierClauseParser.Many()
        from sideEffects in SideEffectsClauseParser.Optional()
        from miss in MissClauseParser.Optional()

        select new AbilityIR(
            (immediate.HasValue 
                ? [immediate.Value]
                : Enumerable.Empty<EffectIR>())
            .Concat(modifiers)
            .ToList(),
    
            targeting.HasValue
                ? targeting.Value
                : new Targeting(AutoTargetingStrategy.UserSelected, TargetType.Single, TargetSide.Enemy),
    
            role.HasValue ? new List<Compatibility> { role.Value } : new List<Compatibility>(),
            sideEffects.HasValue 
                ? new List<SideEffectsIR> { sideEffects.Value } 
                : new List<SideEffectsIR>(),
    
            miss.GetValueOrDefault()
        );
}
