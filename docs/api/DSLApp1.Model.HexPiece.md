# <a id="DSLApp1_Model_HexPiece"></a> Class HexPiece

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public class HexPiece
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[HexPiece](DSLApp1.Model.HexPiece.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Model_HexPiece__ctor_DSLApp1_Model_Fragment_"></a> HexPiece\(Fragment\)

```csharp
public HexPiece(Fragment fragment)
```

#### Parameters

`fragment` [Fragment](DSLApp1.Model.Fragment.md)

## Properties

### <a id="DSLApp1_Model_HexPiece_Ability"></a> Ability

```csharp
public IAbility Ability { get; }
```

#### Property Value

 [IAbility](DSLApp1.Model.IAbility.md)

### <a id="DSLApp1_Model_HexPiece_BoardIndex"></a> BoardIndex

```csharp
public int BoardIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_HexPiece_Description"></a> Description

```csharp
public string Description { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_HexPiece_Equips"></a> Equips

```csharp
public List<IModifier> Equips { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IModifier](DSLApp1.Model.IModifier.md)\>

### <a id="DSLApp1_Model_HexPiece_Exclusivities"></a> Exclusivities

```csharp
public List<Exclusivity> Exclusivities { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Exclusivity](DSLApp1.Model.Exclusivity.md)\>

### <a id="DSLApp1_Model_HexPiece_HasAbility"></a> HasAbility

```csharp
public bool HasAbility { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_HexPiece_HexCoords"></a> HexCoords

```csharp
public List<HexCoord> HexCoords { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[HexCoord](DSLApp1.Model.HexCoord.md)\>

### <a id="DSLApp1_Model_HexPiece_HexSignature"></a> HexSignature

```csharp
public string HexSignature { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_HexPiece_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_HexPiece_Offset"></a> Offset

```csharp
public HexCoord Offset { get; set; }
```

#### Property Value

 [HexCoord](DSLApp1.Model.HexCoord.md)

### <a id="DSLApp1_Model_HexPiece_Rarity"></a> Rarity

```csharp
public Rarity Rarity { get; }
```

#### Property Value

 [Rarity](DSLApp1.Model.Rarity.md)

### <a id="DSLApp1_Model_HexPiece_Rotation"></a> Rotation

```csharp
public int Rotation { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_HexPiece_Unlocked"></a> Unlocked

```csharp
public bool Unlocked { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="DSLApp1_Model_HexPiece_ExclusivityText"></a> ExclusivityText\(\)

```csharp
public string ExclusivityText()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_HexPiece_FitsIn_System_Collections_Generic_List_DSLApp1_Model_HexCoord__"></a> FitsIn\(List<HexCoord\>\)

```csharp
public bool FitsIn(List<HexCoord> other)
```

#### Parameters

`other` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[HexCoord](DSLApp1.Model.HexCoord.md)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_HexPiece_GenerateRandomHexPieceSignature_System_Int32_System_Int32_"></a> GenerateRandomHexPieceSignature\(int, int\)

Generates a deterministic random hex piece signature given the number of hexes.
The seed ensures that the same hexCount and seed always yield the same layout.

```csharp
public static string GenerateRandomHexPieceSignature(int hexCount, int seed = 0)
```

#### Parameters

`hexCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`seed` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="DSLApp1_Model_HexPiece_GetCoordinatesFromSignature_System_String_"></a> GetCoordinatesFromSignature\(string\)

Converts a hex signature (a string of digits) into a list of HexCoord objects.
Starts at the origin and for each digit moves to the corresponding neighbor.

```csharp
public static List<HexCoord> GetCoordinatesFromSignature(string signature)
```

#### Parameters

`signature` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[HexCoord](DSLApp1.Model.HexCoord.md)\>

### <a id="DSLApp1_Model_HexPiece_IsCompatibleWith_DSLApp1_Model_ICharacterDefinition_"></a> IsCompatibleWith\(ICharacterDefinition\)

```csharp
public bool IsCompatibleWith(ICharacterDefinition character)
```

#### Parameters

`character` [ICharacterDefinition](DSLApp1.Model.ICharacterDefinition.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_HexPiece_IsSeparateFrom_System_Collections_Generic_HashSet_DSLApp1_Model_HexCoord__"></a> IsSeparateFrom\(HashSet<HexCoord\>\)

```csharp
public bool IsSeparateFrom(HashSet<HexCoord> other)
```

#### Parameters

`other` [HashSet](https://learn.microsoft.com/dotnet/api/system.collections.generic.hashset\-1)<[HexCoord](DSLApp1.Model.HexCoord.md)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_HexPiece_TransformedCoordinates"></a> TransformedCoordinates\(\)

```csharp
public List<HexCoord> TransformedCoordinates()
```

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[HexCoord](DSLApp1.Model.HexCoord.md)\>

