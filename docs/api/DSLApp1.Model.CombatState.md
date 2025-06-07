# <a id="DSLApp1_Model_CombatState"></a> Class CombatState

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public record CombatState : IEquatable<CombatState>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CombatState](DSLApp1.Model.CombatState.md)

#### Implements

[IEquatable<CombatState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Model_CombatState__ctor_System_Collections_Generic_List_DSLApp1_Model_ICombatCharacter__DSLApp1_Model_CombatRound_"></a> CombatState\(List<ICombatCharacter\>, CombatRound\)

```csharp
public CombatState(List<ICombatCharacter> characters, CombatRound round)
```

#### Parameters

`characters` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)\>

`round` [CombatRound](DSLApp1.Model.CombatRound.md)

## Fields

### <a id="DSLApp1_Model_CombatState_Characters"></a> Characters

```csharp
public List<ICombatCharacter> Characters
```

#### Field Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)\>

### <a id="DSLApp1_Model_CombatState_CurrentPhase"></a> CurrentPhase

```csharp
public CombatState.Phase CurrentPhase
```

#### Field Value

 [CombatState](DSLApp1.Model.CombatState.md).[Phase](DSLApp1.Model.CombatState.Phase.md)

### <a id="DSLApp1_Model_CombatState_LastPhase"></a> LastPhase

```csharp
public CombatState.Phase LastPhase
```

#### Field Value

 [CombatState](DSLApp1.Model.CombatState.md).[Phase](DSLApp1.Model.CombatState.Phase.md)

### <a id="DSLApp1_Model_CombatState_Round"></a> Round

```csharp
public CombatRound Round
```

#### Field Value

 [CombatRound](DSLApp1.Model.CombatRound.md)

## Properties

### <a id="DSLApp1_Model_CombatState_CurrentICombatCharacter"></a> CurrentICombatCharacter

```csharp
public ICombatCharacter CurrentICombatCharacter { get; }
```

#### Property Value

 [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

