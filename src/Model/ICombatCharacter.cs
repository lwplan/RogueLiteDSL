

namespace DSLApp1.Model
{
    public interface ICombatCharacter 
    {
        string Name { get; }
        
        // a monobehaviour
        ICharacterCombatState CombatStateManager { get; }
        Behaviour Behaviour { get;  }

        void OnCombatStart();
        bool IsNpc();
    }
}