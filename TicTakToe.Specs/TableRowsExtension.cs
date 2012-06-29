using System;
using System.Linq;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    public static class TableRowsExtension
    {
        public static GameBoard ToGameField(this TableRows theRows)
        {
            var board = new GameBoard();
            theRows.Update(board);

            return board;
        }

        public static void Update(this TableRows theRows, GameBoard board)
        {
            for (int y = 0; y < theRows.Count; y++)
            {
                string[] row = theRows[0].Values.ToArray();
                for (int x = 0; x < row.Length; x++)
                {
                    board[x, y] = CreateCell(row[x]);
                }
            }

        }

        private static BoardCell CreateCell(string cellChar)
        {
            switch (cellChar.ToLower())
            {
                case "x":
                    return new TickedCell();
                case "0":
                    return new TackedCell();
                default:
                    return new EmptyCell();
            }
        }
    }
}