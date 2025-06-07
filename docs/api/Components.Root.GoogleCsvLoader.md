# <a id="Components_Root_GoogleCsvLoader"></a> Class GoogleCsvLoader

Namespace: [Components.Root](Components.Root.md)  
Assembly: DSLApp1.dll  

```csharp
public class GoogleCsvLoader
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GoogleCsvLoader](Components.Root.GoogleCsvLoader.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Components_Root_GoogleCsvLoader__ctor_System_String_"></a> GoogleCsvLoader\(string\)

```csharp
public GoogleCsvLoader(string sheetId)
```

#### Parameters

`sheetId` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Components_Root_GoogleCsvLoader_LoadCsvLines_System_String_System_Boolean_"></a> LoadCsvLines\(string, bool\)

```csharp
public Task<List<string[]>> LoadCsvLines(string sheetName, bool useCache = false)
```

#### Parameters

`sheetName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`useCache` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\[\]\>\>

### <a id="Components_Root_GoogleCsvLoader_LoadCsvRecords_System_String_"></a> LoadCsvRecords\(string\)

```csharp
public Task<List<Dictionary<string, string>>> LoadCsvRecords(string sheetName)
```

#### Parameters

`sheetName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>\>\>

### <a id="Components_Root_GoogleCsvLoader_ParseCsvLine_System_String_"></a> ParseCsvLine\(string\)

```csharp
public static string[] ParseCsvLine(string line)
```

#### Parameters

`line` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

