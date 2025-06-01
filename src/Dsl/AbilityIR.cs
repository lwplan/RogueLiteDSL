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
    List<SupportEffectIR> SupportEffects,
    string? adjectivive
);

public abstract record SupportEffectIR;

public record DamageSupportIR(DamageMechanicType Mechanic, float Value) : SupportEffectIR;

public record ElementSupportIR(Element Element) : SupportEffectIR;

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

public enum DurationType { Rounds, Turns }
public record Duration(DurationType DurationType, int Amount);

public abstract record ModifierIR(
    Duration Duration
);

public record EffectModifierIR(
    Duration Duration,
    EffectIR Effect
) : ModifierIR(Duration);

public record BuffDebuffIR(int Amount, SkillStat Stat);

public record BuffDebuffModifierIR(
    Duration Duration,
    List<BuffDebuffIR> BuffDebuffs
) : ModifierIR(Duration);

public record ShieldModifierIR(
    Duration Duration,
    int Shield,
    bool ShieldBreakable
) : ModifierIR(Duration);

public enum MultiplierModifierType
{
    Vulnerability,
    Protection,
    Might,
    Frailty
}

public record MultiplierModifierIR(
    Duration Duration,
    MultiplierModifierType MultiplierModifierType,
    float Amount,
    Condition Condition
) : ModifierIR(Duration);

public enum ChanceModifierType
{
    Curse,
    Blessing
}

public record ChanceModifierIR(
    Duration Duration,
    ChanceModifierType ChanceModifierType,
    float Amount,
    Condition? Condition
) : ModifierIR(Duration);

public enum SideEffectMechanicType
{
    Bounce,
    Splash
}

public record SideEffectMechanic(SideEffectMechanicType SideEffectMechanicType, float Amount);

public record SideEffectsIR(
    List<SideEffectMechanic> Effects,
    Condition? When = null
);
