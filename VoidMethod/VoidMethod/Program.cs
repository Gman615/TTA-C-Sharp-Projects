using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMath voidMath = new VoidMath();
            int num1 = 5;
            int num2 = 10;
            voidMath.VMath(num1, num2);
            voidMath.VMath(10, 2);
            Console.ReadLine();


        }
    }
}
