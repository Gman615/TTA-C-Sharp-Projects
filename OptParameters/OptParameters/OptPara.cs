using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptParameters
{
    class OptPara
    {
        public int Equation(int num1, int num2 = 2) 
        {
            return 10 * num1 * num2;
        }
    }
}
