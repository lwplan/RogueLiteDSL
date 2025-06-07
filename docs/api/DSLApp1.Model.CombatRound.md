# <a id="DSLApp1_Model_CombatRound"></a> Class CombatRound

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public class CombatRound
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CombatRound](DSLApp1.Model.CombatRound.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Model_CombatRound__ctor"></a> CombatRound\(\)

```csharp
public CombatRound()
```

## Fields

### <a id="DSLApp1_Model_CombatRound_CurrentRoundNo"></a> CurrentRoundNo

```csharp
public int CurrentRoundNo
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_CombatRound_TurnsPerRound"></a> TurnsPerRound

```csharp
public int TurnsPerRound
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="DSLApp1_Model_CombatRound_TurnList"></a> TurnList

```csharp
public List<ICombatCharacter> TurnList { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)\>

## Methods

### <a id="DSLApp1_Model_CombatRound_BuildTurnQueue_System_Collections_Generic_List_DSLApp1_Model_ICombatCharacter__"></a> BuildTurnQueue\(List<ICombatCharacter\>\)

```csharp
public void BuildTurnQueue(List<ICombatCharacter> characters)
```

#### Parameters

`characters` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)\>

### <a id="DSLApp1_Model_CombatRound_GetCurrentTurn"></a> GetCurrentTurn\(\)

```csharp
public ICombatCharacter GetCurrentTurn()
```

#### Returns

 [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

### <a id="DSLApp1_Model_CombatRound_HasActiveTurn"></a> HasActiveTurn\(\)

```csharp
public bool HasActiveTurn()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_CombatRound_RemoveCharacterFromFutureTurns_DSLApp1_Model_ICombatCharacter_"></a> RemoveCharacterFromFutureTurns\(ICombatCharacter\)

```csharp
public void RemoveCharacterFromFutureTurns(ICombatCharacter character)
```

#### Parameters

`character` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

