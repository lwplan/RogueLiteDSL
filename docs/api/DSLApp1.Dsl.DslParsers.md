# <a id="DSLApp1_Dsl_DslParsers"></a> Class DslParsers

Namespace: [DSLApp1.Dsl](DSLApp1.Dsl.md)  
Assembly: DSLApp1.dll  

```csharp
public static class DslParsers
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DslParsers](DSLApp1.Dsl.DslParsers.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="DSLApp1_Dsl_DslParsers_AbilityParser"></a> AbilityParser

```csharp
public static Parser<Token, AbilityIR> AbilityParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [AbilityIR](DSLApp1.Dsl.AbilityIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_AnySideEffectMechanicParser"></a> AnySideEffectMechanicParser

```csharp
public static Parser<Token, SideEffectMechanicIR> AnySideEffectMechanicParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [SideEffectMechanicIR](DSLApp1.Dsl.SideEffectMechanicIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_AppliesEffectParser"></a> AppliesEffectParser

```csharp
public static Parser<Token, ModifierEffectIR> AppliesEffectParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [ModifierEffectIR](DSLApp1.Dsl.ModifierEffectIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_BasicSupportEffectParser"></a> BasicSupportEffectParser

```csharp
public static Parser<Token, SupportEffectIR> BasicSupportEffectParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_CharacterFieldParser"></a> CharacterFieldParser

```csharp
public static Parser<Token, Field> CharacterFieldParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Field](DSLApp1.Dsl.Field.md)\>

### <a id="DSLApp1_Dsl_DslParsers_ChargesClauseParser"></a> ChargesClauseParser

```csharp
public static Parser<Token, Duration> ChargesClauseParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Duration](DSLApp1.Dsl.Duration.md)\>

### <a id="DSLApp1_Dsl_DslParsers_ComparisonOpParser"></a> ComparisonOpParser

```csharp
public static Parser<Token, Op> ComparisonOpParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Op](DSLApp1.Dsl.Op.md)\>

### <a id="DSLApp1_Dsl_DslParsers_ConditionParser"></a> ConditionParser

```csharp
public static Parser<Token, Condition> ConditionParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Condition](DSLApp1.Dsl.Condition.md)\>

### <a id="DSLApp1_Dsl_DslParsers_DamageEffectParser"></a> DamageEffectParser

```csharp
public static Parser<Token, DamageEffectIR> DamageEffectParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [DamageEffectIR](DSLApp1.Dsl.DamageEffectIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_DamageFormulaParser"></a> DamageFormulaParser

```csharp
public static Parser<Token, DamageFormula> DamageFormulaParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [DamageFormula](DSLApp1.Dsl.DamageFormula.md)\>

### <a id="DSLApp1_Dsl_DslParsers_DamageMechanicAtom"></a> DamageMechanicAtom

```csharp
public static Parser<Token, DamageMechanic> DamageMechanicAtom { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [DamageMechanic](DSLApp1.Dsl.DamageMechanic.md)\>

### <a id="DSLApp1_Dsl_DslParsers_DamageMechanicGroupParser"></a> DamageMechanicGroupParser

```csharp
public static Parser<Token, List<DamageMechanic>> DamageMechanicGroupParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[DamageMechanic](DSLApp1.Dsl.DamageMechanic.md)\>\>

### <a id="DSLApp1_Dsl_DslParsers_DamageMechanicTypeParser"></a> DamageMechanicTypeParser

```csharp
public static Parser<Token, DamageMechanicType> DamageMechanicTypeParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [DamageMechanicType](DSLApp1.Dsl.DamageMechanicType.md)\>

### <a id="DSLApp1_Dsl_DslParsers_DamageSupportIRParser"></a> DamageSupportIRParser

```csharp
public static Parser<Token, SupportEffectIR> DamageSupportIRParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_DurationClauseParser"></a> DurationClauseParser

```csharp
public static Parser<Token, Duration> DurationClauseParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Duration](DSLApp1.Dsl.Duration.md)\>

### <a id="DSLApp1_Dsl_DslParsers_DurationParser"></a> DurationParser

```csharp
public static Parser<Token, Duration> DurationParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Duration](DSLApp1.Dsl.Duration.md)\>

### <a id="DSLApp1_Dsl_DslParsers_EffectSupportIRParser"></a> EffectSupportIRParser

```csharp
public static Parser<Token, SupportEffectIR> EffectSupportIRParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_ElementParser"></a> ElementParser

```csharp
public static Parser<Token, Element> ElementParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Element](DSLApp1.Dsl.Element.md)\>

### <a id="DSLApp1_Dsl_DslParsers_ElementSupportIRParser"></a> ElementSupportIRParser

```csharp
public static Parser<Token, SupportEffectIR> ElementSupportIRParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_EventClauseParser"></a> EventClauseParser

```csharp
public static Parser<Token, TimingEvent> EventClauseParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [TimingEvent](DSLApp1.Dsl.TimingEvent.md)\>

### <a id="DSLApp1_Dsl_DslParsers_HeaderParser"></a> HeaderParser

```csharp
public static Parser<Token, Header> HeaderParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Header](DSLApp1.Dsl.Header.md)\>

### <a id="DSLApp1_Dsl_DslParsers_HealMechanicParser"></a> HealMechanicParser

```csharp
public static Parser<Token, HealMechanic> HealMechanicParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [HealMechanic](DSLApp1.Dsl.HealMechanic.md)\>

### <a id="DSLApp1_Dsl_DslParsers_HealingSideEffectParser"></a> HealingSideEffectParser

```csharp
public static Parser<Token, SideEffectMechanicIR> HealingSideEffectParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [SideEffectMechanicIR](DSLApp1.Dsl.SideEffectMechanicIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_HealsEffectParser"></a> HealsEffectParser

```csharp
public static Parser<Token, EffectIR> HealsEffectParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [EffectIR](DSLApp1.Dsl.EffectIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_HexParser"></a> HexParser

```csharp
public static Parser<Token, object> HexParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [object](https://learn.microsoft.com/dotnet/api/system.object)\>

### <a id="DSLApp1_Dsl_DslParsers_ImmediateClauseParser"></a> ImmediateClauseParser

```csharp
public static Parser<Token, EffectIR> ImmediateClauseParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [EffectIR](DSLApp1.Dsl.EffectIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_InflictsEffectParser"></a> InflictsEffectParser

```csharp
public static Parser<Token, ModifierEffectIR> InflictsEffectParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [ModifierEffectIR](DSLApp1.Dsl.ModifierEffectIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_InvokeEffectParser"></a> InvokeEffectParser

```csharp
public static Parser<Token, InvokeEffectIR> InvokeEffectParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [InvokeEffectIR](DSLApp1.Dsl.InvokeEffectIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_InvokeMechanicParser"></a> InvokeMechanicParser

```csharp
public static Parser<Token, InvokeMechanic> InvokeMechanicParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [InvokeMechanic](DSLApp1.Dsl.InvokeMechanic.md)\>

### <a id="DSLApp1_Dsl_DslParsers_InvokeMechanicTypeParser"></a> InvokeMechanicTypeParser

```csharp
public static Parser<Token, InvokeMechanicType> InvokeMechanicTypeParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [InvokeMechanicType](DSLApp1.Dsl.InvokeMechanicType.md)\>

### <a id="DSLApp1_Dsl_DslParsers_MissClauseParser"></a> MissClauseParser

```csharp
public static Parser<Token, Condition> MissClauseParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Condition](DSLApp1.Dsl.Condition.md)\>

### <a id="DSLApp1_Dsl_DslParsers_ModifierClauseParser"></a> ModifierClauseParser

```csharp
public static Parser<Token, EffectIR> ModifierClauseParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [EffectIR](DSLApp1.Dsl.EffectIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_ModifierMechanicParser"></a> ModifierMechanicParser

```csharp
public static Parser<Token, ModifierMechanicIR> ModifierMechanicParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [ModifierMechanicIR](DSLApp1.Dsl.ModifierMechanicIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_MultiplierMechanicParser"></a> MultiplierMechanicParser

```csharp
public static Parser<Token, MultiplierMechanicIR> MultiplierMechanicParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [MultiplierMechanicIR](DSLApp1.Dsl.MultiplierMechanicIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_OutcomeFieldParser"></a> OutcomeFieldParser

```csharp
public static Parser<Token, Field> OutcomeFieldParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Field](DSLApp1.Dsl.Field.md)\>

### <a id="DSLApp1_Dsl_DslParsers_RoleParser"></a> RoleParser

```csharp
public static Parser<Token, Compatibility> RoleParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Compatibility](DSLApp1.Dsl.Compatibility.md)\>

### <a id="DSLApp1_Dsl_DslParsers_SideEffectMechanicParser"></a> SideEffectMechanicParser

```csharp
public static Parser<Token, SideEffectMechanicIR> SideEffectMechanicParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [SideEffectMechanicIR](DSLApp1.Dsl.SideEffectMechanicIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_SideEffectMechanicTypeParser"></a> SideEffectMechanicTypeParser

```csharp
public static Parser<Token, SideEffectMechanicType> SideEffectMechanicTypeParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [SideEffectMechanicType](DSLApp1.Dsl.SideEffectMechanicType.md)\>

### <a id="DSLApp1_Dsl_DslParsers_SideEffectSupportIRParser"></a> SideEffectSupportIRParser

```csharp
public static Parser<Token, SupportEffectIR> SideEffectSupportIRParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_SideEffectsClauseParser"></a> SideEffectsClauseParser

```csharp
public static Parser<Token, SideEffectsIR> SideEffectsClauseParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [SideEffectsIR](DSLApp1.Dsl.SideEffectsIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_SideEffectsParser"></a> SideEffectsParser

```csharp
public static Parser<Token, SideEffectsIR> SideEffectsParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [SideEffectsIR](DSLApp1.Dsl.SideEffectsIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_StatBuffMechanicParser"></a> StatBuffMechanicParser

```csharp
public static Parser<Token, StatBuffMechanicIR> StatBuffMechanicParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [StatBuffMechanicIR](DSLApp1.Dsl.StatBuffMechanicIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_StateMechanicParser"></a> StateMechanicParser

```csharp
public static Parser<Token, StateMechanicIR> StateMechanicParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [StateMechanicIR](DSLApp1.Dsl.StateMechanicIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_SubjectParser"></a> SubjectParser

```csharp
public static Parser<Token, Subject> SubjectParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Subject](DSLApp1.Dsl.Subject.md)\>

### <a id="DSLApp1_Dsl_DslParsers_SupportEffectListOrSingleParser"></a> SupportEffectListOrSingleParser

```csharp
public static Parser<Token, List<SupportEffectIR>> SupportEffectListOrSingleParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md)\>\>

### <a id="DSLApp1_Dsl_DslParsers_SupportEffectListParser"></a> SupportEffectListParser

```csharp
public static Parser<Token, List<SupportEffectIR>> SupportEffectListParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md)\>\>

### <a id="DSLApp1_Dsl_DslParsers_SupportEffectParser"></a> SupportEffectParser

```csharp
public static Parser<Token, List<SupportEffectIR>> SupportEffectParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md)\>\>

### <a id="DSLApp1_Dsl_DslParsers_SupportMechanicsElementListParser"></a> SupportMechanicsElementListParser

```csharp
public static Parser<Token, List<SupportEffectIR>> SupportMechanicsElementListParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[SupportEffectIR](DSLApp1.Dsl.SupportEffectIR.md)\>\>

### <a id="DSLApp1_Dsl_DslParsers_SupportParser"></a> SupportParser

```csharp
public static Parser<Token, SupportIR> SupportParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [SupportIR](DSLApp1.Dsl.SupportIR.md)\>

### <a id="DSLApp1_Dsl_DslParsers_TargetTagParser"></a> TargetTagParser

```csharp
public static Parser<Token, TargetTag> TargetTagParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [TargetTag](DSLApp1.Dsl.TargetTag.md)\>

### <a id="DSLApp1_Dsl_DslParsers_TargetabilityParser"></a> TargetabilityParser

```csharp
public static Parser<Token, Targetability> TargetabilityParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Targetability](DSLApp1.Model.Targetability.md)\>

### <a id="DSLApp1_Dsl_DslParsers_TargetingParser"></a> TargetingParser

```csharp
public static Parser<Token, Targeting> TargetingParser { get; }
```

#### Property Value

 Parser<[Token](DSLApp1.Dsl.Token.md), [Targeting](DSLApp1.Dsl.Targeting.md)\>

