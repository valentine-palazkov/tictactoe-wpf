namespace TicTakToe
{
    public abstract class GameMove : IGameMove
    {
        protected readonly int X;
        protected readonly int Y;

        protected GameMove(int x, int y)
        {
            X = x;
            Y = y;
        }

        #region IGameMove Members

        public bool IsNull
        {
            get { return false; }
        }

        public bool AlreadyMadeOn(GameBoard board)
        {
            return board[X, Y] == this;
        }

        public override string ToString()
        {
            return string.Format("'{0}' at ({1}, {2})", View, X, Y);
        }

        #endregion

        public void Execute(GameBoard board)
        {
            board.MakeMove(this, X, Y);
        }


        public abstract string View { get; }
    }
}