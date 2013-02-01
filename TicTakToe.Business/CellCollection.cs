using System.Collections.Generic;
using System.Linq;

namespace TicTakToe.Business
{
    public class CellCollection
    {
        private readonly List<ICell> _cells = new List<ICell>();

        public CellCollection(IEnumerable<ICell> cells)
        {
            _cells.AddRange(cells);
        }

        public bool AreSame()
        {
            return _cells.Select(x => x.Move.GetType()).Distinct().Count() == 1;
        }

        public CellCollection Add(CellCollection cells)
        {
            _cells.AddRange(cells._cells);
            return this;
        }
    }
}