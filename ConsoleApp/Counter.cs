namespace ConsoleApp
{
    public class Counter
    {
        public int Count { get; private set; }

        public Counter(int count)
        {
            Count = count;
        }

        public Counter AddOne()
        {
            Count++;
            return this;
        }
    }
}