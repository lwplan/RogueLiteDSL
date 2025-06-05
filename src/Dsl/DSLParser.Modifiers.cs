using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public abstract record ModifierIR(
    Duration Duration
);

public record ModifierEffectIR(
    Subject Subject,
    ModifierIR Modifier
) : EffectIR(Subject, EffectType.Modifier);



public record EffectModifierIR(
    Duration Duration,
    EffectIR Effect,
    Condition? Condition
) : ModifierIR(Duration);


public static partial class DslParsers
{
    /* ───────────── MODIFIERS ───────────── */
    public static Parser<Token, Duration> DurationParser =>
        from value in IntLiteral
        from unit in OneOf(
            Tok.Turn.ThenReturn(DurationType.Turns),
            Tok.Turns.ThenReturn(DurationType.Turns),
            Tok.Round.ThenReturn(DurationType.Rounds),
            Tok.Rounds.ThenReturn(DurationType.Rounds)
        )
        select new Duration(unit, value);

    
    // public static Parser<Token, EffectIR> TimedEffectParser =>
    //     from _for in Tok.For
    //     from duration in DurationParser
    //     from _colon in Tok.Colon
    //     from effects in Try(EffectBlockParser).Or(DamageEffectParser.Select(e => new List<EffectIR> { e }))
    //     select (EffectIR)(new ModiferEffectIR(
    //         Subject.Target,
    //         new EffectModifierIR(duration, effects.Count == 1 ? effects[0] : new CompositeEffectIR( Subject.Target, effects))
    //     ));


}