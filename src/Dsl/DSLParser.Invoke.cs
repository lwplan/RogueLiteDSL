using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;


/*
   mechanic-specifier := ['(' amount ')'] ['when' condition]
   
   invokes-clause := 'Invokes'  invoke-mechanic ['if' condition]
   
   invoke-mechanic := invoke-mechanic-type  mechanic-specifier
   
   invoke-mechanic-type := 'Swap' | 'Shuffle' | 'Advance' | 'Delay'
 */
namespace DSLApp1.Dsl;

public enum InvokeMechanicType
{
    Advance,
    Swap,
    Delay,
    Shuffle
}

public record InvokeMechanic(InvokeMechanicType MechanicType, float Value, Condition? Condition);

public record InvokeEffectIR(
    Subject Subject,
    InvokeMechanic InvokeMechanic
) : EffectIR(Subject, EffectType.Invoke);


public static partial class DslParsers
{
    
    /* ───────────── INVOKE MECHANIC ───────────── */
    

    public static Parser<Token, InvokeMechanic> InvokeMechanicParser =>
        from mechType in InvokeMechanicTypeParser
        from amount in Try(
            Tok.LParen.Then(AmountLiteral).Before(Tok.RParen)
        ).Optional()
        from whenCondition in Try(
            Tok.When.Then(ConditionBodyParser)
        ).Optional()
        select new InvokeMechanic(
            mechType,
            amount.HasValue ? amount.Value : 0f,
            whenCondition.HasValue ? whenCondition.Value : null
        );


    /* ───────────── Invoke EFFECT ───────────── */

    public static Parser<Token, InvokeEffectIR> InvokeEffectParser =>
        from _invokes in Tok.Invokes
        from _mechanic in InvokeMechanicParser
        select new InvokeEffectIR(
            Subject.Target,
            _mechanic
        );
    

}