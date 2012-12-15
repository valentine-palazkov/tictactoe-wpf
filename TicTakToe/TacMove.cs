namespace TicTakToe
{
    public class TacMove : GameMove
    {
        public TacMove(int column, int row)
            : base(column, row)
        {
        }

        protected override string View
        {
            get { return "0"; }
        }
    }
}