using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] value;
        public GenericMaximum(params T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);

            return sorted_values[sorted_values.Length - 1];
        }

        public T Max()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
