using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Technical_Test
{
    class Program
    {



        [STAThread]
        static void Main(string[] args)
        {

            CsvConverter csvconverter = new CsvConverter();

            Console.WriteLine("Enter '1' to convert a CSV file to JSON");
            Console.WriteLine("Enter '2' to convert a JSON to a CSV");
            Console.WriteLine("Enter '3' to convert a XML file to JSON");

            string uInput = Console.ReadLine();

            if (uInput == "1")
            {
                csvconverter.ConvertCsvToJson();
            }
            else if (uInput == "2")
            {
                csvconverter.ConvertJsonToCSV();
            }

                Console.ReadKey();

        }



    }
}
