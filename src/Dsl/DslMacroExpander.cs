using System.Text.RegularExpressions;
using DSLApp1.Dsl;

public static class MacroExpander
{
    private static int RomanToInt(string roman)
    {
        var map = new Dictionary<char, int>
        {
            ['I'] = 1, ['V'] = 5, ['X'] = 10, ['L'] = 50, ['C'] = 100,
            ['D'] = 500, ['M'] = 1000
        };
        int result = 0, prev = 0;

        foreach (var c in roman.Reverse())
        {
            int value = map[c];
            result += value < prev ? -value : value;
            prev = value;
        }

        return result;
    }

    public static string Expand(string input, List<MacroDefinition> macros)
    {
        var match = Regex.Match(input, @"@(?<name>\w+)\[(?<arg>[IVXLCDM]+)\]");
        if (!match.Success)
            return input;

        var macroName = "@" + match.Groups["name"].Value;
        var argRoman = match.Groups["arg"].Value;
        int index = RomanToInt(argRoman) - 1;

        var macro = macros.FirstOrDefault(m => m.Name == macroName);
        if (macro == null)
            return input;

        string expanded = macro.Template;

        foreach (var (arg, values) in macro.IndexArgs)
        {
            if (index < 0 || index >= values.Count) continue;
            var value = values[index];
            expanded = expanded.Replace(arg, value.ToString());
        }

        return expanded;
    }
}