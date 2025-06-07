# Ability Implementation Status
This document lists abilities from `tests/TestData/abilities.csv` grouped by implementation status. Each entry has a `Test` value of `Pass`, `Fail`, or `Unimplemented`. Pass abilities should parse successfully; Fail ones are expected to fail; Unimplemented entries are not yet verified.

## Implemented Abilities (Pass)
| Ability | Proposed Mechanics | Test |
|---------|-------------------|------|
| Dark tendrils | Ability : Deals Physical(20) Dark damage miss if roll < 80 | Pass |
| Light ray | Ability : Deals Physical(5) Light damage then Applies @Weakness[I] for 3 turns | Pass |
| Vine whip | Ability : Deals Physical(10) damage then Applies @Slow[I] for 3 turns | Pass |
| Lightning bolt | Ability : Deals Electrical Physical(30) damage miss if roll < 90 | Pass |
| Water bullet | Ability : Deals Water Physical(5) damage then applies vulnerability(150%) to electrical damage for 3 turns | Pass |
| Fireball | Ability : Deals Physical(10) fire damage | Pass |
| Fallen spear | Ability : Deals Dark Physical(20) damage | Pass |
| Illuminate blade | Ability : Deals Dark Physical(20) damage | Pass |
| Earth hammer | Ability : Deals Dark Physical(20) damage | Pass |
| Jet stream axe | Ability : Deals Physical(20) damage miss if roll < 80 | Pass |
| Fire slash | Ability : Deals Fire Physical(20) damage | Pass |
| Flow cut | Ability : Deals Physical(10) water damage | Pass |
| Overwhelming force | Ability : Deals Physical(20) damage | Pass |
| Shield breaker | Ability : Deals Physical(5) damage with ShieldBreaker(30) if roll > 80 | Pass |
| Cannonzade | Ability (Artillery): Targeting Enemies with MultiHit(6) Deals Physical(6) Fire damage | Pass |
| Molten Bombard | Ability (Artillery): inflicts Physical(6) Fire damage for 3 turns | Pass |
| Molton Barbard Test | Ability (Artillery): For 3 turns: { Deals Physical(6) Fire damage, Deals Magical(2) damage } | Pass |
| Heavy Shell | Ability (Artillery): Charges 1 turn then Deals Physical(15) Fire damage | Pass |
| Piercing Shrapnel | Support (Artillery): Adds Piercing(50%) to damage (Adjective = Piercing) | Pass |
| Storm Mortar | Ability (Artillery): Deals Physical(6) Electrical damage afterwards [Bounce if roll < 30] | Pass |
| Load Munition | Support(Artillery) : Adds Fire to damage | Pass |
| Bigger Caliber | Support(Artillery) : Adds ExtraDamage(3) to damage | Pass |
| Critial Magazine | Support(Artillery) : Adds Crit(20%) to damage if roll < 30 | Pass |
| Molten Cannonball | Support(Artillery) : Adds For 3 turns : Deals Physical(6) Fire damage | Pass |
| Siege Lock | Ability (Artillery) : Targeting Enemy,  Invokes Delay(2) | Pass |
| Shuffle | Ability (Chaos): Targeting All Invokes Shuffle | Pass |
| Sleight of Hand | Ability (Chaos): Targeting Ally Invokes Advance(2) | Pass |
| Tripwire | Ability (Chaos): Targeting Enemy Invokes Delay(2) | Pass |
| Double Blink | Ability (Chaos): Targeting Ally Invokes Swap | Pass |
| Joker’s Gambit | Ability (Chaos): Targeting Self Applies Power(300%) for 1 turn if roll > 50 | Pass |
| Finish Him | Ability (Execution): Deals Physical(10) damage if target hpPercent < 30 | Pass |
| Last Words | Ability (Execution): Restore 10 mana | Pass |
| Axe Man | Ability (Execution): Deals Physical(10) damage afterwards Splash if kills > 0 | Pass |
| Fatal Mark | Ability (Execution): Applies Vulnerability(200) until hit | Pass |
| Killing Blow (Splash) | Ability (Execution): Deals Physical(10) damage afterwards Splash(50%) if kills > 0 | Pass |
| Farewell | Ability (Execution): Deals Physical(0) damage with Kill if target hpPercent < 15 | Pass |
| Killing Blow (Bounce) | Ability (Execution): Deals Physical(10) damage afterwards Bounce(50%) if kills > 0 | Pass |
| Sacred Light | Ability (Holy): Targeting Allies Heals(20) | Pass |
| Holy Armor | Ability (Holy): Applies Buff(DEF,6) for 3 turns | Pass |
| Divine Reflex | Ability (Holy): Applies Buff(IVE,6) for 2 rounds | Pass |
| Radiant Vow | Ability (Holy): Applies Revival(1) for 1 round | Pass |
| Light Ray | Ability (Holy): Deals Magical(1) with Light | Pass |
| Cleric’s Boon | Ability (Holy): Targeting Allies Applies Cleanse | Pass |
| Iron Guard | Ability (Protector): Targeting Self, Applies DefensiveStance, Applies Protection(40%) for 1 turn | Pass |
| Shield Wall | Ability (Protector): Targeting Self, Applies DefensiveStance, Applies Shield(30) | Pass |
| Mighty Shield | Ability (Protector): Targeting Self, Applies Shield(30) | Pass |
| Intercepting Step | Ability (Protector): Targeting Self, Applies DefensiveStance until hit | Pass |

## Proposed Abilities (Not yet implemented)
| Ability | Proposed Mechanics | Test |
|---------|-------------------|------|
| Raise shield | Outfit : Equips @Protection[II] and @Endurance[II] | Fail |
| Royal Wall | What is royal wall? | Fail |
| Radiating light |  | Unimplemented |
| Waterfall meditation |  | Unimplemented |
| Ice bolas |  | Unimplemented |
| Holy Smite |  | Unimplemented |
| Camouflage |  | Unimplemented |
| Desert Javeline |  | Unimplemented |
| Nomad care |  | Unimplemented |
| Oil vial |  | Unimplemented |
| Poison darts |  | Unimplemented |
| Desert firebomb |  | Unimplemented |
| Balance |  | Unimplemented |
| Prayer |  | Unimplemented |
| Spiraling dark |  | Unimplemented |
| Ether blast |  | Unimplemented |
| Light Blessing |  | Unimplemented |
| fortitous heal |  | Unimplemented |
| Shadow convocationS |  | Unimplemented |
| Ether Cannon |  | Unimplemented |
| Shield Bash |  | Unimplemented |
| Attack |  | Unimplemented |
| Defend |  | Unimplemented |
| Aegis Throw |  | Unimplemented |
| Venom Bite |  | Unimplemented |
| Super slash |  | Unimplemented |
| Aether blast |  | Unimplemented |
| Great Slash |  | Unimplemented |
| Swift Slash |  | Unimplemented |
| Light spark |  | Unimplemented |
| Meditate |  | Unimplemented |
| Unleash shadows |  | Unimplemented |
| Desert slash |  | Unimplemented |
| Loyalty pledge |  | Unimplemented |
| Brute |  | Fail |
| Overhead Slam | Ability (Brute): Deals Physical(25) damage then Applies Stun(1) to Self for 1 turn | Fail |
| Reckless Charge | Ability (Brute): Targeting Line Deals Physical(15) damage then Applies Vulnerability(125%) to Self for 1 turn | Fail |
| Earthbreaker | Ability (Brute): Deals Piercing Physical(20) damage then Invokes Delay(1) on Self | Fail |
| Double Down | Ability (Brute): Deals Physical(15) damage then Repeat if hit at 80% accuracy | Fail |
| Crushbone | Ability (Brute): Deals Physical(18) damage then Applies Stun(1) | Fail |
| Solitude |  | Fail |
| Lone Stance | Ability (Solitude): Applies Power(125%), Protection(25%) for 1 round if no allies acted | Fail |
| Echoing Blade | Ability (Solitude): Deals Physical(10) damage with Power(150%) if last ally to act | Fail |
| Isolated Will | Ability (Solitude): Heals(20) if no allies alive | Fail |
| Stillness Before the Storm | Ability (Solitude): Invokes SkipSelf then Applies Initiative(2), Power(130%) next turn | Fail |
| Last Man Standing | Ability (Solitude): Applies Power(105% per fallen ally) until end of combat | Fail |
| Quiet Defiance | Ability (Solitude): Applies Counter(1) if no allies before in turn order | Fail |
| Discipline |  | Fail |
| Measured Strike | Ability (Discipline): Deals Physical(10) damage gains Power(125%) if used consecutively up to 2x | Fail |
| Calm Mind | Ability (Discipline): Heals(10) then Applies Initiative(1) next turn if not hit | Fail |
| Form Practice | Ability (Discipline): Applies Protection(20%) until next turn then Power(115%) next turn if uninterrupted | Fail |
| Rising Focus | Ability (Discipline): Deals Physical(10) damage with Power(110%+ stored) resets on use | Fail |
| Unwavering | Ability (Discipline): Applies Immunity(Delay,Stun,Redirect) for 2 turns if no Random or Multihit used | Fail |
| Perfect Rhythm | Ability (Discipline): Applies Initiative(1) if same type used 3 turns | Fail |
| Curse |  | Fail |
| Wither Touch | Ability (Curse): Applies Weaken(30%) for 2 turns | Fail |
| Soul Chain | Ability (Curse): Inflicts Physical(10) each turn for 3 turns double next tick if heals | Fail |
| Black Echo | Ability (Curse): Applies Recoil(50%) if target acts next turn | Fail |
| Mark of Frailty | Ability (Curse): Applies Debuff(DEF,-6) for 3 turns | Fail |
| Hex Pulse | Ability (Curse): Applies Curse(NoInitiative) for 1 round | Fail |
| Rotten Grace | Ability (Curse): Applies HealBlock(50%) for 2 turns | Fail |
| Sleight |  | Fail |
| Feint Step | Ability (Sleight): Buffs next attack Initiative(1) expires next turn | Fail |
| Quick Pocket | Ability (Sleight): Steal Mana(5) from random enemy else Applies Initiative(-1) | Fail |
| Smoke Bloom | Ability (Sleight): Applies Untargetable until next turn ends on attack | Fail |
| Misdirection | Ability (Sleight): Redirect next enemy attack to random target | Fail |
| Ghost Draw | Ability (Sleight): Copy top discard fragment for next turn | Fail |
| Palm Flash | Ability (Sleight): Applies Stun(1) if acted earlier this round | Fail |
| Overload |  | Fail |
| Overcharge Pulse | Ability (Overload): Deals Elemental(25) damage then SelfDamage(15) end of next turn | Fail |
| Feedback Arc | Ability (Overload): Recast last ability with Power(125%) then Applies Vulnerability(130%) next round | Fail |
| Crackleburst | Ability (Overload): Applies Initiative(1), Power(120%) this round then Debuff(IVE,-4) for 2 rounds | Fail |
| Core Surge | Ability (Overload): Heals(20) then Power(120%) next turn if overheal SelfDamage(10) | Fail |
| Stability Break | Ability (Overload): Buff next 3 attacks Power(120%) then Applies Silence(1) | Fail |
| Storm Tension | Ability (Overload): Gain Initiative this round then DelaySelf(2) next round | Fail |
| HiddenBlade |  | Fail |
| Veinpiercer | Ability (HiddenBlade): Deals Physical(12) damage then Applies Bleed(5):3 if target at full HP | Fail |
| Silent Fang | Ability (HiddenBlade): Deals Physical(10) damage with Power(150%) if first this round | Fail |
| Crimson Echo | Ability (HiddenBlade): Deals Physical(10) damage then EchoDamage(20%) next turn | Fail |
| Expose Weakness | Ability (HiddenBlade): Applies Vulnerability(125%) for 1 turn | Fail |
| Gut Hook | Ability (HiddenBlade): Deals Physical(6) damage then Applies HealBlock(100%) for 2 turns | Fail |
| Shadow Hemorrhage | Ability (HiddenBlade): Doubles Bleed damage if target has DoT | Fail |
| Resolve |  | Fail |
| Steady Form | Ability (Resolve): Applies Power(110%) each clean turn stacking reset on hit | Fail |
| Stone Patience | Ability (Resolve): Invokes SkipSelf then Buff next attack Power(200%) | Fail |
| Endure Flow | Ability (Resolve): Applies Protection(50%) this round then Heals(10) next round start | Fail |
| Silent Step | Ability (Resolve): Cleanse self then Initiative(2) next turn if no status | Fail |
| Oath Fulfilled | Ability (Resolve): Deals Critical if same ability used 3 turns | Fail |
| Watchful Waiting | Ability (Resolve): Applies Weaken(30%) to last enemy if you act last | Fail |
| Looting |  | Fail |
| Snatch Mana | Ability (Looting): Steal Mana(8) from random enemy | Fail |
| Coin Toss | Ability (Looting): Gain Gold if roll > 50 else SelfDamage(10) | Fail |
| Opportunist Cut | Ability (Looting): Deals Physical(8) damage if kill Gain DoubleGold | Fail |
| Pickpocket Rhythm | Ability (Looting): MultiHit(3) Deals Physical(3) damage each hit Steal Mana(1) | Fail |
| Black Market Gift | Ability (Looting): Applies RandomBuffOrDebuff for 3 turns | Fail |
| Empty Their Pockets | Ability (Looting): Applies Stun(1) then Gain Gold | Fail |
