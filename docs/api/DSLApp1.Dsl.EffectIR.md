# <a id="DSLApp1_Dsl_EffectIR"></a> Class EffectIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public abstract record EffectIR : IEquatable<EffectIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EffectIR](DSLApp1.Dsl.EffectIR.md)

#### Derived

[DamageEffectIR](DSLApp1.Dsl.DamageEffectIR.md), 
[HealEffectIR](DSLApp1.Dsl.HealEffectIR.md), 
[InvokeEffectIR](DSLApp1.Dsl.InvokeEffectIR.md), 
[ModifierEffectIR](DSLApp1.Dsl.ModifierEffectIR.md)

#### Implements

[IEquatable<EffectIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_EffectIR__ctor_DSLApp1_Dsl_Subject_DSLApp1_Dsl_EffectType_"></a> EffectIR\(Subject, EffectType\)

```csharp
protected EffectIR(Subject Subject, EffectType EffectType)
```

#### Parameters

`Subject` [Subject](DSLApp1.Dsl.Subject.md)

`EffectType` [EffectType](DSLApp1.Dsl.EffectType.md)

## Properties

### <a id="DSLApp1_Dsl_EffectIR_EffectType"></a> EffectType

```csharp
public EffectType EffectType { get; init; }
```

#### Property Value

 [EffectType](DSLApp1.Dsl.EffectType.md)

### <a id="DSLApp1_Dsl_EffectIR_Subject"></a> Subject

```csharp
public Subject Subject { get; init; }
```

#### Property Value

 [Subject](DSLApp1.Dsl.Subject.md)

