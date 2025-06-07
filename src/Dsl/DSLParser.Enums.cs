using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;



/* ───────────── ENUM PARSERS ───────────── */



public enum Element
{
    Fire,
    Electrical,
    Poison,
    Ice,
    Water,
    Earth,
    Dark,
    Light,
    None
}

// Used for querying
public enum Subject
{
    Target,
    User,
    Result
}

    
public enum EffectType
{
    Damage,
    Heal,
    Invoke,
    Economy,
    Modifier,
    Composite
}

public enum BuffMechanicType
{
    Buff,
    Debuff,
}

public enum DamageMultiplierMechanicType
{
    Might,
    Frailty,
    Vulnerability,
    Protection
}


public enum DamageFormula
{
    Magical,
    Physical
}
public static partial class DslParsers
{
    
    public static Parser<Token, Targetability> TargetabilityParser => OneOf(
        Tok.Self.ThenReturn(Targetability.Self),
        Tok.Ally.ThenReturn(Targetability.Ally),
        Tok.Allies.ThenReturn(Targetability.Allies),
        Tok.Enemy.ThenReturn(Targetability.Enemy),
        Tok.Enemies.ThenReturn(Targetability.Enemies),
        Tok.All.ThenReturn(Targetability.All)
    );
    
    public static Parser<Token, Element> ElementParser => OneOf(
        Tok.Fire.ThenReturn(Element.Fire),
        Tok.Poison.ThenReturn(Element.Poison),
        Tok.Ice.ThenReturn(Element.Ice),
        Tok.Water.ThenReturn(Element.Water),
        Tok.Earth.ThenReturn(Element.Earth),
        Tok.Dark.ThenReturn(Element.Dark),
        Tok.Light.ThenReturn(Element.Light),
        Tok.Electrical.ThenReturn(Element.Electrical)
    );
    
    public static Parser<Token, DamageFormula> DamageFormulaParser => OneOf(
        Tok.Magical.ThenReturn(DamageFormula.Magical),
        Tok.Physical.ThenReturn(DamageFormula.Physical)
    );
    
    public static Parser<Token, InvokeMechanicType> InvokeMechanicTypeParser => OneOf(
        Tok.Swap.ThenReturn(InvokeMechanicType.Swap),
        Tok.Advance.ThenReturn(InvokeMechanicType.Advance),
        Tok.Delay.ThenReturn(InvokeMechanicType.Delay),
        Tok.Shuffle.ThenReturn(InvokeMechanicType.Shuffle)
    );
    
    public static Parser<Token, SideEffectMechanicType> SideEffectMechanicTypeParser => OneOf(
        Tok.Bounce.ThenReturn(SideEffectMechanicType.Bounce),
        Tok.Splash.ThenReturn(SideEffectMechanicType.Splash)
    );
    

}