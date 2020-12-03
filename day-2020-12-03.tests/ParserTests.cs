using System.Linq;
using NUnit.Framework;

namespace day_2020_12_03.tests
{
    public class ParserTests
    {
        [Test]
        public void Parse_Works_Correctly()
        {
            const string data = "..##|#...|.#..";
            var cells = Parser.Parse(data, "|");
            
            Assert.That(cells.GetLength(0), Is.EqualTo(4));
            Assert.That(cells.GetLength(1), Is.EqualTo(3));

            var treesCount = Enumerable.Range(0, cells.GetLength(0))
                .Select(x => 
                {
                    return Enumerable.Range(0, cells.GetLength(1))
                        .Count(y => cells[x, y]);
                })
                .Sum();
            Assert.That(treesCount, Is.EqualTo(data.Count(ch => ch == '#')));
        }
    }
}