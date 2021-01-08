using Rules.Figures;

namespace Rules
{
    public class Board
    {
        private IFigure[,] m_Figures;

        public Board()
        {
            m_Figures = new IFigure[8, 8];

            m_Figures[0, 0] = new Rook();
            m_Figures[0, 7] = new Rook();
            m_Figures[0, 1] = new Horse();
            m_Figures[0, 6] = new Horse();
            m_Figures[0, 2] = new Elephant();
            m_Figures[0, 5] = new Elephant();
            m_Figures[0, 3] = new Queen();
            m_Figures[0, 4] = new King();
            for (int i = 0; i < 8; ++i)
                m_Figures[1, i] = new Pawn();

            m_Figures[7, 0] = new Rook();
            m_Figures[7, 7] = new Rook();
            m_Figures[7, 1] = new Horse();
            m_Figures[7, 6] = new Horse();
            m_Figures[7, 2] = new Elephant();
            m_Figures[7, 5] = new Elephant();
            m_Figures[7, 3] = new Queen();
            m_Figures[7, 4] = new King();
            for (int i = 0; i < 8; ++i)
                m_Figures[6, i] = new Pawn();
        }

        public IFigure this[Point point]
        {
            get => m_Figures[point.Y, point.X];
            set => m_Figures[point.Y, point.X] = value;
        }

        public bool IsMoveAvailable(Path path)
        {
            return this[path.From].CanGo(path);
        }
    }
}
