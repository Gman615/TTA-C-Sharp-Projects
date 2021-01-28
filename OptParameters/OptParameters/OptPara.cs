using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptParameters
{
    class OptPara
    {
        // features an optional parameter in num2, the number 2 is used when the user does not put an input for the second variable request
        public int Equation(int num1, int num2 = 2) 
        {
            return 10 * num1 * num2;
        }
    }
}
