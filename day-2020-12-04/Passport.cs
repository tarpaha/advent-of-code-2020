using System.Collections.Generic;

namespace day_2020_12_04
{
    public class Passport         
    {
        private readonly IReadOnlyDictionary<string, string> _dict;

        public Passport(IReadOnlyDictionary<string, string> dict)
        {
            _dict = dict;
        }

        public int ParametersCount => _dict.Count;
        
        public bool IsValidPart1 =>
            _dict.ContainsKey("byr") &&
            _dict.ContainsKey("iyr") &&
            _dict.ContainsKey("eyr") &&
            _dict.ContainsKey("hgt") &&
            _dict.ContainsKey("hcl") &&
            _dict.ContainsKey("ecl") &&
            _dict.ContainsKey("pid");

        public bool IsValidPart2 =>
            IsValidPart1 &&
            Validator.byr(_dict["byr"]) &&
            Validator.iyr(_dict["iyr"]) &&
            Validator.eyr(_dict["eyr"]) &&
            Validator.hgt(_dict["hgt"]) &&
            Validator.hcl(_dict["hcl"]) &&
            Validator.ecl(_dict["ecl"]) &&
            Validator.pid(_dict["pid"]);
    }
}