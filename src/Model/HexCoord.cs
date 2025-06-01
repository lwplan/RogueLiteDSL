namespace DSLApp1.Model
{
    [System.Serializable]
    public struct HexCoord : IEquatable<HexCoord>, IComparable<HexCoord>
    {
        public int q; // Column coordinate
        public int r; // Row coordinate
        public int s { get { return -q - r; } }    // s is computed as -q - r
        
        public HexCoord(int q, int r)
        {
            this.q = q;
            this.r = r;
        }
        

        public static float size = 1.0f;

        public enum FaceDirection : int
        {
            TopRight = 0,
            TopLeft = 1,
            Left = 2,
            BottomLeft = 3,
            BottomRight = 4,
            Right = 5,
        }

        public enum VertexDirection
        {
            Top = 0,
            TopRight = 1,
            BottomRight = 2,
            Bottom = 3,
            BottomLeft = 4,
            TopLeft = 5
        }


#if UNITY_RUNTIME
        public Vector2 Position(float sideLength)
        {
            float sqrt3 = Mathf.Sqrt(3f);
            float xPos = sideLength * (q * sqrt3 + r * sqrt3 / 2f);
            float yPos = sideLength * (r * 1.5f);
            return new Vector2(xPos, yPos);
        }


        public Rect BoundingBox(float sideLength) {
            Vector2 center = Position(sideLength);
            float height = sideLength * 2;
            float width = height * Mathf.Sqrt(3f) / 2f;
            return new Rect(center.x,center.y,width,height);
        }

        public Vector2 PositionWithScale(float scale)
        {
            var position_ = Position(size);
            return new Vector2(position_.x * scale,  position_.y * scale);
        }

        Vector2 HexCornerOffset(int corner)
        {
            float angle = 60 * corner + 30;
            angle *= Mathf.Deg2Rad;
            return new Vector3(Mathf.Cos(angle), Mathf.Sin(angle));
        }


        public Vector2 GetVertexPosition(VertexDirection direction)
        {
            return Position(size) + HexCornerOffset((int)direction);
        }


        public HexCoord GetRandomNeighbor()
        {
            List<HexCoord> neighbours = GetNeighborCoords();
            return neighbours[UnityEngine.Random.Range(0, neighbours.Count)];
        }
        public (Vector3, Vector3) GetEdgeVertices(FaceDirection face)
        {
            Vector3 startPosition = GetVertexPosition((VertexDirection)face);
            Vector3 endPosition = GetVertexPosition((VertexDirection)(((int)face + 1) % 6));
            return (startPosition, endPosition);
        }

#endif
        public HexCoord RotateClockwise()
        {
            int newQ = -s;
            int newR = -q;
            return new HexCoord(newQ, newR);
        }

        public HexCoord RotateAnticlockwise()
        {
            int newQ = -r;
            int newR = -s;
            return new HexCoord(newQ, newR);
        }
        
        public void Translate(HexCoord hexCoord)
        {
            q += hexCoord.q;
            r += hexCoord.r;
        }

        public static HexCoord operator -(HexCoord hex)
        {
            return new HexCoord(-hex.q, -hex.r);
        }

        public HexCoord GetAdjacentCoord(FaceDirection face)
        {
            switch (face)
            {
                case FaceDirection.TopRight: return new HexCoord(q, r + 1);
                case FaceDirection.Right: return new HexCoord(q + 1, r);
                case FaceDirection.BottomRight: return new HexCoord(q + 1, r - 1);
                case FaceDirection.BottomLeft: return new HexCoord(q, r - 1);
                case FaceDirection.Left: return new HexCoord(q - 1, r);
                case FaceDirection.TopLeft: return new HexCoord(q - 1, r + 1);
                default: throw new ArgumentOutOfRangeException(nameof(face), "Invalid face direction");
            }
        }



        public HexCoord TranslateN() {
            if (this.r % 2 == 0) {
                return this.TranslateNE();
            } else {
                return this.TranslateNW();
            }
        }

        public HexCoord TranslateS() {
            if (this.r % 2 == 0) {
                return this.TranslateSE();
            } else {
                return this.TranslateSW();
            }
        }

        public HexCoord TranslateNE() {
            return new HexCoord(q,r+1);
        }

        public HexCoord TranslateNW() {
            return new HexCoord(q-1,r+1);
        }

        public HexCoord TranslateE() {
            return new HexCoord(q+1,r);
        }

        public HexCoord TranslateSE() {
            return new HexCoord(q+1,r-1);
        }

        public HexCoord TranslateSW() {
            return new HexCoord(q,r-1);
        }
        public HexCoord TranslateW() {
            return new HexCoord(q-1,r);
        }

        
        // Instance method to get neighboring coordinates
        public List<HexCoord> GetNeighborCoords()
        {
            return new List<HexCoord>
            {
                new HexCoord(q + 1, r),
                new HexCoord(q - 1, r),
                new HexCoord(q, r + 1),
                new HexCoord(q, r - 1),
                new HexCoord(q + 1, r - 1),
                new HexCoord(q - 1, r + 1)
            };
        }

        
        public override bool Equals(object obj)
        {
            return obj is HexCoord coord && Equals(coord);
        }

        public bool Equals(HexCoord other)
        {
            return q == other.q && r == other.r;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(q, r);
        }
    
        // Implement IComparable<HexCoord> to allow consistent sorting
        public int CompareTo(HexCoord other)
        {
            // First compare q values, then r values if necessary.
            int compareQ = q.CompareTo(other.q);
            if (compareQ != 0)
            {
                return compareQ;
            }
            return r.CompareTo(other.r);
        }
    }

}
