namespace TicTakToe.WinForms.ServiceBus.Messages
{
    public class GameMoveMessage
    {
        public int Column { get; set; }
        public int Row { get; set; }
    }
}