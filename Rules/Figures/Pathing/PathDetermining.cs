using System.Collections.Generic;

namespace Rules.Figures.Pathing
{
    internal class PathDetermining : Pathing
    {
        public PathDetermining(Path path) : base(path) { }

        public IEnumerable<Point> PawnPoints()
        {
            return null;
        }

        public IEnumerable<Point> RookPoints()
        {
            return null;
        }

        public IEnumerable<Point> HorsePoints()
        {
            return null;
        }

        public IEnumerable<Point> ElephantPoints()
        {
            return null;
        }

        public IEnumerable<Point> QueenPoints()
        {
            return null;
        }

        public IEnumerable<Point> KingPoints()
        {
            return null;
        }
    }
}
