namespace TicTakToe.Business
{
    public class CellSafeNull : ICell
    {
        public CellSafeNull()
        {
            Move = GameMoveSafeNull.Instance;
        }

        public IGameMove Move { get; private set; }

        public void Accept(IGameMove move)
        {
        }
    }
}