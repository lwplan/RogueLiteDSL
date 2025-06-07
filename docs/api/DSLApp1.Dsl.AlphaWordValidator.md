# <a id="DSLApp1_Dsl_AlphaWordValidator"></a> Class AlphaWordValidator

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

Utility for validating raw DSL text before macro expansion.
Ensures all alphabetic sequences are either known keywords or macros.

```csharp
public static class AlphaWordValidator
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AlphaWordValidator](DSLApp1.Dsl.AlphaWordValidator.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="DSLApp1_Dsl_AlphaWordValidator_FindUnknownWords_System_String_System_Collections_Generic_IEnumerable_DSLApp1_Dsl_MacroDefinition__"></a> FindUnknownWords\(string, IEnumerable<MacroDefinition\>\)

Finds any words not known to the DSL keyword list or macro list.
Returns the unknown words in their original casing.

```csharp
public static IReadOnlyList<string> FindUnknownWords(string input, IEnumerable<MacroDefinition> macros)
```

#### Parameters

`input` [string](https://learn.microsoft.com/dotnet/api/system.string)

`macros` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[MacroDefinition](DSLApp1.Dsl.MacroDefinition.md)\>

#### Returns

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

