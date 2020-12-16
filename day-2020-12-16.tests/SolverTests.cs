using NUnit.Framework;

namespace day_2020_12_16.tests
{
    public class SolverTests
    {
        [TestCase(@"
class: 1-3 or 5-7
row: 6-11 or 33-44
seat: 13-40 or 45-50

your ticket:
7,1,14

nearby tickets:
7,3,47
40,4,50
55,2,20
38,6,12", 71)]
        public void Part1(string data, int result)
        {
            Assert.That(Solver.Part1(Parser.Parse(data)), Is.EqualTo(result));
        }
        
        [TestCase("class: 1-3 or 5-7", 0, false)]
        [TestCase("class: 1-3 or 5-7", 1, true)]
        [TestCase("class: 1-3 or 5-7", 2, true)]
        [TestCase("class: 1-3 or 5-7", 3, true)]
        [TestCase("class: 1-3 or 5-7", 4, false)]
        [TestCase("class: 1-3 or 5-7", 5, true)]
        [TestCase("class: 1-3 or 5-7", 6, true)]
        [TestCase("class: 1-3 or 5-7", 7, true)]
        [TestCase("class: 1-3 or 5-7", 8, false)]
        public void NumberIsValid_Works_Correctly(string ruleStr, int number, bool result)
        {
            Assert.That(Solver.NumberIsValid(number, Parser.ParseRule(ruleStr)), Is.EqualTo(result));
        }
    }
}