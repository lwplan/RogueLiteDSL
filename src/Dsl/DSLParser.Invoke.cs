using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;
public static partial class DslParsers
{
    
    /* ───────────── INVOKE MECHANIC ───────────── */
    


    public static Parser<Token, InvokeMechanic> InvokeMechanicParser=>
        from mech in InvokeMechanicTypeParser
        from value in Try(Symbol(TokenType.LParen).Then(AmountLiteral).Before(Symbol(TokenType.RParen))).Optional()
        select new InvokeMechanic(mech, value.HasValue ? value.Value : 0f);

    /* ───────────── Invoke EFFECT ───────────── */

    public static Parser<Token, InvokeEffectIR> InvokeEffectParser =>
        from _invokes in Tok(TokenType.Keyword, "Invokes")
        from _mechanic in InvokeMechanicParser
        from _condition in SimpleConditionParser.Optional()
        select new InvokeEffectIR(
            Subject.Target,
            _mechanic,
            _condition.HasValue ? _condition.Value : null
        );



}