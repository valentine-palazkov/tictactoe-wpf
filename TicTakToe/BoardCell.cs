namespace TicTakToe
{
    public abstract class GameMove : IGameMove
    {
        private readonly int x;
        private readonly int y;

        protected GameMove(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract override string ToString();

        public bool IsNull
        {
            get { return false; }
        }

        public abstract void Execute(GameBoard board);
    }
}