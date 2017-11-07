using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class CountriesTextFile
    {
        public static List<string> ReadFromFile(string filename)
        {
            StreamReader inputFile;
            try
            {
                inputFile = new StreamReader(filename);
            }
            catch(SystemException e)
            {
                Console.WriteLine("Error accessing file.  Please check file permissions.");
                Console.WriteLine($"Detailed Info: {e.Message}");
                return null;
            }

            List<string> countries = new List<string>();
            bool keepReading = true;
            while (keepReading)
            {
                string country = inputFile.ReadLine();
                if(country == null || country == "")
                {
                    keepReading = false;
                    continue;
                }
                countries.Add(country);
            }
            inputFile.Close();
            return countries;
        }

        public static void WriteToFile(string filename, List<string> countries)
        {
            StreamWriter outputFile = new StreamWriter(filename);

            foreach(string country in countries)
            {
                outputFile.WriteLine(country);
            }
            outputFile.Close();
        }
    }
}
