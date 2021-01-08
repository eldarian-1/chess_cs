using Rules.Figures.Pathing;
using System.Collections.Generic;

namespace Rules.Figures
{
    public class Rook : AFigure
    {
        public Rook(bool white) : base(white) { }

        protected override IEnumerable<Point> ClearPoints(Path path)
        {
            return new PathDetermining(path).Rook().Points;
        }

        protected override bool IsRight(Path path)
        {
            return new WalkingRules(path).Rook();
        }
    }
}
