namespace Rules.Figures.Pathing
{
    internal class Pathing
    {
        protected int fx;
        protected int fy;
        protected int tx;
        protected int ty;

        public Pathing(Path path)
        {
            fx = path.From.X;
            fy = path.From.Y;
            tx = path.To.X;
            ty = path.To.Y;
        }
    }
}
