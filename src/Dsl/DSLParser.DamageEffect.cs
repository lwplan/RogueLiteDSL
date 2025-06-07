using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public enum DamageMechanicType
{
    Piercing,
    Spiral,
    ExtraDamage,
    Crit
}

public record DamageType(DamageFormula DamageFormula, Element Element, int BaseDamage);

public record DamageMechanic(DamageMechanicType MechanicType, float Value, Condition Condition);


public record DamageEffectIR(
    Subject Subject,
    DamageType DamageType,
    List<DamageMechanic>? With = null,
    Targeting? Targeting = null
) : EffectIR(Subject, EffectType.Damage);



public static partial class DslParsers
{
    /* ───────────── DAMAGE MECHANIC ───────────── */

    public static Parser<Token, DamageMechanicType> DamageMechanicTypeParser => OneOf(
        Tok.Piercing.ThenReturn(DamageMechanicType.Piercing),
        Tok.Spiral.ThenReturn(DamageMechanicType.Spiral),
        Tok.ExtraDamage.ThenReturn(DamageMechanicType.ExtraDamage),
        Tok.Crit.ThenReturn(DamageMechanicType.Crit)
    );

    public static Parser<Token, DamageMechanic> DamageMechanicAtom =>
        from mech in DamageMechanicTypeParser
        from value in Try(Tok.LParen.Then(AmountLiteral).Before(Tok.RParen)).Optional()
        select new DamageMechanic(mech, value.HasValue ? value.Value : 0f, null);

    public static Parser<Token, List<DamageMechanic>> DamageMechanicGroupParser =>
        from _l in Tok.LBracket
        from items in DamageMechanicAtom.Separated(Comma)
        from _r in Tok.RBracket
        select items.ToList();



    public static Parser<Token, DamageType> DamageTypeParser =>
        from parsed in
            Try( // First: Element before base
                from element in ElementParser
                from formula in DamageFormulaParser
                from baseDamage in Tok.LParen.Then(IntLiteral).Before(Tok.RParen)
                select (element, formula, baseDamage)
            ).Or( // Second: Element after base
                from formula in DamageFormulaParser
                from baseDamage in Tok.LParen.Then(IntLiteral).Before(Tok.RParen)
                from element in ElementParser.Optional()
                select (element.GetValueOrDefault(), formula, baseDamage)
            )
        select new DamageType(parsed.formula,  parsed.element, parsed.baseDamage);
    
    public static Parser<Token, DamageEffectIR> DamageEffectParser =>
        from _deals in Tok.Deals
        from _damageType in DamageTypeParser
        from _damage in Tok.Damage
        from withMechs in Try(
            from _w in Tok.With
            from ms in DamageMechanicGroupParser
            select ms
        ).Optional()
        select new DamageEffectIR(
            Subject.Target,
            _damageType,
            withMechs.GetValueOrDefault()
        );
}