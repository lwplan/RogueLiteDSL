using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public static partial class DslParsers
{

    /* ───────────── ABILITY ───────────── */

    public static Parser<Token, AbilityIR> AbilityParser =>
        from _ability in Tok(TokenType.Keyword, "Ability")
        from _lparen in Symbol(TokenType.LParen)
        from role in RoleParser
        from _rparen in Symbol(TokenType.RParen)
        from _colon in Symbol(TokenType.Colon)
        from charges in Try(
            from _c in Tok(TokenType.Keyword, "Charges")
            from duration in DurationParser
            from _then in Tok(TokenType.Keyword, "then").Optional()
            select duration
        ).Optional()
        from maybeTargeting in TargetingParser.Optional()
        from effect in Try(
            TimedEffectParser.Select(e => (EffectIR)e)
                .Or(DamageEffectParser.Select(e => (EffectIR)e))
                .Or(InvokeEffectParser.Select(e => (EffectIR)e))
        )
        from sideEffects in Try(SideEffectsParser).Optional()
        select new AbilityIR(
            new List<EffectIR> { effect },
            maybeTargeting.HasValue
                ? maybeTargeting.Value
                : new Targeting(Targetability.Enemy, new List<TargetMechanic>()),
            new List<Role> { role },
            sideEffects.HasValue ? new List<SideEffectsIR> { sideEffects.Value } : new List<SideEffectsIR>(),
            null
        );

}