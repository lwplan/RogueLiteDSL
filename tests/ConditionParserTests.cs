using System;
using System.Collections.Generic;
using DSLApp1.Dsl;
using DSLApp1.Model;
using Pidgin;
using Xunit;

namespace DSLApp1.Tests.Dsl
{
    public class ConditionParserTests
    {
        private static Condition ParseCondition(string text)
        {
            var tokens = DslTokenizer.Tokenize("Adds Fire to damage " + text);

            // Only parse the condition, skip the prefix
            var parser =
                from _ in DslParsers.SupportEffectParser
                from condition in DslParsers.ConditionParser
                select condition;

            return parser.ParseOrThrow(tokens);
        }

        [Fact]
        public void Parses_If_Roll_Less_Than_30()
        {
            var condition = ParseCondition("if roll < 30");

            Assert.NotNull(condition);
            Assert.Equal(Field.Roll, condition.Field);
            Assert.Equal(Op.Lt, condition.Op);
            Assert.Equal(30, condition.Value);
            Assert.Equal(Subject.Result, condition.Subject);
            /* fails
             Pidgin.ParseException`1[[DSLApp1.Dsl.Token, DSLApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
               Parse error.
                   unexpected Token { Type = Symbol, Text = = }
                   at line 1, col 7
                   */
        }

        [Fact]
        public void Parses_If_Roll_Equals_10()
        {
            var condition = ParseCondition("if roll == 10");
            Assert.NotNull(condition);
            Assert.Equal(Op.Eq, condition.Op);
            Assert.Equal(10, condition.Value);
        }

        [Fact]
        public void Rejects_Invalid_Token()
        {
            var ex = Assert.Throws<Exception>(() =>
                DslTokenizer.Tokenize("Adds Fire to damage if roll ~= 10")
            );

            Assert.Contains("Unexpected character '~' at position", ex.Message);
        }
    }
}