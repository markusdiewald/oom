using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;



namespace Task2
{

    /*public class RootObject
    {
        public int PatientID { get; set; }
        public string HospitalNumber { get; set; }
        public string AccountNumber { get; set; }
        public object SocialSecurity { get; set; }
        public int PersonID { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public int DateOfBirth { get; set; }
        public string Gender { get; set; }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            var patients = new IDemographicInfo[]
            {
                new Patient("Mustermann", "Max", "0000000001", "2017000001", 19600802, 123402081960, 'M'),
                new Patient("Test", "Heinz", "0000000002", "2017000002", 19700901, 987601091970, 'M'),
                /*new Person("Testperson", "Harald", 19850613, 'M'),
                new Person("Testperson2", "Richard", 19850613, 'M'),*/
                new Patient("Test", "Markus", "0000000003", "2017000003", 19920403, 9876003041992, 'M')
            };
            

            using (StreamWriter file = File.CreateText(@"C:\temp\patients.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, patients);
            }

            Patient[] res = JsonConvert.DeserializeObject<Patient[]>(File.ReadAllText(@"C:\temp\patients.json"));
            
            foreach(var x in res)
            {
                x.PrintDemographicData();
            }                
        }
    }


}
