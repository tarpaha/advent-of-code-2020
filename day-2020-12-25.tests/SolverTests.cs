using NUnit.Framework;

namespace day_2020_12_25.tests
{
    public class SolverTests
    {
        [TestCase(5764801, 7, 20201227, 8)]
        [TestCase(17807724, 7, 20201227, 11)]
        public void CalculateLoopCount_Works_Correctly(long key, long subject, long divider, long result)
        {
            Assert.That(Solver.CalculateLoopCount(key, subject, divider), Is.EqualTo(result));
        }
        
        [TestCase(5764801, 17807724, 7, 20201227, 14897079)]
        [TestCase(17807724, 5764801, 7, 20201227, 14897079)]
        public void CalculateEncryptionKey_Works_Correctly(long key1, long key2, long subject, long divider, long result)
        {
            Assert.That(Solver.CalculateEncryptionKey(key1, key2, subject, divider), Is.EqualTo(result));
        }

        [TestCase(5764801, 17807724, 7, 20201227, 14897079)]
        public void Part1(long key1, long key2, long subject, long divider, long result)
        {
            Assert.That(Solver.Part1(key1, key2, subject, divider), Is.EqualTo(result));
        }
        
        [Test]
        public void Part2()
        {
            Assert.That(Solver.Part2(), Is.Null);
        }
    }
}