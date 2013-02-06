namespace TicTakToe.Business.Rules
{
    public class TheSameMoveShouldNotBeMadeAgainRuleValidation : RuleViolation
    {
        private readonly IGameMove _move;

        public TheSameMoveShouldNotBeMadeAgainRuleValidation(IGameMove move)
        {
            _move = move;
        }

        public override string Message
        {
            get
            {
                return string.Format("Can not make move at {{{0}, {1}}} as this move already made", _move.Row,
                                     _move.Column);
            }
        }
    }
}