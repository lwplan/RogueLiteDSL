# <a id="DSLApp1_Dsl_StateMechanicIR"></a> Class StateMechanicIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record StateMechanicIR : ModifierMechanicIR, IEquatable<ModifierMechanicIR>, IEquatable<StateMechanicIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ModifierMechanicIR](DSLApp1.Dsl.ModifierMechanicIR.md) ← 
[StateMechanicIR](DSLApp1.Dsl.StateMechanicIR.md)

#### Implements

[IEquatable<ModifierMechanicIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<StateMechanicIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_StateMechanicIR__ctor_DSLApp1_Dsl_StateMechanicType_System_Nullable_System_Single__DSLApp1_Dsl_Condition_"></a> StateMechanicIR\(StateMechanicType, float?, Condition?\)

```csharp
public StateMechanicIR(StateMechanicType Type, float? Amount, Condition? When)
```

#### Parameters

`Type` [StateMechanicType](DSLApp1.Dsl.StateMechanicType.md)

`Amount` [float](https://learn.microsoft.com/dotnet/api/system.single)?

`When` [Condition](DSLApp1.Dsl.Condition.md)?

## Properties

### <a id="DSLApp1_Dsl_StateMechanicIR_Amount"></a> Amount

```csharp
public float? Amount { get; init; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)?

### <a id="DSLApp1_Dsl_StateMechanicIR_Type"></a> Type

```csharp
public StateMechanicType Type { get; init; }
```

#### Property Value

 [StateMechanicType](DSLApp1.Dsl.StateMechanicType.md)

### <a id="DSLApp1_Dsl_StateMechanicIR_When"></a> When

```csharp
public Condition? When { get; init; }
```

#### Property Value

 [Condition](DSLApp1.Dsl.Condition.md)?

