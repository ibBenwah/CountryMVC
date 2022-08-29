using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryMVC
{
    public class CountryView
    {
        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }

        public Country DisplayCountry { get; set; }
        public void Display()
        {
            string color = "";
            DisplayCountry.Colors.ForEach(x => color += x + ", ");
            color = color.TrimEnd().TrimEnd(',');

            Console.WriteLine("\nName: " + DisplayCountry.Name);
            Console.WriteLine("Continent: " + DisplayCountry.Continent);
            Console.WriteLine("Color: " + color);
        }
    }
}
