# <a id="DSLApp1_Dsl_SupportIR"></a> Class SupportIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record SupportIR : IEquatable<SupportIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SupportIR](DSLApp1.Dsl.SupportIR.md)

#### Implements

[IEquatable<SupportIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_SupportIR__ctor_DSLApp1_Dsl_Compatibility_System_Collections_Generic_List_DSLApp1_Dsl_SupportEffectIR__DSLApp1_Dsl_Condition_"></a> SupportIR\(Compatibility, List<SupportEffectIR\>, Condition?\)

```csharp
public SupportIR(Compatibility Compatibility, List<SupportEffectIR> SupportEffects, Condition? When = null)
```

#### Parameters

`Compatibility` [Compatibility](DSLApp1.Dsl.Compatibility.md)

`SupportEffects` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md)\>

`When` [Condition](DSLApp1.Dsl.Condition.md)?

## Properties

### <a id="DSLApp1_Dsl_SupportIR_Compatibility"></a> Compatibility

```csharp
public Compatibility Compatibility { get; init; }
```

#### Property Value

 [Compatibility](DSLApp1.Dsl.Compatibility.md)

### <a id="DSLApp1_Dsl_SupportIR_SupportEffects"></a> SupportEffects

```csharp
public List<SupportEffectIR> SupportEffects { get; init; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md)\>

### <a id="DSLApp1_Dsl_SupportIR_When"></a> When

```csharp
public Condition? When { get; init; }
```

#### Property Value

 [Condition](DSLApp1.Dsl.Condition.md)?

