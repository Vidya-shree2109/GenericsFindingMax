using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class FindMax
    {
        public int FindMaxInteger(int first, int second, int third)
        {
            if(first.CompareTo(second)>0 && first.CompareTo(third)>0)
            {
                Console.WriteLine("First is greater" + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second is greater" + second);
                return second;
            }
            else
            {
                Console.WriteLine("Third is greater");
                return third;
            }
        }
    }
}
