using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public static partial class DslParsers
{
    
    /* ───────────── TARGETING PARSERS ───────────── */
        
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
    
    public static Parser<Token, Targeting> TargetingParser =>
        from _targets in Tok(TokenType.Keyword, "Targets")
        from tAbility in TargetabilityParser
        from maybeMechs in Try(
            from _with in Tok(TokenType.Keyword, "with")
            from tMechs in Try(TargetMechanicGroupParser)
                .Or(TargetMechanicParser.Separated(Comma).Select(ms => ms.ToList()))
            select tMechs
        ).Optional()
        from _comma in Comma.Optional()  // ✅ optional, don't require one after targeting
        select new Targeting(tAbility, maybeMechs.HasValue ? maybeMechs.Value.ToList() : new List<TargetMechanic>());

    
    
}