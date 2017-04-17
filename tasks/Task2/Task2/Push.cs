using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Task2
{
    class Push
    {
        public static void Run()
        {
            var producer = new Subject<Patient>();

            producer.Subscribe(x => Console.WriteLine($"Created Patient with PatientID {x.PatientID} and Lastname {x.Lastname}"));

            for (var i = 0; i < 100; i++)
            {
                Patient x = new Patient($"Test{i}", "Patient", $"PID{i}", $"AZ{i}", 0, 0, 'M');
                System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(250));

                producer.OnNext(x); // question: is there another way to push the data?
            }       
        }
    }
}
