


namespace DSLApp1.Model
{
    public enum Exclusivity { All, Enemy,  Knight, Priestess, Beduin }

    [Serializable]
    public class Fragment
    {
        public bool Unlocked { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string HexSignature { get; private set; }
        
        public Rarity Rarity { get; private set; }
        
        public List<Exclusivity> Exclusivities { get; private set; }

        public List<IModifier> Equips { get;  }
        public bool HasAbility { get; }
        public IAbility Ability { get; }

        public Fragment(
            string name, string description, string hexSignature, string elementString, 
            string rarity, string exclusivities, string levelString, string opportunityPotString, string manaCostString, string riskString,
            string targetabilityString, string equips, string deals, string applies, string animation,
            string damageEffect, string castEffect)
        {
            Name = name;
            Description = description;
            HexSignature = hexSignature;
            HasAbility = deals is { Length: > 0 } || applies is { Length: > 0 };
            
            Unlocked = false; //levelString == "0";
                
            // try
            // {
            //     Rarity = Enum.Parse<Rarity>(rarity);
            //
            //     Exclusivities = exclusivities
            //         .Split(',', StringSplitOptions.RemoveEmptyEntries)  
            //         .Select(s => Enum.Parse<Exclusivity>(s.Trim()))   
            //         .ToList();                                          
            //

                // Map CSV fields to Ability properties
            //     var element = ElementEnumExtensions.FromAbbrev(elementString);
            //     var targetability = Enum.Parse<Targetability>(targetabilityString);
            //     var animationType = Enum.Parse<AnimationType>(animation);
            //     var opportunityPot =string.IsNullOrEmpty(opportunityPotString) ? 0 :  int.Parse(opportunityPotString);
            //     var manaCost = string.IsNullOrEmpty(manaCostString) ? 0 : int.Parse(manaCostString);
            //     var risk = string.IsNullOrEmpty(riskString) ? 0 :  int.Parse(riskString);
            //
            //     Equips = ModifierFactory.ParseList(equips, name);
            //     
            //     // Use AbilityFactory to create the appropriate Ability subclass
            //     Ability = HasAbility
            //         ? new Ability(
            //             name: name,
            //             element: element,
            //             manaCost: manaCost,
            //             risk: risk,
            //             opportunityPot: opportunityPot,
            //             targetability: targetability, // Rename to match CSV/ApplicationType
            //             deals: deals,
            //             applies: applies,
            //             animation: animationType,
            //             damageEffect: damageEffect,
            //             castEffect: castEffect)
            //         : null;
            // }
            // catch (Exception e)
            // {
            //     Log.LogException(e);
            //     throw;
            // }

        }
    }
}