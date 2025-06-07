# <a id="DSLApp1_Dsl_SideEffectsIR"></a> Class SideEffectsIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record SideEffectsIR : IEquatable<SideEffectsIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SideEffectsIR](DSLApp1.Dsl.SideEffectsIR.md)

#### Implements

[IEquatable<SideEffectsIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_SideEffectsIR__ctor_System_Collections_Generic_List_DSLApp1_Dsl_SideEffectMechanicIR__DSLApp1_Dsl_Condition_"></a> SideEffectsIR\(List<SideEffectMechanicIR\>, Condition?\)

```csharp
public SideEffectsIR(List<SideEffectMechanicIR> Mechanics, Condition? When)
```

#### Parameters

`Mechanics` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[SideEffectMechanicIR](DSLApp1.Dsl.SideEffectMechanicIR.md)\>

`When` [Condition](DSLApp1.Dsl.Condition.md)?

## Properties

### <a id="DSLApp1_Dsl_SideEffectsIR_Mechanics"></a> Mechanics

```csharp
public List<SideEffectMechanicIR> Mechanics { get; init; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[SideEffectMechanicIR](DSLApp1.Dsl.SideEffectMechanicIR.md)\>

### <a id="DSLApp1_Dsl_SideEffectsIR_When"></a> When

```csharp
public Condition? When { get; init; }
```

#### Property Value

 [Condition](DSLApp1.Dsl.Condition.md)?

