namespace day_2020_12_16
{
    public class Rule
    {
        public string Name { get; }
        public (int min, int max) Range1 { get; }
        public (int min, int max) Range2 { get; }

        public Rule(string name, (int, int) range1, (int, int) range2)
        {
            Name = name;
            Range1 = range1;
            Range2 = range2;
        }
    }
}