using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _2025
{
    internal class FindDuplicateString
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("_2025.............................FindDuplicateString");
            string[] words = { "apple", "banana", "orange", "apple", "grape", "banana", "kiwi" };

            Console.WriteLine("Original Array: " + string.Join(", ", words));

            HashSet<string> seen = new HashSet<string>();
            HashSet<string> duplicates = new HashSet<string>();

            /// Find duplicates using HashSet
            foreach (string word in words)
            {
                if (!seen.Add(word))
                {
                    duplicates.Add(word);
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
            Console.writeLine(".............................................");

            Console.ReadLine();
        }

    }
}
