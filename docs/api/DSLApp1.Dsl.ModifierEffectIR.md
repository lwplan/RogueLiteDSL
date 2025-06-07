# <a id="DSLApp1_Dsl_ModifierEffectIR"></a> Class ModifierEffectIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record ModifierEffectIR : EffectIR, IEquatable<EffectIR>, IEquatable<ModifierEffectIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EffectIR](DSLApp1.Dsl.EffectIR.md) ← 
[ModifierEffectIR](DSLApp1.Dsl.ModifierEffectIR.md)

#### Implements

[IEquatable<EffectIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<ModifierEffectIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

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

### <a id="DSLApp1_Dsl_ModifierEffectIR__ctor_DSLApp1_Dsl_Subject_DSLApp1_Dsl_ModifierIR_"></a> ModifierEffectIR\(Subject, ModifierIR\)

```csharp
public ModifierEffectIR(Subject Subject, ModifierIR Modifier)
```

#### Parameters

`Subject` [Subject](DSLApp1.Dsl.Subject.md)

`Modifier` [ModifierIR](DSLApp1.Dsl.ModifierIR.md)

## Properties

### <a id="DSLApp1_Dsl_ModifierEffectIR_Modifier"></a> Modifier

```csharp
public ModifierIR Modifier { get; init; }
```

#### Property Value

 [ModifierIR](DSLApp1.Dsl.ModifierIR.md)

