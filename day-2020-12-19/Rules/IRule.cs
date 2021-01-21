namespace day_2020_12_19.Rules
{
    public interface IRule
    {
        public bool Match(string str, ref int pos);
    }
}