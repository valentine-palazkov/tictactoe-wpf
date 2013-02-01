using System.Windows.Forms;
using StructureMap;

namespace TicTakToe.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controls.Add(ObjectFactory.GetInstance<TicTakToeView>());
        }
    }
}