namespace TicTakToe
{
    public class MoveSafeNull : SafeNull<IGameMove, MoveSafeNull>, IGameMove
    {
        public override string ToString()
        {
            return string.Empty;
        }

        public bool IsNull
        {
            get { return true; }
        }

        public void Execute(GameBoard board)
        {
        }

        public bool AlreadyMadeOn(GameBoard board)
        {
            return true;
        }

        public string View
        {
            get { return " "; }
        }
    }
}