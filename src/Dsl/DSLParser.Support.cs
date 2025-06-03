using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;
using static Pidgin.Parser<DSLApp1.Dsl.Token>;

namespace DSLApp1.Dsl;

public static partial class DslParsers
{
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


    public static Parser<Token, List<SupportEffectIR>> SupportMechanicsElementListParser =>
        from effects in Try(SupportEffectListParser) // [Fire, Piercing(50)]
            .Or(DamageSupportIRParser.Select(e => new List<SupportEffectIR> { e })) // Piercing(50)
            .Or(ElementSupportIRParser.Select(e => new List<SupportEffectIR> { e })) // Fire
        from _to in Tok(TokenType.Keyword, "to")
        from _damage in Tok(TokenType.Keyword, "damage")
        select effects;

    
    public static Parser<Token, SupportEffectIR> EffectSupportIRParser =>
        EffectParser.Select(e => (SupportEffectIR)new EffectSupportIR(e));
    
    public static Parser<Token, List<SupportEffectIR>> SupportEffectParser =>
        from _adds in Tok(TokenType.Keyword, "Adds")
        from effects in Try(SupportMechanicsElementListParser)
            .Or(EffectSupportIRParser.Select(e => new List<SupportEffectIR> { e }))
        select effects;
    

    public static Parser<Token, SupportIR> SupportParser =>
        from _support in Tok(TokenType.Keyword, "Support")
        from _1 in Symbol(TokenType.LParen)
        from role in RoleParser.Before(Symbol(TokenType.RParen))
        from _colon in Symbol(TokenType.Colon)
        from effects in SupportEffectParser
        from condition in DslParsers.SimpleConditionParser.Optional()
        from adjective in AdjectiveAnnotationParser.Optional()
        select new SupportIR(
            role,
            effects,
            adjective.GetValueOrDefault(),
            condition.HasValue ? condition.Value : null
        );


}