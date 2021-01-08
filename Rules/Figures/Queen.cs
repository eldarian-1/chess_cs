using Rules.Figures.Pathing;
using System.Collections.Generic;

namespace Rules.Figures
{
    public class Queen : AFigure
    {
        public Queen(bool white) : base(white) { }

        protected override IEnumerable<Point> ClearPoints(Path path)
        {
            return new PathDetermining(path).Queen().Points;
        }

        protected override bool IsRight(Path path)
        {
            return new WalkingRules(path).Queen();
        }
    }
}
