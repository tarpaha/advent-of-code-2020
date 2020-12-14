using NUnit.Framework;

namespace day_2020_12_14.tests
{
    public class SolverTests
    {
        [TestCase(11, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X", 73)]
        [TestCase(101, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X", 101)]
        [TestCase(0, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X", 64)]
        public void ApplyMask_Works_Correctly(long number, string mask, long result)
        {
            Assert.That(Solver.ApplyMask(number, mask), Is.EqualTo(result));
        }
    }
}