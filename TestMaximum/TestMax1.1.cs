using FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMax1
    {
        [Test]
        public void GivenFloatInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax max = new FindMax();
            float actual = max.FindMaxFloat(3.5f, 2.5f, 1.5f);
            Assert.AreEqual(actual,3.5);
        }
    }
}