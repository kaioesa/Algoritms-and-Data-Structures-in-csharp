using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithm_and_Data_Structures_in_csharp
{
    public class Algorithms
    {
        // Linear Search Algorithm -- O(n)
        public void linearSearch(List<int> list, int target)
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
        public void binarySearch(List<int> list, int target)
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
    }
    // recursiveBinarySearch - TODO
}