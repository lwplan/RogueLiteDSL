
namespace DSLApp1.Model
{
    public interface ICharacterBaseState
    {
        public string CharacterName { get; }
        public Guid Id { get; }
        public string CharacterDescription { get; }
        public  BehaviourType BehaviourType { get; }
        int BaseHp { get; }
        int BaseAttack { get; }
        int BaseDefense { get; }
        int BaseIntelligence { get; }
        int BaseResistance { get; }
        int BaseInitiative { get; }
        int BaseMana { get; }
        int BaseManaPerTurn { get; }
        int BaseMaxOpportunityTurns { get; }
        IAbility PrimaryAbility { get; }
        IAbility OpportunityAbility { get; }
        List<IAbility> HexPieceAbilties { get; }
        
    }
}