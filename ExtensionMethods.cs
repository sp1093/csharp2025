using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2025.ExtensionMethods;

namespace _2025
{
    internal class ExtensionMethods
    {
#pragma warning disable
        public static void Main(string[] args)
        {
            Console.WriteLine("2025----------------- ExtensionMehtods");


            Student s = new Student();
            s.Name = "John";
            s.Marks = 75;
            bool isPassed = s.IsPassed();
            Console.WriteLine($"{s.Name} has {(isPassed ? "passed" : "failed")} with marks {s.Marks}.");
            Console.ReadLine();
        }

    }
    /// <summary>
    /// Entity class representing a student by sp singh
    /// </summary>
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }
    /// <summary>
    /// Extension methods for Student class
    /// </summary>
    public static class StudentExtensions
    {
        public static bool IsPassed(this Student student)
        {
            return student.Marks >= 40;
        }
    }
}
