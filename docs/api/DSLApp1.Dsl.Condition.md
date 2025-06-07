# <a id="DSLApp1_Dsl_Condition"></a> Class Condition

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record Condition : BaseCondition, IEquatable<BaseCondition>, IEquatable<Condition>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BaseCondition](DSLApp1.Dsl.BaseCondition.md) ← 
[Condition](DSLApp1.Dsl.Condition.md)

#### Implements

[IEquatable<BaseCondition\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<Condition\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_Condition__ctor_DSLApp1_Dsl_Subject_DSLApp1_Dsl_Field_DSLApp1_Dsl_Op_System_Single_"></a> Condition\(Subject, Field, Op, float\)

```csharp
public Condition(Subject Subject, Field Field, Op Op, float Value)
```

#### Parameters

`Subject` [Subject](DSLApp1.Dsl.Subject.md)

`Field` [Field](DSLApp1.Dsl.Field.md)

`Op` [Op](DSLApp1.Dsl.Op.md)

`Value` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="DSLApp1_Dsl_Condition_Field"></a> Field

```csharp
public Field Field { get; init; }
```

#### Property Value

 [Field](DSLApp1.Dsl.Field.md)

### <a id="DSLApp1_Dsl_Condition_Op"></a> Op

```csharp
public Op Op { get; init; }
```

#### Property Value

 [Op](DSLApp1.Dsl.Op.md)

### <a id="DSLApp1_Dsl_Condition_Subject"></a> Subject

```csharp
public Subject Subject { get; init; }
```

#### Property Value

 [Subject](DSLApp1.Dsl.Subject.md)

### <a id="DSLApp1_Dsl_Condition_Value"></a> Value

```csharp
public float Value { get; init; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

