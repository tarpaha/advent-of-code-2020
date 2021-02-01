using System.Linq;
using day_2020_12_19.Rules;

namespace day_2020_12_19
{
    public static class Solver
    {
        public static int Part1(Problem problem)
        {
            var rule = problem.Rules[0];
            return problem.Messages.Count(message => IsMessageValid(rule, message));
        }
        
        public static bool IsMessageValid(IRule rule, string message)
        {
            var pos = 0;
            var result = rule.Match(message, ref pos);
            return result && pos == message.Length;
        }

        public static int Part2(Problem problem)
        {
            // 0: 8 11
            //
            // 8: 42 | 42 8
            // 11: 42 31 | 42 11 31
            //
            // so it
            // (42){x} (42){y} (31){y}

            var rule31 = problem.Rules[31];
            var rule42 = problem.Rules[42];

            return problem.Messages.Count(message => IsMessageValid(rule31, rule42, message));
        }
        
        public static bool IsMessageValid(IRule rule31, IRule rule42, string message)
        {
            // (42){x}    (42){y} (31){y}
            
            var secondPartMinLength = rule42.Length + rule31.Length;
            var firstPartMaxRepeatCount = (message.Length - secondPartMinLength) / rule42.Length;
            // loop with all possible times first part can repeat
            for (var firstPartRepeatCount = 1; firstPartRepeatCount <= firstPartMaxRepeatCount; firstPartRepeatCount++)
            {
                var pos = 0;
                int i;
                for (i = 1; i <= firstPartRepeatCount; i++)
                {
                    if (!rule42.Match(message, ref pos))
                        return false;
                }

                var charsLeft = (message.Length - pos);
                var secondPartRepeatCount = charsLeft / secondPartMinLength;
                // second part must repeat without any chars left
                if (secondPartRepeatCount * secondPartMinLength != charsLeft)
                    continue;

                for (i = 1; i <= secondPartRepeatCount; i++)
                {
                    if (!rule42.Match(message, ref pos))
                        break;
                }
                if(i <= secondPartRepeatCount)
                    continue;
                
                for (i = 1; i <= secondPartRepeatCount; i++)
                {
                    if (!rule31.Match(message, ref pos))
                        break;
                }
                if(i <= secondPartRepeatCount)
                    continue;

                return true;
            }
            
            return false;
        }
    }
}