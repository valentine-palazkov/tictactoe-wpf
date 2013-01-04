using System.Collections.Generic;
using System.Linq;

namespace TicTakToe.Business
{
	public class Game
	{
		private readonly GameBoard _board;
		private readonly List<IGameMove> _moves = new List<IGameMove>();
		private readonly TickTackToeRules _rules;

		public Game(GameBoard board)
		{
			_board = board;
			_rules = new TickTackToeRules(_moves, board);
		}

		public IGameMove Make(Row row, Column column)
		{
			var move = _moves.LastOrDefault();
			if (move == null || move.GetType() == typeof (TacMove))
			{
				move = new TicMove(row, column);
				
			}
			else
			{
				move = new TacMove(row, column);
			}

			Make(move);
			return move;
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
}