using Rhino.ServiceBus.StructureMap;

namespace TicTakToe.WinForms.ServiceBus
{
	public class BootStrapper : StructureMapBootStrapper
	{
		protected override void ConfigureContainer()
		{
			base.ConfigureContainer();

			Container.Configure(x => x.AddRegistry<TicTacToeWinFormsRegistry>());
		}
	}
}