using Rules.Figures.Pathing;
using System.Collections.Generic;

namespace Rules.Figures
{
    public class Pawn : AFigure
    {
        public Pawn(bool white) : base(white) { }

        protected override IEnumerable<Point> ClearPoints(Path path)
        {
            return new PathDetermining(path).Pawn().Points;
        }

        protected override bool IsRight(Path path)
        {
            return new WalkingRules(path).Pawn(IsWhite);
        }
    }
}
