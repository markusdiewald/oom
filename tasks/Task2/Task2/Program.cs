using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Reactive.Linq;
using System.Reactive.Subjects;



namespace Task2
{

    class Program
    {
        static void Main(string[] args)
        {
            var patients = new IDemographicInfo[]
            {
                new Patient("Mustermann", "Max", "0000000001", "2017000001", 19600802, 123402081960, 'M'),
                new Patient("Test", "Heinz", "0000000002", "2017000002", 19700901, 987601091970, 'M'),
                new Patient("Test", "Markus", "0000000003", "2017000003", 19920403, 9876003041992, 'M'),
                new Person("Doe", "John", 19600101, 'M'),
                new Person("Test", "Person", 19801121, 'W')
            };

            /************** Push Test Start ****************************************************************/

            //Push.Run();

            /************** Push Test End ******************************************************************/


            /************** Asynchronous Test Start ********************************************************/

            AsynchronousTest.Start();
            Console.WriteLine("Meanwhile start counting in main...");
            for (int i = 0; i < 20; i++)
            {
                System.Threading.Thread.Sleep(250);
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("...End");

            /************** Asynchronous Test End **********************************************************/

            /************** Json Serialization Begin *******************************************************/

            /*
            var jsonsettings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(patients, jsonsettings));
            
            var text = JsonConvert.SerializeObject(patients, jsonsettings);
            File.WriteAllText(@"C:\temp\patients.json", text);
                        
            var textFromFile = File.ReadAllText(@"C:\temp\patients.json");
            var itemsFromFile = JsonConvert.DeserializeObject<IDemographicInfo[]>(textFromFile, jsonsettings);
            foreach (var x in itemsFromFile) x.PrintDemographicData();    
            */

            /************** Json Serialization End *********************************************************/
        }
    }    
}
