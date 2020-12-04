using System.Linq;
using NUnit.Framework;

namespace day_2020_12_04.tests
{
    public class ParserTests
    {
        [Test]
        public void ParsePassports_Works_Correctly()
        {
            const string data = @"
ecl:gry pid:860033327 eyr:2020 hcl:#fffffd
byr:1937 iyr:2017 cid:147 hgt:183cm

iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884
hcl:#cfa07d byr:1929

hcl:#ae17e1 iyr:2013
eyr:2024
ecl:brn pid:760753108 byr:1931
hgt:179cm

hcl:#cfa07d eyr:2025 pid:166559648
iyr:2011 ecl:brn hgt:59in";
            var passports = Parser.ParsePassports(data);
            Assert.That(passports.Count(), Is.EqualTo(4));
        }
        
        [TestCase("ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm", true)]
        [TestCase("iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884 hcl:#cfa07d byr:1929", false)]
        public void ParsePassport_Works_Correctly(string data, bool result)
        {
            Assert.That(Parser.ParsePassport(data).IsValid, Is.EqualTo(result));
        }
    }
}