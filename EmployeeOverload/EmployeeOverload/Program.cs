﻿using System;
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
            Console.WriteLine(ID1 == ID2);

            Console.ReadLine();
        }
    }
}