using System;

namespace TicTakToe
{
	public class Game
	{
		private readonly GameBoard board;

		public Game(GameBoard board)
		{
			this.board = board;
		}

		public void Make(params IGameMove[] gameMove)
		{

		}
	}
}