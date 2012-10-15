namespace TicTakToe
{
    public class TickMove : GameMove
    {
        public TickMove(int x, int y) : base(x, y)
        {
            
        }

        public override string ToString()
        {
            return "x";
        }

	    public override void Execute()
	    {
		    throw new System.NotImplementedException();
	    }
    }
}