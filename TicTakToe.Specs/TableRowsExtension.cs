using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace TicTakToe.Specs
{
    public static class TableRowsExtension
    {


        public static GameBoard ToGameField(this TableRows theRows)
        {
            var board = new GameBoard();
            var game = new Game(board);

            ModifyBoard(theRows, game);
            return board;
        }

        public static void Update(this TableRows theRows, Game game)
        {
            ModifyBoard(theRows, game);
        }

        private static void ModifyBoard(TableRows theRows, Game game)
        {
            for (int y = 0; y < theRows.Count; y++)
            {
                string[] row = theRows[y].Values.ToArray();
                for (int x = 0; x < row.Length; x++)
                {
                    var gameMove = CreateMove(row[x], x, y);
                    game.Make(gameMove);
                }
            }
        }

        private static IGameMove CreateMove(string cellChar, int x, int y)
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

    public class Game
    {
        private readonly GameBoard board;

        public Game(GameBoard board)
        {
            this.board = board;
        }

        public void Make(IGameMove gameMove)
        {
            throw new NotImplementedException();
        }
    }
}