using System;
using System.Windows.Forms;
using Rhino.ServiceBus;
using StructureMap;

namespace TicTakToe.WinForms
{
    public partial class MoveButton : UserControl
    {
        public MoveButton()
        {
            InitializeComponent();
        }

        public int Row { get; set; }
        public int Column { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjectFactory.GetInstance<IServiceBus>().Publish(new UserWantsToMoveMessage {Row = Row, Column = Column,});
        }
    }

    public class UserWantsToMoveMessage
    {
        public int Column { get; set; }

        public int Row { get; set; }
    }
}