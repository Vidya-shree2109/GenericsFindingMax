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
            FindMax<float> max = new FindMax<float>(20.5f, 30.5f, 10.5f);
            float actual = max.FindMaxElement();
            Assert.AreEqual(actual, 30.5f);
        }
    }
}
