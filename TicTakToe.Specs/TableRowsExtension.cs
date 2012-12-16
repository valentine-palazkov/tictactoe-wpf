using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TicTakToe.Business;

namespace TicTakToe.Specs
{
    public static class TableRowsExtension
    {
        public static IEnumerable<IGameMove> ParseMoves(this Table theRows)
        {
            var moves = new List<IGameMove>();
            for (int rowIndex = 0; rowIndex < theRows.Rows.Count; rowIndex++)
            {
                string[] row = theRows.Rows[rowIndex].Values.ToArray();
                for (int columnIndex = 0; columnIndex < row.Length; columnIndex++)
                {
                    moves.Add(ParseStep(row[columnIndex].ToCharArray().FirstOrDefault(), rowIndex, columnIndex));
                }
            }

            return moves;
        }

        public static IGameMove ParseStep(this char cellChar, Row row, Column column)
        {
            switch (char.ToLower(cellChar))
            {
                case 'x':
                    return new TicMove(row, column);
                case '0':
                    return new TacMove(row, column);
                default:
                    return new NoMove(row, column);
            }
        }
    }
}