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
        public void GivenIntInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax max = new FindMax();
            int actual = max.FindMaxInteger(10, 30, 20);
            Assert.AreEqual(actual, 30);
        }
    }
}
