using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using FluentAssertions.Assertions;
using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    public class GameBoardAssertions : ReferenceTypeAssertions<TableRows, GameBoardAssertions>
    {
        private readonly GameBoard board;

        public GameBoardAssertions(GameBoard board)
        {
            this.board = board;
        }

        public void Match(TableRows rows)
        {
            Subject = rows;

            for (int y = 0; y < rows.Count; y++)
            {
                string[] row = rows[0].Values.ToArray();
                for (int x = 0; x < row.Length; x++)
                {
                    board[x, y].ToString().Should().Be(row[x]);
                }
            }
            
        }
    }
}