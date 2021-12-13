using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Test
{
    public class Person
    {
        public string name;
        //public string[] address;
        public string line1;
        public string line2;


        //a method to seperate each row(object) in to its individual properties for easy handling.
        public Person(string rowData, string format)
        {
            if(format == "CSV") { 
            string[] data = rowData.Split(',');

            this.name = data[0];
            this.line1 = data[1];
            this.line2 = data[2];
            }
            //else if (format == "JSON")
            //{
            //    this.name = rowData.
            //}


        }


        //the method for assigning a person is contained within the person class for good programming practice.


        //i ended up using a Json library because it was nicer to work with but i left my own JSON syntax converter in to show you just incase that was part
        // of the requirements.
        //
        public string toJSON()
        {
            string str = "{" + System.Environment.NewLine + $"   name: {name}, "+ System.Environment.NewLine + "   address: {" + System.Environment.NewLine + "      line1: " + $"{line1},"
                + System.Environment.NewLine + $"      line2: {line2}" + System.Environment.NewLine + "   }" + System.Environment.NewLine + "}" + System.Environment.NewLine;     
            return str;
        }

    }

    

    
}
