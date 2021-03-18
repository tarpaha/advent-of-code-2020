namespace day_2020_12_23
{
    public class CircleListNode
    {
        public int Number { get; }
        public CircleListNode Next { get; set; }

        public CircleListNode(int number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return $"{Number}";
        }
    }
}