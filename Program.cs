using System;
using Algorithm_and_Data_Structures_in_csharp;

namespace AlgorithmAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var listOfNumbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var listOfNumbersUnordered = new List<int> { 78, 1, 6, 37, 96, 567, 123, 579, 23, 8, 18, 28, 58, 45, 2, 76 };

            // TODO // recursiveBinarySearch(listOfNumbersUnordered, 16, 0, listOfNumbersUnordered.Count - 1);
            var algorithms = new Algorithms();

            algorithms.linearSearch(listOfNumbers, 6);
            algorithms.binarySearch(listOfNumbers, 6);

        }
    }
}


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