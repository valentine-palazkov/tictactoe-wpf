namespace TicTakToe.Business
{
    public interface ICell
    {
        IGameMove Move { get; }
        void Accept(IGameMove move);
        string ToString();
    }
}