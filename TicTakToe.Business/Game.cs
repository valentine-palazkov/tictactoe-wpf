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
                var browser = new BoardBrowser(_board[0, 0], _board);
                if (browser.Left(2).AreSame())
                    return true;

                if (browser.Right(2).AreSame())
                    return true;

                if (browser.Up(2).AreSame())
                    return true;

                if (browser.Down(2).AreSame())
                    return true;

                if (browser.LeftUp(2).AreSame())
                    return true;

                if (browser.LeftDown(2).AreSame())
                    return true;

                if (browser.RightUp(2).AreSame())
                    return true;

                if (browser.RightDown(2).AreSame())
                    return true;

                if (browser.Down().Up().AreSame())
                    return true;

                if (browser.Right().Left().AreSame())
                    return true;

                if (browser.LeftUp().RightDown().AreSame())
                    return true;

                if (browser.LeftDown().RightUp().AreSame())
                    return true;

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