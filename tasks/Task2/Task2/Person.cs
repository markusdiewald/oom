using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Person : IDemographicInfo
    {
        public static int personID;

        public Person(string lastname, string firstname, int dateOfBirth, char gender)
        {
            if (string.IsNullOrWhiteSpace(lastname)) throw new ArgumentException("Lastname must not be empty.", nameof(lastname));
            if (string.IsNullOrWhiteSpace(firstname)) throw new ArgumentException("Firstname must not be empty.", nameof(firstname));

            personID++;
            _personID = personID;
            _Lastname = lastname;
            _Firstname = firstname;
            _DateOfBirth = dateOfBirth;
            _Gender = gender;
        }

        private int _personID;

        public int PersonID
        {
            get { return _personID; }
        }

        private string _Lastname;

        public string Lastname
        {
            get { return _Lastname; }
        }

        private string _Firstname;

        public string Firstname
        {
            get { return _Firstname; }
        }

        private int _DateOfBirth;

        public int DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = DateOfBirth; }
        }

        private char _Gender;

        public char Gender
        {
            get { return _Gender; }
            set { _Gender = Gender; }
        }

        public void PrintDemographicData ()
        {
            Console.WriteLine($"PersonID: {PersonID}\nName: {Firstname} {Lastname}\nGeburtsdatum: {DateOfBirth}\nGeschlecht: {Gender}\n");
        }
    }
}
