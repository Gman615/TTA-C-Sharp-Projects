using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOverload
{
    public class Employee
    {
        public int ID { get; set; }
        public int num;
        // two chained constructors
        public Employee()
        {
            num = 0;
        }
        public Employee(int num1)
        {
            num = num1;
        }
        // boolian comparison of ID nums
        public static bool operator== (Employee ID1, Employee ID2) 
        {
            if (ID1.num == ID2.num) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public static bool operator!= (Employee ID1, Employee ID2) 
        {            
            if (ID1.num != ID2.num) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        } 
    }
}
