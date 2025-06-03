using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public static partial class DslParsers
{
    /* ───────────── ENUM PARSERS ───────────── */

    public static Parser<Token, Role> RoleParser => OneOf(

        Tok(TokenType.Keyword, "Brute").ThenReturn(Role.Brute),
        Tok(TokenType.Keyword, "Artillery").ThenReturn(Role.Artillery),
        Tok(TokenType.Keyword, "Nomad").ThenReturn(Role.Nomad),
        Tok(TokenType.Keyword, "Chaos").ThenReturn(Role.Chaos),
        Tok(TokenType.Keyword, "Blessing").ThenReturn(Role.Blessing),
        Tok(TokenType.Keyword, "Execution").ThenReturn(Role.Execution)
    );

    public static Parser<Token, Targetability> TargetabilityParser => OneOf(
        Tok(TokenType.Keyword, "Self").ThenReturn(Targetability.Self),
        Tok(TokenType.Keyword, "Ally").ThenReturn(Targetability.Ally),
        Tok(TokenType.Keyword, "Allies").ThenReturn(Targetability.Allies),
        Tok(TokenType.Keyword, "Enemy").ThenReturn(Targetability.Enemy),
        Tok(TokenType.Keyword, "Enemies").ThenReturn(Targetability.Enemies),
        Tok(TokenType.Keyword, "All").ThenReturn(Targetability.All)
    );

    public static Parser<Token, TargetMechanicType> TargetMechanicTypeParser => OneOf(
        Tok(TokenType.Keyword, "MultiTarget").ThenReturn(TargetMechanicType.MultiTarget),
        Tok(TokenType.Keyword, "MultiHit").ThenReturn(TargetMechanicType.MultiHit),
        Tok(TokenType.Keyword, "SingleTarget").ThenReturn(TargetMechanicType.SingleTarget),
        Tok(TokenType.Keyword, "SingleHit").ThenReturn(TargetMechanicType.SingleHit),
        Tok(TokenType.Keyword, "Random").ThenReturn(TargetMechanicType.Random)
    );
    
    public static Parser<Token, Element> ElementParser => OneOf(
        Tok(TokenType.Keyword, "Fire").ThenReturn(Element.Fire),
        Tok(TokenType.Keyword, "Poison").ThenReturn(Element.Poison),
        Tok(TokenType.Keyword, "Ice").ThenReturn(Element.Ice),
        Tok(TokenType.Keyword, "Water").ThenReturn(Element.Water),
        Tok(TokenType.Keyword, "Dark").ThenReturn(Element.Dark),
        Tok(TokenType.Keyword, "Light").ThenReturn(Element.Light),
        Tok(TokenType.Keyword, "Electrical").ThenReturn(Element.Electrical)
    );
    
    public static Parser<Token, DamageFormula> DamageFormulaParser => OneOf(
        Tok(TokenType.Keyword, "Magical").ThenReturn(DamageFormula.Magical),
        Tok(TokenType.Keyword, "Physical").ThenReturn(DamageFormula.Physical)
    );
    
    public static Parser<Token, InvokeMechanicType> InvokeMechanicTypeParser => OneOf(
        Tok(TokenType.Keyword, "Swap").ThenReturn(InvokeMechanicType.Swap),
        Tok(TokenType.Keyword, "Advance").ThenReturn(InvokeMechanicType.Advance),
        Tok(TokenType.Keyword, "Delay").ThenReturn(InvokeMechanicType.Delay),
        Tok(TokenType.Keyword, "Shuffle").ThenReturn(InvokeMechanicType.Shuffle)
    );
    
    public static Parser<Token, SideEffectMechanicType> SideEffectMechanicTypeParser => OneOf(
        Tok(TokenType.Keyword, "Bounce").ThenReturn(SideEffectMechanicType.Bounce),
        Tok(TokenType.Keyword, "Splash").ThenReturn(SideEffectMechanicType.Splash)
    );
    

}