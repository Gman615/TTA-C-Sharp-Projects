using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Math
    {
        public void Math1(int num) 
        {
            int num1 = num / 2;
            Console.WriteLine(num1);
        }
        public void Math2(out int num2, out int num3) 
        {
            Console.WriteLine("Enter a number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            num3 = Convert.ToInt32(Console.ReadLine());
        }
        public void Math1(int num4, int num5) 
        {
            int num6 = num4 * num5;
            Console.WriteLine(num6);
        }
    }
}
