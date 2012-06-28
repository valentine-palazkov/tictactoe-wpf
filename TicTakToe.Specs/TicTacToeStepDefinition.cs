using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    public static class TableRowsExtension
    {
        public static GameField ToGameField(this TableRows theRows)
        {
            var gameField = new GameField();

        }
    }

    public class GameField
    {
    }

    [Binding]
    public class TicTacToeStepDefinition
    {
        [Given(@"field:")]
        public void GivenField(Table table)
        {
            var rows = table.Rows.ToGameField();
        }

        [Then(@"the result should be:")]
        public void ThenTheResultShouldBe(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"try to update field with:")]
        public void WhenTryToUpdateFieldWith(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }

    public class GameFieldInfo
    {
        public GameFieldInfo()
        {
        }
    }
}