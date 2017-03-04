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
            Patient patient01 = new Patient ("Mustermann", "Max", "0123456789", "2017123456", 19600802, 123402081960, 'M');
            
            Console.WriteLine($"Patientenname: {patient01.Firstname} {patient01.Lastname}\nPID: {patient01.HospitalNumber}\nFallzahl: {patient01.AccountNumber}\nGeschlecht: {patient01.Gender}\n");

            patient01.UpdateHospitalNumber("9876543210");
            patient01.Gender = 'M';

            Console.WriteLine($"Patientenname: {patient01.Firstname} {patient01.Lastname}\nPID: {patient01.HospitalNumber}\nFallzahl: {patient01.AccountNumber}\nGeschlecht: {patient01.Gender}\n");
                        
        }
    }
}
