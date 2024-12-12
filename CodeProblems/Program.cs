using System;

namespace CodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TwoSum c = new TwoSum();
            int[] res = c.solution(new int[] { 3, 2, 4 }, 6);
            Console.WriteLine($"Result: {res[0]}, {res[1]}");
            res = c.solution(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"Result: {res[0]}, {res[1]}");
            Console.ReadKey();
        }
    }
}

