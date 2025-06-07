using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public static partial class DslParsers
{

  
    
    /* ───────────── HEX WRAPPER ───────────── */

    public static Parser<Token, object> HexParser =>
        Try(AbilityParser.Select(a => (object)a))
            .Or(SupportParser.Select(s => (object)s))
            .Or(OutfitParser.Select(o => (object)o))
            .Before(Tok.EOF);

}