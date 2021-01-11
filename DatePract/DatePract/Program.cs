using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatePract
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTimeNow = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number");
            int userHours = Convert.ToInt32(Console.ReadLine());
            DateTime hoursLater = dateTimeNow.AddHours(userHours);
            Console.WriteLine("It will be " + hoursLater + " in {0} hours", userHours);
            
 
            

            Console.ReadLine();
        }
    }
}
