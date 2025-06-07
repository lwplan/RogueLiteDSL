# <a id="DSLApp1_Dsl_DslGrammar"></a> Class DslGrammar

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public static class DslGrammar
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DslGrammar](DSLApp1.Dsl.DslGrammar.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="DSLApp1_Dsl_DslGrammar_BurnMacro"></a> BurnMacro

```csharp
public static Parser<char, string> BurnMacro { get; }
```

#### Property Value

 Parser<[char](https://learn.microsoft.com/dotnet/api/system.char), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="DSLApp1_Dsl_DslGrammar_Expression"></a> Expression

```csharp
public static Parser<char, string> Expression { get; }
```

#### Property Value

 Parser<[char](https://learn.microsoft.com/dotnet/api/system.char), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="DSLApp1_Dsl_DslGrammar_Identifier"></a> Identifier

```csharp
public static Parser<char, string> Identifier { get; }
```

#### Property Value

 Parser<[char](https://learn.microsoft.com/dotnet/api/system.char), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="DSLApp1_Dsl_DslGrammar_Number"></a> Number

```csharp
public static Parser<char, string> Number { get; }
```

#### Property Value

 Parser<[char](https://learn.microsoft.com/dotnet/api/system.char), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="DSLApp1_Dsl_DslGrammar_QuotedString"></a> QuotedString

```csharp
public static Parser<char, string> QuotedString { get; }
```

#### Property Value

 Parser<[char](https://learn.microsoft.com/dotnet/api/system.char), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Methods

### <a id="DSLApp1_Dsl_DslGrammar_ParseBurn_System_String_"></a> ParseBurn\(string\)

```csharp
public static string ParseBurn(string input)
```

#### Parameters

`input` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

