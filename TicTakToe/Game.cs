using System.Collections.Generic;
using System.Linq;

namespace TicTakToe
{
    public class Game
    {
        private readonly GameBoard _board;
        private readonly List<IGameMove> _moves = new List<IGameMove>();

        public Game(GameBoard board)
        {
            _board = board;
        }

        public void Make(IGameMove move)
        {
            move.Execute(_board);
            _moves.Add(move);
        }

        public void Make(IEnumerable<IGameMove> gameMoves)
        {
            gameMoves.ToList().ForEach(Make);
        }
    }
}