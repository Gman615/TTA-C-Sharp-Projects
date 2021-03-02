using System;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates an input based app that asks a student for a daily report, shows practice with different C# basic data types
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNum);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string Help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(Help);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string Positive = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string Hours = Console.ReadLine();
            int studyHours = Convert.ToInt32(Hours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");          
            Console.ReadLine();            
        }
    }
}
