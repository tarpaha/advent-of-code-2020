using NUnit.Framework;

namespace day_2020_12_21.tests
{
    public class SolverTests
    {
        private Problem _problem;
        
        [SetUp]
        public void Init()
        {
            _problem = Parser.Parse(@"
mxmxvkd kfcds sqjhc nhms (contains dairy, fish)
trh fvjkl sbzzf mxmxvkd (contains dairy)
sqjhc fvjkl (contains soy)
sqjhc mxmxvkd sbzzf (contains fish)");
        }

        [TestCase(5)]
        public void Part1(int result)
        {
            Assert.That(Solver.Part1(_problem), Is.EqualTo(result));
        }

        [TestCase("mxmxvkd,sqjhc,fvjkl")]
        public void Part2(string result)
        {
            Assert.That(Solver.Part2(_problem), Is.EqualTo(result));
        }
    }
}