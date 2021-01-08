﻿using Rules.Figures.Pathing;
using System.Collections.Generic;

namespace Rules.Figures
{
    public class Pawn : AFigure
    {
        protected override IEnumerable<Point> ClearPoints(Path path)
        {
            return new PathDetermining(path).ElephantPoints();
        }

        protected override bool IsRight(Path path)
        {
            return new WalkingRules(path).IsElephantPath();
        }
    }
}
