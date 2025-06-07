# <a id="DSLApp1_Model_BoardState"></a> Class BoardState

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
[Serializable]
public class BoardState
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BoardState](DSLApp1.Model.BoardState.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Model_BoardState__ctor_System_Int32_"></a> BoardState\(int\)

```csharp
public BoardState(int range)
```

#### Parameters

`range` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="DSLApp1_Model_BoardState_BoardCoordinates"></a> BoardCoordinates

```csharp
public List<HexCoord> BoardCoordinates { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[HexCoord](DSLApp1.Model.HexCoord.md)\>

### <a id="DSLApp1_Model_BoardState_HexPieces"></a> HexPieces

```csharp
public List<HexPiece> HexPieces { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[HexPiece](DSLApp1.Model.HexPiece.md)\>

## Methods

### <a id="DSLApp1_Model_BoardState_AddHexPiece_DSLApp1_Model_HexPiece_"></a> AddHexPiece\(HexPiece\)

```csharp
public void AddHexPiece(HexPiece getHexPiece)
```

#### Parameters

`getHexPiece` [HexPiece](DSLApp1.Model.HexPiece.md)

### <a id="DSLApp1_Model_BoardState_GenerateBoardCoordinates_System_Int32_"></a> GenerateBoardCoordinates\(int\)

```csharp
public static List<HexCoord> GenerateBoardCoordinates(int range)
```

#### Parameters

`range` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[HexCoord](DSLApp1.Model.HexCoord.md)\>

### <a id="DSLApp1_Model_BoardState_RemoveHexPiece_DSLApp1_Model_HexPiece_"></a> RemoveHexPiece\(HexPiece\)

```csharp
public void RemoveHexPiece(HexPiece getHexPiece)
```

#### Parameters

`getHexPiece` [HexPiece](DSLApp1.Model.HexPiece.md)

