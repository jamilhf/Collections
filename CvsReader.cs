using System.Collections.Generic;
using System.IO;

namespace Collections
{


     class CvsReader
    {


        private string CvsFilePath;

        public CvsReader(string FilePath)
        {
            this.CvsFilePath = FilePath;

        }

        public List<Country> ReadAllCountres()
        {
            List<Country> countries = new List<Country>();

          
            using (StreamReader sr = new StreamReader(CvsFilePath))
            {
                sr.ReadLine();

                string csvLine;

                while ((csvLine=sr.ReadLine())!=null)
                {
                    countries.Add(csvLine);
                }
            }
                return countries;

        }


        public Country ReadfromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');
            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);

        }
    }

}