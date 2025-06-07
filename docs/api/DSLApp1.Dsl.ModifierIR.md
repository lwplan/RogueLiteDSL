# <a id="DSLApp1_Dsl_ModifierIR"></a> Class ModifierIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public abstract record ModifierIR : IEquatable<ModifierIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ModifierIR](DSLApp1.Dsl.ModifierIR.md)

#### Derived

[AppliesModifierIR](DSLApp1.Dsl.AppliesModifierIR.md), 
[EffectModifierIR](DSLApp1.Dsl.EffectModifierIR.md)

#### Implements

[IEquatable<ModifierIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_ModifierIR__ctor_DSLApp1_Dsl_Duration_"></a> ModifierIR\(Duration\)

```csharp
protected ModifierIR(Duration Duration)
```

#### Parameters

`Duration` [Duration](DSLApp1.Dsl.Duration.md)

## Properties

### <a id="DSLApp1_Dsl_ModifierIR_Duration"></a> Duration

```csharp
public Duration Duration { get; init; }
```

#### Property Value

 [Duration](DSLApp1.Dsl.Duration.md)

