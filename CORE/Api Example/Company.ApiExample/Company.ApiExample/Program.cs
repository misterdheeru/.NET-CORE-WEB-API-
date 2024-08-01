using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.ApiExample
{
    public class Movies
    {
        public  int  ID { get; set; }
        public string NAME { get; set; }

        public string MOBILENUMBER { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialization");

       
          
    

            List<Movies> movList = new List<Movies>
            {
                 new Movies{ ID=123,NAME="VIKRAM MARUKUDU",MOBILENUMBER="91+984915983"},
                 new Movies{ ID=1234,NAME="VIKRAM MARUKUDU",MOBILENUMBER="91+984915983"}
            };
            string result = JsonConvert.SerializeObject(movList);
            Console.WriteLine(result);
        }
    }
}
