namespace DSLApp1.Model;

public record CombatState
{
    public enum Phase
    {
        Unstarted,
        StartingCombat,
        StartingRound,
        StartingTurn,
        WaitingForPlayer,
        ApplyingModifiers,
        EndingTurn,
        EndingRound,
        CombatEnding,
        CombatEnded,
    }

    public CombatState.Phase CurrentPhase = Phase.Unstarted;
    public CombatState.Phase LastPhase = Phase.Unstarted;
    public List<ICombatCharacter> Characters;
    public CombatRound Round;

    public ICombatCharacter CurrentICombatCharacter => Round.GetCurrentTurn();

    public CombatState(List<ICombatCharacter> characters, CombatRound round)
    {
        CurrentPhase =  Phase.Unstarted;
        LastPhase =  Phase.Unstarted;
        Characters = characters;
        Round = round;
    }
}