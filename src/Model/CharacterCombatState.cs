namespace DSLApp1.Model;

public abstract class CharacterCombatState : ICharacterCombatState
{
    public enum AbilityMode
    {
        Primary,
        Specialities,
        Opportunity
    }

    private sealed class State
    {
        public Dictionary<Stat, int> BaseStats;

        internal IAbility PrimaryAbility { get; set; }
        internal List<IAbility> HexPieceAbilities = new List<IAbility>();
        internal IAbility OpportunityAbility { get; set; }

        internal readonly List<IModifier> CharacterModifiers = new List<IModifier>();
        internal readonly List<IModifier> HexPieceModifiers = new List<IModifier>();
        internal readonly List<IModifier> CombatModifiers = new List<IModifier>();
            
        public int CurrentHp { get; set; }

        public int CurrentMana { get; set; }

        public int OpportunityGauge { get; set;   }
            
        public int OpportunityTurnsRemaining { get; set; }

        public Dictionary<IModifier, int> ModifierRemainingTurns { get; } = new Dictionary<IModifier, int>();

        public Dictionary<IAbility, int> AbilityUsageCounts { get; } = new Dictionary<IAbility, int>();
        public bool IsDead { get; set; }
        public bool IsStunned { get; set; }
            
    }

    // private readonly ICombatCharacter combatCharacter;
    private readonly State state = new State();
        

    public CharacterCombatState(ICharacterDefinition characterDefinition)
    {
        var baseState = characterDefinition.BaseState;
        var boardState  = characterDefinition.BoardState;
        state.BaseStats = new Dictionary<Stat, int>
        {
            { Stat.MaxHp, baseState.BaseHp },
            { Stat.Attack, baseState.BaseAttack },
            { Stat.Defense, baseState.BaseDefense },
            { Stat.Intelligence, baseState.BaseIntelligence },
            { Stat.Resistance, baseState.BaseResistance },
            { Stat.Initiative, baseState.BaseInitiative },
            { Stat.InitialMana, baseState.BaseMana },
            { Stat.ManaPerTurn, baseState.BaseManaPerTurn }
        };
        state.PrimaryAbility = baseState.PrimaryAbility;
        state.OpportunityAbility = baseState.OpportunityAbility;
        state.HexPieceAbilities = baseState.HexPieceAbilties;
        state.HexPieceAbilities.Clear(); // Ahem
        if (boardState != null) // only player characters have boards
        {
            foreach (var piece in boardState.HexPieces)
            {
                if (piece.Equips.Count > 0)
                {
                    state.HexPieceModifiers.AddRange(piece.Equips);
                }

                if (piece.HasAbility && piece.Ability != null)
                {
                    state.HexPieceAbilities.Add(piece.Ability);
                }

            }
        }

        // Update currentHp to reflect new MaxHp from buffs
        state.CurrentHp = GetBuffedStat(Stat.MaxHp);
        state.CurrentMana = GetBuffedStat(Stat.InitialMana);
        state.OpportunityGauge = 0;
    }

        
    public int OpportunityTurnsRemaining { get; set; }
    public bool IsActive => state.CurrentHp > 0;

    public List<IModifier> Modifiers  => state.CharacterModifiers
        .Concat(state.HexPieceModifiers)
        .Concat(state.CombatModifiers)
        .ToList();

    public List<IModifier> CombatModifiers => state.CombatModifiers;


    public bool IsDead
    {
        get => state.IsDead;
        set => state.IsDead = value;
    }

    public int GetStat(Stat stat)
    {
        int value = state.BaseStats[stat];
        foreach (var mod in state.CharacterModifiers.Concat(state.HexPieceModifiers).Concat(state.CombatModifiers))
        {
            // if (mod is BuffModifier buff && buff.Stat == stat)
            // {
            //     int buffValue = buff.BuffValue;
            //     value = buffValue > 0 && stat != Stat.MaxHp
            //         ? value + (value * buffValue / 100)
            //         : value + buffValue;
            // }
        }
        return stat == Stat.MaxHp ? Math.Max(value, 0) : value; // Ensure MaxHp isn’t negative
    }
        
    public int GetBuffedStat(Stat stat)
    {
        int value = state.BaseStats[stat];
        foreach (var mod in Modifiers)
        {
            // if (mod is BuffModifier buff && buff.Stat == stat)
            // {
            //     int buffValue = buff.BuffValue;
            //     value = value + buffValue;
            // }
        }
        return Math.Max(value, 1); 
    }



    public void OnCombatStart()
    {
        // Add combat start logic if needed
    }

    public CombatEvent ApplyModifiers(ICombatCharacter character)
    {
        int hpChange = 0;
        int manaChange = 0;
        List<IModifier> damageModifiers = new List<IModifier>();
        List<IModifier> expiredModifiers = new List<IModifier>();

        foreach (var modifier in state.CombatModifiers)
        {
            // if (modifier is PeriodicDamageModifier periodic && (modifier.Lifetime > 0 || modifier.Lifetime == -1))
            // {
            //     if (periodic.HpChange(character) != 0 || periodic.ManaChange != 0)
            //     {
            //         hpChange += periodic.HpChange(character);
            //         manaChange += periodic.ManaChange;
            //         damageModifiers.Add(modifier);
            //     }
            // }
            // only combat modifiers can have a lifetime
            if (modifier.Lifetime > 0)
            {
                state.ModifierRemainingTurns[modifier]--;

            }
            if (modifier.Lifetime == 0)
            {
                RemoveModifier(modifier);
                expiredModifiers.Add(modifier);
            }
        }

        if (hpChange == 0 && manaChange == 0 && expiredModifiers.Count == 0 && damageModifiers.Count == 0)
        {
            return null;
        }
        CombatEventBuilder combatEventBuilder = new CombatEventBuilder();
        bool kill = (hpChange + state.CurrentHp) < 0;
        combatEventBuilder.WithTarget(character);
        combatEventBuilder.WithModifiers(damageModifiers);
        combatEventBuilder.WithExpiredModifiers(expiredModifiers);
        combatEventBuilder.WithDamage(character, hpChange, manaChange, 0, kill, new List<IModifier>());
        return combatEventBuilder.Build();
    }

    private void RemoveModifier(IModifier modifier)
    {
        throw new System.NotImplementedException();
    }

        

    public void OnStartTurn()
    {
        AddMana(GetBuffedStat(Stat.ManaPerTurn));
        if ( state.OpportunityGauge >= 100 &&  state.OpportunityTurnsRemaining == 0)
        {
            state.OpportunityTurnsRemaining = 3;
        }
    }
        
    public void OnEndTurn()
    {
        if ( state.OpportunityTurnsRemaining > 0)
        {
            state.OpportunityTurnsRemaining--;
            if ( state.OpportunityTurnsRemaining == 0)  state.OpportunityGauge = 0;
        }
    }
        
    public void AddHp(int change)
    {
        var maxHp = GetBuffedStat(Stat.MaxHp);
        state.CurrentHp = Math.Clamp(state.CurrentHp + change, 0, maxHp);
    }

    public void AddMana(int manaChange)
    {
        state.CurrentMana = Math.Max(0, state.CurrentMana + manaChange);
    }
        
    public void AddOpportunityPoints(int points)
    {
        state.OpportunityGauge = Math.Min( state.OpportunityGauge + points, 100);
    }

    public bool InOpportunityMode() =>  state.OpportunityGauge >= 100;
    public void OnOpportunityAbilityUsed()
    {
        state.OpportunityTurnsRemaining = 0;
        state.OpportunityGauge = 0;
    }



    public int Hp => state.CurrentHp; 
        
    public int Mana => state.CurrentMana;
        
    public int OpportunityGauge => state.OpportunityGauge;
        
    public int HpPercentage => (int)(100 * (float)state.CurrentHp / GetBuffedStat(Stat.MaxHp));
        
    public List<IAbility> AvailableAbilities(CombatState combat, AbilityMode abilityMode)
    {
        var results = new List<IAbility>();
        switch (abilityMode)
        {
            case AbilityMode.Primary:
                if (state.PrimaryAbility != null)
                    results.Add(state.PrimaryAbility);
                break;
            case AbilityMode.Specialities:
                foreach (var ability in state.HexPieceAbilities)
                {
                    // Add logic to check if ability has targets if needed
                    results.Add(ability);
                }
                break;
            case AbilityMode.Opportunity when state.OpportunityAbility != null:
                results.Add(state.OpportunityAbility);
                break;
        }
        return results;
    }

    public IAbility GetPrimaryAbility() => state.PrimaryAbility;
    public IAbility GetOpportunityAbility()
    {
        return state.OpportunityAbility;
    }

    public List<IAbility> GetHexPieceAbilities() => state.HexPieceAbilities;



    // todo: remove
    public IAbility HexPieceAbilityOrRandom(int index, List<IAbility> fallbackAbilities = null)
    {
        var abilities = state.HexPieceAbilities;
        if (index >= 0 && index < abilities.Count)
        {
            return abilities[index];
        }
        // Fallback to a random ability from HexPieceAbilities or provided list
        var viableAbilities = fallbackAbilities is { Count: > 0 } 
            ? fallbackAbilities 
            : abilities;
        return null;  //viableAbilities.Count > 0 ? Rand.SelectRandom(viableAbilities) : null;
    }



    public void AddModifier(IModifier modifier)
    {
        // if (modifier == null) return;
        // if (modifier.IsStackable || !state.CombatModifiers.Exists(m => m.Tag == modifier.Tag))
        // {
        //     state.CombatModifiers.Add(modifier);
        //     state.ModifierRemainingTurns[modifier] = modifier.Lifetime;
        // }
    }

    public float DamageMultiplier(IAbility ability)
    {
        var multiplier = 1.0f;
        // foreach (var mod in Modifiers.OfType<DamageMultiplierModifier>())
        // {
        //     multiplier *= mod.DamageMultiplier(ability);
        // }
        return multiplier; 
    }

    public float AttackMultiplier(IAbility ability, ICombatCharacter character)
    {
        float multiplier = 1.0f;
        // foreach (var mod in Modifiers.OfType<AttackMultiplierModifier>())
        // {
        //     multiplier *= mod.AttackMultiplier(ability, character);
        // }
        return multiplier; // Return as percentage (e.g., 150 for 1.5x)
    }
        

    public void OnAbilityUsed(IAbility ability)
    {
        state.AbilityUsageCounts.TryAdd(ability, 1);
        state.AbilityUsageCounts[ability]++;
    }

    public int GetAbilityUseCount(IAbility ability)
    {
        return state.AbilityUsageCounts[ability];
    }
        
    public string Description()
    {
        return $"Hp: {state.CurrentHp}/{GetBuffedStat(Stat.MaxHp)}\nAttack: {GetBuffedStat(Stat.Attack)}\nDefense: {GetBuffedStat(Stat.Defense)}\n" +
               $"Intelligence: {GetBuffedStat(Stat.Intelligence)}\nResistance: {GetBuffedStat(Stat.Resistance)}\n" +
               $"Initiative: {GetBuffedStat(Stat.Initiative)}\nMana: {state.CurrentMana}";
    }

    public int RemainingTurns(IModifier modifier)
    {
        state.ModifierRemainingTurns.TryGetValue(modifier, out var remainingTurns);
        return remainingTurns;
    }
}