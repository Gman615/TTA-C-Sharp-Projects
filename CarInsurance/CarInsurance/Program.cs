using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI?");
            string bad = Console.ReadLine();
            bool dui = Convert.ToBoolean(bad);

            Console.WriteLine("How many speeding tickets do you have?");
            string speed = Console.ReadLine();
            int ticket = Convert.ToInt32(speed);

            bool result = (age1 > 15 && dui == false && ticket < 3);
            Console.WriteLine("Qualifited?\n" + result);
            Console.ReadLine();

        }
    }
}
