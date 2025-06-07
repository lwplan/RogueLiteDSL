# <a id="DSLApp1_Dsl_HealEffectIR"></a> Class HealEffectIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record HealEffectIR : EffectIR, IEquatable<EffectIR>, IEquatable<HealEffectIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EffectIR](DSLApp1.Dsl.EffectIR.md) ← 
[HealEffectIR](DSLApp1.Dsl.HealEffectIR.md)

#### Implements

[IEquatable<EffectIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<HealEffectIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[EffectIR.Subject](DSLApp1.Dsl.EffectIR.md\#DSLApp1\_Dsl\_EffectIR\_Subject), 
[EffectIR.EffectType](DSLApp1.Dsl.EffectIR.md\#DSLApp1\_Dsl\_EffectIR\_EffectType), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_HealEffectIR__ctor_DSLApp1_Dsl_Subject_DSLApp1_Dsl_HealMechanic_DSLApp1_Dsl_Targeting_"></a> HealEffectIR\(Subject, HealMechanic, Targeting?\)

```csharp
public HealEffectIR(Subject Subject, HealMechanic Mechanic, Targeting? Targeting = null)
```

#### Parameters

`Subject` [Subject](DSLApp1.Dsl.Subject.md)

`Mechanic` [HealMechanic](DSLApp1.Dsl.HealMechanic.md)

`Targeting` [Targeting](DSLApp1.Dsl.Targeting.md)?

## Properties

### <a id="DSLApp1_Dsl_HealEffectIR_Mechanic"></a> Mechanic

```csharp
public HealMechanic Mechanic { get; init; }
```

#### Property Value

 [HealMechanic](DSLApp1.Dsl.HealMechanic.md)

### <a id="DSLApp1_Dsl_HealEffectIR_Targeting"></a> Targeting

```csharp
public Targeting? Targeting { get; init; }
```

#### Property Value

 [Targeting](DSLApp1.Dsl.Targeting.md)?

