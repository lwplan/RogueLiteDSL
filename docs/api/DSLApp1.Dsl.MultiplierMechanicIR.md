# <a id="DSLApp1_Dsl_MultiplierMechanicIR"></a> Class MultiplierMechanicIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record MultiplierMechanicIR : ModifierMechanicIR, IEquatable<ModifierMechanicIR>, IEquatable<MultiplierMechanicIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ModifierMechanicIR](DSLApp1.Dsl.ModifierMechanicIR.md) ← 
[MultiplierMechanicIR](DSLApp1.Dsl.MultiplierMechanicIR.md)

#### Implements

[IEquatable<ModifierMechanicIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<MultiplierMechanicIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_MultiplierMechanicIR__ctor_DSLApp1_Dsl_MultiplierMechanicType_System_Nullable_System_Single__DSLApp1_Dsl_TargetTag_DSLApp1_Dsl_Condition_"></a> MultiplierMechanicIR\(MultiplierMechanicType, float?, TargetTag, Condition?\)

```csharp
public MultiplierMechanicIR(MultiplierMechanicType Type, float? Amount, TargetTag Against, Condition? When)
```

#### Parameters

`Type` [MultiplierMechanicType](DSLApp1.Dsl.MultiplierMechanicType.md)

`Amount` [float](https://learn.microsoft.com/dotnet/api/system.single)?

`Against` [TargetTag](DSLApp1.Dsl.TargetTag.md)

`When` [Condition](DSLApp1.Dsl.Condition.md)?

## Properties

### <a id="DSLApp1_Dsl_MultiplierMechanicIR_Against"></a> Against

```csharp
public TargetTag Against { get; init; }
```

#### Property Value

 [TargetTag](DSLApp1.Dsl.TargetTag.md)

### <a id="DSLApp1_Dsl_MultiplierMechanicIR_Amount"></a> Amount

```csharp
public float? Amount { get; init; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)?

### <a id="DSLApp1_Dsl_MultiplierMechanicIR_Type"></a> Type

```csharp
public MultiplierMechanicType Type { get; init; }
```

#### Property Value

 [MultiplierMechanicType](DSLApp1.Dsl.MultiplierMechanicType.md)

### <a id="DSLApp1_Dsl_MultiplierMechanicIR_When"></a> When

```csharp
public Condition? When { get; init; }
```

#### Property Value

 [Condition](DSLApp1.Dsl.Condition.md)?

