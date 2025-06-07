# <a id="DSLApp1_Dsl_Header"></a> Class Header

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record Header : IEquatable<Header>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Header](DSLApp1.Dsl.Header.md)

#### Implements

[IEquatable<Header\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_Header__ctor_DSLApp1_Dsl_HexType_System_Nullable_DSLApp1_Dsl_Compatibility__"></a> Header\(HexType, Compatibility?\)

```csharp
public Header(HexType Type, Compatibility? Compatibility)
```

#### Parameters

`Type` [HexType](DSLApp1.Dsl.HexType.md)

`Compatibility` [Compatibility](DSLApp1.Dsl.Compatibility.md)?

## Properties

### <a id="DSLApp1_Dsl_Header_Compatibility"></a> Compatibility

```csharp
public Compatibility? Compatibility { get; init; }
```

#### Property Value

 [Compatibility](DSLApp1.Dsl.Compatibility.md)?

### <a id="DSLApp1_Dsl_Header_Type"></a> Type

```csharp
public HexType Type { get; init; }
```

#### Property Value

 [HexType](DSLApp1.Dsl.HexType.md)

