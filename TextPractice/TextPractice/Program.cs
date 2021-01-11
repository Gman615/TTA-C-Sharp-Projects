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
            int result = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\gma61\source\repos\number.txt", true)) 
            {
                file.WriteLine(result);
            }
            Console.WriteLine("The number you entered is " + result);
            Console.ReadLine();
        }
    }
}
