namespace TicTakToe.Business
{
    public class GameMoveSafeNull : IGameMove
    {
        private static readonly IGameMove _instance = new GameMoveSafeNull();

        public GameMoveSafeNull()
        {
            Column = -1;
            Row = -1;
        }

        public static IGameMove Instance
        {
            get { return _instance; }
        }

        public void Execute(GameBoard board)
        {
        }

        public bool AlreadyMadeOn(GameBoard board)
        {
            return false;
        }

        public Column Column { get; private set; }
        public Row Row { get; private set; }
    }
}