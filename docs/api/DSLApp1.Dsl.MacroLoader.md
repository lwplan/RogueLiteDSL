# <a id="DSLApp1_Dsl_MacroLoader"></a> Class MacroLoader

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public static class MacroLoader
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MacroLoader](DSLApp1.Dsl.MacroLoader.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="DSLApp1_Dsl_MacroLoader_LoadFromGoogleSheet_Components_Root_GoogleCsvLoader_System_String_"></a> LoadFromGoogleSheet\(GoogleCsvLoader, string\)

```csharp
public static Task<List<MacroDefinition>> LoadFromGoogleSheet(GoogleCsvLoader loader, string sheetName)
```

#### Parameters

`loader` [GoogleCsvLoader](Components.Root.GoogleCsvLoader.md)

`sheetName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[MacroDefinition](DSLApp1.Dsl.MacroDefinition.md)\>\>

