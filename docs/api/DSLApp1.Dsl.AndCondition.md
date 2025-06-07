# <a id="DSLApp1_Dsl_AndCondition"></a> Class AndCondition

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record AndCondition : BaseCondition, IEquatable<BaseCondition>, IEquatable<AndCondition>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BaseCondition](DSLApp1.Dsl.BaseCondition.md) ← 
[AndCondition](DSLApp1.Dsl.AndCondition.md)

#### Implements

[IEquatable<BaseCondition\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<AndCondition\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_AndCondition__ctor_System_Collections_Generic_List_DSLApp1_Dsl_BaseCondition__"></a> AndCondition\(List<BaseCondition\>\)

```csharp
public AndCondition(List<BaseCondition> Conditions)
```

#### Parameters

`Conditions` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[BaseCondition](DSLApp1.Dsl.BaseCondition.md)\>

## Properties

### <a id="DSLApp1_Dsl_AndCondition_Conditions"></a> Conditions

```csharp
public List<BaseCondition> Conditions { get; init; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[BaseCondition](DSLApp1.Dsl.BaseCondition.md)\>

