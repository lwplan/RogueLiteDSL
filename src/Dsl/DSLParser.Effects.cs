using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser;

namespace DSLApp1.Dsl;

public static partial class DslParsers
{
    public static Parser<Token, List<EffectIR>> EffectBlockParser =>
        from _l in Symbol(TokenType.LBrace)
        from effects in Try(TimedEffectParser.Select(e => (EffectIR)e)).Or(DamageEffectParser.Select(e => (EffectIR)e)).Separated(Comma)
        from _r in Symbol(TokenType.RBrace)
        select effects.ToList();

    
    public static Parser<Token, EffectIR> EffectParser =>
        Try(TimedEffectParser.Select(e => (EffectIR)e))
            .Or(DamageEffectParser.Select(e => (EffectIR)e));
    // .Or(HealEffectParser.Select(e => (EffectIR)e))
    // .Or(ManaEffectParser.Select(e => (EffectIR)e))
    // .Or(TurnEffectParser.Select(e => (EffectIR)e));


}