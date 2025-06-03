using System.Globalization;
using Pidgin;
using static Pidgin.Parser;
using static Pidgin.Parser<DSLApp1.Dsl.Token>;

namespace DSLApp1.Dsl;


public record Token(TokenType Type, string Text);

public static partial class DslParsers
{

    
    /* ───────────── Helpers  ───────────── */

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
    

}