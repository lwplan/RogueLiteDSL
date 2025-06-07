# <a id="DSLApp1_Dsl_HealingSideEffectMechanic"></a> Class HealingSideEffectMechanic

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record HealingSideEffectMechanic : SideEffectMechanicIR, IEquatable<SideEffectMechanicIR>, IEquatable<HealingSideEffectMechanic>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SideEffectMechanicIR](DSLApp1.Dsl.SideEffectMechanicIR.md) ← 
[HealingSideEffectMechanic](DSLApp1.Dsl.HealingSideEffectMechanic.md)

#### Implements

[IEquatable<SideEffectMechanicIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<HealingSideEffectMechanic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_HealingSideEffectMechanic__ctor_DSLApp1_Dsl_HealMechanic_"></a> HealingSideEffectMechanic\(HealMechanic\)

```csharp
public HealingSideEffectMechanic(HealMechanic Heal)
```

#### Parameters

`Heal` [HealMechanic](DSLApp1.Dsl.HealMechanic.md)

## Properties

### <a id="DSLApp1_Dsl_HealingSideEffectMechanic_Heal"></a> Heal

```csharp
public HealMechanic Heal { get; init; }
```

#### Property Value

 [HealMechanic](DSLApp1.Dsl.HealMechanic.md)

