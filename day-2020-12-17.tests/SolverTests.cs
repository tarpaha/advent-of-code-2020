using System.Linq;
using NUnit.Framework;

namespace day_2020_12_17.tests
{
    public class SolverTests
    {
        [TestCase(".#.|..#|###", "|", 6, 112)]
        public void Part1(string data, string separator, int cyclesCount, int result)
        {
            Assert.That(Solver.Part1(Parser.Parse3D(data, separator), cyclesCount), Is.EqualTo(result));
        }
        
        [Test]
        public void Simulate3D_Works_Correctly()
        {
            var grid = Solver.Simulate3D(Parser.Parse3D(".#.|..#|###", "|"));
            var ((xMin, xMax), (yMin, yMax), _) = grid.GetDimensions();
            Assert.That(GetSliceStr(grid, (xMin, yMin), (xMax, yMax), -1), Is.EqualTo("#..|..#|.#."));
            Assert.That(GetSliceStr(grid, (xMin, yMin), (xMax, yMax),  0), Is.EqualTo("#.#|.##|.#."));
            Assert.That(GetSliceStr(grid, (xMin, yMin), (xMax, yMax), +1), Is.EqualTo("#..|..#|.#."));
            
        }

        [TestCase(".#.|..#|###", "|", 0, 0, 0, 1)]
        [TestCase(".#.|..#|###", "|", 1, 0, 0, 1)]
        [TestCase(".#.|..#|###", "|", 2, 0, 0, 2)]
        [TestCase(".#.|..#|###", "|", 2, 2, 0, 2)]
        [TestCase(".#.|..#|###", "|", 2, 2, -1, 3)]
        [TestCase(".#.|..#|###", "|", 2, 2, +1, 3)]
        public void GetNeighborsCount3D_Works_Correctly(string data, string separator, int x, int y, int z, int result)
        {
            Assert.That(Solver.GetNeighborsCount(Parser.Parse3D(data, separator), x, y, z), Is.EqualTo(result));
        }
        
        private static string GetSliceStr(Grid3D grid, (int x, int y) min, (int x, int y) max, int z)
        {
            var a = string.Join("|", Enumerable.Range(min.y, max.y - min.y + 1).Select(y =>
                string.Concat(Enumerable.Range(min.x, max.x - min.x + 1).Select(x => grid.IsCubeActive(x, y, z) ? '#' : '.'))));
            return a;
        }
    }
}