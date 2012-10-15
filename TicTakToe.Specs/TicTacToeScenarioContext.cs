using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    public class TicTacToeScenarioContext
    {
	    private const string GameBoardKey = "GameBoard";
	    private const string GameKey = "Game";

        public static Game Game
        {
			get { return (Game)Current[GameKey]; }
			set { Current[GameKey] = value; }
        }

        private static ScenarioContext Current
        {
            get { return ScenarioContext.Current; }
        }

	    public static GameBoard Board
	    {
			get { return (GameBoard)Current[GameBoardKey]; }
			set { Current[GameBoardKey] = value; }
		}
    }
}