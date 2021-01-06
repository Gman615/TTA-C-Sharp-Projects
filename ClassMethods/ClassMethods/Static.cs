using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    public static class Static
    {
        public static int Multiply(string number) 
        {
            int number1 = Convert.ToInt32(number);
            int number2 = number1 * number1;
            return number2;
        }
    }
}
