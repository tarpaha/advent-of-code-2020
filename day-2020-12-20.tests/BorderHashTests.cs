using NUnit.Framework;

namespace day_2020_12_20.tests
{
    public class BorderHashTests
    {
        [TestCase(@"
Tile 2311:
..##.#..#.
##..#.....
#...##..#.
####.#...#
##.##.###.
##...#.###
.#.#.#..##
..#....#..
###...#.#.
..###..###",
            0b0111110010,
            0b0001011001,
            0b0011010010,
            0b0011100111)]
        public void Calculate_Works_Correctly(string data, int left, int right, int top, int bottom)
        {
            var tile = Parser.ParseTile(data);
            Assert.That(tile.Left, Is.EqualTo(left));
            Assert.That(tile.Right, Is.EqualTo(right));
            Assert.That(tile.Top, Is.EqualTo(top));
            Assert.That(tile.Bottom, Is.EqualTo(bottom));
        }
    }
}