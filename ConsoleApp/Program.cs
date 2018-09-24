using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new Counter(0);
            var count = counter.AddOne()
                .AddOne()
                .Count;

            Console.WriteLine(count);
        }
    }
}