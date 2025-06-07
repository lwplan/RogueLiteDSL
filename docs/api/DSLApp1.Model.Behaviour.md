# <a id="DSLApp1_Model_Behaviour"></a> Class Behaviour

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public abstract class Behaviour
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Behaviour](DSLApp1.Model.Behaviour.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="DSLApp1_Model_Behaviour_ChooseAction_DSLApp1_Model_CombatState_"></a> ChooseAction\(CombatState\)

```csharp
public virtual Behaviour.NpcAction ChooseAction(CombatState combat)
```

#### Parameters

`combat` [CombatState](DSLApp1.Model.CombatState.md)

#### Returns

 [Behaviour](DSLApp1.Model.Behaviour.md).[NpcAction](DSLApp1.Model.Behaviour.NpcAction.md)

### <a id="DSLApp1_Model_Behaviour_ForCharacterDefinition_DSLApp1_Model_ICharacterBaseState_"></a> ForCharacterDefinition\(ICharacterBaseState\)

```csharp
public static Behaviour ForCharacterDefinition(ICharacterBaseState characterDefinition)
```

#### Parameters

`characterDefinition` [ICharacterBaseState](DSLApp1.Model.ICharacterBaseState.md)

#### Returns

 [Behaviour](DSLApp1.Model.Behaviour.md)

