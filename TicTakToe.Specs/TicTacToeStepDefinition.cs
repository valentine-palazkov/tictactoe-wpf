using System.Linq;
using FluentAssertions.Assertions;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    [Binding]
    public class TicTacToeStepDefinition
    {
        [Given(@"board:")]
        public void GivenBoard(Table table)
        {
            var steps = table.Rows.ParseMoves();
	        steps.Count().Should();
            //steps.Count().Should().Be(9);

            var board = new GameBoard();
            TicTacToeScenarioContext.Board = board;
            var game = new Game(board);
            game.Make(steps.ToArray());
            TicTacToeScenarioContext.Game = game;
        }

        [StepDefinition(@"try to put a tac at \{(.*), (.*)\}")]
        public void WhenTryPutTacAt(int row, int column)
        {
            var move = new TacMove(column, row);
            TicTacToeScenarioContext.Game.Make(move);
        }

        [Then(@"the board should be:")]
        public void ThenTheResultShouldBe(Table table)
        {
            var steps = table.Rows.ParseMoves();
            TicTacToeScenarioContext.Board.Should().Match(steps);
        }
    }
}