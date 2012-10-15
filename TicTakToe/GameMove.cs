namespace TicTakToe
{
	public abstract class GameMove : IGameMove
	{
		private readonly int _x;
		private readonly int _y;

		protected GameMove(int x, int y)
		{
			_x = x;
			_y = y;
		}

		#region IGameMove Members

		public bool IsNull
		{
			get { return false; }
		}

		public abstract void Execute();

		#endregion
	}
}