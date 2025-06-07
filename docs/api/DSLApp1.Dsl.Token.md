# <a id="DSLApp1_Dsl_Token"></a> Class Token

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record Token : IEquatable<Token>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Token](DSLApp1.Dsl.Token.md)

#### Implements

[IEquatable<Token\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_Token__ctor_DSLApp1_Dsl_TokenType_System_String_"></a> Token\(TokenType, string\)

```csharp
public Token(TokenType Type, string Text)
```

#### Parameters

`Type` [TokenType](DSLApp1.Dsl.TokenType.md)

`Text` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="DSLApp1_Dsl_Token_Text"></a> Text

```csharp
public string Text { get; init; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Dsl_Token_Type"></a> Type

```csharp
public TokenType Type { get; init; }
```

#### Property Value

 [TokenType](DSLApp1.Dsl.TokenType.md)

