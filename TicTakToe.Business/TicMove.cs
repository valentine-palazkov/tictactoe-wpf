namespace TicTakToe.Business
{
    public class TicMove : GameMove
    {
        public TicMove(Row row, Column column)
            : base(row, column)
        {
        }

        protected override string Name
        {
            get { return "x"; }
        }
    }
}