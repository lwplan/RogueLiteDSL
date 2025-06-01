using DSLApp1.Model;

namespace DSLApp1.Dsl;

public enum Role
{
    Artillery,
    Brute,
    Nomad,
    Chaos,
    Blessing,
    Execution
}

public enum Element
{
    Fire,
    Electrical,
    Poison,
    Ice,
    Water,
    Dark,
    Light,
    None
}

// Used for querying
public enum Subject
{
    Target,
    User,
    Result
}

public record AbilityIR(
    List<EffectIR> Effects,
    Targeting Targeting,
    List<Role> RoleCompatibilities,
    List<SideEffectsIR> PostEffects,
    Condition? When
);

public enum EffectType
{
    Damage,
    Heal,
    Turn,
    Mana,
    Opportunity,
    Modifier,
    Composite
}



public enum TargetMechanicType
{
    MultiTarget,
    MultiHit,
    SingleTarget,
    SingleHit,
    Random
}

public record TargetMechanic(TargetMechanicType TargetMechanicType, int Value);

public record Targeting( Targetability Targetability, List<TargetMechanic> TargetMechanics);

public enum DamageMechanicType
{
    Piercing,
    Spiral
}

public enum DamageFormula
{
    Magical,
    Physical
}

public record DamageType(DamageFormula DamageFormula, Element Element, int BaseDamage);

public record DamageMechanic(DamageMechanicType MechanicType, float Value, Condition Condition);

public enum SkillStat
{
    Attack,
    Defence,
    Intelligence,
    Resistance,
    Initiative
}

public record SupportIR(
    Role Role,
    List<SupportEffectIR> SupportEffects
);

public abstract record SupportEffectIR;

public record DamageSupportIR(DamageMechanicType Mechanic, float Value) : SupportEffectIR;



public enum EconomyStat
{
    Mana,
    Hp,
    Opportunity
}

public enum Op
{
    Gt, Lt, Eq, Ge, Le,
    Contains
}

public enum Field
{
    Attack,
    Defence,
    Intelligence,
    Resistance,
    Initiative,
    Mana,
    Hp,
    Opportunity,
    Miss,
    Hits,
    KillCount,
    TargetCount,
    Roles,
    Elements,
    Mechanics,
    Roll
}

// Base type for all conditions
public abstract record BaseCondition;

public record Condition(
    Subject Subject,
    Field Field,
    Op Op,
    float Value
) : BaseCondition;

public record AndCondition(List<BaseCondition> Conditions) : BaseCondition;

// EFFECTS

public abstract record EffectIR(
    Subject Subject,
    EffectType EffectType,
    Condition? MissCondition
);


public record CompositeEffectIR(
    Subject Subject,
    List<EffectIR>? EffectIrs
) : EffectIR(Subject, EffectType.Composite, null);

public record DamageEffectIR(
    Subject Subject,
    DamageType DamageType,
    List<DamageMechanic>? With = null
) : EffectIR(Subject, EffectType.Damage, null);

public enum TurnMechanicType
{
    Advance,
    Swap,
    Delay,
    Shuffle
}

public record TurnEffectIR(
    Subject Subject,
    TurnMechanicType TurnMechanic,
    int Amount,
    Condition? Condition
) : EffectIR(Subject, EffectType.Turn, Condition);

public record ManaEffectIR(
    Subject Subject,
    int Amount
) : EffectIR(Subject, EffectType.Mana, null);

public record HealEffectIR(
    Subject Subject,
    int Amount
) : EffectIR(Subject, EffectType.Heal, null);

public record ModiferEffectIR(
    Subject Subject,
    ModifierIR Modifier
) : EffectIR(Subject, EffectType.Modifier, null);


// MODIFIERS

public abstract record ModifierIR(
    int DurationTurns,
    int DurationRounds
);

public record EffectModifierIR(
    int DurationTurns,
    int DurationRounds,
    EffectIR Effect
) : ModifierIR(DurationTurns, DurationRounds);

public record BuffDebuffIR(int Amount, SkillStat Stat);

public record BuffDebuffModifierIR(
    int DurationTurns,
    int DurationRounds,
    List<BuffDebuffIR> BuffDebuffs
) : ModifierIR(DurationTurns, DurationRounds);

public record ShieldModifierIR(
    int DurationTurns,
    int DurationRounds,
    int Shield,
    bool ShieldBreakable
) : ModifierIR(DurationTurns, DurationRounds);

public enum MultiplierModifierType
{
    Vulnerability,
    Protection,
    Might,
    Frailty
}

public record MultiplierModifierIR(
    int DurationTurns,
    int DurationRounds,
    MultiplierModifierType MultiplierModifierType,
    float Amount,
    Condition Condition
) : ModifierIR(DurationTurns, DurationRounds);

public enum ChanceModifierType
{
    Curse,
    Blessing
}

public record ChanceModifierIR(
    int DurationTurns,
    int DurationRounds,
    ChanceModifierType ChanceModifierType,
    float Amount,
    Condition? Condition
) : ModifierIR(DurationTurns, DurationRounds);

public record SideEffectsIR(
    List<EffectIR> Effects,
    Condition? When = null
);
