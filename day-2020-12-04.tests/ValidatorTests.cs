using NUnit.Framework;

namespace day_2020_12_04.tests
{
    public class ValidatorTests
    {
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("abc", false)]
        [TestCase("1919", false)]
        [TestCase("1920", true)]
        [TestCase("2002", true)]
        [TestCase("2003", false)]
        public void byr(string str, bool result)
        {
            Assert.That(Validator.byr(str), Is.EqualTo(result));
        }
        
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("abc", false)]
        [TestCase("2009", false)]
        [TestCase("2010", true)]
        [TestCase("2020", true)]
        [TestCase("2021", false)]
        public void iyr(string str, bool result)
        {
            Assert.That(Validator.iyr(str), Is.EqualTo(result));
        }
        
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("abc", false)]
        [TestCase("2019", false)]
        [TestCase("2020", true)]
        [TestCase("2030", true)]
        [TestCase("2031", false)]
        public void eyr(string str, bool result)
        {
            Assert.That(Validator.eyr(str), Is.EqualTo(result));
        }
        
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("abc", false)]
        [TestCase("58in", false)]
        [TestCase("59in", true)]
        [TestCase("76in", true)]
        [TestCase("77in", false)]
        [TestCase("149cm", false)]
        [TestCase("150cm", true)]
        [TestCase("193cm", true)]
        [TestCase("194cm", false)]
        [TestCase("1000", false)]
        [TestCase("60im", false)]
        [TestCase("150cn", false)]
        public void hgt(string str, bool result)
        {
            Assert.That(Validator.hgt(str), Is.EqualTo(result));
        }

        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("am", false)]
        [TestCase("amb ", false)]
        [TestCase("amc", false)]
        [TestCase("amb", true)]
        [TestCase("blu", true)]
        [TestCase("brn", true)]
        [TestCase("gry", true)]
        [TestCase("grn", true)]
        [TestCase("hzl", true)]
        [TestCase("oth", true)]
        public void ecl(string str, bool result)
        {
            Assert.That(Validator.ecl(str), Is.EqualTo(result));
        }

        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("10000001", false)]
        [TestCase("000000001", true)]
        [TestCase("0123456789", false)]
        [TestCase("0000000a1", false)]
        [TestCase("012345678", true)]
        [TestCase("000000000", true)]
        public void pid(string str, bool result)
        {
            Assert.That(Validator.pid(str), Is.EqualTo(result));
        }
    }
}