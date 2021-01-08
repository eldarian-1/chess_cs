namespace Rules
{
    public class Path
    {
        public Point From { get; private set; }

        public Point To { get; private set; }

        public Path(Point from, Point to)
        {
            From = from;
            To = to;
        }
    }
}
