# <a id="DSLApp1_Model_ICharacterCombatState"></a> Interface ICharacterCombatState

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public interface ICharacterCombatState
```

## Properties

### <a id="DSLApp1_Model_ICharacterCombatState_CombatModifiers"></a> CombatModifiers

```csharp
List<IModifier> CombatModifiers { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

### <a id="DSLApp1_Model_ICharacterCombatState_Hp"></a> Hp

```csharp
int Hp { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterCombatState_HpPercentage"></a> HpPercentage

```csharp
int HpPercentage { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterCombatState_IsActive"></a> IsActive

```csharp
bool IsActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_ICharacterCombatState_IsDead"></a> IsDead

```csharp
bool IsDead { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_ICharacterCombatState_Mana"></a> Mana

```csharp
int Mana { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterCombatState_Modifiers"></a> Modifiers

```csharp
List<IModifier> Modifiers { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

### <a id="DSLApp1_Model_ICharacterCombatState_OpportunityGauge"></a> OpportunityGauge

```csharp
int OpportunityGauge { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="DSLApp1_Model_ICharacterCombatState_AddHp_System_Int32_"></a> AddHp\(int\)

```csharp
void AddHp(int change)
```

#### Parameters

`change` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterCombatState_AddMana_System_Int32_"></a> AddMana\(int\)

```csharp
void AddMana(int value)
```

#### Parameters

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterCombatState_AddModifier_DSLApp1_Model_IModifier_"></a> AddModifier\(IModifier\)

```csharp
void AddModifier(IModifier modifier)
```

#### Parameters

`modifier` [IModifier](DSLApp1.Model.IModifier.md)

### <a id="DSLApp1_Model_ICharacterCombatState_AddOpportunityPoints_System_Int32_"></a> AddOpportunityPoints\(int\)

```csharp
void AddOpportunityPoints(int points)
```

#### Parameters

`points` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterCombatState_ApplyModifiers_DSLApp1_Model_ICombatCharacter_"></a> ApplyModifiers\(ICombatCharacter\)

```csharp
CombatEvent? ApplyModifiers(ICombatCharacter character)
```

#### Parameters

`character` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

#### Returns

 [CombatEvent](DSLApp1.Model.CombatEvent.md)?

### <a id="DSLApp1_Model_ICharacterCombatState_AttackMultiplier_DSLApp1_Model_IAbility_DSLApp1_Model_ICombatCharacter_"></a> AttackMultiplier\(IAbility, ICombatCharacter\)

```csharp
float AttackMultiplier(IAbility ability, ICombatCharacter character)
```

#### Parameters

`ability` [IAbility](DSLApp1.Model.IAbility.md)

`character` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="DSLApp1_Model_ICharacterCombatState_AvailableAbilities_DSLApp1_Model_CombatState_DSLApp1_Model_CharacterCombatState_AbilityMode_"></a> AvailableAbilities\(CombatState, AbilityMode\)

```csharp
List<IAbility> AvailableAbilities(CombatState combat, CharacterCombatState.AbilityMode abilityMode)
```

#### Parameters

`combat` [CombatState](DSLApp1.Model.CombatState.md)

`abilityMode` [CharacterCombatState](DSLApp1.Model.CharacterCombatState.md).[AbilityMode](DSLApp1.Model.CharacterCombatState.AbilityMode.md)

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IAbility](DSLApp1.Model.IAbility.md)\>

### <a id="DSLApp1_Model_ICharacterCombatState_DamageMultiplier_DSLApp1_Model_IAbility_"></a> DamageMultiplier\(IAbility\)

```csharp
float DamageMultiplier(IAbility ability)
```

#### Parameters

`ability` [IAbility](DSLApp1.Model.IAbility.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="DSLApp1_Model_ICharacterCombatState_Description"></a> Description\(\)

```csharp
string Description()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_ICharacterCombatState_GetAbilityUseCount_DSLApp1_Model_IAbility_"></a> GetAbilityUseCount\(IAbility\)

```csharp
int GetAbilityUseCount(IAbility ability)
```

#### Parameters

`ability` [IAbility](DSLApp1.Model.IAbility.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterCombatState_GetBuffedStat_DSLApp1_Model_Stat_"></a> GetBuffedStat\(Stat\)

```csharp
int GetBuffedStat(Stat stat)
```

#### Parameters

`stat` [Stat](DSLApp1.Model.Stat.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterCombatState_GetHexPieceAbilities"></a> GetHexPieceAbilities\(\)

```csharp
List<IAbility> GetHexPieceAbilities()
```

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IAbility](DSLApp1.Model.IAbility.md)\>

### <a id="DSLApp1_Model_ICharacterCombatState_GetOpportunityAbility"></a> GetOpportunityAbility\(\)

```csharp
IAbility GetOpportunityAbility()
```

#### Returns

 [IAbility](DSLApp1.Model.IAbility.md)

### <a id="DSLApp1_Model_ICharacterCombatState_GetPrimaryAbility"></a> GetPrimaryAbility\(\)

```csharp
IAbility GetPrimaryAbility()
```

#### Returns

 [IAbility](DSLApp1.Model.IAbility.md)

### <a id="DSLApp1_Model_ICharacterCombatState_HexPieceAbilityOrRandom_System_Int32_System_Collections_Generic_List_DSLApp1_Model_IAbility__"></a> HexPieceAbilityOrRandom\(int, List<IAbility\>\)

```csharp
IAbility HexPieceAbilityOrRandom(int index, List<IAbility> fallbackAbilities = null)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`fallbackAbilities` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IAbility](DSLApp1.Model.IAbility.md)\>

#### Returns

 [IAbility](DSLApp1.Model.IAbility.md)

### <a id="DSLApp1_Model_ICharacterCombatState_InOpportunityMode"></a> InOpportunityMode\(\)

```csharp
bool InOpportunityMode()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_ICharacterCombatState_OnAbilityUsed_DSLApp1_Model_IAbility_"></a> OnAbilityUsed\(IAbility\)

```csharp
void OnAbilityUsed(IAbility ability)
```

#### Parameters

`ability` [IAbility](DSLApp1.Model.IAbility.md)

### <a id="DSLApp1_Model_ICharacterCombatState_OnCombatStart"></a> OnCombatStart\(\)

```csharp
void OnCombatStart()
```

### <a id="DSLApp1_Model_ICharacterCombatState_OnEndTurn"></a> OnEndTurn\(\)

```csharp
void OnEndTurn()
```

### <a id="DSLApp1_Model_ICharacterCombatState_OnOpportunityAbilityUsed"></a> OnOpportunityAbilityUsed\(\)

```csharp
void OnOpportunityAbilityUsed()
```

### <a id="DSLApp1_Model_ICharacterCombatState_OnStartTurn"></a> OnStartTurn\(\)

```csharp
void OnStartTurn()
```

### <a id="DSLApp1_Model_ICharacterCombatState_RemainingTurns_DSLApp1_Model_IModifier_"></a> RemainingTurns\(IModifier\)

```csharp
int RemainingTurns(IModifier modifier)
```

#### Parameters

`modifier` [IModifier](DSLApp1.Model.IModifier.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

