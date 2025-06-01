using Pidgin;
using static Pidgin.Parser;
using static Pidgin.Parser<char>;

namespace DSLApp1.Dsl
{
    public static class DslGrammar
    {
        public static Parser<char, string> Identifier =>
            Letter.Then(LetterOrDigit.ManyString(), (head, tail) => head + tail);

        public static Parser<char, string> QuotedString =>
            Token('"')
                .Then(AnyCharExcept('"').ManyString(), (open, content) => content)
                .Before(Char('"'));

        public static Parser<char, string> Number =>
            Digit.AtLeastOnceString();

        public static Parser<char, string> Expression =>
            Try(QuotedString).Or(Try(Number)).Or(Identifier);

        public static Parser<char, string> BurnMacro =>
            from _1 in String("@Burn")
            from _2 in Char('(')
            from dmg in Expression.Before(Char(','))
            from dur in Expression.Before(Char(')'))
            select $"Modifier(effect: target.damage({dmg}), duration: {dur})";

        public static string ParseBurn(string input)
        {
            return BurnMacro.ParseOrThrow(input);
        }
    }
}