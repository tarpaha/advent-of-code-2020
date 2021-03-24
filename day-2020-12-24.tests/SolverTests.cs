using NUnit.Framework;

namespace day_2020_12_24.tests
{
    public class SolverTests
    {
        [TestCase(@"
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
wseweeenwnesenwwwswnew", 10)]
        public void Part1(string data, int result)
        {
            Assert.That(Solver.Part1(data), Is.EqualTo(result));
        }

        [Test]
        public void Part2()
        {
            Assert.That(Solver.Part2(), Is.Null);
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