using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025
{
    internal class Encapsulation
    {
#pragma warning disable
        private int _Age;
        private string _Name;

        public int Age
        {
            get { return _Age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                _Age = value;
            }
        }

        public string Name
        {
            get { return _Name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                _Name = value;
            }
        }



        public static void Main(string[] args)
        {
            Console.WriteLine("_2025..............Encapsulation");

            Encapsulation person = new Encapsulation();
            person.Name = "Alice";
            person.Age = 30;
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            Console.ReadLine();
        }

    }
}
