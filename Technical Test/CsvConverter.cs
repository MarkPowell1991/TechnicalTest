using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Technical_Test
{
    public class CsvConverter
    {

        public CsvConverter()
        {

        }
   

        public void ConvertCsvToJson()
        {
            //show file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            //read all the CSV lines from the CSV file i made "Names-CSV" and add them in to a string array
            string[] csvLines = System.IO.File.ReadAllLines(ofd.FileName);

            //a list of person objects
            var people = new List<Person>();


            //each line from the CSV file is converted in to an instance of a person and added to a list of "people".
            for (int i = 1; i < csvLines.Length; i++)
            {
                Person person = new Person(csvLines[i],"CSV");
                people.Add(person);


            }

            //that list of people is then converted in to JSON syntax and shown on the console.
            for (int i = 0; i < people.Count; i++)
            {
                var jsonString = JsonConvert.SerializeObject(people[i]); //returns Json string
                dynamic json = JsonConvert.DeserializeObject(jsonString); //returns string in Json syntax
                System.Console.WriteLine(json);
            }           

        }


        public void ConvertJsonToCSV()
        {

            //show file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            //read the Json content form a .txt file i created "Names-Json" and place in to a string
            string jsonLines = System.IO.File.ReadAllText(ofd.FileName);

            var people = JsonConvert.DeserializeObject<Person>(jsonLines);

            System.Console.WriteLine(people);

            Person person = JsonConvert.DeserializeObject<Person>(jsonLines);

            Console.WriteLine("name = " + person.name);
            Console.WriteLine("line1 = " + person.line1);
            Console.WriteLine("line2 = " + person.line2);


        }

    }
}
