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
            var stats = new[]
            {
                new Stats("Mistelbach Mustangs", "St. Pölten Dragons", 98, 76),
                new Stats("Mistelbach Mustangs", "DC Timberwolves Vienna", 102, 98),
            };

            foreach (var x in stats)
            {
                Console.WriteLine("{0}:{1} {2}:{3}\n", x.Hometeam, x.Awayteam, x.Score_Hometeam, x.Score_Awayteam);
            }


        }
    }
}
