namespace DSLApp1.Model
{
    public interface ICharacterCombatState
    {
        
        int Hp { get; }
        int OpportunityGauge { get; }
        int Mana { get;  }
        int HpPercentage { get; }
        bool IsActive { get; }
        bool IsDead { get; set; }
        int GetBuffedStat(Stat stat);
        
        void AddHp(int change);
        void AddMana(int value);
        void AddOpportunityPoints(int points);
        void OnCombatStart();
        void OnStartTurn();
        void OnAbilityUsed(IAbility ability);
        void OnEndTurn();
        bool InOpportunityMode();
        void OnOpportunityAbilityUsed();

        
        List<IAbility> AvailableAbilities(CombatState combat, CharacterCombatState.AbilityMode abilityMode);
        IAbility GetPrimaryAbility();
        IAbility GetOpportunityAbility();
        public int GetAbilityUseCount(IAbility ability);
        List<IAbility> GetHexPieceAbilities();
        IAbility HexPieceAbilityOrRandom(int index, List<IAbility> fallbackAbilities = null);

        List<IModifier> Modifiers { get; }
        List<IModifier> CombatModifiers { get;  }
        void AddModifier(IModifier modifier);
        CombatEvent? ApplyModifiers(ICombatCharacter character);
        float DamageMultiplier(IAbility ability);
        float AttackMultiplier(IAbility ability, ICombatCharacter character);
        
        string Description();

        int RemainingTurns(IModifier modifier);
    }

}