using System;

namespace AlgoritmsAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var listOfNumbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var listOfNumbersUnordered = new List<int> { 78, 1, 6, 37, 96, 567, 123, 579, 23, 8, 18, 28, 58, 45, 2, 76 };

            // TODO // recursiveBinarySearch(listOfNumbersUnordered, 16, 0, listOfNumbersUnordered.Count - 1);

            // linearSearch(listOfNumbers, 6);
            // binarySearch(listOfNumbers, 6);
        
            
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

        // Binary Search Algorithm -- 0(n log n)
        public static void binarySearch(List<int> list, int target)
        {
            int first = 0;
            int last = list.Count - 1;

            while (first <= last)
            {
                int midpoint = (first + last) / 2;

                if (list[midpoint] == target)
                {
                    System.Console.WriteLine($"o ponteiro está em {midpoint}");
                    break;
                }
                else if (list[midpoint] < target)
                {
                    System.Console.WriteLine($"o ponteiro está em {midpoint}");
                    first = midpoint - 1;
                }
                else
                {
                    System.Console.WriteLine($"o ponteiro está em {midpoint}");
                    last = midpoint + 1;
                }
            }
        }


        // TODO
        // public static int recursiveBinarySearch(List<int> list, int target, int min, int max)
        // {
        //     int midpoint = (min + max) / 2;

        //     if (list[midpoint] == target)
        //     {
        //         foreach (int x in list)
        //             Console.Write(x + " ");
        //         Console.WriteLine();

        //         System.Console.WriteLine($"O ponteiro está aqui {++midpoint}");
        //         return midpoint++;

        //     }

        //     if (list[midpoint] > target)
        //     {
        //         System.Console.WriteLine($"Midpoint maior que o target, chamando função");
        //         return recursiveBinarySearch(list, target, min, midpoint - 1);
        //     }

        //     if (max < min) return -1;

        //     return recursiveBinarySearch(list, target, midpoint + 1, max);
        //     System.Console.WriteLine($"Midpoint menor que o target, chamando função");
        // }
    }
}