using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            double num2 = 6.33;
            string str = "18";
            int answer;
            double answer1;
            int answer2;
            TestMethods math = new TestMethods();
            answer = math.Math(num1);
            Console.WriteLine(answer);
            answer1 = math.Math(num2);
            Console.WriteLine(answer1);
            answer2 = math.Math(str);
            Console.WriteLine(answer2);
            Console.ReadLine();
        }
    }
}
