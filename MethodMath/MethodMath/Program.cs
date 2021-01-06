using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a random number for some math operations:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int answer;
            Math math = new Math();


            answer = math.Math1(num1);
            Console.WriteLine(answer);
            answer = math.Math2(num1);
            Console.WriteLine(answer);
            answer = math.Math3(num1);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }    
}
