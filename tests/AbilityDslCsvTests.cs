using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Components.Root;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
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
        private static readonly Task<List<object[]>> CachedRows = LoadRows();

        public AbilityDslCsvTests(ITestOutputHelper output) => _output = output;

        public static async Task<List<object[]>> LoadRows()
        {
            var csvPath = Path.Combine(AppContext.BaseDirectory, "TestData", "abilities.csv");
            using var reader = new StreamReader(csvPath);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null,
                MissingFieldFound = null,
            };
            using var csv = new CsvReader(reader, config);
            var records = csv.GetRecords<AbilityRow>().ToList();

            return records
                .Where(r => r.Test.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                .Where(r => r.SyntaxCheck.Equals("OK", StringComparison.OrdinalIgnoreCase))
                .Select(r => new object[] { r.Name, r.ProposedDSL, true })
                .ToList();
        }

        private record AbilityRow
        {
            public string Name { get; set; } = string.Empty;
            public string Test { get; set; } = string.Empty;
            public string? Legacy { get; set; }
            [Name("Syntax Check")]
            public string SyntaxCheck { get; set; } = string.Empty;
            public string ProposedDSL { get; set; } = string.Empty;
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
