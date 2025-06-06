# <a id="DSLApp1_Dsl_HealMechanic"></a> Class HealMechanic

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record HealMechanic : IEquatable<HealMechanic>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[HealMechanic](DSLApp1.Dsl.HealMechanic.md)

#### Implements

[IEquatable<HealMechanic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_HealMechanic__ctor_DSLApp1_Dsl_HealMechanicType_System_Single_DSLApp1_Dsl_EconomyStat_DSLApp1_Dsl_Condition_"></a> HealMechanic\(HealMechanicType, float, EconomyStat, Condition\)

```csharp
public HealMechanic(HealMechanicType Type, float Amount, EconomyStat Stat, Condition Condition)
```

#### Parameters

`Type` [HealMechanicType](DSLApp1.Dsl.HealMechanicType.md)

`Amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

`Stat` [EconomyStat](DSLApp1.Dsl.EconomyStat.md)

`Condition` [Condition](DSLApp1.Dsl.Condition.md)

## Properties

### <a id="DSLApp1_Dsl_HealMechanic_Amount"></a> Amount

```csharp
public float Amount { get; init; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="DSLApp1_Dsl_HealMechanic_Condition"></a> Condition

```csharp
public Condition Condition { get; init; }
```

#### Property Value

 [Condition](DSLApp1.Dsl.Condition.md)

### <a id="DSLApp1_Dsl_HealMechanic_Stat"></a> Stat

```csharp
public EconomyStat Stat { get; init; }
```

#### Property Value

 [EconomyStat](DSLApp1.Dsl.EconomyStat.md)

### <a id="DSLApp1_Dsl_HealMechanic_Type"></a> Type

```csharp
public HealMechanicType Type { get; init; }
```

#### Property Value

 [HealMechanicType](DSLApp1.Dsl.HealMechanicType.md)

