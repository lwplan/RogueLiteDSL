namespace DSLApp1.Model;

public interface IAbility : IIdentifiable
{
    string Name { get; }
    int ManaCost { get; }
    Targetability Targetability { get; }
    List<ICombatCharacter> ValidTargets(ICombatCharacter user, List<ICombatCharacter> targets);
    CombatEvent Apply(ICombatCharacter combatCharacter, List<ICombatCharacter> targets, bool opportunity = false);
}
