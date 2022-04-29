using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class FindMax
    {
        public string FindMaxString(string first, string second, string third)
        {
            int firstLength = first.Length;
            int secondLength = second.Length;
            int thirdLength = third.Length;
            if (firstLength.CompareTo(secondLength) > 0 && firstLength.CompareTo(thirdLength) > 0)
            {
                Console.WriteLine("String: First is Greater -> " + first);
                return first;
            }
            if (secondLength.CompareTo(firstLength) > 0 && secondLength.CompareTo(thirdLength) > 0)
            {
                Console.WriteLine("String: Second is Greater -> " + second);
                return second;
            }
            else
            {
                Console.Write("String: Third is Greater -> " + third);
                return third;
            }
        }
    }
}
