using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2025
{
#pragma warning disable
    internal class SubstringFinder
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("_2025---------------------------SubstringFinder");

            //string myString = "dog";
            string myString = Console.ReadLine();

            List<string> result = FindAllSubstrings(myString);

            Console.WriteLine($"All substrings of '{myString}':");
            foreach (var substring in result)
            {

                Console.WriteLine(substring);
            }

            // Example with a longer string
            Console.WriteLine("\n---------------------------------\n");

            Console.ReadLine();
        }



        public static List<string> FindAllSubstrings(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return new List<string>();
            }

            return Enumerable.Range(0, input.Length)
                             .SelectMany(start => Enumerable.Range(1, input.Length - start + 1)
                                                             .Select(length => input.Substring(start, length - 1)))
                             .Distinct() // Add this to get unique substrings
                             .ToList();
        }


        //private static List<string> FindAllSubstrings(string input)
        //{
        //    var substrings = new List<string>();
        //    if (string.IsNullOrEmpty(input))
        //    {
        //        return substrings;
        //    }

        //    for (int start = 0; start < input.Length; start++)
        //    {
        //        int startValue = input.Length;
        //        for (int length = 1; length <= input.Length - start; length++)
        //        {
        //            int lengthValue = input.Length - start;
        //            substrings.Add(input.Substring(start, length));
        //        }
        //    }
        //    return substrings;
        //}
    }
}
