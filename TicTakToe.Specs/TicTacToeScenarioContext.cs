using TechTalk.SpecFlow;
using TicTakToe.Business;
using TicTakToe.Business.Rules;

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

        public static RuleViolationException RuleViolationException
        {
            get { return Current.Get<RuleViolationException>(); }
            set { Current.Set(value); }
        }
    }
}