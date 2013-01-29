using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using FluentAssertions.Assertions;
using TechTalk.SpecFlow;
using TicTakToe.Business;

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

        [When(@"gamer tries to put '(.*)' at \{(.*), (.*)}")]
        public void WhenTryToPutAt(char moveType, int row, int column)
        {
            try
            {
                WhenPutAt(moveType, row, column);
            }
            catch (RuleViolationException e)
            {
                TicTacToeScenarioContext.RuleViolationException = e;
            }
            catch
            {
                
            }
            
        }

        [StepDefinition(@"gamer puts '(.*)' at \{(.*), (.*)}")]
        public void WhenPutAt(char moveType, int row, int column)
        {
            IGameMove move = moveType.ParseStep(row, column);
            TicTacToeScenarioContext.Game.Make(move);
        }

		[StepDefinition(@"gamer makes a move at \{(.*), (.*)}")]
		public void GivenGamerMakesAMoveAt(int row, int column)
		{
			TicTacToeScenarioContext.Game.Make(row, column);
		}

        [Given(@"board is:")]
        public void GivenBoardIs(Table table)
        {
            IEnumerable<IGameMove> steps = table.ParseMoves().Where(x => x.GetType() != typeof(NoMove));
            TicTacToeScenarioContext.Board.Restore(steps);
        }

        [Then(@"the board should be:")]
        public void ThenTheResultShouldBe(Table table)
        {
            IEnumerable<IGameMove> steps = table.ParseMoves();
            TicTacToeScenarioContext.Board.Should().Match(steps);
        }


        [Then(@"rule violated should be '(.*)'")]
        public void ThenRuleViolatedShouldBe(string rule)
        {
            TicTacToeScenarioContext.RuleViolationException.Message.TrimEnd('\r', '\n') .Should()
                                    .Be(rule);
        }

        [Then(@"the game completed")]
        public void ThenTheGameCompleted()
        {
            TicTacToeScenarioContext.Game.IsCompleted.Should().Be(true);
        }
    }
}