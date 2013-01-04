using System.Collections.Generic;
using System.Linq;

namespace TicTakToe.Business
{
    internal class TickTackToeRules
    {
        private readonly GameBoard _board;
        private readonly IEnumerable<IGameMove> _moves;

        public TickTackToeRules(IEnumerable<IGameMove> moves, GameBoard board)
        {
            _moves = moves;
            _board = board;
        }

        public IEnumerable<RuleViolation> Validate(IGameMove move)
        {
            var validationResult = new List<RuleViolation>();
            ValidateMoveOrder(move, validationResult);
            ValidateTheSameMove(move, validationResult);
            return validationResult;
        }

        private void ValidateTheSameMove(IGameMove move, List<RuleViolation> validationResult)
        {
            if (_board[move.Row, move.Column].Move.GetType() != typeof(NoMove))
            {
                validationResult.Add(new TheSameMoveShouldNotBeMadeAgainRuleValidation(move));
            }
        }

        private void ValidateMoveOrder(IGameMove move, List<RuleViolation> validationResult)
        {
            IGameMove lastMove = _moves.LastOrDefault();

            if (lastMove != null && lastMove.GetType() == move.GetType())
            {
                validationResult.Add(new MoveOrderRuleViolation(move));
            }
        }
    }

    public class TheSameMoveShouldNotBeMadeAgainRuleValidation : RuleViolation
    {
        private readonly IGameMove _move;

        public TheSameMoveShouldNotBeMadeAgainRuleValidation(IGameMove move)
        {
            _move = move;
        }

        public override string Message
        {
            get { return string.Format("Can not make move at {{{0}, {1}}} as this move already made", _move.Row, _move.Column); }
        }
    }
}