using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DSLApp1.Dsl
{
    /// <summary>
    /// Utility for validating raw DSL text before macro expansion.
    /// Ensures all alphabetic sequences are either known keywords or macros.
    /// </summary>
    public static class AlphaWordValidator
    {
        private static readonly HashSet<string> Keywords = new(
            new[]
            {
                "Afterwards","Ability","Inflicts","Deals","With","Physical","damage",
                "For","Charges","Adds","If","Against","When","roll","Fire","Poison",
                "Ice","Water","Earth","Dark","Light","Electrical","then","Support",
                "Outfit","Spiral","Artillery","Brute","Nomad","Chaos","Execution","Holy",
                "Piercing","Adjective","Self","Ally","Allies","Enemy","Enemies",
                "Magical","to","ExtraDamage","Crit","ShieldBreaker","MultiHit",
                "MultiTarget","Random","turns","rounds","turn","round","Start","End",
                "Buff","Debuff","Vulnerability","Protection","Power","Frailty",
                "Blessing","Curse","Stun","Defensive","Revival","Shield","Cleanse",
                "Bounce","Splash","Exhaust","CoolOff","Invokes","Delay","Advance",
                "Swap","Shuffle","All","Miss","Attack","Defense","Intelligence",
                "Resistance","Initiative","Applies","Mana","Hp","HpPercent",
                "Opportunity","User","Target","Missed","Kills","Kill","Hits","On",
                "Restores","Drains","Gives","Takes","Targeting","UserSelected",
                "Neutral","Strongest","Weakest","NextUp","LastUp","Single","Multiple"
            },
            StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Finds any words not known to the DSL keyword list or macro list.
        /// Returns the unknown words in their original casing.
        /// </summary>
        public static IReadOnlyList<string> FindUnknownWords(string input, IEnumerable<MacroDefinition> macros)
        {
            var macroNames = new HashSet<string>(
                macros.Select(m => m.Name.TrimStart('@')),
                StringComparer.OrdinalIgnoreCase);

            var unknown = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Check macros first
            foreach (Match m in Regex.Matches(input, @"@(?<name>\w+)\[[^\]]+\]"))
            {
                var name = m.Groups["name"].Value;
                if (!macroNames.Contains(name))
                    unknown.Add("@" + name);
            }

            // Remove macro expressions so their internal words are ignored
            var cleaned = Regex.Replace(input, @"@\w+\[[^\]]+\]", " ");

            foreach (Match m in Regex.Matches(cleaned, @"[A-Za-z]+"))
            {
                var word = m.Value;
                if (!Keywords.Contains(word) && !macroNames.Contains(word))
                    unknown.Add(word);
            }

            return unknown.ToList();
        }
    }
}
