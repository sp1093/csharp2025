using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025
{
    internal class IntegerDuplicate
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("_2025------------------------------IntegerDuplicate\n\n");
            int[] numbers = { 4, 3, 2, 5, 6, 3, 4, 7, 8, 9, 5, 4 };

            Console.WriteLine("Original Array: " + string.Join(", ", numbers));
            Console.WriteLine("---------------------------------------------------");
            //FindDuplicatesWithHashSet(numbers);
            FindDuplicatesWithLinq(numbers);
            Console.ReadLine();
        }

        private static void FindDuplicatesWithLinq(int[] numbers)
        {
            var duplicateNumbers = numbers
                .GroupBy(n => n)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();

            if (duplicateNumbers.Any())
            {
                Console.WriteLine("Duplicates found: " + string.Join(", ", duplicateNumbers));
            }
            else
            {
                Console.WriteLine("No duplicates found.");

            }
        }

        private static void FindDuplicatesWithHashSet(int[] numbers)
        {
            var seenNum = new HashSet<int>();
            var dupNum = new HashSet<int>();

            foreach (var item in numbers)
            {
                if (!seenNum.Add(item))
                {
                    dupNum.Add(item);
                }
            }
            if (dupNum.Count > 0)
            {
                Console.WriteLine("Duplicates found: " + string.Join(", ", dupNum));
            }
            else
            {
                Console.WriteLine("No duplicates found.");
            }

        }
    }
}
