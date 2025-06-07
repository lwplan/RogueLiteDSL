# <a id="DSLApp1_Dsl_DamageEffectIR"></a> Class DamageEffectIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record DamageEffectIR : EffectIR, IEquatable<EffectIR>, IEquatable<DamageEffectIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EffectIR](DSLApp1.Dsl.EffectIR.md) ← 
[DamageEffectIR](DSLApp1.Dsl.DamageEffectIR.md)

#### Implements

[IEquatable<EffectIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<DamageEffectIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

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

### <a id="DSLApp1_Dsl_DamageEffectIR__ctor_DSLApp1_Dsl_Subject_DSLApp1_Dsl_DamageType_System_Collections_Generic_List_DSLApp1_Dsl_DamageMechanic__DSLApp1_Dsl_Targeting_"></a> DamageEffectIR\(Subject, DamageType, List<DamageMechanic\>?, Targeting?\)

```csharp
public DamageEffectIR(Subject Subject, DamageType DamageType, List<DamageMechanic>? With = null, Targeting? Targeting = null)
```

#### Parameters

`Subject` [Subject](DSLApp1.Dsl.Subject.md)

`DamageType` [DamageType](DSLApp1.Dsl.DamageType.md)

`With` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[DamageMechanic](DSLApp1.Dsl.DamageMechanic.md)\>?

`Targeting` [Targeting](DSLApp1.Dsl.Targeting.md)?

## Properties

### <a id="DSLApp1_Dsl_DamageEffectIR_DamageType"></a> DamageType

```csharp
public DamageType DamageType { get; init; }
```

#### Property Value

 [DamageType](DSLApp1.Dsl.DamageType.md)

### <a id="DSLApp1_Dsl_DamageEffectIR_Targeting"></a> Targeting

```csharp
public Targeting? Targeting { get; init; }
```

#### Property Value

 [Targeting](DSLApp1.Dsl.Targeting.md)?

### <a id="DSLApp1_Dsl_DamageEffectIR_With"></a> With

```csharp
public List<DamageMechanic>? With { get; init; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[DamageMechanic](DSLApp1.Dsl.DamageMechanic.md)\>?

