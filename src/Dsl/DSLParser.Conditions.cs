using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public static partial class DslParsers
{
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
            Tok(TokenType.Symbol, "!=").ThenReturn(Op.Ne) 
        )
        from value in IntLiteral
        select new Condition(Subject.Result, Field.Roll, op, value);

}