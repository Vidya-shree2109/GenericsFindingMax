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
            float actual = max.FindMaxFloat(2.5f, 3.5f, 1.5f);
            Assert.AreEqual(actual, 3.5);
        }
    }
}
