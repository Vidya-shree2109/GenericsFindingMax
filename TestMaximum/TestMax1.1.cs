using FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMax1
    {
        [Test]
        public void GivenIntInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax<int> max = new FindMax<int>(1, 2, 3);
            int actual = max.FindMaxElement();
            Assert.AreEqual(actual, 3);
        }
    }
}