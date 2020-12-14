using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day_2020_12_14
{
    public class Computer2
    {
        public static IEnumerable<long> ExpandMask(string maskTemplate)
        {
            var masks = new List<string> {maskTemplate};
            for (var i = 0; i < masks.Count; i++)
            { 
                var xPos = masks[i].IndexOf('X');
                if (xPos < 0)
                    continue;

                var mask = new StringBuilder(masks[i]);

                mask[xPos] = '0';
                masks[i] = mask.ToString();
                
                mask[xPos] = '1';
                masks.Add(mask.ToString());

                i -= 1;
            }
            return masks.Select(m => Convert.ToInt64(m, 2)).ToList();
        }
    }
}