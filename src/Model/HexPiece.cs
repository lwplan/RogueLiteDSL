namespace DSLApp1.Model
{
    public class HexPiece
    {
        // Board-specific properties
        public int BoardIndex { get; set; }
        public HexCoord Offset { get; set; }
        public int Rotation { get; set; } = 0;
        public List<HexCoord> HexCoords { get; }

        public bool Unlocked { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string HexSignature { get; private set; }
        
        public Rarity Rarity { get; private set; }
        
        public List<Exclusivity> Exclusivities { get; private set; }
        public List<IModifier> Equips { get;  }
        public bool HasAbility => this.Ability != null;
        public IAbility Ability { get; }

        public HexPiece(Fragment fragment)
        {
            this.Unlocked = fragment.Unlocked;
            this.Name = fragment.Name;
            this.Description = fragment.Description;
            this.HexSignature = fragment.HexSignature;
            this.Rarity = fragment.Rarity;
            this.Exclusivities = fragment.Exclusivities;
            this.Equips = fragment.Equips;
            this.Ability = fragment.HasAbility ? fragment.Ability : null;
            this.Offset = new HexCoord(0, 0);
            this.Rotation = 0;
            this.BoardIndex = -1;
            // Use the fragment's HexSignature to generate the layout.
            this.HexCoords = GetCoordinatesFromSignature(fragment.HexSignature);
        }
        
        #if UNITY_RUNTIME
        public Color Color()
        {
            if (Ability is Ability ability)
            {
                return ability.Element.Color(); // Assume Element has a Color() method
            }
            return UnityEngine.Color.gray;
        }

#endif
        /// <summary>
        /// Converts a hex signature (a string of digits) into a list of HexCoord objects.
        /// Starts at the origin and for each digit moves to the corresponding neighbor.
        /// </summary>
        public static List<HexCoord> GetCoordinatesFromSignature(string signature)
        {
            List<HexCoord> hexCoords = new List<HexCoord> { new HexCoord(0, 0) };
            for (int i = 0; i < signature.Length; i++)
            {
                if (!char.IsDigit(signature[i]))
                    continue; // Skip any invalid characters
                int neighborIndex = signature[i] - '0';
                HexCoord lastCoord = hexCoords.Last();
                List<HexCoord> neighbors = lastCoord.GetNeighborCoords();
                if (neighborIndex >= 0 && neighborIndex < neighbors.Count)
                {
                    HexCoord newCoord = neighbors[neighborIndex];
                    if (!hexCoords.Contains(newCoord))
                        hexCoords.Add(newCoord);
                }
            }

            return hexCoords;
        }

        /// <summary>
        /// Generates a deterministic random hex piece signature given the number of hexes.
        /// The seed ensures that the same hexCount and seed always yield the same layout.
        /// </summary>
        public static string GenerateRandomHexPieceSignature(int hexCount, int seed = 0)
        {
            var hexCoords = new List<HexCoord> { new(0, 0) };
            string signature = "";
            System.Random rng = new System.Random(seed);
            for (int i = 1; i < hexCount; i++)
            {
                HexCoord baseCoord = hexCoords.Last();
                List<HexCoord> neighbors = baseCoord.GetNeighborCoords();
                int neighborIndex;
                HexCoord newCoord;
                do
                {
                    neighborIndex = rng.Next(0, neighbors.Count);
                    newCoord = neighbors[neighborIndex];
                } while (hexCoords.Contains(newCoord));

                signature += neighborIndex.ToString();
                hexCoords.Add(newCoord);
            }

            return signature;
        }


        public List<HexCoord> TransformedCoordinates()
        {
            var transformedCoords = new List<HexCoord>();
            var hexCoords = this.HexCoords;
            foreach (var coord in hexCoords)
            {
                HexCoord rotatedCoord = coord;
                for (var i = 0; i < Rotation; i++)
                {
                    rotatedCoord = rotatedCoord.RotateClockwise();
                }

                HexCoord transformedCoord = new HexCoord(rotatedCoord.q + Offset.q, rotatedCoord.r + Offset.r);
                transformedCoords.Add(transformedCoord);
            }

            return transformedCoords;
        }

        public bool FitsIn(List<HexCoord> other)
        {
            return TransformedCoordinates().All(coord => other.Contains(coord));
        }

        public bool IsSeparateFrom(HashSet<HexCoord> other)
        {
            return TransformedCoordinates().All(coord => !other.Contains(coord));
        }

        public bool IsCompatibleWith(ICharacterDefinition character)
        {
            if (Exclusivities.Contains(Exclusivity.Enemy))
            {
                if (character.BaseState.BehaviourType != BehaviourType.PlayerCharacterBehaviour) { return true; }
            }
            if (Exclusivities.Contains(Exclusivity.All))
            {
                return true;
            }
            switch (character.BaseState.CharacterName)
            {
                case "Knight": return Exclusivities.Contains(Exclusivity.Knight);
                case "Priestess": return Exclusivities.Contains(Exclusivity.Priestess);
                case "Beduin": return Exclusivities.Contains(Exclusivity.Beduin);
                default: return false;
            }
        }

        public string ExclusivityText()
        {
           return "Available To: " + string.Join(", ", Exclusivities);
        }
    }
}
