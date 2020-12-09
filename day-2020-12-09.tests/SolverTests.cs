using NUnit.Framework;

namespace day_2020_12_09.tests
{
    public class SolverTests
    {
        [TestCase(new long[] {15,21,2,20,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17}, 0, 25, 26, true)]
        [TestCase(new long[] {15,21,2,20,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17}, 0, 25, 49, true)]
        [TestCase(new long[] {15,21,2,20,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17}, 0, 25, 100, false)]
        [TestCase(new long[] {15,21,2,20,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17}, 0, 25, 50,  false)]
        [TestCase(new long[] {20,21,2,15,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17,45}, 1, 25, 26, true)]
        [TestCase(new long[] {20,21,2,15,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17,45}, 1, 25, 65, false)]
        [TestCase(new long[] {20,21,2,15,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17,45}, 1, 25, 64, true)]
        [TestCase(new long[] {20,21,2,15,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17,45}, 1, 25, 66, true)]
        public void HaveTwoNumbersWithSum(long[] numbers, int offset, int len, long sum, bool result)
        {
            Assert.That(Solver.HaveTwoNumbersWithSum(numbers, offset, len, sum), Is.EqualTo(result));
        }
    }
}