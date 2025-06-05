using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

/*
 *
 * side-effects-clause := 'afterwards'  side-effect-mechanic { ',' side-effect-mechanic}
   
   side-effect-mechanic := side-effect-mechanic |  side-effect-healing-mechanic
   
   side-effect-mechanic := side-effect-mechanic-type mechanic-specifier 
   
   side-effect-mechanic-type  := 'Bounce' | 'Splash' | 'Exhaust' | 'CoolOff'
   
   healing-side-effect := 'Restores' healing-clause
   
 */

public enum SideEffectMechanicType
{
    Bounce,
    Splash,
    Exhaust,
    CoolOff
}

public abstract record SideEffectMechanicIR;

public record SideEffectMechanic(
    SideEffectMechanicType Type,
    float Amount
) : SideEffectMechanicIR;

public record HealingSideEffectMechanic(
    HealMechanic Heal
) : SideEffectMechanicIR;

public record SideEffectsIR(
    List<SideEffectMechanicIR> Mechanics,
    Condition? When
);


public static partial class DslParsers
{
    /* ───────────── Side Effects ──────── */

    public static Parser<Token, SideEffectMechanicIR> SideEffectMechanicParser =>
        OneOf(
            Tok.Bounce.Then(
                Tok.LParen
                    .Then(AmountLiteral)
                    .Before(Tok.RParen)
            ).Select(value => (SideEffectMechanicIR)new SideEffectMechanic(SideEffectMechanicType.Bounce, value)),

            Tok.Splash.Then(
                Tok.LParen
                    .Then(AmountLiteral)
                    .Before(Tok.RParen)
            ).Select(value => (SideEffectMechanicIR)new SideEffectMechanic(SideEffectMechanicType.Splash, value)),

            Tok.Exhaust.Then(
                Tok.LParen
                    .Then(AmountLiteral)
                    .Before(Tok.RParen)
            ).Select(value => (SideEffectMechanicIR)new SideEffectMechanic(SideEffectMechanicType.Exhaust, value)),

            Tok.CoolOff.Then(
                Tok.LParen
                    .Then(AmountLiteral)
                    .Before(Tok.RParen)
            ).Select(value => (SideEffectMechanicIR)new SideEffectMechanic(SideEffectMechanicType.CoolOff, value))
        );

    public static Parser<Token, SideEffectMechanicIR> HealingSideEffectParser =>
        from heal in HealMechanicParser  // reuse your existing Heals parser here
        select (SideEffectMechanicIR)new HealingSideEffectMechanic(heal);

    public static Parser<Token, SideEffectMechanicIR> AnySideEffectMechanicParser =>
        HealingSideEffectParser
            .Or(SideEffectMechanicParser);

    public static Parser<Token, SideEffectsIR> SideEffectsParser =>
        from _after in Tok.Afterwards
        from effects in AnySideEffectMechanicParser.Separated(Tok.Comma)
        from condition in Try(ConditionParser).Optional()
        select new SideEffectsIR(
            effects.ToList(),
            condition.HasValue ? condition.Value : null
        );


}