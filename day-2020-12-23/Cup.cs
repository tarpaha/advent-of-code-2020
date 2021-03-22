namespace day_2020_12_23
{
    public class Cup
    {
        public int Number { get; }
        public Cup Next { get; set; }

        public Cup(int number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return $"{Number}";
        }
    }
}