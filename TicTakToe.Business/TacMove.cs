namespace TicTakToe.Business
{
    public class TacMove : GameMove
    {
        public TacMove(Row row, Column column)
            : base(row, column)
        {
        }

        protected override string Name
        {
            get { return "0"; }
        }
    }
}