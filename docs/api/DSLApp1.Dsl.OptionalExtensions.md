# <a id="DSLApp1_Dsl_OptionalExtensions"></a> Class OptionalExtensions

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public static class OptionalExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[OptionalExtensions](DSLApp1.Dsl.OptionalExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="DSLApp1_Dsl_OptionalExtensions_ToNullable__1_Pidgin_Maybe___0__"></a> ToNullable<T\>\(Maybe<T\>\)

```csharp
public static T? ToNullable<T>(this Maybe<T> optional) where T : struct
```

#### Parameters

`optional` Maybe<T\>

#### Returns

 T?

#### Type Parameters

`T` 

