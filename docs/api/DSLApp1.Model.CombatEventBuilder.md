# <a id="DSLApp1_Model_CombatEventBuilder"></a> Class CombatEventBuilder

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public class CombatEventBuilder
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CombatEventBuilder](DSLApp1.Model.CombatEventBuilder.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="DSLApp1_Model_CombatEventBuilder_Build"></a> Build\(\)

```csharp
public CombatEvent Build()
```

#### Returns

 [CombatEvent](DSLApp1.Model.CombatEvent.md)

### <a id="DSLApp1_Model_CombatEventBuilder_WithAbility_DSLApp1_Model_IAbility_"></a> WithAbility\(IAbility\)

```csharp
public CombatEventBuilder WithAbility(IAbility ability)
```

#### Parameters

`ability` [IAbility](DSLApp1.Model.IAbility.md)

#### Returns

 [CombatEventBuilder](DSLApp1.Model.CombatEventBuilder.md)

### <a id="DSLApp1_Model_CombatEventBuilder_WithDamage_DSLApp1_Model_ICombatCharacter_System_Int32_System_Int32_System_Int32_System_Boolean_System_Collections_Generic_List_DSLApp1_Model_IModifier__"></a> WithDamage\(ICombatCharacter, int, int, int, bool, List<IModifier\>\)

```csharp
public CombatEventBuilder WithDamage(ICombatCharacter target, int hpChange, int manaChange, int opportunityChange, bool kill = false, List<IModifier> appliedModifiers = null)
```

#### Parameters

`target` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

`hpChange` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`manaChange` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`opportunityChange` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`kill` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`appliedModifiers` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

#### Returns

 [CombatEventBuilder](DSLApp1.Model.CombatEventBuilder.md)

### <a id="DSLApp1_Model_CombatEventBuilder_WithExpiredModifiers_System_Collections_Generic_List_DSLApp1_Model_IModifier__"></a> WithExpiredModifiers\(List<IModifier\>\)

```csharp
public void WithExpiredModifiers(List<IModifier> expiredModifiers)
```

#### Parameters

`expiredModifiers` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

### <a id="DSLApp1_Model_CombatEventBuilder_WithMiss_System_Boolean_"></a> WithMiss\(bool\)

```csharp
public CombatEventBuilder WithMiss(bool miss)
```

#### Parameters

`miss` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [CombatEventBuilder](DSLApp1.Model.CombatEventBuilder.md)

### <a id="DSLApp1_Model_CombatEventBuilder_WithModifiers_System_Collections_Generic_List_DSLApp1_Model_IModifier__"></a> WithModifiers\(List<IModifier\>\)

```csharp
public CombatEventBuilder WithModifiers(List<IModifier> modifiers)
```

#### Parameters

`modifiers` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

#### Returns

 [CombatEventBuilder](DSLApp1.Model.CombatEventBuilder.md)

### <a id="DSLApp1_Model_CombatEventBuilder_WithTarget_DSLApp1_Model_ICombatCharacter_"></a> WithTarget\(ICombatCharacter\)

```csharp
public CombatEventBuilder WithTarget(ICombatCharacter target)
```

#### Parameters

`target` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

#### Returns

 [CombatEventBuilder](DSLApp1.Model.CombatEventBuilder.md)

### <a id="DSLApp1_Model_CombatEventBuilder_WithTargets_System_Collections_Generic_IEnumerable_DSLApp1_Model_ICombatCharacter__"></a> WithTargets\(IEnumerable<ICombatCharacter\>\)

```csharp
public CombatEventBuilder WithTargets(IEnumerable<ICombatCharacter> newTargets)
```

#### Parameters

`newTargets` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)\>

#### Returns

 [CombatEventBuilder](DSLApp1.Model.CombatEventBuilder.md)

### <a id="DSLApp1_Model_CombatEventBuilder_WithUser_DSLApp1_Model_ICombatCharacter_"></a> WithUser\(ICombatCharacter\)

```csharp
public CombatEventBuilder WithUser(ICombatCharacter user)
```

#### Parameters

`user` [ICombatCharacter](DSLApp1.Model.ICombatCharacter.md)

#### Returns

 [CombatEventBuilder](DSLApp1.Model.CombatEventBuilder.md)

