using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025
{
#pragma warning disable
    internal class StringReverser
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("_2025________________________StringReverser");
            Console.WriteLine("Enter a string of your choice");
            string inputStr = Console.ReadLine();


            char[] charArray = inputStr.ToCharArray();
            int lengthStr = Convert.ToInt32(charArray.Length - 1);

            string reversedString = ReverseWordsInPlaceLinq(inputStr);

            Console.WriteLine("--------------Reverse of string-------------");
            Console.WriteLine(reversedString);

            /*
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write(charArray[i]);
            }
            Console.WriteLine("\n\n");

            for (int i = lengthStr; i >= 0; i--)
            {
                Console.Write(charArray[i]);
            }
            //------------------------------------------->
            //foreach (char c in charArray.Reverse())
            //{
            //    Console.Write(c);
            //}
            */
            Console.WriteLine("");

            Console.ReadLine();
        }


        public static string ReverseWordsInPlaceLinq(string input)
        {
            string returnString = string.Join(" ",
                input.Split(' ')
                     .Select(word => new string(word.Reverse().ToArray()))
                );
            return returnString;
        }

    }
}
