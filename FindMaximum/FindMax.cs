using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class FindMax
    {
        public float FindMaxFloat(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("Float: First Number is greater -> " + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Float: Second Number is greater -> " + second);
                return second;
            }
            else
            {
                Console.WriteLine("Float: Third Number is greater -> " + third);
                return third;
            }
        }
    }
}
