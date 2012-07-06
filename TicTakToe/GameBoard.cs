using System.Collections.Generic;

namespace TicTakToe
{
    public class GameBoard
    {
        private readonly List<List<IBoardCell>> cells = new List<List<IBoardCell>>();
        private IBoardCell previousMove = BoardCellSafeNull.Instance;

        public GameBoard()
        {
            cells.Add(new List<IBoardCell> {BoardCellSafeNull.Instance, BoardCellSafeNull.Instance, BoardCellSafeNull.Instance});
            cells.Add(new List<IBoardCell> {BoardCellSafeNull.Instance, BoardCellSafeNull.Instance, BoardCellSafeNull.Instance});
            cells.Add(new List<IBoardCell> {BoardCellSafeNull.Instance, BoardCellSafeNull.Instance, BoardCellSafeNull.Instance});
        }

        public IBoardCell this[int x, int y]
        {
            get { return cells[y][x]; }
        }

        public void Initialize(int x, int y, IBoardCell cell)
        {
            var boardCells = cells[y];
            boardCells[x] = cell;
        }

        public void Move(int x, int y, IBoardCell cell)
        {
            if (!previousMove.IsNull && (cell.GetType() == previousMove.GetType()))
            {
                return;
            }

            var boardCells = cells[y];
            if (!boardCells[x].IsNull)
                return;

            boardCells[x] = cell;

            previousMove = cell;
        }

        public void SetLastMove(int x, int y)
        {
            previousMove = cells[x][y];
        }
    }

    public class BoardCellSafeNull : SafeNull<IBoardCell, BoardCellSafeNull>, IBoardCell
    {
        public override string ToString()
        {
            return string.Empty;
        }

        public bool IsNull
        {
            get { return true; }
        }
    }

    public interface IBoardCell : INullable
    {
    }

    public interface INullable
    {
        bool IsNull { get; }
    }

    public class SafeNull<T, TSafeNull> where TSafeNull : T, new()
    {
        public static readonly T Instance = new TSafeNull();
    }
}