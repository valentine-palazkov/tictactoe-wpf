namespace TicTakToe.Business.Rules
{
    internal class GameAlreadyCompletedRuleValidation : RuleViolation
    {
        private readonly IGameMove _move;

        public GameAlreadyCompletedRuleValidation(IGameMove move)
        {
            _move = move;
        }

        public override string Message
        {
            get
            {
                return string.Format("Can not make move at {{{0}, {1}}} as the game already completed", _move.Row,
                                     _move.Column);
            }
        }
    }
}