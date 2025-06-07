# <a id="DSLApp1_Dsl_AbilityIR"></a> Class AbilityIR

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public record AbilityIR : IEquatable<AbilityIR>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AbilityIR](DSLApp1.Dsl.AbilityIR.md)

#### Implements

[IEquatable<AbilityIR\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="DSLApp1_Dsl_AbilityIR__ctor_System_Collections_Generic_List_DSLApp1_Dsl_EffectIR__DSLApp1_Dsl_Targeting_System_Collections_Generic_List_DSLApp1_Dsl_Compatibility__System_Collections_Generic_List_DSLApp1_Dsl_SideEffectsIR__DSLApp1_Dsl_Condition_"></a> AbilityIR\(List<EffectIR\>, Targeting, List<Compatibility\>, List<SideEffectsIR\>, Condition?\)

```csharp
public AbilityIR(List<EffectIR> Effects, Targeting Targeting, List<Compatibility> RoleCompatibilities, List<SideEffectsIR> PostEffects, Condition? When)
```

#### Parameters

`Effects` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[EffectIR](DSLApp1.Dsl.EffectIR.md)\>

`Targeting` [Targeting](DSLApp1.Dsl.Targeting.md)

`RoleCompatibilities` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Compatibility](DSLApp1.Dsl.Compatibility.md)\>

`PostEffects` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[SideEffectsIR](DSLApp1.Dsl.SideEffectsIR.md)\>

`When` [Condition](DSLApp1.Dsl.Condition.md)?

## Properties

### <a id="DSLApp1_Dsl_AbilityIR_Effects"></a> Effects

```csharp
public List<EffectIR> Effects { get; init; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[EffectIR](DSLApp1.Dsl.EffectIR.md)\>

### <a id="DSLApp1_Dsl_AbilityIR_PostEffects"></a> PostEffects

```csharp
public List<SideEffectsIR> PostEffects { get; init; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[SideEffectsIR](DSLApp1.Dsl.SideEffectsIR.md)\>

### <a id="DSLApp1_Dsl_AbilityIR_RoleCompatibilities"></a> RoleCompatibilities

```csharp
public List<Compatibility> RoleCompatibilities { get; init; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Compatibility](DSLApp1.Dsl.Compatibility.md)\>

### <a id="DSLApp1_Dsl_AbilityIR_Targeting"></a> Targeting

```csharp
public Targeting Targeting { get; init; }
```

#### Property Value

 [Targeting](DSLApp1.Dsl.Targeting.md)

### <a id="DSLApp1_Dsl_AbilityIR_When"></a> When

```csharp
public Condition? When { get; init; }
```

#### Property Value

 [Condition](DSLApp1.Dsl.Condition.md)?

