using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listofBands = new List<string>() 
            {
                "Led Zeppelin",
                "The Beatles",
                "The Rolling Stones",
                "The Who",
                "The Doors",
                "The Moody Blues",
                "Aerosmith",
                "KISS",
                "Lynyrd Skynyrd",
            };
            string[] strArray = new string[] { "red", "orange", "yellow", "green", "blue", "purple" };
            int[] intArray = new int[] { 1, 10, 100, 1000, 10000, 100000 };

            Console.WriteLine("Select a rainbow color using a number");
            string color = Console.ReadLine();            
            int intcolor = Convert.ToInt32(color);
            if (intcolor > 5 || intcolor < 0)
            {
                Console.WriteLine("Sorry that number is not part of the Index.");
            }
            else 
            {
                Console.WriteLine(strArray[intcolor]);
            }
            Console.WriteLine("Select a number for an exponent that represents the place in the decimal system");
            string expo = Console.ReadLine();
            int exponent = Convert.ToInt32(expo);
            if (exponent > 5 || exponent < 0) 
            {
                Console.WriteLine("Sorry that number is not part of the Index");
            }
            else 
            {
                Console.WriteLine(intArray[exponent]);
            }
            Console.WriteLine("Select a number to see what is in this list");
            string bands = Console.ReadLine();
            int intbands = Convert.ToInt32(bands);
            if (intbands > 8 || intbands < 0) 
            {
                Console.WriteLine("Sorry that number is not part of the Index");
            }
            else 
            {
                Console.WriteLine(listofBands[intbands]);
            }
            Console.ReadLine();

        }
    }
}
