using DSLApp1.Model;
using Pidgin;
using static Pidgin.Parser<DSLApp1.Dsl.Token>;



namespace DSLApp1.Dsl
{

    public static class Tok
    {
        // Generic parser for keywords
        private static Parser<Token, Token> Keyword(string keyword) =>
            Token(t => t.Type == TokenType.Keyword && t.Text.Equals(keyword, StringComparison.OrdinalIgnoreCase));

        // Generic parser for symbols
        private static Parser<Token, Token> Symbol(string symbol) =>
            Token(t => t.Type == TokenType.Symbol && t.Text == symbol);

            public static readonly Parser<Token, Token> Afterwards = Keyword("Afterwards");
            public static readonly Parser<Token, Token> Ability = Keyword("Ability");
            public static readonly Parser<Token, Token> Inflicts = Keyword("Inflicts");
            public static readonly Parser<Token, Token> Deals = Keyword("Deals");
            public static readonly Parser<Token, Token> With = Keyword("With");
            public static readonly Parser<Token, Token> Physical = Keyword("Physical");
            public static readonly Parser<Token, Token> Damage = Keyword("damage");
            public static readonly Parser<Token, Token> For = Keyword("For");
            public static readonly Parser<Token, Token> Charges = Keyword("Charges");
            public static readonly Parser<Token, Token> Adds = Keyword("Adds");
            public static readonly Parser<Token, Token> If = Keyword("If");
            public static readonly Parser<Token, Token> Against = Keyword("Against");
            
            public static readonly Parser<Token, Token> When = Keyword("When");
            public static readonly Parser<Token, Token> Roll = Keyword("roll");

            public static readonly Parser<Token, Token> Fire = Keyword("Fire");
            public static readonly Parser<Token, Token> Poison = Keyword("Poison");
            public static readonly Parser<Token, Token> Ice = Keyword("Ice");
            public static readonly Parser<Token, Token> Water = Keyword("Water");
            public static readonly Parser<Token, Token> Dark = Keyword("Dark");
            public static readonly Parser<Token, Token> Light = Keyword("Light");
            public static readonly Parser<Token, Token> Electrical = Keyword("Electrical");

            public static readonly Parser<Token, Token> Then = Keyword("then");
            public static readonly Parser<Token, Token> Support = Keyword("Support");
            public static readonly Parser<Token, Token> Outfit = Keyword("Outfit");
            public static readonly Parser<Token, Token> Spiral = Keyword("Spiral");

            public static readonly Parser<Token, Token> Artillery = Keyword("Artillery");
            public static readonly Parser<Token, Token> Brute = Keyword("Brute");
            public static readonly Parser<Token, Token> Nomad = Keyword("Nomad");
            public static readonly Parser<Token, Token> Chaos = Keyword("Chaos");
            public static readonly Parser<Token, Token> Execution = Keyword("Execution");
            public static readonly Parser<Token, Token> Holy = Keyword("Holy");
            public static readonly Parser<Token, Token> Piercing = Keyword("Piercing");
            public static readonly Parser<Token, Token> Adjective = Keyword("Adjective");

            public static readonly Parser<Token, Token> Self = Keyword("Self");
            public static readonly Parser<Token, Token> Ally = Keyword("Ally");
            public static readonly Parser<Token, Token> Allies = Keyword("Allies");
            public static readonly Parser<Token, Token> Enemy = Keyword("Enemy");
            public static readonly Parser<Token, Token> Enemies = Keyword("Enemies");
            public static readonly Parser<Token, Token> Magical = Keyword("Magical");
            public static readonly Parser<Token, Token> To = Keyword("to");

            public static readonly Parser<Token, Token> ExtraDamage = Keyword("ExtraDamage");
            public static readonly Parser<Token, Token> Crit = Keyword("Crit");
            public static readonly Parser<Token, Token> MultiHit = Keyword("MultiHit");
            public static readonly Parser<Token, Token> MultiTarget = Keyword("MultiTarget");
            public static readonly Parser<Token, Token> Random = Keyword("Random");

            public static readonly Parser<Token, Token> Turns = Keyword("turns");
            public static readonly Parser<Token, Token> Rounds = Keyword("rounds");
            public static readonly Parser<Token, Token> Turn = Keyword("turn");
            public static readonly Parser<Token, Token> Round = Keyword("round");
            public static readonly Parser<Token, Token> Start = Keyword("Start");
            public static readonly Parser<Token, Token> End = Keyword("End");
            
            public static readonly Parser<Token, Token> Buff = Keyword("Buff");
            public static readonly Parser<Token, Token> Debuff = Keyword("Debuff");
            

            public static readonly Parser<Token, Token> Vulnerability = Keyword("Vulnerability");
            public static readonly Parser<Token, Token> Protection = Keyword("Protection");
            public static readonly Parser<Token, Token> Power = Keyword("Power");
            public static readonly Parser<Token, Token> Frailty = Keyword("Frailty");
            
            public static readonly Parser<Token, Token> Blessing = Keyword("Blessing");
            public static readonly Parser<Token, Token> Curse = Keyword("Curse");
            public static readonly Parser<Token, Token> Stun = Keyword("Stun");
            public static readonly Parser<Token, Token> Defensive = Keyword("Defensive");
            public static readonly Parser<Token, Token> Revival = Keyword("Revival");
            public static readonly Parser<Token, Token> Shield = Keyword("Shield");
            
            public static readonly Parser<Token, Token> Bounce = Keyword("Bounce");
            public static readonly Parser<Token, Token> Splash = Keyword("Splash");
            public static readonly Parser<Token, Token> Exhaust = Keyword("Exhaust");
            public static readonly Parser<Token, Token> CoolOff = Keyword("CoolOff");
            
            public static readonly Parser<Token, Token> Invokes = Keyword("Invokes");
            public static readonly Parser<Token, Token> Delay = Keyword("Delay");
            public static readonly Parser<Token, Token> Advance = Keyword("Advance");
            public static readonly Parser<Token, Token> Swap = Keyword("Swap");
            public static readonly Parser<Token, Token> Shuffle = Keyword("Shuffle");

            public static readonly Parser<Token, Token> All = Keyword("All");
            
            public static readonly Parser<Token, Token> Miss = Keyword("Miss");
            
            public static readonly Parser<Token, Token> Attack = Keyword("Attack");
            public static readonly Parser<Token, Token> Defense = Keyword("Defense");
            public static readonly Parser<Token, Token> Intelligence = Keyword("Intelligence");
            public static readonly Parser<Token, Token> Resistance = Keyword("Resistance");
            public static readonly Parser<Token, Token> Initiative = Keyword("Initiative");
            
            public static readonly Parser<Token, Token> Applies = Keyword("Applies");


            
            public static readonly Parser<Token, Token> Mana = Keyword("Mana");
            public static readonly Parser<Token, Token> Hp = Keyword("Hp");
            public static readonly Parser<Token, Token> HpPercent = Keyword("HpPercent");
            public static readonly Parser<Token, Token> Opportunity = Keyword("Opportunity");

            public static readonly Parser<Token, Token> User = Keyword("User");
            public static readonly Parser<Token, Token> Target = Keyword("Target");
            public static readonly Parser<Token, Token> Missed = Keyword("Missed");
            public static readonly Parser<Token, Token> Kills = Keyword("Kills");
            public static readonly Parser<Token, Token> Hits = Keyword("Hits");
            public static readonly Parser<Token, Token> On = Keyword("On");
            
            public static readonly Parser<Token, Token> Restores = Keyword("Restores");
            public static readonly Parser<Token, Token> Drains = Keyword("Drains");
            public static readonly Parser<Token, Token> Gives = Keyword("Gives");
            public static readonly Parser<Token, Token> Takes = Keyword("Takes");

            
            public static readonly Parser<Token, Token> Targeting = Keyword("Targeting");
            public static readonly Parser<Token, Token> UserSelected = Keyword("UserSelected");

            public static readonly Parser<Token, Token> Neutral = Keyword("Neutral");
            
            public static readonly Parser<Token, Token> Strongest = Keyword("Strongest");
            public static readonly Parser<Token, Token> Weakest = Keyword("Weakest");
            public static readonly Parser<Token, Token> NextUp = Keyword("NextUp");
            public static readonly Parser<Token, Token> LastUp = Keyword("LastUp");

            
            public static readonly Parser<Token, Token> Single = Keyword("Single");
            
            // public static readonly Parser<Token, Token> Multiple = Keyword("Multiple");
            public static readonly Parser<Token, Token> Multiple = Keyword("Multiple");
            // public static readonly Parser<Token, Token> Random = Keyword("Random");
            //
            
            public static readonly Parser<Token, Token> Comma = Symbol(",");
            public static readonly Parser<Token, Token> Eq = Symbol("==");
            public static readonly Parser<Token, Token> Ne = Symbol("!=");
            public static readonly Parser<Token, Token> Le = Symbol("<=");
            public static readonly Parser<Token, Token> Ge = Symbol(">=");
            public static readonly Parser<Token, Token> Lt = Symbol("<");
            public static readonly Parser<Token, Token> Gt = Symbol(">");
            public static readonly Parser<Token, Token> LParen = Symbol("(");
            public static readonly Parser<Token, Token> RParen = Symbol(")");
            public static readonly Parser<Token, Token> Colon = Symbol(":");
            public static readonly Parser<Token, Token> LBracket = Symbol("[");
            public static readonly Parser<Token, Token> RBracket = Symbol("]");
            public static readonly Parser<Token, Token> EOF = Token(t => t.Type == TokenType.EndOfFile);
        }

}
