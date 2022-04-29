using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FindMaximum;

namespace TestMaximum
{
    public class TestMax2
    {
        [Test]
        public void GivenFloatInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax max = new FindMax();
            string actual = max.FindMaxString("Apple", "Banana", "Peach");
            Assert.AreEqual(actual, "Banana");
        }
    }
}
