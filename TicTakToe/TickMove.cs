namespace TicTakToe
{
    public class TickMove : GameMove
    {
        public TickMove(int x, int y) : base(x, y)
        {
        }

        public override string View
        {
            get { return "x"; }
        }
    }
}