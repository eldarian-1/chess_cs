namespace Rules
{
    public class Round
    {
        private Board m_Board;
        private IReferee m_Referee;

        public Round(IReferee referee)
        {
            m_Board = new Board();
            m_Referee = referee;
        }

        public void Move(Path path)
        {
            if (!m_Board.IsMoveAvailable(path))
                m_Referee.MoveNotAvailable();
        }
    }
}
