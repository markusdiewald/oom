using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Patient
    {
        public Patient(string lastname, string firstname, string hospitalNumber, string accountNumber, int dateOfBirth, long socialSecurity, char gender )
        {
            if (string.IsNullOrWhiteSpace(lastname)) throw new ArgumentException("Lastname must not be empty.", nameof(lastname));
            if (string.IsNullOrWhiteSpace(firstname)) throw new ArgumentException("Firstname must not be empty.", nameof(firstname));
            if (string.IsNullOrWhiteSpace(hospitalNumber)) throw new ArgumentException("Hospitalnumber must not be empty.", nameof(hospitalNumber));
            if (string.IsNullOrWhiteSpace(accountNumber)) throw new ArgumentException("Accountnumber must not be empty.", nameof(accountNumber));

            _Lastname = lastname;
            _Firstname = firstname;
            _HospitalNumber = hospitalNumber;
            _AccountNumber = accountNumber;
            _DateOfBirth = dateOfBirth;
            _SocialSecurity = socialSecurity;
            _Gender = gender;
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

        private string _HospitalNumber;

        public string HospitalNumber
        {
            get { return _HospitalNumber; }
        }

        private string _AccountNumber;

        public string AccountNumber
        {
            get { return _AccountNumber; }
        }

        private int _DateOfBirth;

        public int DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = DateOfBirth; }
        }

        private long _SocialSecurity;

        public long SocialSecurity
        {
            get { return _SocialSecurity; }
        }

        private char _Gender;

        public char Gender
        {
            get { return _Gender; }
            set { _Gender = Gender; }
        }

        public void UpdateHospitalNumber (string newHospitalNumber)
        {
            if (string.IsNullOrWhiteSpace(newHospitalNumber)) throw new ArgumentException("Hospitalnumber must not be empty.", nameof(newHospitalNumber));
            _HospitalNumber = newHospitalNumber;
        }



    }
}

