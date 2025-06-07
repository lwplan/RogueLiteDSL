using System.Runtime.InteropServices;
 using Pidgin;
 using static Pidgin.Parser;
 using static Pidgin.Parser<DSLApp1.Dsl.Token>;
 
 namespace DSLApp1.Dsl;
 
 public enum HexType { Ability, Support, Outfit }
 
 public enum Compatibility
 {
     Artillery,
     Brute,
     Nomad,
     Chaos,
     Blessing,
    Execution,
    Holy,
    Protector
}
 
 public record Header(HexType Type, Compatibility? Compatibility);
 
 public static partial class DslParsers
 {
     
     public static Parser<Token, Compatibility> RoleParser => OneOf(
 
         Tok.Brute.ThenReturn(Compatibility.Brute),
         Tok.Artillery.ThenReturn(Compatibility.Artillery),
         Tok.Nomad.ThenReturn(Compatibility.Nomad),
        Tok.Chaos.ThenReturn(Compatibility.Chaos),
        Tok.Blessing.ThenReturn(Compatibility.Blessing),
        Tok.Execution.ThenReturn(Compatibility.Execution),
        Tok.Holy.ThenReturn(Compatibility.Holy),
        Tok.Protector.ThenReturn(Compatibility.Protector)
    );
     
     public static Parser<Token, Header> HeaderParser =>
         from type in OneOf(
             Tok.Ability.ThenReturn(HexType.Ability),
             Tok.Support.ThenReturn(HexType.Support),
             Tok.Outfit.ThenReturn(HexType.Outfit)
         )
         from compatOpt in Try(
             from _lparen in Tok.LParen
             from compat in RoleParser
             from _rparen in Tok.RParen
             select compat
         ).Optional()
         from _colon in Tok.Colon
         select new Header(type, compatOpt.ToNullable());

 }