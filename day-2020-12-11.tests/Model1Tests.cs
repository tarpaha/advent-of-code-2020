using NUnit.Framework;

namespace day_2020_12_11.tests
{
    public class Model1Tests
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
L.LLLLL.LL",
            @"
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
#.#####.##",
            @"
#.LL.L#.##
#LLLLLL.L#
L.L.L..L..
#LLL.LL.L#
#.LL.LL.LL
#.LLLL#.##
..L.L.....
#LLLLLLLL#
#.LLLLLL.L
#.#LLLL.##")]
        
        [TestCase(@"
#.LL.L#.##
#LLLLLL.L#
L.L.L..L..
#LLL.LL.L#
#.LL.LL.LL
#.LLLL#.##
..L.L.....
#LLLLLLLL#
#.LLLLLL.L
#.#LLLL.##",
            @"
#.##.L#.##
#L###LL.L#
L.#.#..#..
#L##.##.L#
#.##.LL.LL
#.###L#.##
..#.#.....
#L######L#
#.LL###L.L
#.#L###.##")]
        
        [TestCase(@"
#.##.L#.##
#L###LL.L#
L.#.#..#..
#L##.##.L#
#.##.LL.LL
#.###L#.##
..#.#.....
#L######L#
#.LL###L.L
#.#L###.##",
            @"
#.#L.L#.##
#LLL#LL.L#
L.L.L..#..
#LLL.##.L#
#.LL.LL.LL
#.LL#L#.##
..L.L.....
#L#LLLL#L#
#.LLLLLL.L
#.#L#L#.##")]
        
        [TestCase(@"
#.#L.L#.##
#LLL#LL.L#
L.L.L..#..
#LLL.##.L#
#.LL.LL.LL
#.LL#L#.##
..L.L.....
#L#LLLL#L#
#.LLLLLL.L
#.#L#L#.##",
            @"
#.#L.L#.##
#LLL#LL.L#
L.#.L..#..
#L##.##.L#
#.#L.LL.LL
#.#L#L#.##
..L.L.....
#L#L##L#L#
#.LLLLLL.L
#.#L#L#.##")]
        public void Step_Works_Correctly(string dataBefore, string dataAfter)
        {
            var cellsBefore = Parser.Parse(dataBefore);
            var cellsAfter = Parser.Parse(dataAfter);
            
            var (cells, changed) = Model1.Step(cellsBefore);
            
            Assert.That(changed, Is.True);
            Assert.That(cells, Is.EquivalentTo(cellsAfter));
        }

        [Test]
        public void GetAdjacentOccupiedSeatsCount_Works_Correctly()
        {
            const string data = @"
L#.
L##
###
";
            var cells = Parser.Parse(data);
            Assert.That(Model1.GetAdjacentOccupiedSeatsCount(cells, 0, 0), Is.EqualTo(2));
            Assert.That(Model1.GetAdjacentOccupiedSeatsCount(cells, 1, 0), Is.EqualTo(2));
            Assert.That(Model1.GetAdjacentOccupiedSeatsCount(cells, 2, 0), Is.EqualTo(3));
            Assert.That(Model1.GetAdjacentOccupiedSeatsCount(cells, 0, 1), Is.EqualTo(4));
            Assert.That(Model1.GetAdjacentOccupiedSeatsCount(cells, 1, 1), Is.EqualTo(5));
            Assert.That(Model1.GetAdjacentOccupiedSeatsCount(cells, 2, 1), Is.EqualTo(4));
            Assert.That(Model1.GetAdjacentOccupiedSeatsCount(cells, 0, 2), Is.EqualTo(2));
            Assert.That(Model1.GetAdjacentOccupiedSeatsCount(cells, 1, 2), Is.EqualTo(4));
            Assert.That(Model1.GetAdjacentOccupiedSeatsCount(cells, 2, 2), Is.EqualTo(3));
        }
    }
}