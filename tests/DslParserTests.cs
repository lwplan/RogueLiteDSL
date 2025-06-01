// using System.Linq;
// using DSLApp1.Dsl;
// using Pidgin;
// using Xunit;
//
// namespace DSLApp1.Tests;
//
// /// <summary>
// /// Golden-path and edge-case tests for the low-level DSL parsers.
// /// If any of these fail you know the AST or grammar drifted.
// /// </summary>
// public sealed class DslParsersTests
// {
//     private static T Parse<T>(Parser<char,T> parser, string input)
//         => parser.ParseOrThrow(input, null);
//
//     /* ───────────────  ENUM PARSERS  ─────────────── */
//
//     [Theory]
//     [InlineData("Piercing", DamageMechanicType.Piercing)]
//     [InlineData("Spiral",   DamageMechanicType.Spiral)]
//     [InlineData("Magical",  DamageMechanicType.Magical)]
//     public void DamageMechanicTypeParser_ParsesValidTokens(string text, DamageMechanicType expected)
//     {
//         var result = Parse(DslParsers.DamageMechanicTypeParser, text);
//         Assert.Equal(expected, result);
//     }
//
//     [Theory]
//     [InlineData("Fire",       Element.Fire)]
//     [InlineData("Electrical", Element.Electrical)]
//     [InlineData("Dark",       Element.Dark)]
//     public void ElementParser_ParsesValidTokens(string text, Element expected)
//     {
//         var result = Parse(DslParsers.ElementParser, text);
//         Assert.Equal(expected, result);
//     }
//
//     /* ───────────────  DAMAGE MECHANIC PARSER  ─────────────── */
//
//     [Fact]
//     public void DamageMechanicParser_ParsesMechanicWithFloat()
//     {
//         const string text = "[Piercing(12.5)]";
//         var dm = Parse(DslParsers.DamageMechanicParser, text);
//
//         var expected = new DamageMechanic(DamageMechanicType.Piercing, 12.5f, null);
//         Assert.Equal(expected, dm);
//     }
//
//     /* ───────────────  DAMAGE EFFECT PARSER  ─────────────── */
//
//     [Fact]
//     public void DamageEffectParser_ParsesSingleMechanicEffect()
//     {
//         const string text = "Deals Fire damage with [Magical(7.2)]";
//
//         var effect = Parse(DslParsers.DamageEffectParser, text);
//
//         Assert.Equal(Subject.Target, effect.Subject);
//         Assert.Single(effect.With!);
//
//         var mech = effect.With.First();
//         Assert.Equal(DamageMechanicType.Magical, mech.MechanicType);
//         Assert.Equal(7.2f, mech.Value, 3);
//         Assert.Null(mech.Condition);
//     }
//
//     [Fact]
//     public void DamageEffectParser_ParsesMultipleMechanicsWithWhitespaceVariations()
//     {
//         const string text = "Deals Ice damage with [Piercing(10)],   [Spiral(2.0)]";
//
//         var effect = Parse(DslParsers.DamageEffectParser, text);
//
//         Assert.Equal(2, effect.With!.Count);
//
//         Assert.Collection(effect.With,
//             m =>
//             {
//                 Assert.Equal(DamageMechanicType.Piercing, m.MechanicType);
//                 Assert.Equal(10f, m.Value);
//             },
//             m =>
//             {
//                 Assert.Equal(DamageMechanicType.Spiral, m.MechanicType);
//                 Assert.Equal(2f, m.Value);
//             });
//     }
//
//     /* ───────────────  NEGATIVE TESTS  ─────────────── */
//
//     [Theory]
//     [InlineData("[Unknown(1)]")]
//     [InlineData("[Piercing()]")]          // missing value
//     [InlineData("[Piercing(abc)]")]       // non-numeric
//     // [InlineData("Deals Fire damage")]     // missing mechanics clause
//     public void Parsers_RejectMalformedInput(string text)
//     {
//         Assert.Throws<Pidgin.ParseException<char>>(() => Parse(DslParsers.DamageEffectParser, text));
//     }
// }
