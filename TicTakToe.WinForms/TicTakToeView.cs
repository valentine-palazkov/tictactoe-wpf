using System.Windows.Forms;

namespace TicTakToe.WinForms
{
    public partial class TicTakToeView : UserControl
    {
        public TicTakToeView()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.Add(new MoveButton {Row = 1, Column = 1});
            tableLayoutPanel1.Controls.Add(new MoveButton {Row = 1, Column = 2});
            tableLayoutPanel1.Controls.Add(new MoveButton {Row = 1, Column = 3});
            tableLayoutPanel1.Controls.Add(new MoveButton {Row = 2, Column = 1});
            tableLayoutPanel1.Controls.Add(new MoveButton {Row = 2, Column = 2});
            tableLayoutPanel1.Controls.Add(new MoveButton {Row = 2, Column = 3});
            tableLayoutPanel1.Controls.Add(new MoveButton {Row = 3, Column = 1});
            tableLayoutPanel1.Controls.Add(new MoveButton {Row = 3, Column = 2});
            tableLayoutPanel1.Controls.Add(new MoveButton {Row = 3, Column = 3});
        }
    }
}