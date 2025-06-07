# <a id="DSLApp1_Dsl_InvokeMechanic"></a> Class InvokeMechanic

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record InvokeMechanic : IEquatable<InvokeMechanic>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InvokeMechanic](DSLApp1.Dsl.InvokeMechanic.md)

#### Implements

[IEquatable<InvokeMechanic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_InvokeMechanic__ctor_DSLApp1_Dsl_InvokeMechanicType_System_Single_DSLApp1_Dsl_Condition_"></a> InvokeMechanic\(InvokeMechanicType, float, Condition?\)

```csharp
public InvokeMechanic(InvokeMechanicType MechanicType, float Value, Condition? Condition)
```

#### Parameters

`MechanicType` [InvokeMechanicType](DSLApp1.Dsl.InvokeMechanicType.md)

`Value` [float](https://learn.microsoft.com/dotnet/api/system.single)

`Condition` [Condition](DSLApp1.Dsl.Condition.md)?

## Properties

### <a id="DSLApp1_Dsl_InvokeMechanic_Condition"></a> Condition

```csharp
public Condition? Condition { get; init; }
```

#### Property Value

 [Condition](DSLApp1.Dsl.Condition.md)?

### <a id="DSLApp1_Dsl_InvokeMechanic_MechanicType"></a> MechanicType

```csharp
public InvokeMechanicType MechanicType { get; init; }
```

#### Property Value

 [InvokeMechanicType](DSLApp1.Dsl.InvokeMechanicType.md)

### <a id="DSLApp1_Dsl_InvokeMechanic_Value"></a> Value

```csharp
public float Value { get; init; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

