# <a id="DSLApp1_Model_CombatEvent"></a> Class CombatEvent

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public class CombatEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CombatEvent](DSLApp1.Model.CombatEvent.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Model_CombatEvent__ctor_DSLApp1_Model_ICombatCharacter_System_Collections_Generic_List_DSLApp1_Model_ICombatCharacter__System_Boolean_DSLApp1_Model_IAbility_System_Collections_Generic_List_DSLApp1_Model_IModifier__System_Collections_Generic_List_DSLApp1_Model_IModifier__"></a> CombatEvent\(ICombatCharacter, List<ICombatCharacter\>, bool, IAbility, List<IModifier\>, List<IModifier\>\)

```csharp
public CombatEvent(ICombatCharacter user, List<ICombatCharacter> targets, bool miss, IAbility ability, List<IModifier> modifiers, List<IModifier> expiredModifiers)
```

#### Parameters

`user` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)\>

`miss` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`ability` [IAbility](DSLApp1.Model.IAbility.md)

`modifiers` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

`expiredModifiers` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

## Properties

### <a id="DSLApp1_Model_CombatEvent_Ability"></a> Ability

```csharp
public IAbility Ability { get; }
```

#### Property Value

 [IAbility](DSLApp1.Model.IAbility.md)

### <a id="DSLApp1_Model_CombatEvent_ExpiredModifiers"></a> ExpiredModifiers

```csharp
public List<IModifier> ExpiredModifiers { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

### <a id="DSLApp1_Model_CombatEvent_Miss"></a> Miss

```csharp
public bool Miss { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_CombatEvent_Modifiers"></a> Modifiers

```csharp
public List<IModifier> Modifiers { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

### <a id="DSLApp1_Model_CombatEvent_Targets"></a> Targets

```csharp
public List<ICombatCharacter> Targets { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)\>

### <a id="DSLApp1_Model_CombatEvent_User"></a> User

```csharp
public ICombatCharacter User { get; }
```

#### Property Value

 [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

## Methods

### <a id="DSLApp1_Model_CombatEvent_Apply_DSLApp1_Model_ICombatCharacter_"></a> Apply\(ICombatCharacter\)

```csharp
public void Apply(ICombatCharacter character)
```

#### Parameters

`character` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

### <a id="DSLApp1_Model_CombatEvent_ExpiredModifier_DSLApp1_Model_ICombatCharacter_DSLApp1_Model_IModifier_"></a> ExpiredModifier\(ICombatCharacter, IModifier\)

```csharp
public void ExpiredModifier(ICombatCharacter character, IModifier modifier)
```

#### Parameters

`character` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

`modifier` [IModifier](DSLApp1.Model.IModifier.md)

### <a id="DSLApp1_Model_CombatEvent_SetDamage_DSLApp1_Model_ICombatCharacter_DSLApp1_Model_Damage_"></a> SetDamage\(ICombatCharacter, Damage\)

```csharp
public void SetDamage(ICombatCharacter target, Damage damage)
```

#### Parameters

`target` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

`damage` [Damage](DSLApp1.Model.Damage.md)

### <a id="DSLApp1_Model_CombatEvent_TryGetDamage_DSLApp1_Model_ICombatCharacter_DSLApp1_Model_Damage__"></a> TryGetDamage\(ICombatCharacter, out Damage\)

```csharp
public bool TryGetDamage(ICombatCharacter character, out Damage damage)
```

#### Parameters

`character` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

`damage` [Damage](DSLApp1.Model.Damage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

