using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public static partial class DslParsers
{
    /* ───────────── Side Effects ──────── */

    
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


}