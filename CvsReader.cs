using System;
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
                    countries.Add(ReadfromCsvLine(csvLine));
                }
            }
                return countries;

        }


        public Country ReadfromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');
            //string name= parts[0];
            //string code = parts[1];
            //string region = parts[2];
            //string popText = parts[3];
            string name;
            string code;
            string region;
            string popText;
            switch (parts.Length)
            {
                case 4:
                    name = parts[0];
                    code = parts[1];
                    region = parts[2];
                    popText = parts[3];
                    break;
                case 5:
                    name = parts[0] + ", "+parts[1];
                    name = name.Replace("\"", null).Trim();
                    code = parts[2];
                    region = parts[3];
                    popText = parts[4];
                    break;
                default:
                    throw new Exception($"Cant parse from csvline:{csvLine}");
            }

            int.TryParse(popText, out int population);
            return new Country(name, code, region, population);

        }
    }

}