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
            string[] arr = { "Apple", "PineApple", "Grapes", "Banana" };
            FindMax<string> max = new FindMax<string>(arr);
            string actual = max.PrintMaxMethod();
            Assert.AreEqual(actual, "PineApple");
        }
    }
}
