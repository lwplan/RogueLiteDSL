using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DSLApp1.Dsl;

namespace DSLApp1.Dsl
{
    public static class DslTokenizer
    {
        private static readonly HashSet<string> Keywords = new(StringComparer.OrdinalIgnoreCase)
        {
            "Ability", "Targets", "Deals", "with", "Physical", "damage", "For", "Charges", "Adds",
            "Fire", "Poison", "Ice", "Water", "Dark", "Light", "Electrical", "then", "Support",
            "Artillery", "Brute", "Nomad", "Chaos", "Blessing", "Execution", "Piercing", "Adjective",
            "Self", "Ally", "Allies", "Enemy", "Enemies", "Magical", "to",
            "MultiHit", "MultiTarget", "Random",  "turns",  "rounds", "Bounce", "Splash", "turn", "round"
        };

        public static IReadOnlyList<Token> Tokenize(string input)
        {
            var tokens = new List<Token>();
            int i = 0;

            while (i < input.Length)
            {
                if (char.IsWhiteSpace(input[i]))
                {
                    i++;
                    continue;
                }

                int start = i;

                if (char.IsLetter(input[i]))
                {
                    while (i < input.Length && (char.IsLetterOrDigit(input[i]) || input[i] == '_'))
                        i++;

                    string word = input.Substring(start, i - start);
                    string lowerWord = word.ToLowerInvariant();
                    tokens.Add(new Token(
                        Keywords.Contains(lowerWord) ? TokenType.Keyword : TokenType.Identifier,
                        Keywords.Contains(lowerWord) ? lowerWord : word
                    ));
                }
                else if (char.IsDigit(input[i]))
                {
                    while (i < input.Length && char.IsDigit(input[i]))
                        i++;

                    if (i < input.Length && input[i] == '%')
                    {
                        i++;
                        string percent = input.Substring(start, i - start);
                        tokens.Add(new Token(TokenType.Percent, percent));
                    }
                    else
                    {
                        string number = input.Substring(start, i - start);
                        tokens.Add(new Token(TokenType.Number, number));
                    }
                }
                else
                {
                    Token token = input[i] switch
                    {
                        '(' => new Token(TokenType.LParen, "("),
                        ')' => new Token(TokenType.RParen, ")"),
                        '[' => new Token(TokenType.LBracket, "["),
                        ']' => new Token(TokenType.RBracket, "]"),
                        ',' => new Token(TokenType.Comma, ","),
                        ':' => new Token(TokenType.Colon, ":"),
                        '{' => new Token(TokenType.LBrace, "{"),
                        '}' => new Token(TokenType.RBrace, "}"),
                        '%' => new Token(TokenType.Percent, "%"),
                        '<' => new Token(TokenType.Symbol, "<"),
                        '>' => new Token(TokenType.Symbol, ">"),
                        '=' => new Token(TokenType.Symbol, "="),
                        '!' => new Token(TokenType.Symbol, "!"),
                        _ => throw new Exception($"Unexpected character '{input[i]}' at position {i}")
                    };
                    tokens.Add(token);
                    i++;
                }
            }

            tokens.Add(new Token(TokenType.EndOfFile, ""));
            return tokens;
        }
        
    }
}
