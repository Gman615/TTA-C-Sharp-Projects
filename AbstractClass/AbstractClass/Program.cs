﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Persons = new List<Person>();
            Person person = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            employee.ID = "0001";
            person += employee;
            IQuittable quittable = new Employee();
            quittable.Quit();
            
            
            Console.ReadLine();
        }
    }
}