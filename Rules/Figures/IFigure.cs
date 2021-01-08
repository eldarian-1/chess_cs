using System.Collections.Generic;

namespace Rules.Figures
{
    public interface IFigure
    {
        bool IsWhite { get; }

        bool CanGo(Path path);

        IEnumerable<Point> AvailablePoints(Point from);
    }
}
