using Rules.Figures.Pathing;
using System.Collections.Generic;

namespace Rules.Figures
{
    public class King : AFigure
    {
        public King(bool white) : base(white) { }

        protected override IEnumerable<Point> ClearPoints(Path path)
        {
            return new PathDetermining(path).King().Points;
        }

        protected override bool IsRight(Path path)
        {
            return new WalkingRules(path).King();
        }
    }
}
