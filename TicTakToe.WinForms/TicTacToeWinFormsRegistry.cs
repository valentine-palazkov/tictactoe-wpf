using StructureMap.Configuration.DSL;
using TicTakToe.Business;

namespace TicTakToe.WinForms
{
	public class TicTacToeWinFormsRegistry : Registry
	{
		public TicTacToeWinFormsRegistry()
		{
			For<Game>().Singleton().Use<Game>();
		}
	}
}