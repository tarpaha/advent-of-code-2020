using NUnit.Framework;
using System.Collections.Generic;
using utils;

namespace solutions.tests
{
    public class Tests
    {
        private static IEnumerable<TestCaseData> SolutionsTestCases
        {
            get
            {
                yield return new TestCaseData(new day_2020_12_01.app.Solution(), 1016131, 276432018);
                yield return new TestCaseData(new day_2020_12_02.app.Solution(), 493, 593);
                yield return new TestCaseData(new day_2020_12_03.app.Solution(), 156, 3521829480);
                yield return new TestCaseData(new day_2020_12_04.app.Solution(), 192, null);
            }
        }

        [TestCaseSource(nameof(SolutionsTestCases))]
        public void Test(ISolution solution, object result1, object result2)
        {
            if(result1 != null)
                Assert.That(solution.SolvePart1(), Is.EqualTo(result1));
            if(result2 != null)
                Assert.That(solution.SolvePart2(), Is.EqualTo(result2));
        }
    }
}