using System.Collections.Generic;
using System.Linq;

namespace TicTakToe.Business
{
    public class BoardBrowser
    {
        private readonly ICell _cell;
        private readonly GameBoard _gameBoard;

        public BoardBrowser(ICell cell, GameBoard gameBoard)
        {
            _cell = cell;
            _gameBoard = gameBoard;
        }

        public CellCollection Right(int cellAmount = 1)
        {
            var cells = new List<ICell> { _cell };
            cells.AddRange(Enumerable.Range(1, cellAmount).Select(x => _gameBoard[_cell.Move.Row, _cell.Move.Column + x]));

            return new CellCollection(cells);
        }

        public CellCollection Down(int cellAmount = 1)
        {
            var cells = new List<ICell> { _cell };
            cells.AddRange(Enumerable.Range(1, cellAmount).Select(y => _gameBoard[_cell.Move.Row + y, _cell.Move.Column]));

            return new CellCollection(cells);
        }

        public CellCollection Diagonal(int cellAmount)
        {
            var cells = new List<ICell> { _cell };
            cells.AddRange(Enumerable.Range(1, cellAmount).Select(xy => _gameBoard[_cell.Move.Row + xy, _cell.Move.Column + xy]));

            return new CellCollection(cells);
        }
    }
}