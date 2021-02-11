using NUnit.Framework;

namespace day_2020_12_20.tests
{
    public class TileOperationsTests
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
..###..###")]
        public void RotateClockwise_Works_Correctly(string data)
        {
            var tile = Parser.ParseTile(data);
            var rotatedTile = TileOperations.RotateClockwise(tile);
            
            Assert.That(tile.Top, Is.EqualTo(rotatedTile.Right));
            Assert.That(tile.Right, Is.EqualTo(rotatedTile.Bottom));
            Assert.That(tile.Bottom, Is.EqualTo(rotatedTile.Left));
            Assert.That(tile.Left, Is.EqualTo(rotatedTile.Top));
        }

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
..###..###")]
        public void RotateClockwise_4Times_ReturnsTheSame(string data)
        {
            var source = Parser.ParseTile(data);
            var rotated = TileOperations.RotateClockwise(source);
            rotated = TileOperations.RotateClockwise(rotated);
            rotated = TileOperations.RotateClockwise(rotated);
            rotated = TileOperations.RotateClockwise(rotated);
            
            Assert.That(source.Top, Is.EqualTo(rotated.Top));
            Assert.That(source.Bottom, Is.EqualTo(rotated.Bottom));
            Assert.That(source.Left, Is.EqualTo(rotated.Left));
            Assert.That(source.Right, Is.EqualTo(rotated.Right));
        }
    }
}