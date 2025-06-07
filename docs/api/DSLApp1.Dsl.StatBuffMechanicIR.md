# <a id="DSLApp1_Dsl_StatBuffMechanicIR"></a> Class StatBuffMechanicIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record StatBuffMechanicIR : ModifierMechanicIR, IEquatable<ModifierMechanicIR>, IEquatable<StatBuffMechanicIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ModifierMechanicIR](DSLApp1.Dsl.ModifierMechanicIR.md) ← 
[StatBuffMechanicIR](DSLApp1.Dsl.StatBuffMechanicIR.md)

#### Implements

[IEquatable<ModifierMechanicIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<StatBuffMechanicIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_StatBuffMechanicIR__ctor_DSLApp1_Dsl_StatField_System_Single_System_Boolean_"></a> StatBuffMechanicIR\(StatField, float, bool\)

```csharp
public StatBuffMechanicIR(StatField Stat, float Amount, bool IsBuff)
```

#### Parameters

`Stat` [StatField](DSLApp1.Dsl.StatField.md)

`Amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

`IsBuff` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="DSLApp1_Dsl_StatBuffMechanicIR_Amount"></a> Amount

```csharp
public float Amount { get; init; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="DSLApp1_Dsl_StatBuffMechanicIR_IsBuff"></a> IsBuff

```csharp
public bool IsBuff { get; init; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Dsl_StatBuffMechanicIR_Stat"></a> Stat

```csharp
public StatField Stat { get; init; }
```

#### Property Value

 [StatField](DSLApp1.Dsl.StatField.md)

