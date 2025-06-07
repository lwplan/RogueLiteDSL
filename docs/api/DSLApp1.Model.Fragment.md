# <a id="DSLApp1_Model_Fragment"></a> Class Fragment

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
[Serializable]
public class Fragment
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Fragment](DSLApp1.Model.Fragment.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Model_Fragment__ctor_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_System_String_"></a> Fragment\(string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string\)

```csharp
public Fragment(string name, string description, string hexSignature, string elementString, string rarity, string exclusivities, string levelString, string opportunityPotString, string manaCostString, string riskString, string targetabilityString, string equips, string deals, string applies, string animation, string damageEffect, string castEffect)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`description` [string](https://learn.microsoft.com/dotnet/api/system.string)

`hexSignature` [string](https://learn.microsoft.com/dotnet/api/system.string)

`elementString` [string](https://learn.microsoft.com/dotnet/api/system.string)

`rarity` [string](https://learn.microsoft.com/dotnet/api/system.string)

`exclusivities` [string](https://learn.microsoft.com/dotnet/api/system.string)

`levelString` [string](https://learn.microsoft.com/dotnet/api/system.string)

`opportunityPotString` [string](https://learn.microsoft.com/dotnet/api/system.string)

`manaCostString` [string](https://learn.microsoft.com/dotnet/api/system.string)

`riskString` [string](https://learn.microsoft.com/dotnet/api/system.string)

`targetabilityString` [string](https://learn.microsoft.com/dotnet/api/system.string)

`equips` [string](https://learn.microsoft.com/dotnet/api/system.string)

`deals` [string](https://learn.microsoft.com/dotnet/api/system.string)

`applies` [string](https://learn.microsoft.com/dotnet/api/system.string)

`animation` [string](https://learn.microsoft.com/dotnet/api/system.string)

`damageEffect` [string](https://learn.microsoft.com/dotnet/api/system.string)

`castEffect` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="DSLApp1_Model_Fragment_Ability"></a> Ability

```csharp
public IAbility Ability { get; }
```

#### Property Value

 [IAbility](DSLApp1.Model.IAbility.md)

### <a id="DSLApp1_Model_Fragment_Description"></a> Description

```csharp
public string Description { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_Fragment_Equips"></a> Equips

```csharp
public List<IModifier> Equips { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

### <a id="DSLApp1_Model_Fragment_Exclusivities"></a> Exclusivities

```csharp
public List<Exclusivity> Exclusivities { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Exclusivity](DSLApp1.Model.Exclusivity.md)\>

### <a id="DSLApp1_Model_Fragment_HasAbility"></a> HasAbility

```csharp
public bool HasAbility { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_Fragment_HexSignature"></a> HexSignature

```csharp
public string HexSignature { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_Fragment_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_Fragment_Rarity"></a> Rarity

```csharp
public Rarity Rarity { get; }
```

#### Property Value

 [Rarity](DSLApp1.Model.Rarity.md)

### <a id="DSLApp1_Model_Fragment_Unlocked"></a> Unlocked

```csharp
public bool Unlocked { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

