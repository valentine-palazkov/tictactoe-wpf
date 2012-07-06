namespace TicTakToe
{
    public abstract class BoardCell : IBoardCell
    {
        public abstract override string ToString();

        public bool IsNull
        {
            get { return false; }
        }
    }
}