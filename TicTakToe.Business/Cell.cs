using System;

namespace TicTakToe.Business
{
    public class Cell : ICell
    {
        private Action<IGameMove> AcceptNewMove;

        public Cell(int row, int column)
        {
            Move = new NoMove(row, column);

            AcceptNewMove = delegate(IGameMove move)
                {
                    Move = move;
                    AcceptNewMove = gameMove => { };
                };
        }

        public IGameMove Move { get; private set; }

        public void Accept(IGameMove move)
        {
            AcceptNewMove(move);
        }

        public override string ToString()
        {
            return Move.ToString();
        }
    }
}