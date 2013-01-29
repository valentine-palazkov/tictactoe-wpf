using System.Collections.Generic;
using System.Linq;

namespace TicTakToe.Business
{
    public class GameBoard
    {
        private readonly List<ICell> _cells = new List<ICell>();

        public GameBoard()
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    _cells.Add(new Cell(y, x));
                }
            }
        }

        public ICell this[Row row, Column column]
        {
            get
            {
                return
                    (from cell in _cells where cell.Move.Column == column && cell.Move.Row == row select cell)
                        .FirstOrDefault() ?? new CellSafeNull();
            }
        }

        public void MakeMove(IGameMove move)
        {
            this[move.Row, move.Column].Accept(move);
        }
    }
}