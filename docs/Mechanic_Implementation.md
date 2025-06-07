# Mechanic Implementation Status

This document summarizes which combat mechanics are currently supported by the parser. Mechanics listed in the implemented table are recognized by the grammar and can be tested. Items in the proposed list appear in ability descriptions but lack parser support.

## Implemented Mechanics (Pass)

| Mechanic | Category |
|----------|----------|
| ExtraDamage | Damage |
| Kill | Damage |
| Crit | Damage |
| Piercing | Damage |
| Spiral | Damage |
| ShieldBreaker | Damage |
| Bounce | Side Effect |
| Splash | Side Effect |
| Exhaust | Side Effect |
| CoolOff | Side Effect |
| Advance | Invoke |
| Swap | Invoke |
| Delay | Invoke |
| Shuffle | Invoke |
| Restore | Heal |
| Drain | Heal |
| Gives | Heal |
| Takes | Heal |
| Vulnerability | Multiplier |
| Protection | Multiplier |
| Power | Multiplier |
| Frailty | Multiplier |
| Blessing | State |
| Curse | State |
| Stun | State |
| Defensive | State |
| Revival | State |
| Shield | State |
| Cleanse | State |
| MultiHit | Targeting |
| MultiTarget | Targeting |
| Random | Targeting |

## Proposed Mechanics (Not yet implemented)

The following mechanics appear in `tests/TestData/abilities.csv` but are not defined in `src/Dsl`:

| Mechanic | Category | Description |
|----------|----------|-------------|
| Bleed | State | Deals damage over time each turn. |
| RandomBuffOrDebuff | State | Applies a random buff or a random debuff. |
| DefensiveStance | State | Enters a defensive posture to reduce damage or intercept. |
| HealBlock | State | Prevents or reduces healing received. |
| Counter | State | Enables a retaliatory hit when attacked. |
| EchoDamage | Side Effect | Repeats a portion of damage on the next turn. |
| Recoil | Side Effect | Causes the user to take damage after acting. |
| SelfDamage | Side Effect | Inflicts damage on the user when the ability resolves. |
| DelaySelf | Invoke | Delays the user's next action. |
| SkipSelf | Invoke | Skips the user's current turn. |
| Immunity | State | Grants immunity to specified effects. |
| Untargetable | State | Cannot be targeted until the effect ends. |
| Weaken | Multiplier | Reduces target damage output. |
| Elemental | Damage | Deals non-specific elemental damage. |
