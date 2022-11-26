using System;

namespace AlgoritmsAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var listOfNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            linearSearch(listOfNumbers, 6);
        }

        // Linear Search Algorithm -- O(n)
        static void linearSearch(List<int> list, int target)
        {
            var result = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == target)
                {
                    result = i + 1;
                }
            }
            System.Console.WriteLine(result);
        }
    }
}