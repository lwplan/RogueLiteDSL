# <a id="DSLApp1_Dsl_SideEffectMechanic"></a> Class SideEffectMechanic

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record SideEffectMechanic : SideEffectMechanicIR, IEquatable<SideEffectMechanicIR>, IEquatable<SideEffectMechanic>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SideEffectMechanicIR](DSLApp1.Dsl.SideEffectMechanicIR.md) ← 
[SideEffectMechanic](DSLApp1.Dsl.SideEffectMechanic.md)

#### Implements

[IEquatable<SideEffectMechanicIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<SideEffectMechanic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_SideEffectMechanic__ctor_DSLApp1_Dsl_SideEffectMechanicType_System_Single_"></a> SideEffectMechanic\(SideEffectMechanicType, float\)

```csharp
public SideEffectMechanic(SideEffectMechanicType Type, float Amount)
```

#### Parameters

`Type` [SideEffectMechanicType](DSLApp1.Dsl.SideEffectMechanicType.md)

`Amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="DSLApp1_Dsl_SideEffectMechanic_Amount"></a> Amount

```csharp
public float Amount { get; init; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="DSLApp1_Dsl_SideEffectMechanic_Type"></a> Type

```csharp
public SideEffectMechanicType Type { get; init; }
```

#### Property Value

 [SideEffectMechanicType](DSLApp1.Dsl.SideEffectMechanicType.md)

