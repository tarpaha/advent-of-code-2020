namespace day_2020_12_19.Rules
{
    public interface IRule
    {
        public int Length { get; }
        public bool Match(string str, ref int pos);
    }
}