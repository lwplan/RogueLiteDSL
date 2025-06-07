# <a id="DSLApp1_Dsl_TargetingMechanic"></a> Class TargetingMechanic

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record TargetingMechanic : IEquatable<TargetingMechanic>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TargetingMechanic](DSLApp1.Dsl.TargetingMechanic.md)

#### Implements

[IEquatable<TargetingMechanic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_TargetingMechanic__ctor_DSLApp1_Dsl_TargetingMechanicsType_System_Int32_"></a> TargetingMechanic\(TargetingMechanicsType, int\)

```csharp
public TargetingMechanic(TargetingMechanicsType MechanicType, int Amount)
```

#### Parameters

`MechanicType` [TargetingMechanicsType](DSLApp1.Dsl.TargetingMechanicsType.md)

`Amount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="DSLApp1_Dsl_TargetingMechanic_Amount"></a> Amount

```csharp
public int Amount { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Dsl_TargetingMechanic_MechanicType"></a> MechanicType

```csharp
public TargetingMechanicsType MechanicType { get; init; }
```

#### Property Value

 [TargetingMechanicsType](DSLApp1.Dsl.TargetingMechanicsType.md)

