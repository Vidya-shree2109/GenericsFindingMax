using FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMax1
    {
        [Test]
        public void GivenIntInput_WhenTestMax_ShouldReturnMaximum()
        {
            int[] arr = { 54, 108, 234, 300, 456 };
            FindMax<int> max = new FindMax<int>(arr);
            int actual = max.PrintMaxMethod();
            Assert.AreEqual(actual, 456);
        }
    }
}