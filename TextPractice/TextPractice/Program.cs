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
            // below line writes all text from the user input to the document
            File.WriteAllText(@"C:\Users\gma61\source\repos\number.txt", result);
            // this reads all text off of the file, then writes to the console.
            Console.WriteLine(File.ReadAllText(@"C:\Users\gma61\source\repos\number.txt"));

            Console.ReadLine();
        }
    }
}
