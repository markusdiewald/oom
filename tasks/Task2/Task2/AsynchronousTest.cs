using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class AsynchronousTest
    {
        public static async void Start()
        {
            Console.WriteLine("Start of Asynchronous Method");
            Console.WriteLine(await TestAsync());
        }

        static async Task<string> TestAsync()
        {
            await Task.Delay(2000);
            return "End of Asynchronous Method";
        }
    }
}
