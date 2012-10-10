using System.Collections.Generic;

namespace TicTakToe
{
    public class GameBoard
    {
        private readonly List<List<IGameMove>> cells = new List<List<IGameMove>>();

        public GameBoard()
        {
            cells.Add(new List<IGameMove>
                {MoveSafeNull.Instance, MoveSafeNull.Instance, MoveSafeNull.Instance});
            cells.Add(new List<IGameMove>
                {MoveSafeNull.Instance, MoveSafeNull.Instance, MoveSafeNull.Instance});
            cells.Add(new List<IGameMove>
                {MoveSafeNull.Instance, MoveSafeNull.Instance, MoveSafeNull.Instance});
        }

        public IGameMove this[int x, int y]
        {
            get { return cells[y][x]; }
        }

        public void Move(int x, int y)
        {
        }
    }
}