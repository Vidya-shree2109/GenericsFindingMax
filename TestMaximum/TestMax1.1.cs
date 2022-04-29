using FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMax1
    {
        [Test]
        public void GivenStringInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMax max = new FindMax();
            string actual = max.FindMaxString("Banana", "Peach", "Apple");
            Assert.AreEqual(actual, "Banana");
        }
    }
}