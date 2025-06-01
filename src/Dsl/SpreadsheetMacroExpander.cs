using System.Text.RegularExpressions;

namespace DSLApp1.Dsl
{
    public class SpreadsheetMacroExpander
    {
        private readonly Dictionary<string, string> _macroTemplates;

        public SpreadsheetMacroExpander(Dictionary<string, string> macroTemplates)
        {
            _macroTemplates = macroTemplates;
        }

        public string ExpandMacros(string input)
        {
            return Regex.Replace(input, @"@(\w+)\(([^)]*)\)", match =>
            {
                string macroName = match.Groups[1].Value;
                string[] args = match.Groups[2].Value.Split(',');

                if (!_macroTemplates.TryGetValue(macroName, out string template))
                    throw new Exception($"Macro '{macroName}' not defined.");

                for (int i = 0; i < args.Length; i++)
                {
                    template = template.Replace($"${i + 1}", args[i].Trim());
                }

                return template;
            });
        }

        public static Dictionary<string, string> LoadFromMock()
        {
            // Simulated spreadsheet values
            return new Dictionary<string, string>
            {
                { "Burn", "Modifier(effect: target.damage($1), duration: $2)" },
                { "Poison", "Modifier(effect: target.damage($1), duration: $2).when(element == Poison)" }
            };
        }
    }
}