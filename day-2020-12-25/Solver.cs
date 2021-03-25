namespace day_2020_12_25
{
    public static class Solver
    {
        public static object Part1(long cardPublicKey, long doorPublicKey)
        {
            return null;
        }

        public static long CalculateLoopCount(long key, long subject)
        {
            var n = 1L;
            var count = 1L;
            while (true)
            {
                n = (n * subject) % 20201227;
                if (n == key)
                    break;
                count += 1;
            }
            return count;
        }
        
        public static object Part2()
        {
            return null;
        }
    }
}