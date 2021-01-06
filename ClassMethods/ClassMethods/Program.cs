using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Enter a number to divide it by 2");
            int number = Convert.ToInt32(Console.ReadLine());
            math.Math1(number);
            int num, num1;
            math.Math2(out num, out num1);
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine("Choose a number again");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a number again");
            int num3 = Convert.ToInt32(Console.ReadLine());
            math.Math1(num2, num3);
            Console.WriteLine("Enter a number to multiply it times itself");
            int num4 = Static.Multiply(Console.ReadLine());
            Console.WriteLine(num4);
            Console.ReadLine();
        }
    }
}
