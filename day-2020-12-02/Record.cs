namespace day_2020_12_02
{
    public class Record
    {
        public int Min { get; }
        public int Max { get; }
        public char Char { get; }
        public string Password { get; }

        public Record(int min, int max, char ch, string password)
        {
            Min = min;
            Max = max;
            Char = ch;
            Password = password;
        }
    }
}