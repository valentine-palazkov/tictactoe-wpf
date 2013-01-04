using System.Windows.Forms;
using StructureMap;

namespace TicTakToe.WinForms
{
	public partial class TicTakToeView : UserControl
	{
		public TicTakToeView()
		{
			InitializeComponent();

			tableLayoutPanel1.Controls.Add(CreateMoveButton(row: 0, column: 0));
			tableLayoutPanel1.Controls.Add(CreateMoveButton(row: 0, column: 1));
			tableLayoutPanel1.Controls.Add(CreateMoveButton(row: 0, column: 2));
			tableLayoutPanel1.Controls.Add(CreateMoveButton(row: 1, column: 0));
			tableLayoutPanel1.Controls.Add(CreateMoveButton(row: 1, column: 1));
			tableLayoutPanel1.Controls.Add(CreateMoveButton(row: 1, column: 2));
			tableLayoutPanel1.Controls.Add(CreateMoveButton(row: 2, column: 0));
			tableLayoutPanel1.Controls.Add(CreateMoveButton(row: 2, column: 1));
			tableLayoutPanel1.Controls.Add(CreateMoveButton(row: 2, column: 2));
		}

		private static Control CreateMoveButton(int row, int column)
		{
			var moveButton = ObjectFactory.GetInstance<MoveButton>();
			moveButton.Row = row;
			moveButton.Column = column;
			return moveButton;
		}
	}
}