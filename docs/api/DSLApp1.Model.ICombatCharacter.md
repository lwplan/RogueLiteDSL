# <a id="DSLApp1_Model_ICombatCharacter"></a> Interface ICombatCharacter

Namespace: [DSLApp1.Model](DSLApp1.Model.md)  
Assembly: DSLApp1.dll  

```csharp
public interface ICombatCharacter
```

## Properties

### <a id="DSLApp1_Model_ICombatCharacter_Behaviour"></a> Behaviour

```csharp
Behaviour Behaviour { get; }
```

#### Property Value

 [Behaviour](DSLApp1.Model.Behaviour.md)

### <a id="DSLApp1_Model_ICombatCharacter_CombatStateManager"></a> CombatStateManager

```csharp
ICharacterCombatState CombatStateManager { get; }
```

#### Property Value

 [ICharacterCombatState](DSLApp1.Model.ICharacterCombatState.md)

### <a id="DSLApp1_Model_ICombatCharacter_Name"></a> Name

```csharp
string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="DSLApp1_Model_ICombatCharacter_IsNpc"></a> IsNpc\(\)

```csharp
bool IsNpc()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="DSLApp1_Model_ICombatCharacter_OnCombatStart"></a> OnCombatStart\(\)

```csharp
void OnCombatStart()
```

