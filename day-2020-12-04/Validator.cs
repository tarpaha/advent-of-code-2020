using System.Collections.Generic;
using System.Linq;

namespace day_2020_12_04
{
    public static class Validator
    {
        public static bool byr(string str) => NumberBetween(str, 1920, 2002);
        public static bool iyr(string str) => NumberBetween(str, 2010, 2020);
        public static bool eyr(string str) => NumberBetween(str, 2020, 2030);

        public static bool hgt(string str)
        {
            if (str == null || str.Length < 4 || str.Length > 5)
                return false;
            return str[^2..] switch
            {
                "cm" => NumberBetween(str[..^2], 150, 193),
                "in" => NumberBetween(str[..^2], 59, 76),
                _ => false
            };
        }

        public static bool hcl(string str)
        {
            return str != null &&
                   str.Length == 7 &&
                   str[0] == '#' && 
                   str[1..].All(HexadecimalDigit);
        }

        public static bool ecl(string str)
        {
            return str != null
                   && Colors.Contains(str);
        }

        public static bool pid(string str)
        {
            return str != null
                   && str.Length == 9
                   && str.All(DecimalDigit);
        }

        private static readonly HashSet<string> Colors = new HashSet<string>(new [] {
            "amb", "blu", "brn", "gry", "grn", "hzl", "oth"
        }); 
        
        private static bool NumberBetween(string str, int min, int max)
        {
            try
            {
                var num = int.Parse(str);
                return min <= num && num <= max;
            }
            catch
            {
                return false;
            }
        }

        private static bool DecimalDigit(char ch)
        {
            return '0' <= ch && ch <= '9';
        }
        
        private static bool HexadecimalDigit(char ch)
        {
            return DecimalDigit(ch) || ('a' <= ch && ch <= 'f');
        }
    }
}