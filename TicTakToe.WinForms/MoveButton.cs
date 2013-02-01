using System;
using System.Windows.Forms;
using Rhino.ServiceBus;
using TicTakToe.WinForms.ServiceBus.Messages;

namespace TicTakToe.WinForms
{
    public partial class MoveButton : UserControl, OccasionalConsumerOf<TicMoveMadeMessage>,
                                      OccasionalConsumerOf<TakMoveMadeMessage>
    {
        private readonly IServiceBus _bus;

        public MoveButton(IServiceBus bus)
        {
            _bus = bus;
            _bus.AddInstanceSubscription(this);
            InitializeComponent();
        }

        public int Row { get; set; }
        public int Column { get; set; }

        public override string Text
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _bus.Publish(new UserWantsToMoveMessage {Row = Row, Column = Column,});
        }

        private delegate void TicConsumerDelegate(TicMoveMadeMessage message);

        private delegate void TakConsumerDelegate(TakMoveMadeMessage message);


        public void Consume(TicMoveMadeMessage message)
        {
            if (InvokeRequired)
            {
                Invoke(new TicConsumerDelegate(Consume), message);
                return;
            }

            if (message.Row == Row && message.Column == Column)
            {
                button1.Text = "Tic";
            }
        }

        public void Consume(TakMoveMadeMessage message)
        {
            if (InvokeRequired)
            {
                Invoke(new TakConsumerDelegate(Consume), message);
                return;
            }

            if (message.Row == Row && message.Column == Column)
            {
                button1.Text = "Tak";
            }
        }
    }
}