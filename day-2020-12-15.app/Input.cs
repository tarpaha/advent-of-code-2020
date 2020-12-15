using System;
using System.Linq;
using System.Collections.Generic;

namespace day_2020_12_15.app
{
    public static class Input
    {
        public static IEnumerable<int> GetData()
        {
            return GetDataText()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        }

        private static string GetDataText()
        {
            return @"11,18,0,20,1,7,16";
        }
    }
}