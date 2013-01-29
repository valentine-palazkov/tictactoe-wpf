using System.Collections.Generic;
using System.Linq;

namespace TicTakToe.Business
{
    public class CellCollection
    {
        private readonly IEnumerable<ICell> _cells;

        public CellCollection(IEnumerable<ICell> cells)
        {
            _cells = cells;
        }

        public bool AreSame()
        {
            return _cells.Select(x => x.Move.GetType()).Distinct().Count() == 1;
        }

        public CellCollection Up()
        {
            return this;
        }

        public CellCollection Left()
        {
            return this;
        }

        public CellCollection RightDown()
        {
            return this;
        }

        public CellCollection RightUp()
        {
            return this;
        }
    }
}