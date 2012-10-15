using System.Linq;
using FluentAssertions;
using FluentAssertions.Assertions;
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
            TicTacToeScenarioContext.Board.Should().Match(table.Rows);
        }
    }
}