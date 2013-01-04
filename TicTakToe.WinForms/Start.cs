using Rhino.ServiceBus.Hosting;
using Rhino.ServiceBus.Msmq;
using TicTakToe.WinForms.ServiceBus;

namespace TicTakToe.WinForms
{
	public class Start
	{
		public static void Main()
		{
			PrepareQueues.Prepare("msmq://localhost/TicTakToe.Backend", QueueType.Standard);
			var host = new DefaultHost();
			host.Start<BootStrapper>();

			var forms = new Form1();
			forms.ShowDialog();
		}
	}
}