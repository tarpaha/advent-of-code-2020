using System.Linq;
using NUnit.Framework;

namespace day_2020_12_14.tests
{
    public class Computer2Tests
    {
        [TestCase("000000000000000000000000000000X1101X", new long[] { 26, 27, 58, 59 })]
        [TestCase("00000000000000000000000000000001X0XX", new long[] { 16, 17, 18, 19, 24, 25, 26, 27 })]
        public void ExpandTemplate_Works_Correctly(string mask, long[] result)
        {
            var masks = Computer2.ExpandTemplate(mask);
            Assert.That(masks.OrderBy(m => m), Is.EquivalentTo(result.OrderBy(m => m)));
        }

        [TestCase(0, "000000000000000000000000000000000000")]
        [TestCase(42, "000000000000000000000000000000101010")]
        public void DecimalToBinary36_Works_Correctly(long number, string result)
        {
            Assert.That(Computer2.DecimalToBinary36(number).ToString(), Is.EqualTo(result));
        }
    }
}