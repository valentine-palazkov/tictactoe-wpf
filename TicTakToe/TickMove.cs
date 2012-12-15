namespace TicTakToe
{
    public class TickMove : GameMove
    {
        public TickMove(int column, int row) : base(column, row)
        {
        }

        protected override string View
        {
            get { return "x"; }
        }
    }
}