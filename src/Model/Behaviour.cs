namespace DSLApp1.Model


{
    public enum BehaviourType
    {
        PlayerCharacterBehaviour,
        BoarBehaviour,
        DinoBotBehaviour,
        RandomBehaviour
    }

    public abstract class Behaviour
    {
        public class NpcAction
        {
            private readonly ICombatCharacter player;
            private readonly List<ICombatCharacter> targets;
            private readonly IAbility ability;

            public NpcAction(ICombatCharacter player, List<ICombatCharacter> targets, IAbility ability)
            {
                this.player = player;
                this.targets = targets;
                this.ability = ability;
            }

            public CombatEvent Perform()
            {
                return ability.Apply(player, targets);
            }
        }

        public virtual NpcAction ChooseAction(CombatState combat)
        {
            return null;
        }

        public static Behaviour ForCharacterDefinition(ICharacterBaseState characterDefinition)
        {
            return null;
        }
    }

}