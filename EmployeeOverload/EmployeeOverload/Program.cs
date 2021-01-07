using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ID1 = new Employee(0001);
            Employee ID2 = new Employee(0002);
            if(ID1 == ID2) 
            {
                Console.WriteLine("The ID numbers are equal");
            }
            else 
            {
                Console.WriteLine("The ID numbers are not equal");
            }
            Console.ReadLine();
        }
    }
}
