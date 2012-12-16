using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTakToe.Business
{
    public class Game
    {
        private readonly GameBoard _board;
        private readonly List<IGameMove> _moves = new List<IGameMove>();
        private TickTackToeRules _rules;

        public Game(GameBoard board)
        {
            _board = board;
            _rules = new TickTackToeRules(_moves, board);
        }

        public void Make(IGameMove move)
        {
            MoveValidationResult result = _rules.Validate(move);
            if (!result.IsMoveOk)
            {
                throw new RuleViolationException(result.Message);
            }


            move.Execute(_board);
            _moves.Add(move);
        }

        public void Make(IEnumerable<IGameMove> gameMoves)
        {
            gameMoves.ToList().ForEach(Make);
        }
    }

    public class RuleViolationException : ApplicationException
    {
        public RuleViolationException(string message)
            : base(message)
        {
            
        }
    }

    internal class TickTackToeRules
    {
        private readonly IEnumerable<IGameMove> _moves;
        private readonly GameBoard _board;

        public TickTackToeRules(IEnumerable<IGameMove> moves, GameBoard board)
        {
            _moves = moves;
            _board = board;
        }

        public MoveValidationResult Validate(IGameMove move)
        {
            var lastMove = _moves.LastOrDefault();
            
            if (lastMove == null || lastMove.GetType() != move.GetType())
            {
                return new MoveValidationResult
                    {
                        IsMoveOk = true,
                        Message = string.Format("Move '{0}' is OK", move)
                    };
            }

            return new MoveValidationResult
                {
                    IsMoveOk = false,
                    Message = string.Format("Move '{0}' is not OK because the previous move was the same", move)
                };
        }
    }

    internal class MoveValidationResult
    {
        public bool IsMoveOk { get; set; }
        public string Message { get; set; }
    }
}