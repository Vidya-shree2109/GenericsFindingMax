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
        public void GivenfloatInput_WhenTestMax_ShouldReturnMaximum()
        {
            float[] arr = { 3.5f, 4.9f, 0.2f, 9.6f, 2.1f };
            FindMax<float> max = new FindMax<float>(arr);
            float actual = max.PrintMaxMethod();
            Assert.AreEqual(actual, 9.6f);
        }
    }
}
