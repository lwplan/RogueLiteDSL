# <a id="DSLApp1_Dsl_ElementTag"></a> Class ElementTag

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record ElementTag : TargetTag, IEquatable<TargetTag>, IEquatable<ElementTag>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TargetTag](DSLApp1.Dsl.TargetTag.md) ← 
[ElementTag](DSLApp1.Dsl.ElementTag.md)

#### Implements

[IEquatable<TargetTag\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<ElementTag\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_ElementTag__ctor_DSLApp1_Dsl_Element_"></a> ElementTag\(Element\)

```csharp
public ElementTag(Element Element)
```

#### Parameters

`Element` [Element](DSLApp1.Dsl.Element.md)

## Properties

### <a id="DSLApp1_Dsl_ElementTag_Element"></a> Element

```csharp
public Element Element { get; init; }
```

#### Property Value

 [Element](DSLApp1.Dsl.Element.md)

