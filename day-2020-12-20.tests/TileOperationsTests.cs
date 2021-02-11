using NUnit.Framework;

namespace day_2020_12_20.tests
{
    public class TileOperationsTests
    {
        private Tile _tile;

        [SetUp]
        public void Init()
        {
            _tile = Parser.ParseTile(@"
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
..###..###");
        }

        
        [Test]
        public void RotateClockwise_Works_Correctly()
        {
            var rotated = TileOperations.RotateClockwise(_tile);
            
            Assert.That(rotated.Right, Is.EqualTo(_tile.Top));
            Assert.That(rotated.Bottom, Is.EqualTo(0b1001101000)); // inverted tile right
            Assert.That(rotated.Left, Is.EqualTo(_tile.Bottom));
            Assert.That(rotated.Top, Is.EqualTo(0b0100111110)); // inverted left
        }

        [Test]
        public void RotateClockwise_4Times_ReturnsTheSame()
        {
            var rotated = TileOperations.RotateClockwise(_tile);
            rotated = TileOperations.RotateClockwise(rotated);
            rotated = TileOperations.RotateClockwise(rotated);
            rotated = TileOperations.RotateClockwise(rotated);
            
            Assert.That(_tile.Top, Is.EqualTo(rotated.Top));
            Assert.That(_tile.Bottom, Is.EqualTo(rotated.Bottom));
            Assert.That(_tile.Left, Is.EqualTo(rotated.Left));
            Assert.That(_tile.Right, Is.EqualTo(rotated.Right));
        }

        [Test]
        public void FlipHorizontal_Works_Correctly()
        {
            var flipped = TileOperations.FlipHorizontal(_tile);
            
            Assert.That(flipped.Right, Is.EqualTo(_tile.Left));
            Assert.That(flipped.Left, Is.EqualTo(_tile.Right));
            Assert.That(flipped.Top, Is.EqualTo(0b0100101100)); // inverted tile top
            Assert.That(flipped.Bottom, Is.EqualTo(0b1110011100)); // inverted tile bottom
        }

        [Test]
        public void FlipHorizontal_2Times_ReturnsTheSame()
        {
            var flipped = TileOperations.FlipHorizontal(_tile);
            flipped = TileOperations.FlipHorizontal(flipped);

            Assert.That(flipped.Top, Is.EqualTo(_tile.Top));
            Assert.That(flipped.Bottom, Is.EqualTo(_tile.Bottom));
            Assert.That(flipped.Left, Is.EqualTo(_tile.Left));
            Assert.That(flipped.Right, Is.EqualTo(_tile.Right));
        }
    }
}