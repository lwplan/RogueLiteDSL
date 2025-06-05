using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;
using static Pidgin.Parser<DSLApp1.Dsl.Token>;

namespace DSLApp1.Dsl;



public abstract record SupportEffectIR;

public record DamageSupportIR(DamageMechanicType Mechanic, float Value) : SupportEffectIR;

public record ElementSupportIR(Element Element) : SupportEffectIR;

public record EffectSupportIR(EffectIR Effect) : SupportEffectIR;

public record SideEffectSupportIR(SideEffectsIR SideEffects) : SupportEffectIR;


public record SupportIR(
    Compatibility Compatibility,
    List<SupportEffectIR> SupportEffects,
    Condition? When = null
);

public static partial class DslParsers
{
    /* ───────────── SUPPORT ───────────── */
    
    public static Parser<Token, SupportEffectIR> ElementSupportIRParser =>
        ElementParser.Select(e => (SupportEffectIR)new ElementSupportIR(e));

    public static Parser<Token, SupportEffectIR> DamageSupportIRParser =>
        from mech in DamageMechanicTypeParser
        from value in Tok.LParen.Then(AmountLiteral).Before(Tok.RParen)
        select (SupportEffectIR)new DamageSupportIR(mech, value);

    public static Parser<Token, SupportEffectIR> EffectSupportIRParser =>
        AppliesEffectParser.Select(e => (SupportEffectIR)new EffectSupportIR(e));

    public static Parser<Token, SupportEffectIR> BasicSupportEffectParser =>
        DamageSupportIRParser
            .Or(ElementSupportIRParser)
            .Or(EffectSupportIRParser)
            .Or(SideEffectSupportIRParser);

    public static Parser<Token, List<SupportEffectIR>> SupportEffectListParser =>
        from _l in Tok.LBracket
        from items in BasicSupportEffectParser.Separated(Comma)
        from _r in Tok.RBracket
        select items.ToList();

    public static Parser<Token, List<SupportEffectIR>> SupportEffectListOrSingleParser =>
        Try(SupportEffectListParser)
            .Or(BasicSupportEffectParser.Select(x => new List<SupportEffectIR> { x }));

    public static Parser<Token, List<SupportEffectIR>> SupportMechanicsElementListParser =>
        from effects in SupportEffectListOrSingleParser
        from _to in Tok.To
        from _damage in Tok.Damage
        select effects;

    public static Parser<Token, List<SupportEffectIR>> SupportEffectParser =>
        from _adds in Tok.Adds
        from effects in Try(SupportMechanicsElementListParser)
            .Or(EffectSupportIRParser.Select(e => new List<SupportEffectIR> { e }))
        
        select effects;
    
    public static Parser<Token, SupportEffectIR> SideEffectSupportIRParser =>
        SideEffectsParser.Select(e => (SupportEffectIR)new SideEffectSupportIR(e));

    
    public static Parser<Token, SupportIR> SupportParser =>
        from _support in Tok.Support
        from _1 in Tok.LParen
        from role in RoleParser.Before(Tok.RParen)
        from _colon in Tok.Colon
        from effects in SupportEffectParser
        from condition in ConditionParser.Optional()
        select new SupportIR(
            role,
            effects,
            condition.GetValueOrDefault()
        );
}
