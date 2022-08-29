using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryMVC
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; } = new List<Country>()
        {
            new Country("USA",
                "North America",
                new List<string> {"Red", "White", "Blue" }),
            new Country("Canada,",
                " North America",
                new List<string> {"Red", "White" }),
            new Country("Sweden",
                "Europe",
                new List<string> {"Blue", "Yellow" })
        };

        public void CountryAction(Country c)
        {
            var country = new CountryView(c);
            country.Display();
        }

        public void WelcomeAction()
        {
            bool loopChoice = true;

            while (loopChoice)
            {
                var country = new CountryListView(CountryDb);

                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:\n");
                country.Display();
                Console.WriteLine(); 
                int selection = 0;

                try
                {
                    selection = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nNot a valid choice. Please press any button to try again.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                if (selection <= 0 || selection > CountryDb.Count)
                {
                    Console.WriteLine("\nNot a valid choice. Please press any button to try again.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                CountryAction(CountryDb[selection - 1]);

                Console.WriteLine("\nWould you like to learn about another country? (y/n)\n");
                string loopInput = Console.ReadLine().ToLower();

                if (loopInput == "y")
                {
                    loopChoice = true;
                    Console.Clear();
                }
                else if (loopInput == "n")
                {
                    Console.WriteLine("\nGoodbye!");
                    loopChoice = false;
                }
                else
                {
                    Console.WriteLine("\nNot a valid choice! ");
                    Thread.Sleep(2500);
                    Console.Clear();
                    loopChoice = true;
                }
            }

        }
    }
}