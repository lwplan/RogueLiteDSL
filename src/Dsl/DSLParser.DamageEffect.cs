using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public static partial class DslParsers
{
    /* ───────────── DAMAGE MECHANIC ───────────── */

    public static Parser<Token, DamageMechanicType> DamageMechanicTypeParser => OneOf(
        Tok(TokenType.Keyword, "Piercing").ThenReturn(DamageMechanicType.Piercing),
        Tok(TokenType.Keyword, "Spiral").ThenReturn(DamageMechanicType.Spiral),
        Tok(TokenType.Keyword, "ExtraDamage").ThenReturn(DamageMechanicType.ExtraDamage),
        Tok(TokenType.Keyword, "Crit").ThenReturn(DamageMechanicType.Crit)
    );

    public static Parser<Token, DamageMechanic> DamageMechanicAtom =>
        from mech in DamageMechanicTypeParser
        from value in Try(Symbol(TokenType.LParen).Then(AmountLiteral).Before(Symbol(TokenType.RParen))).Optional()
        select new DamageMechanic(mech, value.HasValue ? value.Value : 0f, null);

    public static Parser<Token, List<DamageMechanic>> DamageMechanicGroupParser =>
        from _l in Symbol(TokenType.LBracket)
        from items in DamageMechanicAtom.Separated(Comma)
        from _r in Symbol(TokenType.RBracket)
        select items.ToList();
    
    public static Parser<Token, DamageEffectIR> DamageEffectParser =>
        from _deals in Tok(TokenType.Keyword, "Deals")
        from formula in DamageFormulaParser
        from baseDamage in Symbol(TokenType.LParen).Then(IntLiteral).Before(Symbol(TokenType.RParen))
        from element in ElementParser.Optional()
        from _dmg in Tok(TokenType.Keyword, "damage")
        from withMechs in Try(
            from _w in Tok(TokenType.Keyword, "with")
            from ms in DamageMechanicGroupParser
            select ms
        ).Optional()
        select new DamageEffectIR(
            Subject.Target,
            new DamageType(formula, element.GetValueOrDefault(Element.None), baseDamage),
            withMechs.HasValue ? withMechs.Value : null
        );
    
}