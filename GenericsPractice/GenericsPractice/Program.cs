using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employees = new Employee<string>();
            employees.Things = new List<string>() { "Jim", "Joe", "Jack", "Garrett" };
            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>() { 33, 66, 99, 132 };
            foreach (string employee in employees.Things) 
            {
                Console.WriteLine(employee);
            }
            foreach (int employee in employee1.Things) 
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
    }
}
