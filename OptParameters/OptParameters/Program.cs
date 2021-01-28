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
            // creates an instance of the class object
            OptPara optpara = new OptPara();
            int answer;
            int answer1;
            Console.WriteLine("Pick a number for this math equation");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number for this math equation (note: to leave blank enter 0, input optional)");
            string num2 = Console.ReadLine();
            // checks to see if second user input has a value, if not, then it uses the first number given and the default parameter of 2
            if (num2 == "") 
            {
                answer1 = optpara.Equation(num1);
                Console.WriteLine(answer1);
            }
            else
            {
                int num3 = Convert.ToInt32(num2);
                answer = optpara.Equation(num1, num3);
                Console.WriteLine(answer);
            }




            Console.ReadLine();
        }
    }
}
