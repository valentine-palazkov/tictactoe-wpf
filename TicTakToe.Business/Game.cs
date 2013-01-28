using System;
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

	    public bool IsCompleted
	    {
	        get
	        {
	            Type moveType0 = _board[0, 0].Move.GetType();
                if (moveType0 != typeof (NoMove))
                {
                    Type moveType1 = _board[0, 1].Move.GetType();
                    Type moveType2 = _board[0, 2].Move.GetType();
                    if ((moveType0 == moveType1) && (moveType1 == moveType2))
                        return true;

                    moveType1 = _board[1, 1].Move.GetType();
                    moveType2 = _board[2, 2].Move.GetType();

                    if ((moveType0 == moveType1) && (moveType1 == moveType2))
                        return true;

                    moveType1 = _board[0, 1].Move.GetType();
                    moveType2 = _board[0, 2].Move.GetType();

                    if ((moveType0 == moveType1) && (moveType1 == moveType2))
                        return true;
                }

                return false;
	        }
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
            var result = _rules.Validate(move);
            if (result.Any())
			{
				throw new RuleViolationException(result);
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