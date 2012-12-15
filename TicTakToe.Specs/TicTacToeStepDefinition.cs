using System.Collections.Generic;
using FluentAssertions.Assertions;
using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    [Binding]
    public class TicTacToeStepDefinition
    {
        [BeforeScenario("EmptyBoard")]
        public void EmptyBoard()
        {
            var board = new GameBoard();
            TicTacToeScenarioContext.Board = board;

            var game = new Game(board);
            TicTacToeScenarioContext.Game = game;
        }

        [Given(@"gamer puts '(.*)' at \{(.*), (.*)}")]
        [When(@"gamer tries to put '(.*)' at \{(.*), (.*)}")]
        public void WhenTryToPutAt(char moveType, int row, int column)
        {
            IGameMove move;
            switch (moveType)
            {
                case 'x':
                    move = new TickMove(row, column);
                    break;
                case '0':
                    move = new TacMove(row, column);
                    break;
                default:
                    move = new NoMove(row, column);
                    break;
            }

            TicTacToeScenarioContext.Game.Make(move);
        }

        [Then(@"the board should be:")]
        public void ThenTheResultShouldBe(Table table)
        {
            IEnumerable<IGameMove> steps = table.ParseMoves();
            TicTacToeScenarioContext.Board.Should().Match(steps);
        }
    }
}