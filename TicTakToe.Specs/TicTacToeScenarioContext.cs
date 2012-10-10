using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    public class TicTacToeScenarioContext
    {
        private const string Gameboard = "GameBoard";

        public static GameBoard Board
        {
            get { return (GameBoard) Current[Gameboard]; }
            set { Current[Gameboard] = value; }
        }

        private static ScenarioContext Current
        {
            get { return ScenarioContext.Current; }
        }
    }
}