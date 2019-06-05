using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Program3
    {
        static void Main(string[] args)
        {
            Country norway = new Country("Norway", "NOR", "Europe", 522324);
            Country finland = new Country("Finland", "FIN", "Europe", 4235320);
          //  Dictionary<string, Country> countries = new Dictionary<string, Country>();

            var countries = new Dictionary<string, Country>();
            countries.Add(norway.Code, norway);
            countries.Add(finland.Code, finland);
            foreach (var country in countries.Values)
            {
                Console.WriteLine(country.Name);
            }

        }
    }
}
