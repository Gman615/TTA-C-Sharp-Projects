using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("What is your age? Please enter below");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                int yearNow = Convert.ToInt32(DateTime.Now.Year);
                int yearsAgo = yearNow - age;
                if (age <= 0) 
                {
                    throw new WrongNumber();
                }
                else Console.WriteLine("You were born in {0}.", yearsAgo);
                
            }
            catch (WrongNumber) 
            {
                Console.WriteLine("Negative numbers and 0 are not allowed");
            }
            catch (Exception) 
            {
                Console.WriteLine("An error occured, ending program");
            }
            Console.ReadLine();
        }
    }
}
