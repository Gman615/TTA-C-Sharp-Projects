using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            OptPara optpara = new OptPara();
            int answer;
            int answer1;
            Console.WriteLine("Pick a number for this math equation");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number for this math equation (note: to leave blank enter 0, input optional)");
            int num2 = Convert.ToInt32(Console.ReadLine());
            try
            {               
                
                
                
                answer = optpara.Equation(num1, num2);
                Console.WriteLine(answer);
            }
            catch (FormatException ex)
            {
                answer1 = optpara.Equation(num1);
                Console.WriteLine(answer1);
            }              
                
            

            Console.ReadLine();
        }
    }
}
