using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;



namespace DSLApp1.Dsl;

/*
 *
 *
 * inflicts-clause := 'Inflicts' damage-clause [auto-targeting-clause] duration-clause ['if' condition]
   
   auto-targeting-clause := 'Targeting' target-selection-criteria targetabilty 
   
   duration-clause := 'for' (int 'turns' | 'rounds' | 'turn' | 'round' ) [ event-clause ]
   
   event-clause := 'on' ('round' 'start' | 'round' 'end' | 'turn' 'start' | 'turn' 'end' )
 */

// Superclasses to work with




public static partial class DslParsers
{
    public static Parser<Token, ModifierEffectIR> InflictsEffectParser =>
        from _ in Tok.Inflicts
    
        // Damage core
        from formula in DamageFormulaParser
        from baseDamage in Tok.LParen.Then(IntLiteral).Before(Tok.RParen)
        from element in ElementParser.Optional()
        from _dmg in Tok.Damage
    
        // Optional damage mechanics
        from withMechs in Try(
            from _w in Tok.With
            from ms in DamageMechanicGroupParser
            select ms
        ).Optional()

        // Optional auto-targeting
        from targeting in TargetingParser.Optional()

        // Required duration
        from duration in DurationClauseParser

        // Optional condition
        from condition in Try(ConditionParser).Optional()

        select new ModifierEffectIR(
            Subject.Target,
            new EffectModifierIR(
                duration,
                new DamageEffectIR(
                    Subject.Target,
                    new DamageType(formula, element.GetValueOrDefault(Element.None), baseDamage),
                    withMechs.GetValueOrDefault(),
                    targeting.GetValueOrDefault()
                ),
                condition.GetValueOrDefault()
            )
        );

}