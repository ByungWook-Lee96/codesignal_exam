using System;

namespace exam3
{
    // n=1 1, n=2 5, n=3 13, n=4 25,...
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            Console.WriteLine(shapeArea(n));
        }
        static int shapeArea(int n)
        {
            return 2 * n * n - 2 * n + 1;
        }
    }
}
