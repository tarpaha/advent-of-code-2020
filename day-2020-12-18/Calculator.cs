namespace day_2020_12_18
{
    public static class Calculator
    {
        public static (long result, int pos) Calculate(string expression)
        {
            var pos = 0;
            var result = 0L;
            var operation = Operation.None;
            while (pos < expression.Length)
            {
                switch (expression[pos])
                {
                    case var ch when char.IsDigit(ch):
                        result = Operate(result, ch - '0', operation);
                        break;
                    case '+':
                        operation = Operation.Addition;
                        break;
                    case '*':
                        operation = Operation.Multiplication;
                        break;
                    case '(':
                        var (subResult, subPos) = Calculate(expression[(pos + 1)..]);
                        result = Operate(result, subResult, operation);
                        pos += subPos;
                        break;
                    case ')':
                        return (result, pos + 1);
                }
                pos += 1;
            }
            return (result, pos);
        }

        private enum Operation
        {
            None,
            Addition,
            Multiplication
        }
        
        private static long Operate(long n1, long n2, Operation operation)
        {
            return operation switch
            {
                Operation.None => n2,
                Operation.Addition => n1 + n2,
                Operation.Multiplication => n1 * n2
            };
        }
    }
}