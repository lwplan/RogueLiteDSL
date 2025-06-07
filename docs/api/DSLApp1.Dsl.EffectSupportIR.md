# <a id="DSLApp1_Dsl_EffectSupportIR"></a> Class EffectSupportIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record EffectSupportIR : SupportEffectIR, IEquatable<SupportEffectIR>, IEquatable<EffectSupportIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md) ← 
[EffectSupportIR](DSLApp1.Dsl.EffectSupportIR.md)

#### Implements

[IEquatable<SupportEffectIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<EffectSupportIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_EffectSupportIR__ctor_DSLApp1_Dsl_EffectIR_"></a> EffectSupportIR\(EffectIR\)

```csharp
public EffectSupportIR(EffectIR Effect)
```

#### Parameters

`Effect` [EffectIR](DSLApp1.Dsl.EffectIR.md)

## Properties

### <a id="DSLApp1_Dsl_EffectSupportIR_Effect"></a> Effect

```csharp
public EffectIR Effect { get; init; }
```

#### Property Value

 [EffectIR](DSLApp1.Dsl.EffectIR.md)

