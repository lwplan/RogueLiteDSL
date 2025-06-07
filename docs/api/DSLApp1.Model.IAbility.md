# <a id="DSLApp1_Model_IAbility"></a> Interface IAbility

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public interface IAbility : IIdentifiable
```

#### Implements

[IIdentifiable](DSLApp1.Model.IIdentifiable.md)

## Properties

### <a id="DSLApp1_Model_IAbility_ManaCost"></a> ManaCost

```csharp
int ManaCost { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_IAbility_Name"></a> Name

```csharp
string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_IAbility_Targetability"></a> Targetability

```csharp
Targetability Targetability { get; }
```

#### Property Value

 [Targetability](DSLApp1.Model.Targetability.md)

## Methods

### <a id="DSLApp1_Model_IAbility_Apply_DSLApp1_Model_ICombatCharacter_System_Collections_Generic_List_DSLApp1_Model_ICombatCharacter__System_Boolean_"></a> Apply\(ICombatCharacter, List<ICombatCharacter\>, bool\)

```csharp
CombatEvent Apply(ICombatCharacter combatCharacter, List<ICombatCharacter> targets, bool opportunity = false)
```

#### Parameters

`combatCharacter` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)\>

`opportunity` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [CombatEvent](DSLApp1.Model.CombatEvent.md)

### <a id="DSLApp1_Model_IAbility_ValidTargets_DSLApp1_Model_ICombatCharacter_System_Collections_Generic_List_DSLApp1_Model_ICombatCharacter__"></a> ValidTargets\(ICombatCharacter, List<ICombatCharacter\>\)

```csharp
List<ICombatCharacter> ValidTargets(ICombatCharacter user, List<ICombatCharacter> targets)
```

#### Parameters

`user` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)\>

