# <a id="DSLApp1_Dsl_DamageType"></a> Class DamageType

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record DamageType : IEquatable<DamageType>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DamageType](DSLApp1.Dsl.DamageType.md)

#### Implements

[IEquatable<DamageType\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_DamageType__ctor_DSLApp1_Dsl_DamageFormula_DSLApp1_Dsl_Element_System_Int32_"></a> DamageType\(DamageFormula, Element, int\)

```csharp
public DamageType(DamageFormula DamageFormula, Element Element, int BaseDamage)
```

#### Parameters

`DamageFormula` [DamageFormula](DSLApp1.Dsl.DamageFormula.md)

`Element` [Element](DSLApp1.Dsl.Element.md)

`BaseDamage` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="DSLApp1_Dsl_DamageType_BaseDamage"></a> BaseDamage

```csharp
public int BaseDamage { get; init; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Dsl_DamageType_DamageFormula"></a> DamageFormula

```csharp
public DamageFormula DamageFormula { get; init; }
```

#### Property Value

 [DamageFormula](DSLApp1.Dsl.DamageFormula.md)

### <a id="DSLApp1_Dsl_DamageType_Element"></a> Element

```csharp
public Element Element { get; init; }
```

#### Property Value

 [Element](DSLApp1.Dsl.Element.md)

