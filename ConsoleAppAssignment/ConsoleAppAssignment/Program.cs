using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] textArrays = new string[4];
        Console.WriteLine("Write something to add to an array");
        for (int i = 0; i < textArrays.Length; i++)
        {
            string add = Console.ReadLine();
            textArrays[i] = add;
        }
        foreach (string textArray in textArrays)


        {
            Console.WriteLine(textArray);
        }
        int loop = 0;
        while (loop < 15)
        {
            Console.WriteLine(loop);
            loop++;
        }
        int x = 16;
        while (x > 14 && x < 30)
        {
            Console.WriteLine(x);
            x++;
        }
        int y = 5;
        while (y <= 30)
        {
            Console.WriteLine(y);
            y++;
        }
        List<string> animals = new List<string>() { "duck", "bear", "cat", "dog", "shark", "dolphin", "whale", "lion", "zebra" };
        Console.WriteLine("Search within this list of animals");
        string search = Console.ReadLine();
        bool inside = animals.Contains(search);
        for (int j = 0; j < 1; j++)
        {
            int searched = animals.IndexOf(search);
            if (inside == false)
            {
                Console.WriteLine("This animal is not in the list");
                continue;
            }
            else
            {
                Console.WriteLine(searched);
                break;
            }
        }
        List<string> animals1 = new List<string>() { "duck", "bear", "cat", "dog", "shark", "dolphin", "whale", "lion", "zebra", "dog" };
        Console.WriteLine("Search within this list of animals");
        string search1 = Console.ReadLine();
        bool inside1 = animals1.Contains(search1);
        for (int k = 0; k < animals1.Count; k++)
        {
            if (animals1[k] == search1)
            {
                Console.WriteLine(k);
            }
            else if (inside1 == false)
            {
                Console.WriteLine("This animal is not in the list");
                break;
            }
        }
        List<string> vehicles = new List<string>() { "car", "truck", "van", "crossover", "truck", "airplane", "van" };
        List<string> distinct = vehicles.Distinct().ToList();

        foreach (string vehicle in distinct)
        {
            Console.WriteLine(vehicle + " is not already in the list");          
        }




        Console.ReadLine();

    }
}

