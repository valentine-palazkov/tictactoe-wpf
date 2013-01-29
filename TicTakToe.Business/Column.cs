using System.Globalization;

namespace TicTakToe.Business
{
    public class Column
    {
        protected bool Equals(Column other)
        {
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Column) obj);
        }

        public override int GetHashCode()
        {
            return Value;
        }

        public int Value { get; set; }

        public static implicit operator Column(int columnValue)
        {
            return new Column {Value = columnValue};
        }

        public static bool operator ==(Column arg0, Column arg1)
        {
            return arg0.Value == arg1.Value;
        }

        public static bool operator !=(Column arg0, Column arg1)
        {
            return !(arg0.Value == arg1.Value);
        }

        public static Column operator -(Column arg0, Column arg1)
        {
            return arg0.Value - arg1.Value;
        }

        public static Column operator +(Column arg0, Column arg1)
        {
            return arg0.Value + arg1.Value;
        }

        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }
    }
}