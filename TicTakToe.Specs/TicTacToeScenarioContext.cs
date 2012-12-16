using TechTalk.SpecFlow;
using TicTakToe.Business;

namespace TicTakToe.Specs
{
    public class TicTacToeScenarioContext
    {
        public static Game Game
        {
            get { return Current.Get<Game>(); }
            set { Current.Set(value); }
        }

        private static ScenarioContext Current
        {
            get { return ScenarioContext.Current; }
        }

        public static GameBoard Board
        {
            get { return Current.Get<GameBoard>(); }
            set { Current.Set(value); }
        }
    }
}