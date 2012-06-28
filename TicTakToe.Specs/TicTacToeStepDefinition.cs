using FluentAssertions;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    [Binding]
    public class TicTacToeStepDefinition
    {
        [Given(@"board:")]
        public void GivenField(Table table)
        {
            GameBoard field = table.Rows.ToGameField();
            TicCacToeScenarioContext.Board = field;
        }

        [Then(@"the board should be:")]
        public void ThenTheResultShouldBe(Table table)
        {
            TicCacToeScenarioContext.Board.Should().Match(table.Rows);
            TicCacToeScenarioContext.Board.Should().Be(table.Rows);
        }

        [When(@"try to update board with:")]
        public void WhenTryToUpdateFieldWith(Table table)
        {
            table.Rows.Update(TicCacToeScenarioContext.Board);
        }
    }
}