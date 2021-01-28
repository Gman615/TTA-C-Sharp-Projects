using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // this program uses while and do while loops with switch statements
            Console.WriteLine("What day of the week is it?");
            string day = Console.ReadLine();
            bool toDay = false;

            while (!toDay) 
            { 
                switch (day) 
                {
                    case "Monday":
                        Console.WriteLine("What world do you live in?");
                        Console.WriteLine("Guess Again");
                        day = Console.ReadLine();
                        break;
                    case "Tuesday":
                        Console.WriteLine("What world do you live in?");
                        Console.WriteLine("Guess Again");
                        day = Console.ReadLine();
                        break;
                    case "Wednesday":
                        Console.WriteLine("This is correct!");                        
                        toDay = true;
                        break;
                    case "Thursday":
                        Console.WriteLine("Where are you from? Sorry, it may be right where you are, but it is wrong here.");
                        Console.WriteLine("Guess Again");
                        day = Console.ReadLine();
                        break;
                    case "Friday":
                        Console.WriteLine("What world do you live in?");
                        Console.WriteLine("Guess Again");
                        day = Console.ReadLine();
                        break;
                    case "Saturday":
                        Console.WriteLine("What world do you live in?");
                        Console.WriteLine("Guess Again");
                        day = Console.ReadLine();
                        break;
                    case "Sunday":
                        Console.WriteLine("What world do you live in?");
                        Console.WriteLine("Guess Again");
                        day = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("That isn't even a day, come on.");
                        Console.WriteLine("guess Again");
                        day = Console.ReadLine();
                        break;
                }
            }
            
            Console.WriteLine("What is my favorite movie?\nHint: it is an action/thriller directed by Steven Spielberg.\nPlease do not write out the whole title, just for example Indiana Jones 4");
            string movie = Console.ReadLine();
            bool favMovie = movie == "Jurassic Park";

            do
            {
                switch (movie)
                {
                    case "Indiana Jones":
                        Console.WriteLine("Sorry this is wrong.");
                        Console.WriteLine("Guess Again");
                        movie = Console.ReadLine();
                        break;
                    case "Indiana Jones 2":
                        Console.WriteLine("Sorry this is wrong.");
                        Console.WriteLine("Guess Again");
                        movie = Console.ReadLine();
                        break;
                    case "Indiana Jones 3":
                        Console.WriteLine("Sorry this is wrong.");
                        Console.WriteLine("Guess Again");
                        movie = Console.ReadLine();
                        break;
                    case "Jurassic Park":
                        Console.WriteLine("This is correct! Well Done!");
                        favMovie = true;
                        break;
                    case "Jurassic Park 2":
                        Console.WriteLine("Sorry this is wrong.");
                        Console.WriteLine("Guess Again");
                        movie = Console.ReadLine();
                        break;
                    case "Munich":
                        Console.WriteLine("Sorry this is wrong.");
                        Console.WriteLine("Guess Again");
                        movie = Console.ReadLine();
                        break;
                    case "Jaws":
                        Console.WriteLine("Sorry this is wrong.");
                        Console.WriteLine("Guess Again");
                        movie = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Not even close");
                        Console.WriteLine("Guess Again");
                        movie = Console.ReadLine();
                        break;
                }
            }

            while (!favMovie);
            Console.ReadLine();
        }
    }
}
