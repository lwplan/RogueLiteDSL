# <a id="DSLApp1_Dsl_DamageSupportIR"></a> Class DamageSupportIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record DamageSupportIR : SupportEffectIR, IEquatable<SupportEffectIR>, IEquatable<DamageSupportIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md) ← 
[DamageSupportIR](DSLApp1.Dsl.DamageSupportIR.md)

#### Implements

[IEquatable<SupportEffectIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<DamageSupportIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_DamageSupportIR__ctor_DSLApp1_Dsl_DamageMechanicType_System_Single_"></a> DamageSupportIR\(DamageMechanicType, float\)

```csharp
public DamageSupportIR(DamageMechanicType Mechanic, float Value)
```

#### Parameters

`Mechanic` [DamageMechanicType](DSLApp1.Dsl.DamageMechanicType.md)

`Value` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="DSLApp1_Dsl_DamageSupportIR_Mechanic"></a> Mechanic

```csharp
public DamageMechanicType Mechanic { get; init; }
```

#### Property Value

 [DamageMechanicType](DSLApp1.Dsl.DamageMechanicType.md)

### <a id="DSLApp1_Dsl_DamageSupportIR_Value"></a> Value

```csharp
public float Value { get; init; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

