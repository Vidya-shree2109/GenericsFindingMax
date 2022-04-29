using FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMaxNumber
    {
        [Test]
        public void GivenIntInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax max = new FindMax();
            int actual = max.FindMaxInteger(1, 2, 3);
            Assert.AreEqual(actual,3);
        }
    }
}