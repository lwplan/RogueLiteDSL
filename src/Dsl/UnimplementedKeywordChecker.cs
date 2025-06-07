using System.Collections.Generic;
using System.Linq;

namespace DSLApp1.Dsl;

/// <summary>
/// Scans token streams for keywords representing mechanics that are not yet implemented.
/// </summary>
public static class UnimplementedKeywordChecker
{
    private static readonly HashSet<string> Unimplemented = new(
        new[]
        {
            "Bleed",
            "Cleanse",
            "RandomBuffOrDebuff",
            "DefensiveStance",
            "HealBlock",
            "Counter",
            "EchoDamage",
            "Recoil",
            "SelfDamage",
            "DelaySelf",
            "SkipSelf",
            "Immunity",
            "Untargetable",
            "Weaken",
            "Elemental",
        },
        System.StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Returns any unimplemented keywords found in the given token sequence.
    /// </summary>
    public static IReadOnlyList<string> Find(IEnumerable<Token> tokens)
    {
        return tokens
            .Where(t => t.Type == TokenType.Keyword && Unimplemented.Contains(t.Text))
            .Select(t => t.Text)
            .Distinct(System.StringComparer.OrdinalIgnoreCase)
            .ToList();
    }
}
