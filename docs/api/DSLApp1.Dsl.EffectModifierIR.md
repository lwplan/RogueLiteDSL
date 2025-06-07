# <a id="DSLApp1_Dsl_EffectModifierIR"></a> Class EffectModifierIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record EffectModifierIR : ModifierIR, IEquatable<ModifierIR>, IEquatable<EffectModifierIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ModifierIR](DSLApp1.Dsl.ModifierIR.md) ← 
[EffectModifierIR](DSLApp1.Dsl.EffectModifierIR.md)

#### Implements

[IEquatable<ModifierIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<EffectModifierIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

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

### <a id="DSLApp1_Dsl_EffectModifierIR__ctor_DSLApp1_Dsl_Duration_DSLApp1_Dsl_EffectIR_DSLApp1_Dsl_Condition_"></a> EffectModifierIR\(Duration, EffectIR, Condition?\)

```csharp
public EffectModifierIR(Duration Duration, EffectIR Effect, Condition? Condition)
```

#### Parameters

`Duration` [Duration](DSLApp1.Dsl.Duration.md)

`Effect` [EffectIR](DSLApp1.Dsl.EffectIR.md)

`Condition` [Condition](DSLApp1.Dsl.Condition.md)?

## Properties

### <a id="DSLApp1_Dsl_EffectModifierIR_Condition"></a> Condition

```csharp
public Condition? Condition { get; init; }
```

#### Property Value

 [Condition](DSLApp1.Dsl.Condition.md)?

### <a id="DSLApp1_Dsl_EffectModifierIR_Effect"></a> Effect

```csharp
public EffectIR Effect { get; init; }
```

#### Property Value

 [EffectIR](DSLApp1.Dsl.EffectIR.md)

