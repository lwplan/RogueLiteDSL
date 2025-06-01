namespace DSLApp1.Model
{
    public class Damage
    {
        public int HpChange { get; }
        public int ManaChange { get; }
        public int OpportunityChange { get; }
        public bool Kill { get; set; }
        public List<IModifier> AppliedModifiers { get; }
        public List<IModifier> ExpiredModifiers { get; }

        public Damage(
            int hpChange, 
            int manaChange, 
            int opportunityChange, 
            bool kill, 
            List<IModifier> appliedModifiers)
        {
            HpChange = hpChange;
            ManaChange = manaChange;
            OpportunityChange = opportunityChange;
            Kill = kill;
            AppliedModifiers = appliedModifiers ?? new List<IModifier>();
        }
    }

    public class CombatEvent
    {
        // Public Properties
        public ICombatCharacter User { get; }
        public List<ICombatCharacter> Targets { get; }
        public IAbility Ability { get; }
        public List<IModifier> Modifiers { get; }
        public List<IModifier> ExpiredModifiers { get; }
        public bool Miss { get;  }
        // Private Storage
        private readonly Dictionary<ICombatCharacter, Damage> _damageDict = new();

        // Constructor
        public CombatEvent(ICombatCharacter user, List<ICombatCharacter> targets, bool miss, IAbility ability, List<IModifier> modifiers, List<IModifier> expiredModifiers)
        {
            User = user;
            Targets = targets ?? new List<ICombatCharacter>();
            Ability = ability;
            Modifiers = modifiers;
            Miss = miss;
            ExpiredModifiers = expiredModifiers;
        }

        public void SetDamage(ICombatCharacter target, Damage damage)
        {
            if (target != null && damage != null)
            {
                _damageDict[target] = damage;
            }
        }

        // Apply all encapsulated changes to a character
        public void Apply(ICombatCharacter character)
        {
            if (character == null || !_damageDict.TryGetValue(character, out var damage) || damage == null)
                return;

            ICharacterCombatState stateManager = character.CombatStateManager;

            stateManager?.AddHp(damage.HpChange);
            stateManager?.AddMana(damage.ManaChange);
            stateManager?.AddOpportunityPoints(damage.OpportunityChange);
            foreach (var appliedModifier in damage.AppliedModifiers)
            {
                stateManager?.AddModifier(appliedModifier);
            }
        }
        
        public bool TryGetDamage(ICombatCharacter character, out Damage damage)
        {
            return _damageDict.TryGetValue(character, out damage);
        }

        public void ExpiredModifier(ICombatCharacter character, IModifier modifier)
        {
            if (character == null || modifier == null)
                return;

            if (_damageDict.TryGetValue(character, out var damage))
            {
                damage.ExpiredModifiers.Add(modifier);
            }
            else
            {
                var newDamage = new Damage(
                    hpChange: 0,
                    manaChange: 0,
                    opportunityChange: 0,
                    kill: false,
                    appliedModifiers: new List<IModifier>());
                _damageDict.Add(character, newDamage);
            }
        }
    }
}
