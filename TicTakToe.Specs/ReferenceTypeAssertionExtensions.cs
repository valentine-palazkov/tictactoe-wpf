using TicTakToe;
using TicTakToe.Business;
using TicTakToe.Specs;

// ReSharper disable CheckNamespace
namespace FluentAssertions.Assertions
// ReSharper restore CheckNamespace
{
    public static class ReferenceTypeAssertionExtensions
    {
        public static GameBoardAssertions Should(this GameBoard board)
        {
            return new GameBoardAssertions(board);
        }
    }
}