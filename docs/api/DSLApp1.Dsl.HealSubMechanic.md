# <a id="DSLApp1_Dsl_HealSubMechanic"></a> Class HealSubMechanic

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record HealSubMechanic : IEquatable<HealSubMechanic>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[HealSubMechanic](DSLApp1.Dsl.HealSubMechanic.md)

#### Implements

[IEquatable<HealSubMechanic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_HealSubMechanic__ctor_DSLApp1_Dsl_HealSubMechanicType_System_Single_"></a> HealSubMechanic\(HealSubMechanicType, float\)

```csharp
public HealSubMechanic(HealSubMechanicType Type, float Amount)
```

#### Parameters

`Type` [HealSubMechanicType](DSLApp1.Dsl.HealSubMechanicType.md)

`Amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="DSLApp1_Dsl_HealSubMechanic_Amount"></a> Amount

```csharp
public float Amount { get; init; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="DSLApp1_Dsl_HealSubMechanic_Type"></a> Type

```csharp
public HealSubMechanicType Type { get; init; }
```

#### Property Value

 [HealSubMechanicType](DSLApp1.Dsl.HealSubMechanicType.md)

