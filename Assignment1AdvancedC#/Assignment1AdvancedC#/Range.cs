using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1AdvancedC_
{
    internal class Range<T> where T:IComparable<T> 
    {
        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0) throw new Exception("min should be less than or equal to max");

            Minimum = minimum;
            Maximum = maximum;
        }

        public  T Minimum { get; }
        public T Maximum { get;  }

        public override string ToString()
        {
            return $"Minimum: {Minimum} \nMaximum: {Maximum}";
        }
        public  bool isInRange(T value)
        {
            return (value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0);
        }

        public dynamic GetLength()
        {
            return ((dynamic)Maximum - (dynamic)Minimum);
        }


    }
}
