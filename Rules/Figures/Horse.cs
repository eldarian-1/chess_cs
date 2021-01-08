using Rules.Figures.Pathing;
using System.Collections.Generic;

namespace Rules.Figures
{
    public class Horse : AFigure
    {
        public Horse(bool white) : base(white) { }

        protected override IEnumerable<Point> ClearPoints(Path path)
        {
            return new PathDetermining(path).Horse().Points;
        }

        protected override bool IsRight(Path path)
        {
            return new WalkingRules(path).Horse();
        }
    }
}
