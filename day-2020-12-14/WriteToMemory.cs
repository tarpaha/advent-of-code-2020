namespace day_2020_12_14
{
    public class WriteToMemory : Command
    {
        public long Address { get; }
        public long Value { get; }

        public WriteToMemory(long address, long value)
        {
            Address = address;
            Value = value;
        }
    }
}