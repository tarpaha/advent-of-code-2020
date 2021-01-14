using NUnit.Framework;

namespace day_2020_12_13.tests
{
    public class SolverTests
    {
        [TestCase(@"939
7,13,x,x,59,x,31,19", 295)]
        public void Part1(string data, int result)
        {
            var (time, ids) = Parser.Parse(data);
            Assert.That(Solver.Part1(time, ids), Is.EqualTo(result));
        }
        
        [TestCase(new long[] { 17,0,13,19 }, 3417)]
        [TestCase(new long[] { 67,7,59,61 }, 754018)]
        [TestCase(new long[] { 67,0,7,59,61 }, 779210)]
        [TestCase(new long[] { 67,7,0,59,61 }, 1261476)]
        [TestCase(new long[] { 1789,37,47,1889 }, 1202161486L)]
        public void Part2(long[] ids, long result)
        {
            Assert.That(Solver.Part2(ids), Is.EqualTo(result));
        }
    }
}