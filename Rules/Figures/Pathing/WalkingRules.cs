namespace Rules.Figures.Pathing
{
    internal class WalkingRules : Pathing
    {
        public WalkingRules(Path path) : base(path) { }

        public bool IsPawnPath()
        {
            return true;
        }

        public bool IsRookPath()
        {
            return true;
        }

        public bool IsHorsePath()
        {
            return true;
        }

        public bool IsElephantPath()
        {
            return true;
        }

        public bool IsQueenPath()
        {
            return true;
        }

        public bool IsKingPath()
        {
            return true;
        }
    }
}
