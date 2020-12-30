using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease enter the package weight:");
            string weight = Console.ReadLine();
            int weight1 = Convert.ToInt32(weight);
            
            if (weight1 <= 50) 
            {
                Console.WriteLine("Please enter the package width:");
                string width = Console.ReadLine();
                int width1 = Convert.ToInt32(width);
                Console.WriteLine("Please enter the package height:");
                string height = Console.ReadLine();
                int height1 = Convert.ToInt32(height);
                Console.WriteLine("Please enter the package length:");
                string length = Console.ReadLine();
                int length1 = Convert.ToInt32(length);
                int dimensions = height1 + length1 + width1;                
                if (dimensions <= 50) 
                {
                    int price = ((width1 * length1 * height1) * weight1) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + price + "\nThank You");
                }
                else 
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
            }
            else 
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            Console.ReadLine();
        }
    }
}
