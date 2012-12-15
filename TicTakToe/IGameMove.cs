namespace TicTakToe
{
    public interface IGameMove : INullable
    {
        void Execute(GameBoard board);
        bool AlreadyMadeOn(GameBoard board);
        int Column { get; }
        int Row { get; }
    }
}