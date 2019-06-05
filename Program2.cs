using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Program2
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\jhasan\source\repos\Collections\Book3.csv";

            CvsReader reader = new CvsReader(filePath);

            List<Country> countries = reader.ReadAllCountres();
            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 20000);
            int lilliputIndex=countries.FindIndex(x=>x.Population<100000);
            countries.Insert(lilliputIndex, lilliput);
            countries.RemoveAt(lilliputIndex);

            

            foreach (Country item in countries)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(countries.Count);

        }
    }
}
