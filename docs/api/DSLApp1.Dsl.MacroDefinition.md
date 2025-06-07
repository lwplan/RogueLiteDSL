# <a id="DSLApp1_Dsl_MacroDefinition"></a> Class MacroDefinition

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record MacroDefinition : IEquatable<MacroDefinition>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MacroDefinition](DSLApp1.Dsl.MacroDefinition.md)

#### Implements

[IEquatable<MacroDefinition\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_MacroDefinition__ctor_System_String_System_String_System_Collections_Generic_Dictionary_System_String_System_Collections_Generic_List_System_Int32___System_String_System_String_"></a> MacroDefinition\(string, string, Dictionary<string, List<int\>\>, string, string\)

```csharp
public MacroDefinition(string Name, string Template, Dictionary<string, List<int>> IndexArgs, string Category, string Tooltip)
```

#### Parameters

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Template` [string](https://learn.microsoft.com/dotnet/api/system.string)

`IndexArgs` [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>\>

`Category` [string](https://learn.microsoft.com/dotnet/api/system.string)

`Tooltip` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="DSLApp1_Dsl_MacroDefinition_Category"></a> Category

```csharp
public string Category { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Dsl_MacroDefinition_IndexArgs"></a> IndexArgs

```csharp
public Dictionary<string, List<int>> IndexArgs { get; init; }
```

#### Property Value

 [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>\>

### <a id="DSLApp1_Dsl_MacroDefinition_Name"></a> Name

```csharp
public string Name { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Dsl_MacroDefinition_Template"></a> Template

```csharp
public string Template { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Dsl_MacroDefinition_Tooltip"></a> Tooltip

```csharp
public string Tooltip { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

