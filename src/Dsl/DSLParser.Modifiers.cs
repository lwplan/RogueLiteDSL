using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;
public static partial class DslParsers
{
    /* ───────────── MODIFIERS ───────────── */
    public static Parser<Token, Duration> DurationParser =>
        from value in IntLiteral
        from unit in OneOf(
            Tok(TokenType.Keyword, "turn").ThenReturn(DurationType.Turns),
            Tok(TokenType.Keyword, "turns").ThenReturn(DurationType.Turns),
            Tok(TokenType.Keyword, "round").ThenReturn(DurationType.Rounds),
            Tok(TokenType.Keyword, "rounds").ThenReturn(DurationType.Rounds)
        )
        select new Duration(unit, value);

    
    public static Parser<Token, EffectIR> TimedEffectParser =>
        from _for in Tok(TokenType.Keyword, "For")
        from duration in DurationParser
        from _colon in Symbol(TokenType.Colon)
        from effects in Try(EffectBlockParser).Or(DamageEffectParser.Select(e => new List<EffectIR> { e }))
        select (EffectIR)(new ModiferEffectIR(
            Subject.Target,
            new EffectModifierIR(duration, effects.Count == 1 ? effects[0] : new CompositeEffectIR( Subject.Target, effects))
        ));


}