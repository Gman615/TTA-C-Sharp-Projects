using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            // this app asks the user how much they make at their job and then offers a comparison after calculating yearly salaries
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nHourly Rate:");
            string rate = Console.ReadLine();
            double rate1 = Convert.ToDouble(rate);
            Console.WriteLine("Hours worked per week:");
            string hours = Console.ReadLine();
            int hours1 = Convert.ToInt32(hours);
            Console.WriteLine("Person 2\nHourly Rate:");
            string rate2 = Console.ReadLine();
            double rate3 = Convert.ToDouble(rate2);
            Console.WriteLine("Hours worked per week:");
            string hours2 = Console.ReadLine();
            int hours3 = Convert.ToInt32(hours2);
            double person1 = (rate1 * hours1) * 52;
            double person2 = (rate3 * hours3) * 52;
            Console.WriteLine("Annual salary of Person 1:\n" + person1);
            Console.WriteLine("Annual salary of Person 2:\n" + person2);
            bool compare = person1 > person2;
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + compare);
            Console.ReadLine();
        }
    }
}
