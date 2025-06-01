using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;
using static Pidgin.Parser<DSLApp1.Dsl.Token>;

namespace DSLApp1.Dsl;

public enum TokenType
{
    Keyword,
    Identifier,
    Number,
    Float,
    LParen,
    RParen,
    LBracket,
    RBracket,
    Comma,
    Colon,
    EndOfFile,
    LBrace,
    RBrace,
    Percent,
    Symbol,
}

public record Token(TokenType Type, string Text);

public static class DslParsers
{
    /* ───── helpers ───── */
    public static Parser<Token, Token> Tok(TokenType type, string text) =>
        Token(t => t.Type == type && t.Text.Equals(text, StringComparison.OrdinalIgnoreCase)
        );


    private static Parser<Token, Token> Symbol(TokenType type) => Token(t => t.Type == type);

    private static Parser<Token, int> IntLiteral =>
        Token(t => t.Type == TokenType.Number).Select(t => int.Parse(t.Text, CultureInfo.InvariantCulture));

    private static Parser<Token, float> AmountLiteral =>
        OneOf(
            Token(t => t.Type == TokenType.Percent).Select(t => float.Parse(t.Text.TrimEnd('%'), CultureInfo.InvariantCulture)),
            Token(t => t.Type == TokenType.Number).Select(t => float.Parse(t.Text, CultureInfo.InvariantCulture))
        );

    private static readonly Parser<Token, Unit> Comma = Symbol(TokenType.Comma).Then(Return(Unit.Value));


    /* ───────────── ENUM PARSERS ───────────── */

    public static Parser<Token, Role> RoleParser => OneOf(

        Tok(TokenType.Keyword, "Brute").ThenReturn(Role.Brute),
        Tok(TokenType.Keyword, "Artillery").ThenReturn(Role.Artillery),
        Tok(TokenType.Keyword, "Nomad").ThenReturn(Role.Nomad),
        Tok(TokenType.Keyword, "Chaos").ThenReturn(Role.Chaos),
        Tok(TokenType.Keyword, "Blessing").ThenReturn(Role.Blessing),
        Tok(TokenType.Keyword, "Execution").ThenReturn(Role.Execution)
    );

    public static Parser<Token, Targetability> TargetabilityParser => OneOf(
        Tok(TokenType.Keyword, "Self").ThenReturn(Targetability.Self),
        Tok(TokenType.Keyword, "Ally").ThenReturn(Targetability.Ally),
        Tok(TokenType.Keyword, "Allies").ThenReturn(Targetability.Allies),
        Tok(TokenType.Keyword, "Enemy").ThenReturn(Targetability.Enemy),
        Tok(TokenType.Keyword, "Enemies").ThenReturn(Targetability.Enemies)
    );

    public static Parser<Token, TargetMechanicType> TargetMechanicTypeParser => OneOf(
        Tok(TokenType.Keyword, "MultiTarget").ThenReturn(TargetMechanicType.MultiTarget),
        Tok(TokenType.Keyword, "MultiHit").ThenReturn(TargetMechanicType.MultiHit),
        Tok(TokenType.Keyword, "SingleTarget").ThenReturn(TargetMechanicType.SingleTarget),
        Tok(TokenType.Keyword, "SingleHit").ThenReturn(TargetMechanicType.SingleHit),
        Tok(TokenType.Keyword, "Random").ThenReturn(TargetMechanicType.Random)
    );

    public static Parser<Token, TargetMechanic> TargetMechanicParser =>
        from mech in TargetMechanicTypeParser
        from value in Try(
                Symbol(TokenType.LParen).Then(IntLiteral).Before(Symbol(TokenType.RParen))
            ).Optional()
        select new TargetMechanic(mech, value.GetValueOrDefault());

    public static Parser<Token, List<TargetMechanic>> TargetMechanicGroupParser =>
        from _l in Symbol(TokenType.LBracket)
        from items in TargetMechanicParser.Separated(Comma)
        from _r in Symbol(TokenType.RBracket)
        select items.ToList();

    /* ───────────── DAMAGE MECHANIC ───────────── */

    public static Parser<Token, DamageMechanicType> DamageMechanicTypeParser => OneOf(
        Tok(TokenType.Keyword, "Piercing").ThenReturn(DamageMechanicType.Piercing),
        Tok(TokenType.Keyword, "Spiral").ThenReturn(DamageMechanicType.Spiral)
    );

    public static Parser<Token, DamageMechanic> DamageMechanicAtom =>
        from mech in DamageMechanicTypeParser
        from value in Try(Symbol(TokenType.LParen).Then(AmountLiteral).Before(Symbol(TokenType.RParen))).Optional()
        select new DamageMechanic(mech, value.HasValue ? value.Value : 0f, null);

    public static Parser<Token, List<DamageMechanic>> DamageMechanicGroupParser =>
        from _l in Symbol(TokenType.LBracket)
        from items in DamageMechanicAtom.Separated(Comma)
        from _r in Symbol(TokenType.RBracket)
        select items.ToList();

    /* ───────────── ELEMENT ───────────── */

    public static Parser<Token, Element> ElementParser => OneOf(
        Tok(TokenType.Keyword, "Fire").ThenReturn(Element.Fire),
        Tok(TokenType.Keyword, "Poison").ThenReturn(Element.Poison),
        Tok(TokenType.Keyword, "Ice").ThenReturn(Element.Ice),
        Tok(TokenType.Keyword, "Water").ThenReturn(Element.Water),
        Tok(TokenType.Keyword, "Dark").ThenReturn(Element.Dark),
        Tok(TokenType.Keyword, "Light").ThenReturn(Element.Light),
        Tok(TokenType.Keyword, "Electrical").ThenReturn(Element.Electrical)
    );

    public static Parser<Token, DamageFormula> DamageFormulaParser => OneOf(
        Tok(TokenType.Keyword, "Magical").ThenReturn(DamageFormula.Magical),
        Tok(TokenType.Keyword, "Physical").ThenReturn(DamageFormula.Physical)
    );

    /* ───────────── DAMAGE EFFECT ───────────── */

    public static Parser<Token, DamageEffectIR> DamageEffectParser =>
        from _deals in Tok(TokenType.Keyword, "Deals")
        from formula in DamageFormulaParser
        from baseDamage in Symbol(TokenType.LParen).Then(IntLiteral).Before(Symbol(TokenType.RParen))
        from element in ElementParser.Optional()
        from _dmg in Tok(TokenType.Keyword, "damage")
        from withMechs in Try(
                from _w in Tok(TokenType.Keyword, "with")
                from ms in DamageMechanicGroupParser
                select ms
            ).Optional()
        select new DamageEffectIR(
            Subject.Target,
            new DamageType(formula, element.GetValueOrDefault(Element.None), baseDamage),
            withMechs.HasValue ? withMechs.Value : null
        );

    /* ───────────── MODIFIERS ───────────── */
    public static Parser<Token, List<EffectIR>> EffectBlockParser =>
        from _l in Symbol(TokenType.LBrace)
        from effects in Try(TimedEffectParser.Select(e => (EffectIR)e)).Or(DamageEffectParser.Select(e => (EffectIR)e)).Separated(Comma)
        from _r in Symbol(TokenType.RBrace)
        select effects.ToList();

    
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
    /* ───────────── Side Effects ──────── */
    public static Parser<Token, SideEffectMechanicType> SideEffectMechanicTypeParser => OneOf(
        Tok(TokenType.Keyword, "Bounce").ThenReturn(SideEffectMechanicType.Bounce),
        Tok(TokenType.Keyword, "Splash").ThenReturn(SideEffectMechanicType.Splash)
    );
    
    public static Parser<Token, SideEffectMechanic> SideEffectMechanicParser =>
        OneOf(
            Tok(TokenType.Keyword, "Bounce").Then(
                Symbol(TokenType.LParen)
                    .Then(AmountLiteral)
                    .Before(Symbol(TokenType.RParen))
            ).Select(value => new SideEffectMechanic(SideEffectMechanicType.Bounce, value)),
        
            Tok(TokenType.Keyword, "Splash").Then(
                Symbol(TokenType.LParen)
                    .Then(AmountLiteral)
                    .Before(Symbol(TokenType.RParen))
            ).Select(value => new SideEffectMechanic(SideEffectMechanicType.Splash, value))
        );


    
    public static Parser<Token, SideEffectsIR> SideEffectsParser =>
        from _after in Tok(TokenType.Keyword, "afterwards")
        from effect in SideEffectMechanicParser
        from condition in SimpleConditionParser.Optional()
        select new SideEffectsIR(
            new List<SideEffectMechanic> { effect },
            condition.HasValue ? condition.Value : null
        );

    
    /* ───────────── Conditions ──────── */
    
    public static Parser<Token, Condition> SimpleConditionParser =>
        from _if in Tok(TokenType.Keyword, "if")
        from _roll in Tok(TokenType.Keyword, "roll")
        from op in OneOf(
            Tok(TokenType.Symbol, "<").ThenReturn(Op.Lt),
            Tok(TokenType.Symbol, "<=").ThenReturn(Op.Le),
            Tok(TokenType.Symbol, ">").ThenReturn(Op.Gt),
            Tok(TokenType.Symbol, ">=").ThenReturn(Op.Ge),
            Tok(TokenType.Symbol, "==").ThenReturn(Op.Eq),
            Tok(TokenType.Symbol, "!=").ThenReturn(Op.Eq) // or NotEqual if you add it
        )
        from value in IntLiteral
        select new Condition(Subject.Result, Field.Roll, op, value);

    
    /* ───────────── SUPPORT ───────────── */
    
    
    public static Parser<Token, string> Identifier =>
        Token(t => t.Type == TokenType.Identifier || t.Type == TokenType.Keyword)
            .Select(t => t.Text);

    public static Parser<Token, SupportEffectIR> ElementSupportIRParser =>
        ElementParser.Select(e => (SupportEffectIR)new ElementSupportIR(e));

    public static Parser<Token, SupportEffectIR> DamageSupportIRParser =>
        from mech in DamageMechanicTypeParser
        from value in Symbol(TokenType.LParen).Then(AmountLiteral).Before(Symbol(TokenType.RParen))
        select (SupportEffectIR)new DamageSupportIR(mech, value);

    public static Parser<Token, List<SupportEffectIR>> SupportEffectListParser =>
        from _l in Symbol(TokenType.LBracket)
        from items in OneOf(DamageSupportIRParser, ElementSupportIRParser).Separated(Comma)
        from _r in Symbol(TokenType.RBracket)
        select items.ToList();
    
    
    public static Parser<Token, string> AdjectiveAnnotationParser =>
        from _lparen in Symbol(TokenType.LParen)
        from adjectiveKey in Tok(TokenType.Keyword, "Adjective")
        from _eq in Tok(TokenType.Symbol, "=")
        from adjectiveValue in Identifier 
        from _rparen in Symbol(TokenType.RParen)
        select adjectiveValue;

    
    public static Parser<Token, List<SupportEffectIR>> SupportEffectParser =>
        from _adds in Tok(TokenType.Keyword, "Adds")
        from effects in Try(SupportEffectListParser) // case: [Fire, Piercing(50)]
            .Or(DamageSupportIRParser.Select(e => new List<SupportEffectIR> { e })) // case: Piercing(50)
            .Or(ElementSupportIRParser.Select(e => new List<SupportEffectIR> { e })) // case: Fire
        from _to in Tok(TokenType.Keyword, "to")
        from _damage in Tok(TokenType.Keyword, "damage")
        select effects;

    public static Parser<Token, SupportIR> SupportParser =>
        from _support in Tok(TokenType.Keyword, "Support")
        from _1 in Symbol(TokenType.LParen)
        from role in RoleParser.Before(Symbol(TokenType.RParen))
        from _colon in Symbol(TokenType.Colon)
        from effects in SupportEffectParser
        from adjective in AdjectiveAnnotationParser.Optional()
        select new SupportIR(role, effects, adjective.HasValue ? adjective.Value : null);




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
        from maybeTargeting in Try(
            from _targets in Tok(TokenType.Keyword, "Targets")
            from tAbility in TargetabilityParser
            from _with in Tok(TokenType.Keyword, "with")
            from tMechs in Try(TargetMechanicGroupParser)
                .Or(TargetMechanicParser.Separated(Comma).Select(ms => ms.ToList()))
            from _comma in Comma
            select new Targeting(tAbility, tMechs.ToList())
        ).Optional()
        from effect in Try(
            TimedEffectParser.Select(e => (EffectIR)e)
                .Or(DamageEffectParser.Select(e => (EffectIR)e))
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

    
    /* ───────────── HEX WRAPPER ───────────── */

    public static Parser<Token, object> HexParser =>
        Try(AbilityParser.Select(a => (object)a))
            .Or(SupportParser.Select(s => (object)s));
    
}
