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

        public Country[] ReadFirstNCountries(int nCountries)
        {
            

            Country[] countries = new Country[nCountries];
            using (StreamReader sr = new StreamReader(CvsFilePath))
            {
                sr.ReadLine();

                    for (int i = 0; i < nCountries; i++)
                {
                    string csvLine = sr.ReadLine();
                    countries[i] = ReadfromCsvLine(csvLine);
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