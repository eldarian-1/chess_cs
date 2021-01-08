using System.Collections.Generic;

namespace Rules.Figures
{
    public abstract class AFigure : IFigure
    {
        public bool IsWhite { get; private set; }

        protected AFigure(bool white)
        {
            IsWhite = white;
        }

        protected abstract bool IsRight(Path path);

        protected abstract IEnumerable<Point> ClearPoints(Path path);

        private bool IsClearPoints(IEnumerable<Point> points)
        {
            return true;
        }

        public bool CanGo(Path path)
        {
            return IsRight(path) && IsClearPoints(ClearPoints(path));
        }

        public IEnumerable<Point> AvailablePoints(Point from)
        {
            for(int i = 0; i < 8; ++i)
                for(int j = 0; j < 8; ++j)
                {
                    Point to = new Point(i, j);
                    if (CanGo(new Path(from, to)))
                        yield return to;
                }
        }
    }
}
