namespace Rules.Figures.Pathing
{
    internal abstract class Pathing
    {
        protected int h0;
        protected int v0;
        protected int h1;
        protected int v1;

        public Pathing(Path path)
        {
            h0 = path.From.X;
            v0 = path.From.Y;
            h1 = path.To.X;
            v1 = path.To.Y;
        }
    }
}
