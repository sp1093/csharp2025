using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025
{
    internal class Collection1
    {
        public static bool Compare<T>(T a, T b)
        {

            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// collection1 Main defined
        /// </summary>
        /// <param name="args"></param>

        public static void Main(string[] args)
        {
            Console.WriteLine("_2025-----------------------------Collection1");

            bool result1 = Compare<int>(5, 5);
            bool result2 = Compare<string>("hello", "world");
            bool result3 = Compare<double>(3.14, 3.14);
            Console.WriteLine($"{result1}");
            Console.WriteLine($"{result2}");
            Console.WriteLine($"{result3}");
            Console.ReadLine(); //End of Main
        }

    }
}
