using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Validator
    {
        public static bool GetSelection()
        {
            bool repeat = true;
            List<string> countries = CountriesTextFile.ReadFromFile("countries.txt");
            Console.WriteLine("\n1.Display list of countries\n2.Add a country to the list\n3.Delete a country from the list\n4.Exit application\n");
            Console.Write("Please select an option from the list above (1-4): ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine();
                foreach (string country in countries)
                {
                    Console.WriteLine(country);
                }
                repeat = true;
            }
            else if (input == "2")
            {
                Console.Write("\nPlease enter a country to add to the list: ");
                countries.Add(Console.ReadLine());
                CountriesTextFile.WriteToFile("countries.txt", countries);
                repeat = true;
            }
            else if (input == "3")
            {
                if (countries.Count == 0)
                {
                    Console.WriteLine("\nThere are no countries to delete!");
                }
                else
                {
                    Console.WriteLine();
                    for (int i = 0; i < countries.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {countries[i]}");
                    }
                    Console.Write($"\nPlease enter the number of the country that you would like to delete (1-{countries.Count}): ");
                    string response = Console.ReadLine();
                    bool success = int.TryParse(response, out int num);
                    while (!success || num < 1 || num > countries.Count)
                    {
                        Console.Write($"\nInvalid selection. Please enter the number of the country that you would like to delete (1-{countries.Count}): ");
                        response = Console.ReadLine();
                        success = int.TryParse(response, out num);
                    }
                    countries.RemoveAt(num - 1);
                    CountriesTextFile.WriteToFile("countries.txt", countries);
                }
                repeat = true;
            }
            else if (input == "4")
            {
                repeat = false;
            }
            else
            {
                Console.WriteLine("\nInvalid input.");
                repeat = true;
            }
            return repeat;
        }
    }
}
