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
            
            Assert.That(rotatedTile.Right, Is.EqualTo(tile.Top));
            Assert.That(rotatedTile.Bottom, Is.EqualTo(0b1001101000)); // inverted tile right
            Assert.That(rotatedTile.Left, Is.EqualTo(tile.Bottom));
            Assert.That(rotatedTile.Top, Is.EqualTo(0b0100111110)); // inverted left
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
        public void FlipHorizontal_Works_Correctly(string data)
        {
            var tile = Parser.ParseTile(data);
            var flippedTile = TileOperations.FlipHorizontal(tile);
            
            Assert.That(flippedTile.Right, Is.EqualTo(tile.Left));
            Assert.That(flippedTile.Left, Is.EqualTo(tile.Right));
            Assert.That(flippedTile.Top, Is.EqualTo(0b0100101100)); // inverted tile top
            Assert.That(flippedTile.Bottom, Is.EqualTo(0b1110011100)); // inverted tile bottom
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
        public void FlipHorizontal_2Times_ReturnsTheSame(string data)
        {
            var tile = Parser.ParseTile(data);
            var flipped = TileOperations.FlipHorizontal(tile);
            flipped = TileOperations.FlipHorizontal(flipped);

            Assert.That(flipped.Top, Is.EqualTo(tile.Top));
            Assert.That(flipped.Bottom, Is.EqualTo(tile.Bottom));
            Assert.That(flipped.Left, Is.EqualTo(tile.Left));
            Assert.That(flipped.Right, Is.EqualTo(tile.Right));
        }
    }
}