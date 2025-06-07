# RogueLite DSL Overview

This document provides a top‑down walk through of the ability description language used in this repository.  It summarizes the syntax using EBNF inspired notation and highlights some of the limits built into the grammar.

## 1. Top Level: `ability`

At the highest level an ability is composed of a header followed by a body.  The body is built from a series of optional clauses which may appear in a fixed order.  The grammar in `src/Dsl/Grammar.txt` starts with:

```ebnf
ability := header body

body :=
    [charges-clause]
    [targeting-clause]
    [immediate-clause]
    [modifier-clause]
    [side-effects-clause]
    [miss-clause]
```


Only the header is mandatory.  Each clause in the body is optional but must appear in the order shown above.  A single ability may contain exactly one immediate effect and zero or more modifier effects.

## 2. Immediate Effects

Immediate effects describe actions that happen as soon as the ability resolves.  The grammar allows dealing damage, healing, or invoking combat mechanics.  From the grammar:

```ebnf
immediate-clause := [deals-clause | heals-clause | invokes-clause]

deals-clause := 'Deals' damage-clause

heals-clause := healing-type healing-clause

healing-type := 'Restores' | 'Drains' | 'Gives' | 'Takes'

invokes-clause := 'Invokes' invoke-mechanic ['if' condition]
```

`deals-clause` uses `damage-clause` which supports optional elemental tags and modifiers:

```ebnf
 damage-clause := { element-type } damage-type 'damage'
                  ['with' damage-mechanic {',' damage-mechanic}]
                  ['if' condition]

damage-mechanic := damage-mechanic-type mechanic-specifier
damage-mechanic-type :=
    'Spiral' | 'Piercing' | 'Kill' |
    'ExtraDamage' | 'Crit' | 'ShieldBreaker'
```

Elements such as `Fire` or `Ice` may be listed before the damage type (`Physical` or `Magical`).  Damage mechanics like `Piercing`, `ExtraDamage`, or `Spiral` can be supplied after the keyword `with`.  Each mechanic accepts an amount (number or percentage) and may include an additional condition introduced by `when` or `if`.

Healing and invoking mechanics follow similar patterns with optional conditions and parameters.

## 3. Modifier Effects

Modifier effects apply ongoing changes.  These include inflicting damage over time, curing effects, or applying buffs and debuffs.  The grammar excerpt is:

```ebnf
modifier-clause :=
    inflicts-clause | cures-clause | applies-clause

inflicts-clause := 'Inflicts' damage-clause [auto-targeting-clause] duration-clause ['if' condition]

cures-clause := ['Restores' | 'Drains' | 'Loots' | 'Donates'] healing-clause [targeting-clause] duration-clause ['if' condition]

applies-clause := 'Applies' modifier-mechanic {',' modifier-mechanic} [duration-clause] ['if' condition]
```


`duration-clause` limits how long the modifier lasts and can optionally attach an event such as `on round start`.

Modifier mechanics can represent stat buffs, multipliers (e.g., `Vulnerability`), or named states like `Stun`:

```ebnf
modifier-mechanic := stat-buff-mechanic | multiplier-mechanic | state-mechanic
state-mechanic := ('Blessing' | 'Curse' | 'Stun' | 'Defensive' | 'Revival' | 'Shield' | 'Wet' | 'Oiled') [mechanic-specifier]
multiplier-mechanic := ('Vulnerability' | 'Protection' | 'Power' | 'Frailty') ['(' amount ')'] [('against' | 'to') (element | compatibility) damage] ['when' condition]
stat-buff-mechanic := ('Buff' | 'Debuff') '(' amount ')' 'to' stat-field
stat-field := 'Attack' | 'Defense' | 'Intelligence' | 'Resistance' | 'Initiative'
```


## 4. Targeting and Side Effects

Targeting controls which units an ability can affect.  When present it specifies an automatic strategy, an optional target type, and the target side:

```ebnf
auto-targeting-clause := 'Targeting' target-selection-criteria targetability ['with' targeting-mechanic { ',' targeting-mechanic } ]

targeting-mechanic := targeting-mechanic-type ['(' amount ')']
targeting-mechanic-type := 'MultiHit' | 'MultiTarget' | 'Random'
```

Side effects occur after the main effects resolve and can include mechanics like `Bounce` or `Splash`:

```ebnf
side-effects-clause := 'afterwards' side-effect-mechanic {',' side-effect-mechanic}
```

Healing can also be used as a side effect.  Each mechanic accepts a numeric amount in parentheses and may be gated by a condition.

## 5. Conditions

Conditions gate many parts of the language.  They compare a subject’s stat or an outcome metric to a numeric value.

```ebnf
condition := comparison-field comparison amount

comparison-field := (('User' | 'Target') character-stat) | outcome-stat
character-stat := 'Attack' | 'Defense' | 'Intelligence' | 'Resistance' | 'Initiative' | 'MaxHp' | 'InitialMana' | 'Mana' | 'Hp' | 'Opportunity'
outcome-stat := 'Roll' | 'Kills' | 'Missed' | 'Hits'
```


Comparison operators include `==`, `!=`, `<`, `>`, `<=`, and `>=`.  A special `miss-clause` uses a condition to specify when an ability is considered to miss.

## 6. Restrictions and Notes

- Clauses must appear in the strict order defined in the body grammar.
- Exactly one immediate effect may be specified, but multiple modifier effects are allowed.
- Element and mechanic names are case-insensitive keywords defined by the tokenizer.
- Amounts for mechanics accept either whole numbers or numbers followed by `%`.
- Conditions only support numeric comparisons; complex boolean logic is not currently part of the grammar.

This overview mirrors the formal grammar found in [`src/Dsl/Grammar.txt`](../src/Dsl/Grammar.txt) and should help when authoring new ability definitions or extending the parser logic.

## 7. Common Pitfalls

Several lines in `tests/TestData/abilities.csv` fail to parse due to minor syntax mistakes:

- **Stat buffs** must use `Buff(6) to Defense`.  Abbreviations like `Buff(DEF,6)` are invalid.
- **Unimplemented mechanics** such as `RandomBuffOrDebuff` will cause errors.
- **Side effects** must follow the `afterwards` keyword, e.g. `afterwards Bounce(50%) if kills > 0`.

## 8. Examples from the CSV files

The test data in `tests/TestData/abilities.csv` and `tests/TestData/macros.csv` provides
real ability descriptions and macro definitions.  A few lines are reproduced here to
illustrate how the syntax looks in practice.

### Ability rows

* **Lightning bolt** – `Ability : Deals Electrical Physical(30) damage miss if roll < 90`
* **Vine whip** – `Ability : Deals Physical(10) damage then Applies @Slow[I] for 3 turns`
* **Shield breaker** – `Ability : Deals Physical(5) damage with ShieldBreaker(30) if roll > 80`

These examples show damage keywords, conditional clauses and the use of a macro
(`@Slow[I]`) which expands to a debuff.

### Macro snippets

The `macros.csv` file defines shortcuts such as:

```
@Strength[X],Buff,"Buff(X#[4,6,7,9,10]) to Attack"
@Weakness[X],Debuff,"Debuff(X#[4,6,7,9,10]) to Resistance"
```

Using `@Strength[III]` in an ability would expand to `Buff(9) to Attack`.  Likewise
`@Weakness[I]` expands to `Debuff(4) to Resistance` as seen in the **Light ray** entry
of the abilities CSV.  Any macro beginning with `@` can be substituted before parsing
the DSL text.
