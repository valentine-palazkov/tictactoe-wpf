using Rhino.ServiceBus;
using TicTakToe.Business;
using TicTakToe.Business.Rules;

namespace TicTakToe.WinForms.ServiceBus.Messages
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

                if (_game.IsCompleted)
                {
                    _bus.Send(new GameCompletedMessage());
                }
            }
            catch (RuleViolationException exception)
            {
                _bus.Send(new GameRulesViolatedMessage(exception.Message));
            }
        }
    }

    public class GameRulesViolatedMessage
    {
        public string Message { get; private set; }

        public GameRulesViolatedMessage(string message)
        {
            Message = message;
        }
    }

    public class GameCompletedMessage
    {
    }
}