namespace DSLApp1.Model
{
    // For HexCoord, HexPieceDefinition, etc.

    [Serializable]
    public class BoardState
    {
        private List<HexCoord> boardCoordinates;
        private List<HexPiece> hexPieces = new();

        public BoardState(int range)
        {
            boardCoordinates = GenerateBoardCoordinates(range);
        }

        public List<HexCoord> BoardCoordinates => boardCoordinates;
        public List<HexPiece> HexPieces => hexPieces;
        
        public static List<HexCoord> GenerateBoardCoordinates(int range)
        {
            var coords = new List<HexCoord>();
            for (int q = -range; q <= range; q++)
            {
                int r1 = Math.Max(-range, -q - range);
                int r2 = Math.Min(range, -q + range);
                for (int r = r1; r <= r2; r++)
                {
                    coords.Add(new HexCoord(q, r));
                }
            }
            return coords;
        }

        public void AddHexPiece(HexPiece getHexPiece)
        {
            hexPieces.Add(getHexPiece);
            // Log.Info($"Added Hex Piece: {getHexPiece.Name}");
            // Log.Info($"Board includes Hex Piece: {string.Join(", ", hexPieces.Select(h => h.Name))}");

        }

        public void RemoveHexPiece(HexPiece getHexPiece)
        {
            hexPieces.Remove(getHexPiece);
            // Log.Info($"Removed Hex Piece: {getHexPiece.Name}");
            //
            // Log.Info($"Board includes Hex Piece: {string.Join(", ", hexPieces.Select(h => h.Name))}");

        }
    }
}