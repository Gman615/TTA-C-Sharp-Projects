using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 18, 33, 99, 15 };
            // exception added to make sure program does not malfunction when certain input is given by the user
            try
            {
                Console.WriteLine("Pick a number to divide this list by.");
                int num = Convert.ToInt32(Console.ReadLine());
                // iterates through the list, dividing each number in the list by the user provided number
                for (int i = 0; i < numbers.Count; i++)
                {
                    int num1 = numbers[i] / num;
                    Console.WriteLine(num1);
                    Console.ReadLine();
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by 0");
                return;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please use numbers only, no strings");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution complete");
                Console.ReadLine();
            }

        }
    }
}
