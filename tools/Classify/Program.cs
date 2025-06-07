using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using DSLApp1.Dsl;
using Pidgin;
using Components.Root;

class AbilityRow
{
    public string Name { get; set; } = string.Empty;
    public string Test { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ProposedDSL { get; set; } = string.Empty;
    public string SyntaxCheck { get; set; } = string.Empty;
    public string? Rarity { get; set; }
    public string? ManaCost { get; set; }
    public string? Notes { get; set; }
}

class Program
{
    static int Main(string[] args)
    {
        var csvPath = Path.Combine("..", "..", "tests", "TestData", "abilities.csv");
        var macrosPath = Path.Combine("..", "..", "tests", "TestData", "macros.csv");
        using var reader = new StreamReader(csvPath);
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HeaderValidated = null,
            MissingFieldFound = null,
        };
        using var csv = new CsvReader(reader, config);
        var records = csv.GetRecords<AbilityRow>().ToList();
        var macros = LoadMacros(macrosPath);
        Console.Error.WriteLine($"Loaded {macros.Count} macros");

        foreach (var r in records)
        {
            Console.Error.WriteLine($"Checking {r.Name}");
            var expanded = System.Text.RegularExpressions.Regex.Replace(
                r.ProposedDSL,
                @"@\w+\[[IVXLCDM]+\]",
                m => MacroExpander.Expand(m.Value, macros));
            Console.Error.WriteLine($"Expanded: {expanded}");
            var tokens = DslTokenizer.Tokenize(expanded);
            var unimpl = UnimplementedKeywordChecker.Find(tokens);
            string result;
            if (unimpl.Any())
            {
                result = "Unimplemented";
            }
            else
            {
                try
                {
                    var ir = DslParsers.HexParser.ParseOrThrow(tokens);
                    result = "Pass";
                }
                catch (Exception ex)
                {
                    result = "Fail";
                }
            }
            Console.WriteLine($"{r.Name}: {result}");
        }
        return 0;
    }
    static List<MacroDefinition> LoadMacros(string path)
    {
        if (!File.Exists(path)) return new();
        var lines = File.ReadAllLines(path)
            .Where(l => !string.IsNullOrWhiteSpace(l))
            .ToArray();
        if (lines.Length == 0) return new();
        var headers = GoogleCsvLoader.ParseCsvLine(lines[0]);
        var records = new List<Dictionary<string, string>>();
        for (int i = 1; i < lines.Length; i++)
        {
            var values = GoogleCsvLoader.ParseCsvLine(lines[i]);
            var dict = headers.Zip(values, (h, v) => new { h, v })
                .ToDictionary(x => x.h.Trim(), x => x.v.Trim());
            records.Add(dict);
        }
        var macros = new List<MacroDefinition>();
        var argPattern = new System.Text.RegularExpressions.Regex(@"(?<name>\w+)#\[(?<values>[\d,\s]+)\]");
        foreach (var record in records)
        {
            if (!record.TryGetValue("@Keyword[X]", out var rawKeyword) ||
                !record.TryGetValue("macro", out var macroBody))
                continue;
            record.TryGetValue("Class", out var macroClass);
            record.TryGetValue("Tool Tip", out var tooltip);
            var indexArgs = new Dictionary<string, List<int>>();
            string template = macroBody;
            foreach (System.Text.RegularExpressions.Match m in argPattern.Matches(macroBody))
            {
                var argName = m.Groups["name"].Value;
                var values = m.Groups["values"].Value
                    .Split(',')
                    .Select(v => int.TryParse(v.Trim(), out var n) ? n : -1)
                    .Where(n => n >= 0)
                    .ToList();
                indexArgs[argName] = values;
                template = template.Replace(m.Value, argName);
            }
            var nameMatch = System.Text.RegularExpressions.Regex.Match(rawKeyword, @"@(?<name>\w+)\[\w+\]");
            if (!nameMatch.Success) continue;
            var name = "@" + nameMatch.Groups["name"].Value;
            macros.Add(new MacroDefinition(name, template, indexArgs, macroClass ?? "", tooltip ?? ""));
        }
        return macros;
    }
}
