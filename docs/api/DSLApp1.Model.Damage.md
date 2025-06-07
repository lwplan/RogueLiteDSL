# <a id="DSLApp1_Model_Damage"></a> Class Damage

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public class Damage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Damage](DSLApp1.Model.Damage.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Model_Damage__ctor_System_Int32_System_Int32_System_Int32_System_Boolean_System_Collections_Generic_List_DSLApp1_Model_IModifier__"></a> Damage\(int, int, int, bool, List<IModifier\>\)

```csharp
public Damage(int hpChange, int manaChange, int opportunityChange, bool kill, List<IModifier> appliedModifiers)
```

#### Parameters

`hpChange` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`manaChange` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`opportunityChange` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`kill` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`appliedModifiers` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

## Properties

### <a id="DSLApp1_Model_Damage_AppliedModifiers"></a> AppliedModifiers

```csharp
public List<IModifier> AppliedModifiers { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

### <a id="DSLApp1_Model_Damage_ExpiredModifiers"></a> ExpiredModifiers

```csharp
public List<IModifier> ExpiredModifiers { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

### <a id="DSLApp1_Model_Damage_HpChange"></a> HpChange

```csharp
public int HpChange { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_Damage_Kill"></a> Kill

```csharp
public bool Kill { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_Damage_ManaChange"></a> ManaChange

```csharp
public int ManaChange { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_Damage_OpportunityChange"></a> OpportunityChange

```csharp
public int OpportunityChange { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

