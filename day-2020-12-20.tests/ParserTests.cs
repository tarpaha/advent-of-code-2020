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
..###..###", 2311, 10)]
        public void ParseTile_Works_Correctly(string data, int id, int size)
        {
            var tile = Parser.ParseTile(data);
            Assert.That(tile.Id, Is.EqualTo(2311));
            Assert.That(tile.Size, Is.EqualTo(10));

            var dataLines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            for (var y = 1; y <= tile.Size; y++)
            {
                var dataLine = dataLines[y];
                var line = new string(Enumerable.Range(0, tile.Size).Select(x => tile.GetCell(x, y - 1)).Select(v => v ? '#' : '.').ToArray());
                Assert.That(line, Is.EqualTo(dataLine));
            }
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
.....##...", new [] { 2311, 1951, 1171 }, 10)]
        public void ParseTiles_Works_Correctly(string data, int[] ids, int size)
        {
            var tiles = Parser.ParseTiles(data).ToList();
            Assert.That(tiles.Select(tile => tile.Id), Is.EquivalentTo(ids));
            Assert.That(tiles.All(tile => tile.Size == size), Is.True);
        }
    }
}