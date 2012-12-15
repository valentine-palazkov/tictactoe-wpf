namespace TicTakToe
{
    public class NoMove : GameMove
    {
        public NoMove(int column, int row) : base(column, row)
        {
        }

        protected override string View
        {
            get { return "no move"; }
        }
    }
}