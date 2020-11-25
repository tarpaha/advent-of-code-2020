using NUnit.Framework;

namespace utils.tests
{
    public class MathematicsTests
    {
        [TestCase(1, true)]
        [TestCase(2, false)]
        public void IsOdd_Works_Correctly(int v, bool result)
        {
            Assert.That(Mathematics.IsOdd(v), Is.EqualTo(result));
        }
    }
}