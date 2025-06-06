using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public enum HealSubMechanicType
{
    Cleanse
}

public record HealSubMechanic(HealSubMechanicType Type, float Amount);

public enum HealMechanicType
{
    Restore,
    Drain, 
    Gives,
    Takes
}

public enum EconomyStat
{
    Mana,
    Hp,
    Opportunity
}

public record HealMechanic(
    HealMechanicType Type,
    float Amount,
    EconomyStat Stat,
    Condition Condition
);

public record HealEffectIR(
    Subject Subject,
    HealMechanic Mechanic,
    Targeting? Targeting = null
) : EffectIR(Subject, EffectType.Heal);


public static partial class DslParsers
{
    /* ────────── Healing Mechanics ────────── */

    public static Parser<Token, HealSubMechanic> HealSubMechanicParser =>
        Tok.Cleanse.Select(_ => new HealSubMechanic(HealSubMechanicType.Cleanse, 0f));

    public static Parser<Token, List<HealSubMechanic>> HealSubMechanicListParser =>
        Try(
            from _l in Tok.LBracket
            from items in HealSubMechanicParser.Separated(Comma)
            from _r in Tok.RBracket
            select items.ToList()
        ).Or(HealSubMechanicParser.Separated(Comma).Select(ms => ms.ToList()));

    public static Parser<Token, HealMechanic> HealMechanicParser =>
        from healType in OneOf(
            Tok.Restores.ThenReturn(HealMechanicType.Restore),
            Tok.Drains.ThenReturn(HealMechanicType.Drain),
            Tok.Gives.ThenReturn(HealMechanicType.Gives),
            Tok.Takes.ThenReturn(HealMechanicType.Takes)
        )
        from amount in AmountLiteral
        from stat in OneOf(
            Tok.Hp.ThenReturn(EconomyStat.Hp),
            Tok.Mana.ThenReturn(EconomyStat.Mana),
            Tok.Opportunity.ThenReturn(EconomyStat.Opportunity)
        )
        from condition in Try(ConditionParser).Optional()
        select new HealMechanic(healType, amount, stat, condition.GetValueOrDefault());

    public static Parser<Token, EffectIR> HealsEffectParser =>
        from heal in HealMechanicParser
        from _sub in Try(Tok.With.Then(HealSubMechanicListParser)).Optional() // Currently unused
        from targeting in Try(TargetingParser).Optional()
        from duration in Try(DurationClauseParser).Optional()
        select duration.HasValue
            ? new ModifierEffectIR(
                Subject.Target,
                new EffectModifierIR(
                    duration.Value,
                    new HealEffectIR(Subject.Target, heal, targeting.GetValueOrDefault()),
                    heal.Condition
                )
            )
            : targeting.HasValue
                ? throw new Exception("Targeting without duration is not allowed for healing effects.")
                : (EffectIR)new HealEffectIR(Subject.Target, heal);
}
