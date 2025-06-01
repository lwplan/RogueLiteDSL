namespace DSLApp1.Model
{
    public class CombatEventBuilder
    {
        private ICombatCharacter user;
        private List<ICombatCharacter> targets = new();
        private IAbility ability;
        private List<IModifier> modifiers = new();
        private List<IModifier> expiredModifiers = new();
        private bool miss = false;

        // Damage per target
        private readonly Dictionary<ICombatCharacter, Damage> damageDict = new();

        public CombatEventBuilder WithUser(ICombatCharacter user)
        {
            this.user = user;
            return this;
        }

        public CombatEventBuilder WithTarget(ICombatCharacter target)
        {
            if (target != null && !targets.Contains(target))
            {
                targets.Add(target);
            }
            return this;
        }

        public CombatEventBuilder WithTargets(IEnumerable<ICombatCharacter> newTargets)
        {
            foreach (var target in newTargets)
            {
                WithTarget(target);
            }
            return this;
        }

        public CombatEventBuilder WithAbility(IAbility ability)
        {
            this.ability = ability;
            return this;
        }
        
        public CombatEventBuilder WithMiss(bool miss)
        {
            this.miss = miss;
            return this;
        }

        public CombatEventBuilder WithModifiers(List<IModifier> modifiers)
        {
            this.modifiers = modifiers;
            return this;
        }

        public CombatEventBuilder WithDamage(
            ICombatCharacter target, 
            int hpChange, 
            int manaChange, 
            int opportunityChange, 
            bool kill = false,
            List<IModifier> appliedModifiers = null)
        {
            if (target == null)
                return this;

            damageDict[target] = new Damage(
                hpChange,
                manaChange,
                opportunityChange,
                kill,
                appliedModifiers ?? new List<IModifier>()
            );
            return this;
        }

        public CombatEvent Build()
        {
            var combatEvent = new CombatEvent(user, targets, miss, ability, modifiers, expiredModifiers);

            foreach (var kvp in damageDict)
            {
                combatEvent.SetDamage(kvp.Key, kvp.Value);
            }

            return combatEvent;
        }

        public void WithExpiredModifiers(List<IModifier> expiredModifiers)
        {
            this.expiredModifiers = expiredModifiers;
        }
    }
}
