using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDoW
{
    class Program
    {
        static void Main(string[] args)           
        {
            Console.WriteLine("Enter the current day of the week");
            try
            {
                string day = Console.ReadLine();
                DayOfTheWeek DayValue = (DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), day, true);
                Console.WriteLine("Today is " + DayValue);
            }
            catch (SystemException ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();
        }
        public enum DayOfTheWeek 
        { 
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }        
    }
}
