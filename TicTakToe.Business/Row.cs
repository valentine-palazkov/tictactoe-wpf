using System.Globalization;

namespace TicTakToe.Business
{
    public class Row
    {
        protected bool Equals(Row other)
        {
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Row) obj);
        }

        public override int GetHashCode()
        {
            return Value;
        }

        public int Value { get; set; }

        public static implicit operator Row(int rowValue)
        {
            return new Row {Value = rowValue};
        }

        public static bool operator ==(Row arg0, Row arg1)
        {
            return arg0.Value == arg1.Value;
        }

        public static bool operator !=(Row arg0, Row arg1)
        {
            return !(arg0 == arg1);
        }

        public static Row operator -(Row arg0, Row arg1)
        {
            return arg0.Value - arg1.Value;
        }

        public static Row operator +(Row arg0, Row arg1)
        {
            return arg0.Value + arg1.Value;
        }
        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }
    }
}