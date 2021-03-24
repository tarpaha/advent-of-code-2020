using NUnit.Framework;

namespace day_2020_12_24.tests
{
    public class SolverTests
    {
        private string _data;
        
        [SetUp]
        public void Init()
        {
            _data = @"
sesenwnenenewseeswwswswwnenewsewsw
neeenesenwnwwswnenewnwwsewnenwseswesw
seswneswswsenwwnwse
nwnwneseeswswnenewneswwnewseswneseene
swweswneswnenwsewnwneneseenw
eesenwseswswnenwswnwnwsewwnwsene
sewnenenenesenwsewnenwwwse
wenwwweseeeweswwwnwwe
wsweesenenewnwwnwsenewsenwwsesesenwne
neeswseenwwswnwswswnw
nenwswwsewswnenenewsenwsenwnesesenew
enewnwewneswsewnwswenweswnenwsenwsw
sweneswneswneneenwnewenewwneswswnese
swwesenesewenwneswnwwneseswwne
enesenwswwswneneswsenwnewswseenwsese
wnwnesenesenenwwnenwsewesewsesesew
nenewswnwewswnenesenwnesewesw
eneswnwswnwsenenwnwnwwseeswneewsenese
neswnwewnwnwseenwseesewsenwsweewe
wseweeenwnesenwwwswnew";
        }
        
        
        [TestCase(10)]
        public void Part1(int result)
        {
            Assert.That(Solver.Part1(_data), Is.EqualTo(result));
        }

        [TestCase(1, 15)]
        [TestCase(2, 12)]
        [TestCase(3, 25)]
        [TestCase(4, 14)]
        [TestCase(5, 23)]
        [TestCase(6, 28)]
        [TestCase(7, 41)]
        [TestCase(8, 37)]
        [TestCase(9, 49)]
        [TestCase(10, 37)]
        [TestCase(20, 132)]
        [TestCase(30, 259)]
        [TestCase(40, 406)]
        [TestCase(50, 566)]
        [TestCase(60, 788)]
        [TestCase(70, 1106)]
        [TestCase(80, 1373)]
        [TestCase(90, 1844)]
        [TestCase(100, 2208)]
        public void Part2(int days, int result)
        {
            Assert.That(Solver.Part2(_data, days), Is.EqualTo(result));
        }

        [TestCase(0, 0, "nwwswee", 0, 0)]
        [TestCase(0, 0, "nwswseenenwsw", 0, 0)]
        public void Move_Works_Correctly(int x1, int y1, string str, int x2, int y2)
        {
            var result = Solver.Move((x1, y1), Parser.Parse(str));
            Assert.That(result, Is.EqualTo((x2, y2)));
        }
    }
}