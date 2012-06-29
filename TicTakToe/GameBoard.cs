using System.Collections.Generic;

namespace TicTakToe
{
    public class GameBoard
    {
        private readonly List<BoardCell[]> cells = new List<BoardCell[]>();

        public GameBoard()
        {
            cells.Add(new[] { new EmptyCell(), new EmptyCell(), new EmptyCell() });
            cells.Add(new[] { new EmptyCell(), new EmptyCell(), new EmptyCell() });
            cells.Add(new[] { new EmptyCell(), new EmptyCell(), new EmptyCell() });
        }

        public BoardCell this[int x, int y]
        {
            get { return cells[x][y]; }
            set { cells[x][y] = value; }
        }
    }
}