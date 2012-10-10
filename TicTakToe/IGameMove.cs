namespace TicTakToe
{
    public interface IGameMove : INullable
    {
        void Execute(GameBoard board);
    }
}