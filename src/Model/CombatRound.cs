

namespace DSLApp1.Model
{
    public class CombatRound
    {
        private readonly Queue<ICombatCharacter> turnQueue = new();
        private readonly List<ICombatCharacter> turnList = new();
        public int CurrentRoundNo = 1;
        public int TurnsPerRound = 12;
        public List<ICombatCharacter> TurnList => turnList;

        public CombatRound() {}

        public void BuildTurnQueue(List<ICombatCharacter> characters)
        {
            turnQueue.Clear();
            turnList.Clear();

            if (characters.Count == 0)
                throw new Exception("Must be at least one character");

            float cumulativeInitiative = 0.0f;
            foreach (var character in characters)
            {
                if (!character.CombatStateManager.IsActive)
                    continue;

                var stats = character.CombatStateManager;
                if (stats.GetBuffedStat(Stat.Initiative) == 0)
                    throw new Exception($"{character.Name} Initiative cannot be zero");

                cumulativeInitiative += stats.GetBuffedStat(Stat.Initiative);
            }

            float averageInitiative = cumulativeInitiative / characters.Count;
            float[] accumulatedInitiative = new float[characters.Count];

            for (int i = 0; i < 100; i++)
            {
                for (int idx = 0; idx < characters.Count; idx++)
                {
                    var character = characters[idx];
                    if (!character.CombatStateManager.IsActive)
                        continue;

                    var stats = character.CombatStateManager;
                    accumulatedInitiative[idx] += 1 + (stats.GetBuffedStat(Stat.Initiative) / averageInitiative);
                    if (accumulatedInitiative[idx] > 100)
                    {
                        accumulatedInitiative[idx] -= 100;
                        if (stats.IsActive)
                        {
                            turnQueue.Enqueue(character);
                            turnList.Add(character);
                        }
                    }
                }
            }
            SyncIndicator();
        }

        private void SkipInactiveTurns()
        {
            while (turnQueue.Count > 0 && !turnQueue.Peek().CombatStateManager.IsActive)
            {
                var inactiveCharacter = turnQueue.Dequeue();
                turnList.Remove(inactiveCharacter);
            }
        }

        public ICombatCharacter GetCurrentTurn()
        {
            SkipInactiveTurns();
            if (turnQueue.Count > 0)
                return turnQueue.Peek();
            else
                throw new InvalidOperationException("No turns available.");
        }


        public bool HasActiveTurn()
        {
            SkipInactiveTurns();
            return turnQueue.Count > 0;
        }

        public void RemoveCharacterFromFutureTurns(ICombatCharacter character)
        {
            bool modified = false;

            // Remove from queue
            var tempQueue = new Queue<ICombatCharacter>();
            while (turnQueue.Count > 0)
            {
                var c = turnQueue.Dequeue();
                if (c != character)
                    tempQueue.Enqueue(c);
                else
                    modified = true;
            }
            while (tempQueue.Count > 0)
                turnQueue.Enqueue(tempQueue.Dequeue());

            // Remove from list
            modified |= turnList.Remove(character);

            if (modified)
            {
                SyncIndicator();
            }
        }
        
        private void SyncIndicator()
        {
        }
    }
}
