using System.Collections.Generic;

namespace day_2020_12_04
{
    public class Passport : IPassword         
    {
        private readonly IReadOnlyDictionary<string, string> _dict;

        public Passport(IReadOnlyDictionary<string, string> dict)
        {
            _dict = dict;
        }

        public bool IsValid =>
            _dict.ContainsKey("byr") &&
            _dict.ContainsKey("iyr") &&
            _dict.ContainsKey("eyr") &&
            _dict.ContainsKey("hgt") &&
            _dict.ContainsKey("hcl") &&
            _dict.ContainsKey("ecl") &&
            _dict.ContainsKey("pid");
    }
}