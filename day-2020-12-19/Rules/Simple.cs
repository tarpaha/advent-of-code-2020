namespace day_2020_12_19.Rules
{
    public class Simple : IRule
    {
        private readonly char _ch;

        public Simple(char ch)
        {
            _ch = ch;
        }

        public int Length => 1;

        public bool Match(string str, ref int pos)
        {
            if (pos >= str.Length || str[pos] != _ch)
                return false;
            pos += 1;
            return true;
        }
    }
}