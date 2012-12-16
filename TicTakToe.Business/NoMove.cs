namespace TicTakToe.Business
{
    public class NoMove : GameMove
    {
        public NoMove(Row row, Column column)
            : base(row, column)
        {
        }

        protected override string Name
        {
            get { return "no move"; }
        }
    }
}