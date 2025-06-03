// using System.Linq;
// using DSLApp1.Dsl;
// using DSLApp1.Model;
// using Pidgin;
// using Xunit;
// using static Pidgin.Parser;
//
// namespace DSLApp1.Tests
// {
//     public sealed class TargetingParserTests
//     {
//         [Fact]
//         public void Parses_Targeting_With_MultipleMechanics()
//         {
//             const string input = "Targets Enemies with MultiHit(6), Random";
//                 //                1234567890123456789012345678
//
//
//             var result = parser.ParseOrThrow(input, null);
//
//             Assert.Equal(Targetability.Enemies, result.Targetability);
//             Assert.Collection(result.TargetMechanics,
//                 m => Assert.Equal(TargetMechanicType.MultiHit, m.TargetMechanicType),
//                 m => Assert.Equal(TargetMechanicType.Random, m.TargetMechanicType)
//             );
//         }
//     }
// }