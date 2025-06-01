using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using DSLApp1.Dsl;
using Pidgin;
using Xunit;

namespace DSLApp1.Tests.Dsl
{
    /// <summary>
    /// Reads <c>TestData/abilities.csv</c> and checks each ProposedDSL line
    /// against the DSL parser.  Lines flagged “Yes” must parse, “No” must still
    /// fail (until you flip them to Yes).
    /// </summary>
    public sealed class AbilityDslCsvTests
    {
        private static readonly string CsvPath =
            Path.Combine(AppContext.BaseDirectory, "TestData", "abilities.csv");

        /// <summary>
        /// Streams the CSV rows into xUnit’s MemberData.
        /// </summary>
        public static IEnumerable<object[]> CsvRows()
        {
            var path = CsvPath;
            using var reader = new StreamReader(CsvPath);
            var cfg = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = TrimOptions.Trim,      // eat sneaky spaces
                HeaderValidated = null,
                MissingFieldFound = null
            };
            using var csv = new CsvReader(reader, cfg);

            csv.Read();
            csv.ReadHeader();

            while (csv.Read())
            {
                var name        = csv.GetField<string>("Name");
                var shouldPass  = string.Equals(csv.GetField<string>("Test"), "Yes",
                                                StringComparison.OrdinalIgnoreCase);
                var dsl         = csv.GetField<string>("ProposedDSL");

                if (shouldPass)  // ✅ Filter: only run tests expected to succeed
                    yield return new object[] { name, dsl, true };
            }
        }

        /// <remarks>
        /// Today we only have <see cref="DslParsers.DamageEffectParser"/>.
        /// As you grow a full Ability parser, swap <c>DamageEffectParser</c>
        /// for <c>AbilityParser</c> (or whatever you name it) and the tests
        /// instantly level-up.
        /// </remarks>
        [Theory]
        [MemberData(nameof(CsvRows))]
        public void Csv_ProposedDsl_Matches_CurrentGrammar(string name,
            string proposedDsl,
            bool shouldPass)
        {
            var tokens = DslTokenizer.Tokenize(proposedDsl);
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
