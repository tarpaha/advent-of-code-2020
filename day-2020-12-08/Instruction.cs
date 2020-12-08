namespace day_2020_12_08
{
    public class Instruction
    {
        public Operation Operation { get; }
        public int Argument { get; }

        public Instruction(Operation operation, int argument)
        {
            Operation = operation;
            Argument = argument;
        }
    }
}