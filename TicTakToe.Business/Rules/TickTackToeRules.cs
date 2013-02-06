using System.Collections.Generic;
using System.Linq;

namespace TicTakToe.Business.Rules
{
    internal class TickTackToeRules
    {
        private readonly GameBoard _board;
        private readonly Game _game;
        private readonly IEnumerable<IGameMove> _moves;

        public TickTackToeRules(IEnumerable<IGameMove> moves, GameBoard board, Game game)
        {
            _moves = moves;
            _board = board;
            _game = game;
        }

        public IEnumerable<RuleViolation> Validate(IGameMove move)
        {
            var validationResult = new List<RuleViolation>();
            ValidateMoveOrder(move, validationResult);
            ValidateTheSameMove(move, validationResult);
            ValidateGameAlreadyCompleted(move, validationResult);
            return validationResult;
        }

        private void ValidateGameAlreadyCompleted(IGameMove move, List<RuleViolation> validationResult)
        {
            if (_game.IsCompleted)
            {
                validationResult.Add(new GameAlreadyCompletedRuleValidation(move));
            }
        }

        private void ValidateTheSameMove(IGameMove move, List<RuleViolation> validationResult)
        {
            if (_board[move.Row, move.Column].Move.GetType() != typeof (NoMove))
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
}