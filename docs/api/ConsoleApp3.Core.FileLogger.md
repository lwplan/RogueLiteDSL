# <a id="ConsoleApp3_Core_FileLogger"></a> Class FileLogger

Namespace: [ConsoleApp3.Core](ConsoleApp3.Core.md)  
Assembly: DSLApp1.dll  

```csharp
public class FileLogger : ILogger
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FileLogger](ConsoleApp3.Core.FileLogger.md)

#### Implements

[ILogger](ConsoleApp3.Core.ILogger.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ConsoleApp3_Core_FileLogger__ctor_System_String_"></a> FileLogger\(string\)

```csharp
public FileLogger(string path = "app.log")
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="ConsoleApp3_Core_FileLogger_Error_System_String_"></a> Error\(string\)

```csharp
public void Error(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="ConsoleApp3_Core_FileLogger_Log_System_String_"></a> Log\(string\)

```csharp
public void Log(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="ConsoleApp3_Core_FileLogger_LogException_System_Exception_"></a> LogException\(Exception\)

```csharp
public void LogException(Exception ex)
```

#### Parameters

`ex` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

### <a id="ConsoleApp3_Core_FileLogger_Warn_System_String_"></a> Warn\(string\)

```csharp
public void Warn(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

