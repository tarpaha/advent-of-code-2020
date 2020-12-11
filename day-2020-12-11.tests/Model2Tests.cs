using System;
using NUnit.Framework;

namespace day_2020_12_11.tests
{
    public class Model2Tests
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
L.LLLLL.LL", @"
#.##.##.##
#######.##
#.#.#..#..
####.##.##
#.##.##.##
#.#####.##
..#.#.....
##########
#.######.#
#.#####.##")]
        
        [TestCase(@"
#.##.##.##
#######.##
#.#.#..#..
####.##.##
#.##.##.##
#.#####.##
..#.#.....
##########
#.######.#
#.#####.##", @"
#.LL.LL.L#
#LLLLLL.LL
L.L.L..L..
LLLL.LL.LL
L.LL.LL.LL
L.LLLLL.LL
..L.L.....
LLLLLLLLL#
#.LLLLLL.L
#.LLLLL.L#")]
        
        [TestCase(@"
#.LL.LL.L#
#LLLLLL.LL
L.L.L..L..
LLLL.LL.LL
L.LL.LL.LL
L.LLLLL.LL
..L.L.....
LLLLLLLLL#
#.LLLLLL.L
#.LLLLL.L#", @"
#.L#.##.L#
#L#####.LL
L.#.#..#..
##L#.##.##
#.##.#L.##
#.#####.#L
..#.#.....
LLL####LL#
#.L#####.L
#.L####.L#")]
        
        [TestCase(@"
#.L#.##.L#
#L#####.LL
L.#.#..#..
##L#.##.##
#.##.#L.##
#.#####.#L
..#.#.....
LLL####LL#
#.L#####.L
#.L####.L#", @"
#.L#.L#.L#
#LLLLLL.LL
L.L.L..#..
##LL.LL.L#
L.LL.LL.L#
#.LLLLL.LL
..L.L.....
LLLLLLLLL#
#.LLLLL#.L
#.L#LL#.L#")]
        
        [TestCase(@"
#.L#.L#.L#
#LLLLLL.LL
L.L.L..#..
##LL.LL.L#
L.LL.LL.L#
#.LLLLL.LL
..L.L.....
LLLLLLLLL#
#.LLLLL#.L
#.L#LL#.L#", @"
#.L#.L#.L#
#LLLLLL.LL
L.L.L..#..
##L#.#L.L#
L.L#.#L.L#
#.L####.LL
..#.#.....
LLL###LLL#
#.LLLLL#.L
#.L#LL#.L#")]
        
        [TestCase(@"
#.L#.L#.L#
#LLLLLL.LL
L.L.L..#..
##L#.#L.L#
L.L#.#L.L#
#.L####.LL
..#.#.....
LLL###LLL#
#.LLLLL#.L
#.L#LL#.L#", @"
#.L#.L#.L#
#LLLLLL.LL
L.L.L..#..
##L#.#L.L#
L.L#.LL.L#
#.LLLL#.LL
..#.L.....
LLL###LLL#
#.LLLLL#.L
#.L#LL#.L#")]
        public void Step_Works_Correctly(string dataBefore, string dataAfter)
        {
            var cellsBefore = Parser.Parse(dataBefore);
            var cellsAfter = Parser.Parse(dataAfter);
            
            var (cells, changed) = Model2.Step(cellsBefore);

            Assert.That(changed, Is.True);
            Assert.That(cells, Is.EquivalentTo(cellsAfter));
        }
        
        [TestCase(@".......#.
...#.....
.#.......
.........
..#L....#
....#....
.........
#........
...#.....",
            3, 4, 8)]
        
        [TestCase(@"
.............
.L.L.#.#.#.#.
.............",
            1, 1, 0)]

        [TestCase(@"
.##.##.
#.#.#.#
##...##
...L...
##...##
#.#.#.#
.##.##.",
            3, 3, 0)]
        
        public void GetVisibleOccupiedSeatsCount_Works_Correctly(string data, int x, int y, int result)
        {
            Assert.That(Model2.GetVisibleOccupiedSeatsCount(Parser.Parse(data), x, y), Is.EqualTo(result));
        }

        [TestCase(@"L..", 1, 0, -1, 0, 0)]
        [TestCase(@"L..", 1, 0, +1, 0, 0)]
        [TestCase(@"#..", 1, 0, -1, 0, 1)]
        [TestCase(@"#..", 1, 0, +1, 0, 0)]
        public void IsSeatVisible_Works_Correctly(string data, int x, int y, int dx, int dy, int result)
        {
            Assert.That(Model2.IsOccupiedSeatVisible(Parser.Parse(data), x, y, dx, dy), Is.EqualTo(result));
        }
    }
}