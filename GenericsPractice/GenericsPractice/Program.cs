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
            // instanciates the class of Employee which is a generic list as a new list of strings
            Employee<string> employees = new Employee<string>();
            //creates a new list of strings under the employee object
            employees.Things = new List<string>() { "Jim", "Joe", "Jack", "Garrett" };
            // instanciates the class of Employee which is a generic list as a new list of integers
            Employee<int> employee1 = new Employee<int>();
            // creates a new list of integers under the employee object
            employee1.Things = new List<int>() { 33, 66, 99, 132 };
            // iterates through all of the strings in the list of strings
            foreach (string employee in employees.Things) 
            {
                Console.WriteLine(employee);
            }
            // iterates through all of the integers in the list of integers
            foreach (int employee in employee1.Things) 
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
    }
}
