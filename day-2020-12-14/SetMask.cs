namespace day_2020_12_14
{
    public class SetMask : Command
    {
        public string Mask { get; }

        public SetMask(string mask)
        {
            Mask = mask;
        }
    }
}