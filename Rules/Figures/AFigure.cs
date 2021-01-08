using System.Collections.Generic;

namespace Rules.Figures
{
    public abstract class AFigure : IFigure
    {
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
    }
}
