using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

/*
 * duration-clause := 'for' (int 'turns' | 'rounds' | 'turn' | 'round' ) [ event-clause ]
   
   event-clause := 'on' ('round' 'start' | 'round' 'end' | 'turn' 'start' | 'turn' 'end' )
 */

namespace DSLApp1.Dsl;
public enum TimingEvent
{
    TurnStart,
    TurnEnd,
    RoundStart,
    RoundEnd
}

public enum DurationType { Rounds, Turns }
public record Duration(DurationType DurationType, int Amount, TimingEvent? TimingEvent = null);



public static partial class DslParsers
{
    public static Parser<Token, TimingEvent> EventClauseParser =>
        from _on in Tok.On
        from eventType in OneOf(
            Tok.Turn.Then(
                OneOf(
                    Tok.Start.ThenReturn(TimingEvent.TurnStart),
                    Tok.End.ThenReturn(TimingEvent.TurnEnd)
                )
            ),
            Tok.Round.Then(
                OneOf(
                    Tok.Start.ThenReturn(TimingEvent.RoundStart),
                    Tok.End.ThenReturn(TimingEvent.RoundEnd)
                )
            )
        )
        select eventType;

    
    public static Parser<Token, Duration> DurationClauseParser =>
        from _ in Tok.For
        from amount in IntLiteral
        from unit in OneOf(
            Tok.Turn.ThenReturn(DurationType.Turns),
            Tok.Turns.ThenReturn(DurationType.Turns),
            Tok.Round.ThenReturn(DurationType.Rounds),
            Tok.Rounds.ThenReturn(DurationType.Rounds)
        )
        from timing in Try(EventClauseParser).Optional()
        select new Duration(unit, amount, timing.HasValue ? timing.Value : null);


}