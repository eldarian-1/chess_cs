using System;

namespace Rules.Figures.Pathing
{
    internal class WalkingRules : Pathing
    {
        public WalkingRules(Path path) : base(path) { }

        public bool Pawn(bool white)
        {
            if (white)
                return h0 == h1 && (v0 == 1 && v1 == 3 || v1 - v0 == 1);
            else
                return h0 == h1 && (v0 == 6 && v1 == 4 || v0 - v1 == 1);
        }

        public bool Rook()
        {
            return v0 == v1 ^ h0 == h1;
        }

        public bool Horse()
        {
            return Math.Abs(v0 - v1) == 2 && Math.Abs(h0 - h1) == 1
                || Math.Abs(v0 - v1) == 1 && Math.Abs(h0 - h1) == 2;
        }

        public bool Elephant()
        {
            return v0 - v1 == h0 - h1 || v0 - v1 == h1 - h0;
        }

        public bool Queen()
        {
            return Rook() || Elephant();
        }

        public bool King()
        {
            return Math.Abs(v0 - v1) <= 1 && Math.Abs(h0 - h1) <= 1 && Queen();
        }
    }
}
