
using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;


namespace DSLApp1.Dsl;

public enum StateMechanicType
{
    Blessing,
    Curse,
    Stun,
    Defensive,
    Revival,
    Shield,
    Wet,
    Oiled
}


public enum MultiplierMechanicType
{
    Vulnerability,
    Protection,
    Power,
    Frailty
}

public enum StatField
{
    Attack,
    Defense,
    Intelligence,
    Resistance,
    Initiative
}

public abstract record TargetTag;

public record ElementTag(Element Element) : TargetTag;

public record CompatibilityTag(Compatibility Compatibility) : TargetTag;


public abstract record ModifierMechanicIR;


public record StateMechanicIR(
    StateMechanicType Type,
    float? Amount,
    Condition? When
) : ModifierMechanicIR;

public record MultiplierMechanicIR(
    MultiplierMechanicType Type,
    float? Amount,
    TargetTag? Against,
    Condition? When
) : ModifierMechanicIR;

public record AppliesModifierIR(
    Duration Duration,
    List<ModifierMechanicIR> Mechanics,
    Condition? Condition
) : ModifierIR(Duration);

public record StatBuffMechanicIR(
    StatField Stat,
    float Amount,
    bool IsBuff // true for Buff, false for Debuff
) : ModifierMechanicIR;


public static partial class DslParsers
{
    public static Parser<Token, StateMechanicIR> StateMechanicParser =>
        from type in OneOf(
            Tok.Blessing.ThenReturn(StateMechanicType.Blessing),
            Tok.Curse.ThenReturn(StateMechanicType.Curse),
            Tok.Stun.ThenReturn(StateMechanicType.Stun),
            Tok.Defensive.ThenReturn(StateMechanicType.Defensive),
            Tok.Revival.ThenReturn(StateMechanicType.Revival),
            Tok.Shield.ThenReturn(StateMechanicType.Shield),
            Tok.Wet.ThenReturn(StateMechanicType.Wet),
            Tok.Oiled.ThenReturn(StateMechanicType.Oiled)
        )
        from amount in Try(Tok.LParen.Then(AmountLiteral).Before(Tok.RParen)).Optional()
        from when in Try(Tok.When.Then(ConditionBodyParser)).Optional()
        select new StateMechanicIR(type, amount.GetValueOrDefault(), when.GetValueOrDefault());

    public static Parser<Token, TargetTag> TargetTagParser =>
        ElementParser.Select(e => new ElementTag(e) as TargetTag)
            .Or(RoleParser.Select(c => new CompatibilityTag(c) as TargetTag));


    public static Parser<Token, MultiplierMechanicIR> FullMultiplierMechanicParser =>
        from type in OneOf(
            Tok.Vulnerability.ThenReturn(MultiplierMechanicType.Vulnerability),
            Tok.Protection.ThenReturn(MultiplierMechanicType.Protection),
            Tok.Power.ThenReturn(MultiplierMechanicType.Power),
            Tok.Frailty.ThenReturn(MultiplierMechanicType.Frailty)
        )
        // Amount can appear either before or after the infix keyword
        from amountBefore in Try(
            Tok.LParen.Then(AmountLiteral).Before(Tok.RParen)
        ).Optional()
        from _infix in OneOf(
            Tok.Against,
            Tok.To
        )
        from amountAfter in Try(
            Tok.LParen.Then(AmountLiteral).Before(Tok.RParen)
        ).Optional()
        from against in TargetTagParser
        from _ in Tok.Damage
        from when in Try(Tok.When.Then(ConditionBodyParser)).Optional()
        select new MultiplierMechanicIR(
            type,
            amountBefore.HasValue ? amountBefore.Value : amountAfter.GetValueOrDefault(),
            against,
            when.GetValueOrDefault()
        );

    public static Parser<Token, MultiplierMechanicIR> SimpleMultiplierMechanicParser =>
        from type in OneOf(
            Tok.Vulnerability.ThenReturn(MultiplierMechanicType.Vulnerability),
            Tok.Protection.ThenReturn(MultiplierMechanicType.Protection),
            Tok.Power.ThenReturn(MultiplierMechanicType.Power),
            Tok.Frailty.ThenReturn(MultiplierMechanicType.Frailty)
        )
        from amount in Tok.LParen.Then(AmountLiteral).Before(Tok.RParen)
        select new MultiplierMechanicIR(type, amount, null, null);

    public static Parser<Token, MultiplierMechanicIR> MultiplierMechanicParser =>
        Try(FullMultiplierMechanicParser)
            .Or(SimpleMultiplierMechanicParser);


    public static Parser<Token, StatBuffMechanicIR> StatBuffMechanicParser =>
        from isBuff in OneOf(
            Tok.Buff.ThenReturn(true),
            Tok.Debuff.ThenReturn(false)
        )
        from amount in Tok.LParen.Then(AmountLiteral).Before(Tok.RParen)
        from _ in Tok.To
        from stat in OneOf(
            Tok.Attack.ThenReturn(StatField.Attack),
            Tok.Defense.ThenReturn(StatField.Defense),
            Tok.Intelligence.ThenReturn(StatField.Intelligence),
            Tok.Resistance.ThenReturn(StatField.Resistance),
            Tok.Initiative.ThenReturn(StatField.Initiative)
        )
        select new StatBuffMechanicIR(stat, amount, isBuff);
    
    public static Parser<Token, ModifierMechanicIR> ModifierMechanicParser =>
        StatBuffMechanicParser.Select(x => (ModifierMechanicIR)x)
            .Or(StateMechanicParser.Select(x => (ModifierMechanicIR)x))
            .Or(MultiplierMechanicParser.Select(x => (ModifierMechanicIR)x));


    private static Parser<Token, EffectIR> QuotedImmediateEffectParser =>
        from _open in Tok.SingleQuote
        from effect in OneOf(
            DamageEffectParser.Cast<EffectIR>(),
            HealsEffectParser.Cast<EffectIR>()
        )
        from _close in Tok.SingleQuote
        select effect;


    public static Parser<Token, ModifierEffectIR> AppliesEffectParser =>
        from _ in Tok.Applies
        from result in Try(
            from quoted in QuotedImmediateEffectParser
            from duration in DurationClauseParser
            from condition in Try(ConditionParser).Optional()
            select new ModifierEffectIR(
                Subject.Target,
                new EffectModifierIR(duration, quoted, condition.GetValueOrDefault())
            )
        ).Or(
            from mechanics in ModifierMechanicParser.Separated(Tok.Comma)
            from duration in Try(DurationClauseParser).Optional()
            from condition in Try(ConditionParser).Optional()
            select new ModifierEffectIR(
                Subject.Target,
                new AppliesModifierIR(
                    duration.GetValueOrDefault(new Duration(DurationType.Rounds, int.MaxValue)), // "forever"
                    mechanics.ToList(),
                    condition.GetValueOrDefault()
                )
            )
        )
        select result;

}