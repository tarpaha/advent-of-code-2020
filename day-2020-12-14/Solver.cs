namespace day_2020_12_14
{
    public static class Solver
    {
        public static long ApplyMask(long number, string mask)
        {
            long bit = 1;
            for (var i = mask.Length - 1; i >= 0; i--, bit <<= 1)
            {
                switch (mask[i])
                {
                    case '0':
                        number &= ~bit;
                        break;
                    case '1':
                        number |= bit;
                        break;
                }
            }
            return number;
        }
    }
}