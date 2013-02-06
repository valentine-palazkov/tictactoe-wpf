using System.Collections.Generic;
using System.Linq;
using TicTakToe.Business.Rules;

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
            _rules = new TickTackToeRules(_moves, board, this);
        }

        public bool IsCompleted
        {
            get
            {
                IGameMove[] gameMoves =
                    _board.Where(x => x.Move.GetType() != typeof (NoMove)).Select(x => x.Move).ToArray();
                if (gameMoves.Length == 9)
                    return true;

                foreach (var move in gameMoves)
                {
                    var cell = _board[move.Row, move.Column];
                    var browser = new BoardBrowser(cell, _board);

                    if (browser.Down(2).AreSame())
                        return true;

                    if (browser.Diagonal(2).AreSame())
                        return true;

                    if (browser.Right(2).AreSame())
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