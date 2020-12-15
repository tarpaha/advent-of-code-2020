using NUnit.Framework;
using System.Collections.Generic;

namespace day_2020_12_15.tests
{
    public class SolverTests
    {
        [TestCase(new[] {0, 3, 6}, 4, 0)]
        [TestCase(new[] {0, 3, 6}, 5, 3)]
        [TestCase(new[] {0, 3, 6}, 6, 3)]
        [TestCase(new[] {0, 3, 6}, 7, 1)]
        [TestCase(new[] {0, 3, 6}, 8, 0)]
        [TestCase(new[] {0, 3, 6}, 9, 4)]
        [TestCase(new[] {0, 3, 6}, 10, 0)]
        [TestCase(new[] {1, 3, 2}, 2020, 1)]
        [TestCase(new[] {2, 1, 3}, 2020, 10)]
        [TestCase(new[] {1, 2, 3}, 2020, 27)]
        [TestCase(new[] {2, 3, 1}, 2020, 78)]
        [TestCase(new[] {3, 2, 1}, 2020, 438)]
        [TestCase(new[] {3, 1, 2}, 2020, 1836)]
        public void Part1(IEnumerable<int> startingNumbers, int turns, int result)
        {
            Assert.That(Solver.Part1(startingNumbers, turns), Is.EqualTo(result));
        }
    }
}