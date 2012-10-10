namespace TicTakToe
{
    public class TacMove : GameMove
    {
        public TacMove(int x, int y)
            : base(x, y)
        {
            
        }

        public override string ToString()
        {
            return "0";
        }
    }
}