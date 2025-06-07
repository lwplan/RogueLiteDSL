# <a id="DSLApp1_Model_CharacterCombatState"></a> Class CharacterCombatState

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public abstract class CharacterCombatState : ICharacterCombatState
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CharacterCombatState](DSLApp1.Model.CharacterCombatState.md)

#### Implements

[ICharacterCombatState](DSLApp1.Model.ICharacterCombatState.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Model_CharacterCombatState__ctor_DSLApp1_Model_ICharacterDefinition_"></a> CharacterCombatState\(ICharacterDefinition\)

```csharp
public CharacterCombatState(ICharacterDefinition characterDefinition)
```

#### Parameters

`characterDefinition` [ICharacterDefinition](DSLApp1.Model.ICharacterDefinition.md)

## Properties

### <a id="DSLApp1_Model_CharacterCombatState_CombatModifiers"></a> CombatModifiers

```csharp
public List<IModifier> CombatModifiers { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

### <a id="DSLApp1_Model_CharacterCombatState_Hp"></a> Hp

```csharp
public int Hp { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_CharacterCombatState_HpPercentage"></a> HpPercentage

```csharp
public int HpPercentage { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_CharacterCombatState_IsActive"></a> IsActive

```csharp
public bool IsActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_CharacterCombatState_IsDead"></a> IsDead

```csharp
public bool IsDead { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_CharacterCombatState_Mana"></a> Mana

```csharp
public int Mana { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_CharacterCombatState_Modifiers"></a> Modifiers

```csharp
public List<IModifier> Modifiers { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

### <a id="DSLApp1_Model_CharacterCombatState_OpportunityGauge"></a> OpportunityGauge

```csharp
public int OpportunityGauge { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_CharacterCombatState_OpportunityTurnsRemaining"></a> OpportunityTurnsRemaining

```csharp
public int OpportunityTurnsRemaining { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="DSLApp1_Model_CharacterCombatState_AddHp_System_Int32_"></a> AddHp\(int\)

```csharp
public void AddHp(int change)
```

#### Parameters

`change` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_CharacterCombatState_AddMana_System_Int32_"></a> AddMana\(int\)

```csharp
public void AddMana(int manaChange)
```

#### Parameters

`manaChange` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_CharacterCombatState_AddModifier_DSLApp1_Model_IModifier_"></a> AddModifier\(IModifier\)

```csharp
public void AddModifier(IModifier modifier)
```

#### Parameters

`modifier` [IModifier](DSLApp1.Model.IModifier.md)

### <a id="DSLApp1_Model_CharacterCombatState_AddOpportunityPoints_System_Int32_"></a> AddOpportunityPoints\(int\)

```csharp
public void AddOpportunityPoints(int points)
```

#### Parameters

`points` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_CharacterCombatState_ApplyModifiers_DSLApp1_Model_ICombatCharacter_"></a> ApplyModifiers\(ICombatCharacter\)

```csharp
public CombatEvent ApplyModifiers(ICombatCharacter character)
```

#### Parameters

`character` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

#### Returns

 [CombatEvent](DSLApp1.Model.CombatEvent.md)

### <a id="DSLApp1_Model_CharacterCombatState_AttackMultiplier_DSLApp1_Model_IAbility_DSLApp1_Model_ICombatCharacter_"></a> AttackMultiplier\(IAbility, ICombatCharacter\)

```csharp
public float AttackMultiplier(IAbility ability, ICombatCharacter character)
```

#### Parameters

`ability` [IAbility](DSLApp1.Model.IAbility.md)

`character` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="DSLApp1_Model_CharacterCombatState_AvailableAbilities_DSLApp1_Model_CombatState_DSLApp1_Model_CharacterCombatState_AbilityMode_"></a> AvailableAbilities\(CombatState, AbilityMode\)

```csharp
public List<IAbility> AvailableAbilities(CombatState combat, CharacterCombatState.AbilityMode abilityMode)
```

#### Parameters

`combat` [CombatState](DSLApp1.Model.CombatState.md)

`abilityMode` [CharacterCombatState](DSLApp1.Model.CharacterCombatState.md).[AbilityMode](DSLApp1.Model.CharacterCombatState.AbilityMode.md)

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IAbility](DSLApp1.Model.IAbility.md)\>

### <a id="DSLApp1_Model_CharacterCombatState_DamageMultiplier_DSLApp1_Model_IAbility_"></a> DamageMultiplier\(IAbility\)

```csharp
public float DamageMultiplier(IAbility ability)
```

#### Parameters

`ability` [IAbility](DSLApp1.Model.IAbility.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="DSLApp1_Model_CharacterCombatState_Description"></a> Description\(\)

```csharp
public string Description()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_CharacterCombatState_GetAbilityUseCount_DSLApp1_Model_IAbility_"></a> GetAbilityUseCount\(IAbility\)

```csharp
public int GetAbilityUseCount(IAbility ability)
```

#### Parameters

`ability` [IAbility](DSLApp1.Model.IAbility.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_CharacterCombatState_GetBuffedStat_DSLApp1_Model_Stat_"></a> GetBuffedStat\(Stat\)

```csharp
public int GetBuffedStat(Stat stat)
```

#### Parameters

`stat` [Stat](DSLApp1.Model.Stat.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_CharacterCombatState_GetHexPieceAbilities"></a> GetHexPieceAbilities\(\)

```csharp
public List<IAbility> GetHexPieceAbilities()
```

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IAbility](DSLApp1.Model.IAbility.md)\>

### <a id="DSLApp1_Model_CharacterCombatState_GetOpportunityAbility"></a> GetOpportunityAbility\(\)

```csharp
public IAbility GetOpportunityAbility()
```

#### Returns

 [IAbility](DSLApp1.Model.IAbility.md)

### <a id="DSLApp1_Model_CharacterCombatState_GetPrimaryAbility"></a> GetPrimaryAbility\(\)

```csharp
public IAbility GetPrimaryAbility()
```

#### Returns

 [IAbility](DSLApp1.Model.IAbility.md)

### <a id="DSLApp1_Model_CharacterCombatState_GetStat_DSLApp1_Model_Stat_"></a> GetStat\(Stat\)

```csharp
public int GetStat(Stat stat)
```

#### Parameters

`stat` [Stat](DSLApp1.Model.Stat.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_CharacterCombatState_HexPieceAbilityOrRandom_System_Int32_System_Collections_Generic_List_DSLApp1_Model_IAbility__"></a> HexPieceAbilityOrRandom\(int, List<IAbility\>\)

```csharp
public IAbility HexPieceAbilityOrRandom(int index, List<IAbility> fallbackAbilities = null)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`fallbackAbilities` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IAbility](DSLApp1.Model.IAbility.md)\>

#### Returns

 [IAbility](DSLApp1.Model.IAbility.md)

### <a id="DSLApp1_Model_CharacterCombatState_InOpportunityMode"></a> InOpportunityMode\(\)

```csharp
public bool InOpportunityMode()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_CharacterCombatState_OnAbilityUsed_DSLApp1_Model_IAbility_"></a> OnAbilityUsed\(IAbility\)

```csharp
public void OnAbilityUsed(IAbility ability)
```

#### Parameters

`ability` [IAbility](DSLApp1.Model.IAbility.md)

### <a id="DSLApp1_Model_CharacterCombatState_OnCombatStart"></a> OnCombatStart\(\)

```csharp
public void OnCombatStart()
```

### <a id="DSLApp1_Model_CharacterCombatState_OnEndTurn"></a> OnEndTurn\(\)

```csharp
public void OnEndTurn()
```

### <a id="DSLApp1_Model_CharacterCombatState_OnOpportunityAbilityUsed"></a> OnOpportunityAbilityUsed\(\)

```csharp
public void OnOpportunityAbilityUsed()
```

### <a id="DSLApp1_Model_CharacterCombatState_OnStartTurn"></a> OnStartTurn\(\)

```csharp
public void OnStartTurn()
```

### <a id="DSLApp1_Model_CharacterCombatState_RemainingTurns_DSLApp1_Model_IModifier_"></a> RemainingTurns\(IModifier\)

```csharp
public int RemainingTurns(IModifier modifier)
```

#### Parameters

`modifier` [IModifier](DSLApp1.Model.IModifier.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

