using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    public class TicCacToeScenarioContext
    {
        public static GameBoard Board
        {
            get { return (GameBoard) Current["GameBoard"]; }
            set { Current["GameBoard"] = value; }
        }

        private static ScenarioContext Current
        {
            get { return ScenarioContext.Current; }
        }
    }
}