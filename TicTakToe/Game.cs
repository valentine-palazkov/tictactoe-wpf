using System.Collections.Generic;
using System.Linq;

namespace TicTakToe
{
    public class Game
    {
        private readonly GameBoard board;
        private readonly List<IGameMove> moves = new List<IGameMove>();

        public Game(GameBoard board)
        {
            this.board = board;
        }

        public void Make(params IGameMove[] gameMoves)
        {
            gameMoves.ToList().ForEach(move =>
                {
                    move.Execute(board);
                    moves.Add(move);
                });
        }
    }
}