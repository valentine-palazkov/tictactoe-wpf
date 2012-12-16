using System;

namespace TicTakToe.Business
{
    public class Cell
    {
        private Action<IGameMove> AcceptNewMove;
        private IGameMove _move;

        public Cell(int row, int column)
        {
            _move = new NoMove(row, column);

            AcceptNewMove = delegate(IGameMove move)
                {
                    _move = move;
                    AcceptNewMove = gameMove => { };
                };
        }

        public IGameMove Move
        {
            get { return _move; }
        }

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