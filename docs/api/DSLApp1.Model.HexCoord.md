# <a id="DSLApp1_Model_HexCoord"></a> Struct HexCoord

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
[Serializable]
public struct HexCoord : IEquatable<HexCoord>, IComparable<HexCoord>
```

#### Implements

[IEquatable<HexCoord\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IComparable<HexCoord\>](https://learn.microsoft.com/dotnet/api/system.icomparable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Model_HexCoord__ctor_System_Int32_System_Int32_"></a> HexCoord\(int, int\)

```csharp
public HexCoord(int q, int r)
```

#### Parameters

`q` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`r` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Fields

### <a id="DSLApp1_Model_HexCoord_q"></a> q

```csharp
public int q
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_HexCoord_r"></a> r

```csharp
public int r
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="DSLApp1_Model_HexCoord_size"></a> size

```csharp
public static float size
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="DSLApp1_Model_HexCoord_s"></a> s

```csharp
public int s { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="DSLApp1_Model_HexCoord_CompareTo_DSLApp1_Model_HexCoord_"></a> CompareTo\(HexCoord\)

Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.

```csharp
public int CompareTo(HexCoord other)
```

#### Parameters

`other` [HexCoord](DSLApp1.Model.HexCoord.md)

An object to compare with this instance.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A value that indicates the relative order of the objects being compared. The return value has these meanings:  

 <table><thead><tr><th class="term"> Value</th><th class="description"> Meaning</th></tr></thead><tbody><tr><td class="term"> Less than zero</td><td class="description"> This instance precedes <code class="paramref">other</code> in the sort order.</td></tr><tr><td class="term"> Zero</td><td class="description"> This instance occurs in the same position in the sort order as <code class="paramref">other</code>.</td></tr><tr><td class="term"> Greater than zero</td><td class="description"> This instance follows <code class="paramref">other</code> in the sort order.</td></tr></tbody></table>

### <a id="DSLApp1_Model_HexCoord_Equals_System_Object_"></a> Equals\(object\)

Indicates whether this instance and a specified object are equal.

```csharp
public override bool Equals(object obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to compare with the current instance.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">obj</code> and this instance are the same type and represent the same value; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="DSLApp1_Model_HexCoord_Equals_DSLApp1_Model_HexCoord_"></a> Equals\(HexCoord\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(HexCoord other)
```

#### Parameters

`other` [HexCoord](DSLApp1.Model.HexCoord.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="DSLApp1_Model_HexCoord_GetAdjacentCoord_DSLApp1_Model_HexCoord_FaceDirection_"></a> GetAdjacentCoord\(FaceDirection\)

```csharp
public HexCoord GetAdjacentCoord(HexCoord.FaceDirection face)
```

#### Parameters

`face` [HexCoord](DSLApp1.Model.HexCoord.md).[FaceDirection](DSLApp1.Model.HexCoord.FaceDirection.md)

#### Returns

 [HexCoord](DSLApp1.Model.HexCoord.md)

### <a id="DSLApp1_Model_HexCoord_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="DSLApp1_Model_HexCoord_GetNeighborCoords"></a> GetNeighborCoords\(\)

```csharp
public List<HexCoord> GetNeighborCoords()
```

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[HexCoord](DSLApp1.Model.HexCoord.md)\>

### <a id="DSLApp1_Model_HexCoord_RotateAnticlockwise"></a> RotateAnticlockwise\(\)

```csharp
public HexCoord RotateAnticlockwise()
```

#### Returns

 [HexCoord](DSLApp1.Model.HexCoord.md)

### <a id="DSLApp1_Model_HexCoord_RotateClockwise"></a> RotateClockwise\(\)

```csharp
public HexCoord RotateClockwise()
```

#### Returns

 [HexCoord](DSLApp1.Model.HexCoord.md)

### <a id="DSLApp1_Model_HexCoord_Translate_DSLApp1_Model_HexCoord_"></a> Translate\(HexCoord\)

```csharp
public void Translate(HexCoord hexCoord)
```

#### Parameters

`hexCoord` [HexCoord](DSLApp1.Model.HexCoord.md)

### <a id="DSLApp1_Model_HexCoord_TranslateE"></a> TranslateE\(\)

```csharp
public HexCoord TranslateE()
```

#### Returns

 [HexCoord](DSLApp1.Model.HexCoord.md)

### <a id="DSLApp1_Model_HexCoord_TranslateN"></a> TranslateN\(\)

```csharp
public HexCoord TranslateN()
```

#### Returns

 [HexCoord](DSLApp1.Model.HexCoord.md)

### <a id="DSLApp1_Model_HexCoord_TranslateNE"></a> TranslateNE\(\)

```csharp
public HexCoord TranslateNE()
```

#### Returns

 [HexCoord](DSLApp1.Model.HexCoord.md)

### <a id="DSLApp1_Model_HexCoord_TranslateNW"></a> TranslateNW\(\)

```csharp
public HexCoord TranslateNW()
```

#### Returns

 [HexCoord](DSLApp1.Model.HexCoord.md)

### <a id="DSLApp1_Model_HexCoord_TranslateS"></a> TranslateS\(\)

```csharp
public HexCoord TranslateS()
```

#### Returns

 [HexCoord](DSLApp1.Model.HexCoord.md)

### <a id="DSLApp1_Model_HexCoord_TranslateSE"></a> TranslateSE\(\)

```csharp
public HexCoord TranslateSE()
```

#### Returns

 [HexCoord](DSLApp1.Model.HexCoord.md)

### <a id="DSLApp1_Model_HexCoord_TranslateSW"></a> TranslateSW\(\)

```csharp
public HexCoord TranslateSW()
```

#### Returns

 [HexCoord](DSLApp1.Model.HexCoord.md)

### <a id="DSLApp1_Model_HexCoord_TranslateW"></a> TranslateW\(\)

```csharp
public HexCoord TranslateW()
```

#### Returns

 [HexCoord](DSLApp1.Model.HexCoord.md)

## Operators

### <a id="DSLApp1_Model_HexCoord_op_UnaryNegation_DSLApp1_Model_HexCoord_"></a> operator \-\(HexCoord\)

```csharp
public static HexCoord operator -(HexCoord hex)
```

#### Parameters

`hex` [HexCoord](DSLApp1.Model.HexCoord.md)

#### Returns

 [HexCoord](DSLApp1.Model.HexCoord.md)

