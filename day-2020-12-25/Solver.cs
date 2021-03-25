using System.Threading.Tasks;

namespace day_2020_12_25
{
    public static class Solver
    {
        public static object Part1(long cardPublicKey, long doorPublicKey, long defaultSubject, long divider)
        {
            var tasks = new[]
            {
                Task.Run(() => CalculateEncryptionKey(cardPublicKey, doorPublicKey, defaultSubject, divider)),
                Task.Run(() => CalculateEncryptionKey(doorPublicKey, cardPublicKey, defaultSubject, divider))
            };
            return Task.WhenAny(tasks).Result.Result;
        }

        public static long CalculateEncryptionKey(long key1, long key2, long defaultSubject, long divider)
        {
            var cardLoopCount = CalculateLoopCount(key1, defaultSubject, divider);
            var n = 1L;
            for (var i = 0; i < cardLoopCount; i++)
            {
                n = (n * key2) % divider;
            }
            return n;
        }
        
        public static long CalculateLoopCount(long key, long subject, long divider)
        {
            var n = 1L;
            var count = 1L;
            while (true)
            {
                n = (n * subject) % divider;
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