using NUnit.Framework;

namespace day_2020_12_11.tests
{
    public class Model2Tests
    {
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
            1, 1, 1)]

        [TestCase(@"
.............
.L.L.........
.............",
            1, 1, 1)]
        
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
            Assert.That(Model2.GetVisibleSeatsCount(Parser.Parse(data), x, y), Is.EqualTo(result));
        }

        [TestCase(@"L..", 1, 0, -1, 0, 1)]
        [TestCase(@"L..", 1, 0, +1, 0, 0)]
        public void IsSeatVisible_Works_Correctly(string data, int x, int y, int dx, int dy, int result)
        {
            Assert.That(Model2.IsSeatVisible(Parser.Parse(data), x, y, dx, dy), Is.EqualTo(result));
        }
    }
}