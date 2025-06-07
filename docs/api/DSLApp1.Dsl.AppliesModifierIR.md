# <a id="DSLApp1_Dsl_AppliesModifierIR"></a> Class AppliesModifierIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record AppliesModifierIR : ModifierIR, IEquatable<ModifierIR>, IEquatable<AppliesModifierIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ModifierIR](DSLApp1.Dsl.ModifierIR.md) ← 
[AppliesModifierIR](DSLApp1.Dsl.AppliesModifierIR.md)

#### Implements

[IEquatable<ModifierIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<AppliesModifierIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[ModifierIR.Duration](DSLApp1.Dsl.ModifierIR.md\#DSLApp1\_Dsl\_ModifierIR\_Duration), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_AppliesModifierIR__ctor_DSLApp1_Dsl_Duration_System_Collections_Generic_List_DSLApp1_Dsl_ModifierMechanicIR__DSLApp1_Dsl_Condition_"></a> AppliesModifierIR\(Duration, List<ModifierMechanicIR\>, Condition?\)

```csharp
public AppliesModifierIR(Duration Duration, List<ModifierMechanicIR> Mechanics, Condition? Condition)
```

#### Parameters

`Duration` [Duration](DSLApp1.Dsl.Duration.md)

`Mechanics` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ModifierMechanicIR](DSLApp1.Dsl.ModifierMechanicIR.md)\>

`Condition` [Condition](DSLApp1.Dsl.Condition.md)?

## Properties

### <a id="DSLApp1_Dsl_AppliesModifierIR_Condition"></a> Condition

```csharp
public Condition? Condition { get; init; }
```

#### Property Value

 [Condition](DSLApp1.Dsl.Condition.md)?

### <a id="DSLApp1_Dsl_AppliesModifierIR_Mechanics"></a> Mechanics

```csharp
public List<ModifierMechanicIR> Mechanics { get; init; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[ModifierMechanicIR](DSLApp1.Dsl.ModifierMechanicIR.md)\>

