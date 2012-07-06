using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    public static class TableRowsExtension
    {
        public static GameBoard ToGameField(this TableRows theRows)
        {
            var board = new GameBoard();
            ModifyBoard(theRows, board, (gameBoard, x, y, cell) => board.Initialize(x, y, cell));
            return board;
        }

        public static void Update(this TableRows theRows, GameBoard board)
        {
            ModifyBoard(theRows, board, (gameBoard, x, y, cell) =>
                                            {
                                                if(board[x, y].GetType() != cell.GetType())
                                                    board.Move(x, y, cell);
                                            });
        }

        private static void ModifyBoard(TableRows theRows, GameBoard board, Action<GameBoard, int, int, IBoardCell> BoardCellApplyAction)
        {
            for (int y = 0; y < theRows.Count; y++)
            {
                string[] row = theRows[y].Values.ToArray();
                for (int x = 0; x < row.Length; x++)
                {
                    IBoardCell boardCell = CreateCell(row[x]);
                    BoardCellApplyAction(board, x, y, boardCell);
                }
            }
        }

        private static IBoardCell CreateCell(string cellChar)
        {
            switch (cellChar.ToLower())
            {
                case "x":
                    return new TickedCell();
                case "0":
                    return new TackedCell();
                default:
                    return BoardCellSafeNull.Instance;
            }
        }
    }
}