using System.Collections.Generic;
using FluentAssertions.Assertions;
using FluentAssertions.Primitives;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    public class GameBoardAssertions : ReferenceTypeAssertions<TableRows, GameBoardAssertions>
    {
        private readonly GameBoard _board;

        public GameBoardAssertions(GameBoard board)
        {
            _board = board;
        }

        public void Match(IEnumerable<IGameMove> moves)
        {
            foreach (var move in moves)
            {
                Assert.That(move.AlreadyMadeOn(_board), Is.True, "Move {0} is not done", move);
            }
        }
    }
}