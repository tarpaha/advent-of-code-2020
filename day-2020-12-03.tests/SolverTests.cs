using NUnit.Framework;

namespace day_2020_12_03.tests
{
    public class SolverTests
    {
        private bool[,] _cells;
        
        [OneTimeSetUp]
        public void Setup()
        {
            const string data = "..##.......|#...#...#..|.#....#..#.|..#.#...#.#|.#...##..#.|..#.##.....|.#.#.#....#|.#........#|#.##...#...|#...##....#|.#..#...#.#";
            _cells = Parser.Parse(data, "|");
        }

        [TestCase(1, 1, 2)]
        [TestCase(3, 1, 7)]
        [TestCase(5, 1, 3)]
        [TestCase(7, 1, 4)]
        [TestCase(1, 2, 2)]
        public void TreesCount_Works_Correctly(int stepX, int stepY, int result)
        {
            var trees = Solver.TreesCount(_cells, stepX, stepY);
            Assert.That(trees, Is.EqualTo(result));
        }
    }
}