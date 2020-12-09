using NUnit.Framework;

namespace day_2020_12_09.tests
{
    public class SolverTests
    {
        [TestCase(new long[] {35,20,15,25,47,40,62,55,65,95,102,117,150,182,127,219,299,277,309,576}, 5, 127)]
        public void Part1(long[] numbers, int preambleLength, int result)
        {
            Assert.That(Solver.Part1(numbers, preambleLength), Is.EqualTo(result));
        }
        
        [TestCase(new long[] {15,21,2,20,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17}, 0, 25, 26, true)]
        [TestCase(new long[] {15,21,2,20,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17}, 0, 25, 49, true)]
        [TestCase(new long[] {15,21,2,20,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17}, 0, 25, 100, false)]
        [TestCase(new long[] {15,21,2,20,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17}, 0, 25, 50,  false)]
        [TestCase(new long[] {20,21,2,15,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17,45}, 1, 25, 26, true)]
        [TestCase(new long[] {20,21,2,15,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17,45}, 1, 25, 65, false)]
        [TestCase(new long[] {20,21,2,15,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17,45}, 1, 25, 64, true)]
        [TestCase(new long[] {20,21,2,15,3,7,25,5,24,23,14,18,16,11,9,13,6,1,10,8,19,12,22,4,17,45}, 1, 25, 66, true)]
        public void HaveTwoNumbersWithSum_Works_Correctly(long[] numbers, int offset, int len, long sum, bool result)
        {
            Assert.That(Solver.HaveTwoNumbersWithSum(numbers, offset, len, sum), Is.EqualTo(result));
        }
    }
}