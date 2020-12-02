using NUnit.Framework;

namespace day_2020_12_02.tests
{
    public class SolverTests
    {
        [TestCase(1, 3, 'a', "abcde", true)]
        [TestCase(1, 3, 'b', "cdefg", false)]
        [TestCase(2, 9, 'c', "ccccccccc", true)]
        public void PasswordIsValid_Works_Correctly(int min, int max, char ch, string password, bool result)
        {
            Assert.That(Solver.PasswordIsValid(new Record(min, max, ch, password)), Is.EqualTo(result));
        }
    }
}