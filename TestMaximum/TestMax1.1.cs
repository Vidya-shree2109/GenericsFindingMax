using FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMax1
    {
        [Test]
        public void GivenIntInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax max = new FindMax();
            int actual = max.FindMaxInteger(30, 10, 20);
            Assert.AreEqual(actual,30);
        }
    }
}