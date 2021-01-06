using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods
{
    class TestMethods
    {
        public int Math(int num) 
        {
            return 10 * num;
        }
        public double Math(double num) 
        {
            return 7 * num;
        }
        public int Math(string str) 
        {
            int num = Convert.ToInt32(str) * 3;
            return num;
        }
        
    }
}
