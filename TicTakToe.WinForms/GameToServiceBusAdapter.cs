using Rhino.ServiceBus;
using TicTakToe.Business;

namespace TicTakToe.WinForms
{
	public class GameToServiceBusAdapter : ConsumerOf<UserWantsToMoveMessage>
	{
		private readonly Game _game;
		private readonly IServiceBus _bus;

		public GameToServiceBusAdapter(Game game, IServiceBus bus)
		{
			_game = game;
			_bus = bus;
		}

		public void Consume(UserWantsToMoveMessage message)
		{
            try
            {
                var move = _game.Make(message.Row, message.Column);
                if (move.GetType() == typeof (TicMove))
                {
                    _bus.Send(new TicMoveMadeMessage {Row = message.Row, Column = message.Column});
                }
                else
                {
                    _bus.Send(new TakMoveMadeMessage {Row = message.Row, Column = message.Column});
                }
            }
            catch
            {
                
            }
			
		}
	}
}