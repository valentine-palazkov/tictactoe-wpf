using System.Linq;
using FluentAssertions.Primitives;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TicTakToe.Business;

namespace TicTakToe.Specs
{
    public class GameBoardAssertions : ReferenceTypeAssertions<TableRows, GameBoardAssertions>
    {
        private readonly GameBoard _board;

        public GameBoardAssertions(GameBoard board)
        {
            _board = board;
        }

        public void Match(GameBoard moves)
        {
            var moveThatWeHave = _board.Select(x => x.Move.ToString()).ToArray();

            var notExpectedMoves = moveThatWeHave.Except(moves.Select(x => x.Move.ToString()).ToArray()).ToArray();

            Assert.That(notExpectedMoves, Is.Empty);
        }
    }
}