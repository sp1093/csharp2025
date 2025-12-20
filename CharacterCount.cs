using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025
{
    internal class CharacterCount
    {
#nullable disable
        public static void Main(string[] args)
        {
            Console.WriteLine("_2025..............CharacterCount ");
            Console.WriteLine("Enter a string of your choice.");

            string input = Console.ReadLine();

            char[] chars = input.ToCharArray();
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int c = chars[i];
                count++;
            }
            Console.WriteLine($"Count of string character is  {count}");

            Console.ReadLine();
        }


    }
}
