using System.Linq;
using NUnit.Framework;

namespace day_2020_12_11.tests
{
    public class ParserTests
    {
        [TestCase(@"
L.LL.LL.LL
LLLLLLL.LL
L.L.L..L..
LLLL.LL.LL
L.LL.LL.LL
L.LLLLL.LL
..L.L.....
LLLLLLLLLL
L.LLLLLL.L
L.LLLLL.LL")]
        public void Parse_Works_Correctly(string data)
        {
            var cells = Parser.Parse(data);
            
            Assert.That(cells.GetLength(0), Is.EqualTo(10));
            Assert.That(cells.GetLength(1), Is.EqualTo(10));
            
            Assert.That(GetCellsCount(cells, Cell.Floor), Is.EqualTo(data.Count(ch => ch == '.')));
            Assert.That(GetCellsCount(cells, Cell.EmptySeat), Is.EqualTo(data.Count(ch => ch == 'L')));
        }

        private static int GetCellsCount(Cell[,] cells, Cell cellType)
        {
            return Enumerable
                .Range(0, cells.GetLength(0))
                .Select(x => 
                {
                    return Enumerable
                        .Range(0, cells.GetLength(1))
                        .Count(y => cells[x, y] == cellType);
                })
                .Sum();
        }
    }
}