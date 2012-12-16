namespace TicTakToe.Business
{
    public interface IGameMove
    {
        void Execute(GameBoard board);
        bool AlreadyMadeOn(GameBoard board);
        Column Column { get; }
        Row Row { get; }
    }
}