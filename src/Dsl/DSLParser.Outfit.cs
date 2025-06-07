using System.Collections.Generic;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public record OutfitIR(
    List<ModifierEffectIR> Effects,
    List<Compatibility> RoleCompatibilities
);

public static partial class DslParsers
{
    public static Parser<Token, OutfitIR> OutfitParser =>
        from _outfit in Tok.Outfit
        from role in Try(
            Tok.LParen.Then(RoleParser).Before(Tok.RParen)
        ).Optional()
        from _colon in Tok.Colon
        from effects in AppliesEffectParser.Separated(Tok.Then).Select(e => e.ToList())
        select new OutfitIR(
            effects,
            role.HasValue ? new List<Compatibility>{ role.Value } : new List<Compatibility>()
        );
}
