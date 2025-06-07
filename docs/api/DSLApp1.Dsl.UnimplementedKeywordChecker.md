# <a id="DSLApp1_Dsl_UnimplementedKeywordChecker"></a> Class UnimplementedKeywordChecker

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

Scans token streams for keywords representing mechanics that are not yet implemented.

```csharp
public static class UnimplementedKeywordChecker
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UnimplementedKeywordChecker](DSLApp1.Dsl.UnimplementedKeywordChecker.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="DSLApp1_Dsl_UnimplementedKeywordChecker_Find_System_Collections_Generic_IEnumerable_DSLApp1_Dsl_Token__"></a> Find\(IEnumerable<Token\>\)

Returns any unimplemented keywords found in the given token sequence.

```csharp
public static IReadOnlyList<string> Find(IEnumerable<Token> tokens)
```

#### Parameters

`tokens` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Token](DSLApp1.Dsl.Token.md)\>

#### Returns

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

