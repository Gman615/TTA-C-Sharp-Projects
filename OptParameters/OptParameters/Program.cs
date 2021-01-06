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
            Console.WriteLine("Pick a number for this math equation");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number for this math equation (note: to leave blank enter 0, input optional)");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int answer;
            int answer1;
            OptPara optpara = new OptPara();
            if (num2 == 0)
            {
                answer = optpara.Equation(num1);
                Console.WriteLine(answer);
            }
            else
            {
                answer1 = optpara.Equation(num1, num2);
                Console.WriteLine(answer1);
            }

            Console.ReadLine();
        }
    }
}
