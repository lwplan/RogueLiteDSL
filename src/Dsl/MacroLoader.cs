using System.Text.RegularExpressions;
using Components.Root;

namespace DSLApp1.Dsl;

public record MacroDefinition(
    string Name,                  // e.g., "@Frozen"
    string Template,              // starts as, "Deals Ice Physical(X#(4,6,7,9,10)) damage", parsed to Deals Ice Physical(X) damage
    Dictionary<string, List<int>> IndexArgs,  // e.g., { "X": [4,6,7,9,10] } if x is specified in roman numerals tbe list value is used, otherwise the value is used.
    string Category,
    string Tooltip
);


public static class MacroLoader
{
    public static async Task<List<MacroDefinition>> LoadFromGoogleSheet(GoogleCsvLoader loader, string sheetName)
    {
        var records = await loader.LoadCsvRecords(sheetName);
        var macros = new List<MacroDefinition>();

        foreach (var record in records)
        {
            if (!record.TryGetValue("@Keyword[X]", out var rawKeyword)) continue;
            if (!record.TryGetValue("macro", out var macroBody)) continue;

            record.TryGetValue("Class", out var macroClass);
            record.TryGetValue("Tool Tip", out var tooltip);

            var indexArgs = new Dictionary<string, List<int>>();
            string template = macroBody;

            var argPattern = new Regex(@"(?<name>\w+)#\((?<values>[\d,\s]+)\)");
            foreach (Match m in argPattern.Matches(macroBody))
            {
                var argName = m.Groups["name"].Value;
                var values = m.Groups["values"].Value
                    .Split(',')
                    .Select(v => int.TryParse(v.Trim(), out var n) ? n : -1)
                    .Where(n => n >= 0)
                    .ToList();

                indexArgs[argName] = values;
                template = template.Replace(m.Value, argName);  // normalize to plain placeholder
            }

            var nameMatch = Regex.Match(rawKeyword, @"@(?<name>\w+)\[\w+\]");
            if (!nameMatch.Success) continue;

            var name = "@" + nameMatch.Groups["name"].Value;

            macros.Add(new MacroDefinition(name, template, indexArgs, macroClass ?? "", tooltip ?? ""));
        }

        return macros;
    }
}

