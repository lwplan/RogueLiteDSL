# <a id="DSLApp1_Model_Behaviour_NpcAction"></a> Class Behaviour.NpcAction

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public class Behaviour.NpcAction
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Behaviour.NpcAction](DSLApp1.Model.Behaviour.NpcAction.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Model_Behaviour_NpcAction__ctor_DSLApp1_Model_ICombatCharacter_System_Collections_Generic_List_DSLApp1_Model_ICombatCharacter__DSLApp1_Model_IAbility_"></a> NpcAction\(ICombatCharacter, List<ICombatCharacter\>, IAbility\)

```csharp
public NpcAction(ICombatCharacter player, List<ICombatCharacter> targets, IAbility ability)
```

#### Parameters

`player` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)\>

`ability` [IAbility](DSLApp1.Model.IAbility.md)

## Methods

### <a id="DSLApp1_Model_Behaviour_NpcAction_Perform"></a> Perform\(\)

```csharp
public CombatEvent Perform()
```

#### Returns

 [CombatEvent](DSLApp1.Model.CombatEvent.md)

