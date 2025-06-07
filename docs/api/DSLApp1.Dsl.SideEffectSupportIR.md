# <a id="DSLApp1_Dsl_SideEffectSupportIR"></a> Class SideEffectSupportIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record SideEffectSupportIR : SupportEffectIR, IEquatable<SupportEffectIR>, IEquatable<SideEffectSupportIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md) ← 
[SideEffectSupportIR](DSLApp1.Dsl.SideEffectSupportIR.md)

#### Implements

[IEquatable<SupportEffectIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<SideEffectSupportIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_SideEffectSupportIR__ctor_DSLApp1_Dsl_SideEffectsIR_"></a> SideEffectSupportIR\(SideEffectsIR\)

```csharp
public SideEffectSupportIR(SideEffectsIR SideEffects)
```

#### Parameters

`SideEffects` [SideEffectsIR](DSLApp1.Dsl.SideEffectsIR.md)

## Properties

### <a id="DSLApp1_Dsl_SideEffectSupportIR_SideEffects"></a> SideEffects

```csharp
public SideEffectsIR SideEffects { get; init; }
```

#### Property Value

 [SideEffectsIR](DSLApp1.Dsl.SideEffectsIR.md)

