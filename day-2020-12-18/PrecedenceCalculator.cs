namespace day_2020_12_18
{
    /*
     * expression = sum {'*', sum}
     * sum = value {'+', value}
     * value = digit | '(', expression, ')'
     * digit = '0'|'1'|'2'|'3'|'4'|'5'|'6'|'7'|'8'|'9'
     */
    public static class PrecedenceCalculator
    {
        public static long Calculate(string expression)
        {
            var pos = 0;
            return Expression(expression.Replace(" ", ""), ref pos).value;
        }

        private static (bool result, long value) Expression(string str, ref int pos)
        {
            var (_, value) = Sum(str, ref pos);
            while (pos < str.Length && str[pos] == '*')
            {
                pos += 1;
                value *= Sum(str, ref pos).value;
            }
            return (true, value);
        }

        private static (bool result, long value) Sum(string str, ref int pos)
        {
            var (_, value) = Value(str, ref pos);
            while (pos < str.Length && str[pos] == '+')
            {
                pos += 1;
                value += Value(str, ref pos).value;
            }
            return (true, value);
        }

        private static (bool result, long value) Value(string str, ref int pos)
        {
            if (str[pos] == '(')
            {
                pos += 1;
                var value = Expression(str, ref pos).value;
                pos += 1; // ')'
                return (true, value);
            }
            return Digit(str, ref pos);
        }
        
        private static (bool result, long value) Digit(string str, ref int pos)
        {
            if (pos >= str.Length)
                return (false, 0);
            var ch = str[pos];
            if (ch < '0' || ch > '9')
                return (false, 0);
            pos += 1;
            return (true, ch - '0');
        }
    }
}