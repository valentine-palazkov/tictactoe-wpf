using TechTalk.SpecFlow;
using TicTakToe.Business;

namespace TicTakToe.Specs
{
    public class TicTacToeScenarioContext
    {
        private const string GameBoardKey = "GameBoard";
        private const string GameKey = "Game";

        public static Game Game
        {
            get { return Current.Get<Game>(GameKey); }
            set { Current[GameKey] = value; }
        }

        private static ScenarioContext Current
        {
            get { return ScenarioContext.Current; }
        }

        public static GameBoard Board
        {
            get { return Current.Get<GameBoard>(GameBoardKey); }
            set { Current[GameBoardKey] = value; }
        }
    }
}