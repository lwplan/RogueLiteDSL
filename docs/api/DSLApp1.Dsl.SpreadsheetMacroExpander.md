# <a id="DSLApp1_Dsl_SpreadsheetMacroExpander"></a> Class SpreadsheetMacroExpander

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public class SpreadsheetMacroExpander
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SpreadsheetMacroExpander](DSLApp1.Dsl.SpreadsheetMacroExpander.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_SpreadsheetMacroExpander__ctor_System_Collections_Generic_Dictionary_System_String_System_String__"></a> SpreadsheetMacroExpander\(Dictionary<string, string\>\)

```csharp
public SpreadsheetMacroExpander(Dictionary<string, string> macroTemplates)
```

#### Parameters

`macroTemplates` [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Methods

### <a id="DSLApp1_Dsl_SpreadsheetMacroExpander_ExpandMacros_System_String_"></a> ExpandMacros\(string\)

```csharp
public string ExpandMacros(string input)
```

#### Parameters

`input` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Dsl_SpreadsheetMacroExpander_LoadFromMock"></a> LoadFromMock\(\)

```csharp
public static Dictionary<string, string> LoadFromMock()
```

#### Returns

 [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

