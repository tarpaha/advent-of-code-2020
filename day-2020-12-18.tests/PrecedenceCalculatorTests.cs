using NUnit.Framework;

namespace day_2020_12_18.tests
{
    public class PrecedenceCalculatorTests
    {
        [TestCase("1", 1)]
        [TestCase("1 + 2", 3)]
        [TestCase("1 * 2", 2)]
        [TestCase("2 * 2 + 3", 10)]
        [TestCase("(2 * 2) + 3", 7)]
        [TestCase("1 + (2 * 3) + (4 * (5 + 6))", 51)]
        [TestCase("2 * 3 + (4 * 5)", 46)]
        [TestCase("5 + (8 * 3 + 9 + 3 * 4 * 3)", 1445)]
        [TestCase("5 * 9 * (7 * 3 * 3 + 9 * 3 + (8 + 6 * 4))", 669060)]
        [TestCase("((2 + 4 * 9) * (6 + 9 * 8 + 6) + 6) + 2 + 4 * 2", 23340)]        
        public void Calculate_Works_Correctly(string input, int result)
        { 
            Assert.That(PrecedenceCalculator.Calculate(input), Is.EqualTo(result));   
        }
    }
}