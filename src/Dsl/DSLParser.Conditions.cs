using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;


public enum Op
{
    Gt, Lt, Eq, Ge, Le,
    Contains,
    Ne
}

public enum Field
{
    Attack,
    Defence,
    Intelligence,
    Resistance,
    Initiative,
    Mana,
    Hp,
    HpPercent,
    Opportunity,
    Miss,
    Hits,
    KillCount,
    TargetCount,
    Roles,
    Elements,
    Mechanics,
    Roll
}

// Base type for all conditions
public abstract record BaseCondition;

public record Condition(
    Subject Subject,
    Field Field,
    Op Op,
    float Value
) : BaseCondition;

public record AndCondition(List<BaseCondition> Conditions) : BaseCondition;


public static partial class DslParsers
{
    public static Parser<Token, Subject> SubjectParser =>
        OneOf(
            Tok.User.ThenReturn(Subject.User),
            Tok.Target.ThenReturn(Subject.Target)
        );

    public static Parser<Token, Field> CharacterFieldParser =>
        OneOf(
            Tok.Attack.ThenReturn(Field.Attack),
            Tok.Defense.ThenReturn(Field.Defence),
            Tok.Intelligence.ThenReturn(Field.Intelligence),
            Tok.Resistance.ThenReturn(Field.Resistance),
            Tok.Initiative.ThenReturn(Field.Initiative),
            Tok.Mana.ThenReturn(Field.Mana),
            Tok.Hp.ThenReturn(Field.Hp),
            Tok.HpPercent.ThenReturn(Field.HpPercent),
            Tok.Opportunity.ThenReturn(Field.Opportunity)
        );

    public static Parser<Token, Field> OutcomeFieldParser =>
        OneOf(
            Tok.Roll.ThenReturn(Field.Roll),
            Tok.Kills.ThenReturn(Field.KillCount),
            Tok.Missed.ThenReturn(Field.Miss),
            Tok.Hits.ThenReturn(Field.Hits)
            // Add 'Damage' or others if supported
        );

    public static Parser<Token, Op> ComparisonOpParser =>
        OneOf(
            Tok.Eq.ThenReturn(Op.Eq),
            Tok.Ne.ThenReturn(Op.Ne),
            Tok.Le.ThenReturn(Op.Le),
            Tok.Ge.ThenReturn(Op.Ge),
            Tok.Lt.ThenReturn(Op.Lt),
            Tok.Gt.ThenReturn(Op.Gt)
        );

    public static Parser<Token, Condition> ConditionParser =>
        from _if in Tok.If
        from subjectAndField in Try(
            from subject in SubjectParser
            from field in CharacterFieldParser
            select (subject, field)
        ).Or(
            OutcomeFieldParser.Select(f => (Subject.Result, f))
        )
        from op in ComparisonOpParser
        from value in AmountLiteral
        select new Condition(subjectAndField.Item1, subjectAndField.Item2, op, value);
}
