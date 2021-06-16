using System;

namespace exam2
{
    // Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] inputArray = { 3, 6, -2, -5, 7, 3 };
        }
        static int adjacentElementsProduct(int[] inputArray)
        {
            int max = -1001;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] * inputArray[i + 1] >= max)
                {
                    max = inputArray[i] * inputArray[i + 1];
                }
            }
            return max;

        }
    }
}
