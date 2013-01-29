namespace TicTakToe.Business
{
	public abstract class GameMove : IGameMove
	{
		protected GameMove(Row row, Column column)
		{
			Column = column;
			Row = row;
		}

		#region IGameMove Members

		public bool AlreadyMadeOn(GameBoard board)
		{
			ICell cell = board[Row, Column];
			return cell.Move.GetType() == GetType();
		}

		public Column Column { get; private set; }
		public Row Row { get; private set; }

		public override string ToString()
		{
			return string.Format("'{0}' at ({1}, {2})", Name, Row, Column);
		}

		#endregion

		protected abstract string Name { get; }

		public void Execute(GameBoard board)
		{
			board.MakeMove(this);
		}
	}
}