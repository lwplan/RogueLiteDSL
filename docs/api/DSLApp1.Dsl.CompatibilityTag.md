# <a id="DSLApp1_Dsl_CompatibilityTag"></a> Class CompatibilityTag

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record CompatibilityTag : TargetTag, IEquatable<TargetTag>, IEquatable<CompatibilityTag>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TargetTag](DSLApp1.Dsl.TargetTag.md) ← 
[CompatibilityTag](DSLApp1.Dsl.CompatibilityTag.md)

#### Implements

[IEquatable<TargetTag\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<CompatibilityTag\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_CompatibilityTag__ctor_DSLApp1_Dsl_Compatibility_"></a> CompatibilityTag\(Compatibility\)

```csharp
public CompatibilityTag(Compatibility Compatibility)
```

#### Parameters

`Compatibility` [Compatibility](DSLApp1.Dsl.Compatibility.md)

## Properties

### <a id="DSLApp1_Dsl_CompatibilityTag_Compatibility"></a> Compatibility

```csharp
public Compatibility Compatibility { get; init; }
```

#### Property Value

 [Compatibility](DSLApp1.Dsl.Compatibility.md)

