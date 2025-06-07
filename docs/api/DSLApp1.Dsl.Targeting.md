# <a id="DSLApp1_Dsl_Targeting"></a> Class Targeting

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record Targeting : IEquatable<Targeting>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Targeting](DSLApp1.Dsl.Targeting.md)

#### Implements

[IEquatable<Targeting\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_Targeting__ctor_DSLApp1_Dsl_AutoTargetingStrategy_DSLApp1_Dsl_TargetType_DSLApp1_Dsl_TargetSide_"></a> Targeting\(AutoTargetingStrategy, TargetType, TargetSide\)

```csharp
public Targeting(AutoTargetingStrategy AutoTargetingStrategy, TargetType TargetType, TargetSide TargetSide)
```

#### Parameters

`AutoTargetingStrategy` [AutoTargetingStrategy](DSLApp1.Dsl.AutoTargetingStrategy.md)

`TargetType` [TargetType](DSLApp1.Dsl.TargetType.md)

`TargetSide` [TargetSide](DSLApp1.Dsl.TargetSide.md)

## Properties

### <a id="DSLApp1_Dsl_Targeting_AutoTargetingStrategy"></a> AutoTargetingStrategy

```csharp
public AutoTargetingStrategy AutoTargetingStrategy { get; init; }
```

#### Property Value

 [AutoTargetingStrategy](DSLApp1.Dsl.AutoTargetingStrategy.md)

### <a id="DSLApp1_Dsl_Targeting_TargetSide"></a> TargetSide

```csharp
public TargetSide TargetSide { get; init; }
```

#### Property Value

 [TargetSide](DSLApp1.Dsl.TargetSide.md)

### <a id="DSLApp1_Dsl_Targeting_TargetType"></a> TargetType

```csharp
public TargetType TargetType { get; init; }
```

#### Property Value

 [TargetType](DSLApp1.Dsl.TargetType.md)

