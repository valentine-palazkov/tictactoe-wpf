using System.Collections.Generic;

namespace TicTakToe
{
    public class GameBoard
    {
        private readonly List<List<IGameMove>> _cells = new List<List<IGameMove>>();

        public GameBoard()
        {
            _cells.Add(new List<IGameMove> { MoveSafeNull.Instance, MoveSafeNull.Instance, MoveSafeNull.Instance });
            _cells.Add(new List<IGameMove> { MoveSafeNull.Instance, MoveSafeNull.Instance, MoveSafeNull.Instance });
            _cells.Add(new List<IGameMove> { MoveSafeNull.Instance, MoveSafeNull.Instance, MoveSafeNull.Instance });
        }

        public IGameMove this[int column, int row]
        {
            get { return _cells[row][column]; }
        }

        public void MakeMove(IGameMove move, int column, int row)
        {
            _cells[row][column] = move;
        }
    }
}