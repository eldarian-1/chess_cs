using System.Collections.Generic;

namespace Rules.Figures.Pathing
{
    internal class PathDetermining : Pathing
    {
        public IEnumerable<Point> Points { get; private set; }

        public PathDetermining(Path path) : base(path)
        {
            Points = new List<Point>();
        }

        public PathDetermining Pawn()
        {
            return this;
        }

        public PathDetermining Rook()
        {
            return this;
        }

        public PathDetermining Horse()
        {
            return this;
        }

        public PathDetermining Elephant()
        {
            return this;
        }

        public PathDetermining Queen()
        {
            Rook();
            Elephant();
            return this;
        }

        public PathDetermining King()
        {
            return this;
        }
    }
}
