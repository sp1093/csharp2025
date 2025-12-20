using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025
{
    internal class DuplicateInteger
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("_2025-----------------------------DuplicateInteger\n\n");
            int[] numbers = { 4, 3, 2, 5, 6, 3, 4, 7, 8, 9, 5, 4 };

            Console.WriteLine("Original Array: " + string.Join(", ", numbers));
            Console.WriteLine("---------------------------------------------------");

            FindDuplicatesWithHashSet(numbers);

            int[] FindDuplicates = FindDuplicatesByLinq(numbers);

            Console.ReadLine();
        }
        public static void FindDuplicatesWithHashSet(int[] numbers)
        {
            Console.WriteLine("\n--- Method 1: Using a HashSet ---");

            // A HashSet is a collection that contains no duplicate elements.
            // It provides very fast lookups (O(1) on average).
            var seenNumbers = new HashSet<int>();
            var duplicates = new HashSet<int>();

            foreach (int number in numbers)
            {
                // Try to add the number to our 'seenNumbers' set.
                // If it returns false, it means the number is already in the set,
                // so we have found a duplicate.
                if (!seenNumbers.Add(number))
                {
                    duplicates.Add(number);
                }
            }

            if (duplicates.Count > 0)
            {
                Console.WriteLine("Duplicates found: " + string.Join(", ", duplicates));
            }
            else
            {
                Console.WriteLine("No duplicates found.");
            }
        }

        public static int[] FindDuplicatesByLinq(int[] num)
        {
            int[] dupVal = { };

            return dupVal;
        }
    }
}
