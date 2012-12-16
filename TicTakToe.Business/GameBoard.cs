using System.Collections.Generic;
using System.Linq;

namespace TicTakToe.Business
{
    public class GameBoard
    {
        private readonly List<Cell> _cells = new List<Cell>();

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

        public Cell this[Row row, Column column]
        {
            get
            {
                return
                    (from cell in _cells where cell.Move.Column == column && cell.Move.Row == row select cell).Single();
            }
        }

        public void MakeMove(IGameMove move)
        {
            this[move.Row, move.Column].Accept(move);
        }
    }
}