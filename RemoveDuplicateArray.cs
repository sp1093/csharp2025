using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025
{
    internal class RemoveDuplicateArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("_2025------------------RemoveDuplicateArray");

            int[] arrayWithDuplicates = { 1, 2, 3, 2, 4, 3, 5, 1, 6 };

            //int[] arrayWithoutDuplicates = arrayWithDuplicates.Distinct().ToArray();
            //Console.WriteLine("Array with duplicates: " + string.Join(", ", arrayWithDuplicates));
            //Console.WriteLine("Array without duplicates: " + string.Join(", ", arrayWithoutDuplicates));


            Console.WriteLine("Array with duplicates: " + string.Join(", ", arrayWithDuplicates));
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();
            foreach (int number in arrayWithDuplicates)
            {
                if (!seen.Add(number))
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
            Console.ReadLine();
        }

    }
}
