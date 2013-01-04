using System.Collections.Generic;
using System.Linq;

namespace TicTakToe.Business
{
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
}