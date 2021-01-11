using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string result = Console.ReadLine();
            File.WriteAllText(@"C:\Users\gma61\source\repos\number.txt", result);
            Console.WriteLine(File.ReadAllText(@"C:\Users\gma61\source\repos\number.txt"));

            Console.ReadLine();
        }
    }
}
