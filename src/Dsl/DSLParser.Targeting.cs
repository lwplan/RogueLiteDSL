using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public enum AutoTargetingStrategy
{
    UserSelected,
    Strongest,
    Weakest,
    NextUp,
    LastUp,
    Random
}

public enum TargetSide
{
    Ally,
    Enemy,
    Neutral
}

public enum TargetType
{
    Single,
    Multiple
}

public record Targeting(AutoTargetingStrategy AutoTargetingStrategy, TargetType TargetType, TargetSide TargetSide);
public static partial class DslParsers
{
    
    /* ───────────── TARGETING PARSERS ───────────── */
    
   public static Parser<Token, Targeting> TargetingParser =>
    // Handle "Targeting All" as a special early case
    Try(
        from _ in Tok.Targeting
        from _all in Tok.All
        select new Targeting(
            AutoTargetingStrategy.UserSelected,
            TargetType.Multiple,
            TargetSide.Neutral
        )
    )
    .Or(
        from _ in Tok.Targeting

        // Optional strategy
        from strategy in OneOf(
            Tok.Strongest.ThenReturn(AutoTargetingStrategy.Strongest),
            Tok.Weakest.ThenReturn(AutoTargetingStrategy.Weakest),
            Tok.NextUp.ThenReturn(AutoTargetingStrategy.NextUp),
            Tok.LastUp.ThenReturn(AutoTargetingStrategy.LastUp),
            Tok.Random.ThenReturn(AutoTargetingStrategy.Random)
        ).Optional()

        // Optional target type
        from targetType in OneOf(
            Tok.Single.ThenReturn(TargetType.Single),
            Tok.Multiple.ThenReturn(TargetType.Multiple)
        ).Optional()

        // Required side
        from side in OneOf(
            Tok.Ally.ThenReturn(TargetSide.Ally),
            Tok.Allies.ThenReturn(TargetSide.Ally),
            Tok.Enemy.ThenReturn(TargetSide.Enemy),
            Tok.Enemies.ThenReturn(TargetSide.Enemy)
        )
        select new Targeting(
            strategy.HasValue ? strategy.Value : AutoTargetingStrategy.UserSelected,
            targetType.HasValue ? targetType.Value : InferTargetTypeFromSide(side),
            side
        )
    );

private static TargetType InferTargetTypeFromSide(TargetSide side) =>
    side switch
    {
        TargetSide.Ally => TargetType.Single,
        TargetSide.Enemy => TargetType.Single,
        TargetSide.Neutral => TargetType.Multiple,
        _ => TargetType.Single
    };


}