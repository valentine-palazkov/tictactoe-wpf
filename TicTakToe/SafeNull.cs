namespace TicTakToe
{
    public class SafeNull<T, TSafeNull> where TSafeNull : T, new()
    {
        public static readonly T Instance = new TSafeNull();
    }
}