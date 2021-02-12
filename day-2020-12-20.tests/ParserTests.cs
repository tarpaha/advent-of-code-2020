using System;
using System.Linq;
using NUnit.Framework;

namespace day_2020_12_20.tests
{
    public class ParserTests
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
        public void ParseTile_Works_Correctly(string data)
        {
            var tile = Parser.ParseTile(data);
            Assert.That(Environment.NewLine + TileOperations.ToString(tile), Is.EqualTo(data));
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
..###..###

Tile 1951:
#.##...##.
#.####...#
.....#..##
#...######
.##.#....#
.###.#####
###.##.##.
.###....#.
..#.#..#.#
#...##.#..

Tile 1171:
####...##.
#..##.#..#
##.#..#.#.
.###.####.
..###.####
.##....##.
.#...####.
#.##.####.
####..#...
.....##...")]
        public void ParseTiles_Works_Correctly(string data)
        {
            var tiles = Parser.ParseTiles(data);
            var result = Environment.NewLine + string.Join($"{Environment.NewLine}{Environment.NewLine}", tiles.Select(TileOperations.ToString));
            Assert.That(result, Is.EqualTo(data));
        }
    }
}