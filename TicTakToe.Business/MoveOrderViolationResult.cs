namespace TicTakToe.Business
{
    public abstract class RuleViolation
    {
        public abstract string Message { get; }
    }

    public class MoveOrderRuleViolation : RuleViolation
    {
        private readonly IGameMove _move;

        public MoveOrderRuleViolation(IGameMove move)
        {
            _move = move;
        }

        public override string Message
        {
            get { return string.Format("Move '{0}' is not OK because the previous move was the same", _move); }
        }
    }
}