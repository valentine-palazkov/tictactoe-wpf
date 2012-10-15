using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
	public static class TableRowsExtension
	{
		public static IEnumerable<IGameMove> ParseMoves(this TableRows theRows)
		{
			for (int y = 0; y < theRows.Count; y++)
			{
				string[] row = theRows[y].Values.ToArray();
				for (int x = 0; x < row.Length; x++)
				{
					yield return ParseStep(row[x], x, y);
				}
			}
		}

		private static IGameMove ParseStep(string cellChar, int x, int y)
		{
			switch (cellChar.ToLower())
			{
				case "x":
					return new TickMove(x, y);
				case "0":
					return new TacMove(x, y);
				default:
					return MoveSafeNull.Instance;
			}
		}
	}
}