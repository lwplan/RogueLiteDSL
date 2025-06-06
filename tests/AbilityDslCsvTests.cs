using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Components.Root;
using CsvHelper;
using CsvHelper.Configuration;
using DSLApp1.Dsl;
using Pidgin;
using Xunit;
using Xunit.Abstractions;

namespace DSLApp1.Tests.Dsl
{
    /// <summary>
    /// Reads <c>TestData/abilities.csv</c> and checks each ProposedDSL line
    /// against the DSL parser.  Lines flagged “Yes” must parse, “No” must still
    /// fail (until you flip them to Yes).
    /// </summary>
    public sealed class AbilityDslCsvTests
    {
        
        private readonly ITestOutputHelper _output;
        private static readonly string SheetId = "1O9QoC-a7ZlYEijzzvyAcg8KNZw8j9kjh_HjwE5il4T0";
        private static readonly string SheetName = "abilities"; // match the tab name exactly
        private static readonly Task<List<object[]>> CachedRows = LoadRows();

        public AbilityDslCsvTests(ITestOutputHelper output) => _output = output;

        public static async Task<List<object[]>> LoadRows()
        {
            var loader = new GoogleCsvLoader(SheetId);
            var records = await loader.LoadCsvRecords(SheetName);

            return records
                .Where(r => r.TryGetValue("Test", out var test) && test.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                .Select(r => new object[]
                {
                    r["Name"],
                    r["ProposedDSL"],
                    true
                    
                })
                .ToList();
        }

        public static IEnumerable<object[]> CsvRows()
        {
            return CachedRows.Result;
        }

        [Theory]
        [MemberData(nameof(CsvRows))]
        public void Csv_ProposedDsl_Matches_CurrentGrammar(string name, string proposedDsl, bool shouldPass)
        {
            
            // var expanded = DslMacroExpander.ExpandMacros(proposedDsl);
            var tokens = DslTokenizer.Tokenize(proposedDsl);
            
            foreach (var t in tokens)
                _output.WriteLine($"{t.Type}: '{t.Text}'");

            var parser = DslParsers.HexParser;

            if (shouldPass)
            {
                var ir = parser.ParseOrThrow(tokens);
                Assert.NotNull(ir);
            }
            else
            {
                Assert.Throws<ParseException>(() => parser.ParseOrThrow(tokens));
            }
        }
    }
}
