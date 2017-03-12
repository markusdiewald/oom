using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                new Person("Testperson", "Harald", 19850613, 'M'),
                new Person("Testperson2", "Richard", 19850613, 'M')
            };

            foreach(var x in patients)
            {
                x.PrintDemographicData();
            }
                                    
        }
    }
}
