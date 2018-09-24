namespace ConsoleApp
{
    public class Counter
    {
        public int Count { get; }

        public Counter(int count)
        {
            Count = count;
        }
    }
    
    public static class CounterExt
    {
        public static Counter AddOne(this Counter counter)
        {
            return new Counter(counter.Count + 1); 
        }
    }
}