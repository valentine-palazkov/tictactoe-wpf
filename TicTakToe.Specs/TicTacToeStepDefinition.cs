using FluentAssertions.Assertions;
using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    [Binding]
    public class TicTacToeStepDefinition
    {
        [Given(@"board:")]
        public void GivenField(Table table)
        {
            TicTacToeScenarioContext.Board = table.Rows.ToGameField();
        }


        [When(@"try to update board with:")]
        public void WhenTryToUpdateFieldWith(Table table)
        {
            table.Rows.Update(TicTacToeScenarioContext.Board);
        }

        [Then(@"the board should be:")]
        public void ThenTheResultShouldBe(Table table)
        {
            TicTacToeScenarioContext.Board.Should().Match(table.Rows);
        }
    }
}