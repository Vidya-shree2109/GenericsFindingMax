using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FindMaximum;

namespace TestMaximum
{
    public class TestMax3
    {
        [Test]
        public void GivenStringInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax<string> max = new FindMax<string>("Banana", "Apple", "Peach");
            string actual = max.FindMaxElement();
            Assert.AreEqual(actual, "Peach");
        }
    }
}
