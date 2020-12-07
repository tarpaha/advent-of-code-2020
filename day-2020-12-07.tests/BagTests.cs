using System.Linq;
using NUnit.Framework;

namespace day_2020_12_07.tests
{
    public class BagTests
    {
        [Test]
        public void AddInnerBag_Works_Correctly()
        {
            var a = new Bag("A");
            var b = new Bag("B");
            var c = new Bag("C");
            
            a.AddInnerBag(b, 1);
            a.AddInnerBag(c, 2);
            
            Assert.That(a.OuterBags.Count(), Is.Zero);
            Assert.That(a.InnerBags, Is.EquivalentTo(new [] { (b, 1), (c, 2) }));
            
            Assert.That(b.InnerBags.Count(), Is.Zero);
            Assert.That(b.OuterBags, Is.EquivalentTo(new [] { a }));

            Assert.That(c.InnerBags.Count(), Is.Zero);
            Assert.That(c.OuterBags, Is.EquivalentTo(new [] { a }));
        }
    }
}