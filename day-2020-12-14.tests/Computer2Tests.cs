using System.Linq;
using NUnit.Framework;

namespace day_2020_12_14.tests
{
    public class Computer2Tests
    {
        [TestCase("XX", new long[] { 0, 1, 2, 3 })]
        [TestCase("00000000000000000000000000000000X0XX", new long[] { 0, 1, 2, 3, 8, 9, 10, 11 })]
        public void ExpandMask_Works_Correctly(string mask, long[] result)
        {
            var masks = Computer2.ExpandMask(mask);
            Assert.That(masks.OrderBy(m => m), Is.EquivalentTo(result.OrderBy(m => m)));
        }
    }
}