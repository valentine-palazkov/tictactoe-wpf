namespace TicTakToe
{
    public abstract class GameMove : IGameMove
    {
        protected GameMove(int column, int row)
        {
            Column = column;
            Row = row;
        }

        #region IGameMove Members

        public bool IsNull
        {
            get { return false; }
        }

        public bool AlreadyMadeOn(GameBoard board)
        {
            Cell cell = board[Row, Column];
            return cell.Move.GetType() == GetType();
        }

        public int Column { get; private set; }
        public int Row { get; private set; }

        public override string ToString()
        {
            return string.Format("'{0}' at ({1}, {2})", View, Column, Row);
        }

        #endregion

        protected abstract string View { get; }

        public void Execute(GameBoard board)
        {
            board.MakeMove(this);
        }
    }
}