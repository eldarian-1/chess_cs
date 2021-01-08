using Rules.Figures.Pathing;
using System.Collections.Generic;

namespace Rules.Figures
{
    public class Elephant : AFigure
    {
        public Elephant(bool white) : base(white) { }

        protected override IEnumerable<Point> ClearPoints(Path path)
        {
            return new PathDetermining(path).Elephant().Points;
        }

        protected override bool IsRight(Path path)
        {
            return new WalkingRules(path).Elephant();
        }
    }
}
