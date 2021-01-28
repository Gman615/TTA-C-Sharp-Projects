using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // takes the user input and adds it at the end of each string in the array
        string[] textArrays = new string[4] { "Cheddar ", "Romano ", "Parmesan ", "Monterey Jack " };
        Console.WriteLine("Write something to add to an array");
        string input = Console.ReadLine();

        for (int i = 0; i < textArrays.Length; i++)
        {
            textArrays[i] += input;
            Console.WriteLine(textArrays[i]);
        }
        // these are practice with creating while loops
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
        // this program allows the user to input anything, and checks if that input is in this list of animals below.
        List<string> animals = new List<string>() { "duck", "bear", "cat", "dog", "shark", "dolphin", "whale", "lion", "zebra" };
        Console.WriteLine("Search within this list of animals");
        string search = Console.ReadLine();
        bool inside = animals.Contains(search);
        // iterates through the list
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
        // this program gives the index of the item in the list based on the user input - if the user input is not in the list, then a message is returned. If the input is in the list, ALL applicable indexes are specified.
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
        // this program deterimes if an item is already in the list (finds duplicates).
        List<string> vehicles = new List<string>() { "car", "truck", "van", "crossover", "truck", "airplane", "van" };
        // new empty list
        List<string> vehicles1 = new List<string>();
        // iterates through the list
        foreach (string vehicle in vehicles)
        {
            // logic here states that if a "vehicle" from the first list of "vehicles" is not in the second list "vehicles1" then add it to the second list
            if (vehicles1.Contains(vehicle) == false)
            {
                vehicles1.Add(vehicle);
                Console.WriteLine(vehicle + " is not already on the list");
            }
            // otherwise, if the item is already in list 2, then show it as a duplicate
            else 
            {
                Console.WriteLine(vehicle + " is already on the list");
            }
        }
        
        




        Console.ReadLine();

    }
}

