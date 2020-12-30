using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = "I love movies";
            string good = " that are exciting";
            string fun = " and fun to watch";
            Console.WriteLine(movie + good + fun);

            string name = "Favorite Movies";
            Console.WriteLine(name.ToUpper());
            

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Many movies are enjoyable and well made, but if I get tired of it after a few watches then it is not a favorite.");
            sb.AppendLine("My favorite movie is Jurassic Park because I have seen it at least 50 times and it is still enjoyable.");
            sb.AppendLine("My second favorite movie is Grandma's Boy for the same reason.");
            sb.AppendLine("Ocean's 11 is another movie that I have seen many times and it does not get old.");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
