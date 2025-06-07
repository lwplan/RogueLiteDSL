using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public enum HealSubMechanicType
{
    Cleanse
}

public record HealSubMechanic(HealSubMechanicType HealSubMechanicType, float Amount)


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
    HealMechanicType HealMechanicType,
    float Amount,
    EconomyStat EconomyStat,
    Condition Condition);

public record HealEffectIR(
    Subject Subject,
    HealMechanic HealMechanic,
    List<HealSubMechanic>? SubMechanics,
    Targeting? Targeting = null
) : EffectIR(Subject, EffectType.Heal);


public static partial class DslParsers
{
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
        select new HealMechanic(
            healType,
            amount,
            stat,
            condition.GetValueOrDefault()
        );

    public static Parser<Token, EffectIR> HealsEffectParser =>
        from heal in HealMechanicParser
        from targeting in Try(TargetingParser).Optional()
        from duration in Try(DurationClauseParser).Optional()

        select duration.HasValue
            ? new ModifierEffectIR(
                Subject.Target,
                new EffectModifierIR(
                    duration.Value,
                    new HealEffectIR(
                        Subject.Target,
                        heal,
                        targeting.GetValueOrDefault()
                    ),
                    heal.Condition
                )
            )
            : targeting.HasValue
                ? throw new Exception("Targeting without duration is not allowed for healing effects.")
                : (EffectIR)new HealEffectIR(Subject.Target, heal);
}
