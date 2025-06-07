using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DSLApp1.Dsl;

namespace DSLApp1.Dsl
{
    public enum TokenType
    {
        Keyword,
        Number,
        EndOfFile,
        Percent,
        Symbol,
    }


    public static class DslTokenizer
    {


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
                    tokens.Add(new Token(TokenType.Keyword, word));
                }
                else if (char.IsDigit(input[i]))
                {
                    while (i < input.Length && char.IsDigit(input[i])) i++;

                    if (i < input.Length && input[i] == '%')
                    {
                        i++;
                        tokens.Add(new Token(TokenType.Percent, input.Substring(start, i - start)));
                    }
                    else
                    {
                        tokens.Add(new Token(TokenType.Number, input.Substring(start, i - start)));
                    }
                }
                else if (input[i] == '=' && i + 1 < input.Length && input[i + 1] == '=')
                {
                    tokens.Add(new Token(TokenType.Symbol, "=="));
                    i += 2;
                }
                else if (input[i] == '!' && i + 1 < input.Length && input[i + 1] == '=')
                {
                    tokens.Add(new Token(TokenType.Symbol, "!="));
                    i += 2;
                }
                else if (input[i] == '<' && i + 1 < input.Length && input[i + 1] == '=')
                {
                    tokens.Add(new Token(TokenType.Symbol, "<="));
                    i += 2;
                }
                else if (input[i] == '>' && i + 1 < input.Length && input[i + 1] == '=')
                {
                    tokens.Add(new Token(TokenType.Symbol, ">="));
                    i += 2;
                }
                else
                {
                    var token = input[i] switch
                    {
                        '(' => new Token(TokenType.Symbol, "("),
                        ')' => new Token(TokenType.Symbol, ")"),
                        '[' => new Token(TokenType.Symbol, "["),
                        ']' => new Token(TokenType.Symbol, "]"),
                        ',' => new Token(TokenType.Symbol, ","),
                        ':' => new Token(TokenType.Symbol, ":"),
                        '{' => new Token(TokenType.Symbol, "{"),
                        '}' => new Token(TokenType.Symbol, "}"),
                        '<' => new Token(TokenType.Symbol, "<"),
                        '>' => new Token(TokenType.Symbol, ">"),
                        '=' => new Token(TokenType.Symbol, "="),
                        '!' => new Token(TokenType.Symbol, "!"),
                        '\'' => new Token(TokenType.Symbol, "'"),
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


