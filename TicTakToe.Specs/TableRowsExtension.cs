using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    public static class TableRowsExtension
    {
        public static IEnumerable<IGameMove> ParseMoves(this Table theRows)
        {
            var moves = new List<IGameMove>();
            for (int y = 0; y < theRows.Rows.Count; y++)
            {
                string[] row = theRows.Rows[y].Values.ToArray();
                for (int x = 0; x < row.Length; x++)
                {
                    moves.Add(ParseStep(row[x], x, y));
                }
            }

            return moves;
        }

        private static IGameMove ParseStep(string cellChar, int x, int y)
        {
            switch (cellChar.ToLower())
            {
                case "x":
                    return new TickMove(y, x);
                case "0":
                    return new TacMove(y, x);
                default:
                    return new NoMove(y, x);
            }
        }
    }
}