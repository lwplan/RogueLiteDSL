# <a id="DSLApp1_Model_ICharacterBaseState"></a> Interface ICharacterBaseState

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public interface ICharacterBaseState
```

## Properties

### <a id="DSLApp1_Model_ICharacterBaseState_BaseAttack"></a> BaseAttack

```csharp
int BaseAttack { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterBaseState_BaseDefense"></a> BaseDefense

```csharp
int BaseDefense { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterBaseState_BaseHp"></a> BaseHp

```csharp
int BaseHp { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterBaseState_BaseInitiative"></a> BaseInitiative

```csharp
int BaseInitiative { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterBaseState_BaseIntelligence"></a> BaseIntelligence

```csharp
int BaseIntelligence { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterBaseState_BaseMana"></a> BaseMana

```csharp
int BaseMana { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterBaseState_BaseManaPerTurn"></a> BaseManaPerTurn

```csharp
int BaseManaPerTurn { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterBaseState_BaseMaxOpportunityTurns"></a> BaseMaxOpportunityTurns

```csharp
int BaseMaxOpportunityTurns { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterBaseState_BaseResistance"></a> BaseResistance

```csharp
int BaseResistance { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_ICharacterBaseState_BehaviourType"></a> BehaviourType

```csharp
BehaviourType BehaviourType { get; }
```

#### Property Value

 [BehaviourType](DSLApp1.Model.BehaviourType.md)

### <a id="DSLApp1_Model_ICharacterBaseState_CharacterDescription"></a> CharacterDescription

```csharp
string CharacterDescription { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_ICharacterBaseState_CharacterName"></a> CharacterName

```csharp
string CharacterName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_ICharacterBaseState_HexPieceAbilties"></a> HexPieceAbilties

```csharp
List<IAbility> HexPieceAbilties { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IAbility](DSLApp1.Model.IAbility.md)\>

### <a id="DSLApp1_Model_ICharacterBaseState_Id"></a> Id

```csharp
Guid Id { get; }
```

#### Property Value

 [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

### <a id="DSLApp1_Model_ICharacterBaseState_OpportunityAbility"></a> OpportunityAbility

```csharp
IAbility OpportunityAbility { get; }
```

#### Property Value

 [IAbility](DSLApp1.Model.IAbility.md)

### <a id="DSLApp1_Model_ICharacterBaseState_PrimaryAbility"></a> PrimaryAbility

```csharp
IAbility PrimaryAbility { get; }
```

#### Property Value

 [IAbility](DSLApp1.Model.IAbility.md)

