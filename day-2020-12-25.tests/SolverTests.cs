using NUnit.Framework;

namespace day_2020_12_25.tests
{
    public class SolverTests
    {
        [TestCase(5764801, 7, 8)]
        [TestCase(17807724, 7, 11)]
        public void CalculateLoopCount_Works_Correctly(long key, long subject, long result)
        {
            Assert.That(Solver.CalculateLoopCount(key, subject), Is.EqualTo(result));
        }
        
        public void Part1()
        {
            //Assert.That(Solver.Part1(), Is.Null);
        }
        
        [Test]
        public void Part2()
        {
            Assert.That(Solver.Part2(), Is.Null);
        }
    }
}