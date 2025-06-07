# <a id="DSLApp1_Dsl_DamageMechanic"></a> Class DamageMechanic

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record DamageMechanic : IEquatable<DamageMechanic>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DamageMechanic](DSLApp1.Dsl.DamageMechanic.md)

#### Implements

[IEquatable<DamageMechanic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_DamageMechanic__ctor_DSLApp1_Dsl_DamageMechanicType_System_Single_DSLApp1_Dsl_Condition_"></a> DamageMechanic\(DamageMechanicType, float, Condition\)

```csharp
public DamageMechanic(DamageMechanicType MechanicType, float Value, Condition Condition)
```

#### Parameters

`MechanicType` [DamageMechanicType](DSLApp1.Dsl.DamageMechanicType.md)

`Value` [float](https://learn.microsoft.com/dotnet/api/system.single)

`Condition` [Condition](DSLApp1.Dsl.Condition.md)

## Properties

### <a id="DSLApp1_Dsl_DamageMechanic_Condition"></a> Condition

```csharp
public Condition Condition { get; init; }
```

#### Property Value

 [Condition](DSLApp1.Dsl.Condition.md)

### <a id="DSLApp1_Dsl_DamageMechanic_MechanicType"></a> MechanicType

```csharp
public DamageMechanicType MechanicType { get; init; }
```

#### Property Value

 [DamageMechanicType](DSLApp1.Dsl.DamageMechanicType.md)

### <a id="DSLApp1_Dsl_DamageMechanic_Value"></a> Value

```csharp
public float Value { get; init; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

