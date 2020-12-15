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
                yield return new TestCaseData(new day_2020_12_04.app.Solution(), 192, 101);
                yield return new TestCaseData(new day_2020_12_05.app.Solution(), 835, 649);
                yield return new TestCaseData(new day_2020_12_06.app.Solution(), 6583, 3290);
                yield return new TestCaseData(new day_2020_12_07.app.Solution(), 272, 172246);
                yield return new TestCaseData(new day_2020_12_08.app.Solution(), 1915, 944);
                yield return new TestCaseData(new day_2020_12_09.app.Solution(), 3199139634, 438559930);
                yield return new TestCaseData(new day_2020_12_10.app.Solution(), 2244, 3947645370368);
                yield return new TestCaseData(new day_2020_12_11.app.Solution(), 2261, 2039);
                yield return new TestCaseData(new day_2020_12_12.app.Solution(), 2270, 138669);
                yield return new TestCaseData(new day_2020_12_13.app.Solution(), 410, null);
                yield return new TestCaseData(new day_2020_12_14.app.Solution(), 12512013221615, 3905642473893);
                yield return new TestCaseData(new day_2020_12_15.app.Solution(), null, null);
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