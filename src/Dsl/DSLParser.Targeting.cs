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
    Self,
    Ally,
    Enemy,
    Neutral
}

public enum TargetType
{
    Single,
    Multiple
}

public enum TargetingMechanicsType
{
    MultiHit,
    MultiTarget,
    Random
}

public record TargetingMechanic(TargetingMechanicsType MechanicType, int Amount);

public record Targeting(
    AutoTargetingStrategy AutoTargetingStrategy,
    TargetType TargetType,
    TargetSide TargetSide,
    List<TargetingMechanic>? With = null
);
public static partial class DslParsers
{

    /* ───────────── TARGETING PARSERS ───────────── */

    public static Parser<Token, TargetingMechanicsType> TargetingMechanicTypeParser => OneOf(
        Tok.MultiHit.ThenReturn(TargetingMechanicsType.MultiHit),
        Tok.MultiTarget.ThenReturn(TargetingMechanicsType.MultiTarget),
        Tok.Random.ThenReturn(TargetingMechanicsType.Random)
    );

    public static Parser<Token, TargetingMechanic> TargetingMechanicParser =>
        from mech in TargetingMechanicTypeParser
        from amount in Try(Tok.LParen.Then(IntLiteral).Before(Tok.RParen)).Optional()
        select new TargetingMechanic(mech, amount.HasValue ? amount.Value : 0);

    public static Parser<Token, List<TargetingMechanic>> TargetingMechanicListParser =>
        TargetingMechanicParser.Separated(Comma).Select(x => x.ToList());
    
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
            Tok.Self.ThenReturn(TargetSide.Self),
            Tok.Ally.ThenReturn(TargetSide.Ally),
            Tok.Allies.ThenReturn(TargetSide.Ally),
            Tok.Enemy.ThenReturn(TargetSide.Enemy),
            Tok.Enemies.ThenReturn(TargetSide.Enemy)
        )
        from withMechs in Try(
            from _w in Tok.With
            from ms in TargetingMechanicListParser
            select ms
        ).Optional()
        select new Targeting(
            strategy.HasValue ? strategy.Value : AutoTargetingStrategy.UserSelected,
            targetType.HasValue ? targetType.Value : InferTargetTypeFromSide(side),
            side,
            withMechs.GetValueOrDefault()
        )
    );

private static TargetType InferTargetTypeFromSide(TargetSide side) =>
    side switch
    {
        TargetSide.Self => TargetType.Single,
        TargetSide.Ally => TargetType.Single,
        TargetSide.Enemy => TargetType.Single,
        TargetSide.Neutral => TargetType.Multiple,
        _ => TargetType.Single
    };


}