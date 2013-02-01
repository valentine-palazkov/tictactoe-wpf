using System.Windows.Forms;
using Rhino.ServiceBus;
using TicTakToe.WinForms.ServiceBus.Messages;

namespace TicTakToe.WinForms
{
    public class TicTakToeCompletion : ConsumerOf<GameCompletedMessage>, ConsumerOf<GameRulesViolatedMessage>
    {
        public void Consume(GameCompletedMessage message)
        {
            MessageBox.Show("Game Completed!");
        }

        public void Consume(GameRulesViolatedMessage message)
        {
            MessageBox.Show(message.Message);
        }
    }
}