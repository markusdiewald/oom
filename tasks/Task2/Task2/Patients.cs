using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Patient : Person, IDemographicInfo
    {
        public static int patientID;
        
        public Patient(string lastname, string firstname, string hospitalNumber, string accountNumber, int dateOfBirth, long socialSecurity, char gender ) : base(lastname, firstname, dateOfBirth, gender)
        {
            if (string.IsNullOrWhiteSpace(hospitalNumber)) throw new ArgumentException("Hospitalnumber must not be empty.", nameof(hospitalNumber));
            if (string.IsNullOrWhiteSpace(accountNumber)) throw new ArgumentException("Accountnumber must not be empty.", nameof(accountNumber));

            patientID++;
            _patientID = patientID;
            _HospitalNumber = hospitalNumber;
            _AccountNumber = accountNumber;
            _SocialSecurity = socialSecurity;

        }

        private int _patientID;

        public int PatientID
        {
            get { return _patientID; }
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
              
       private long _SocialSecurity;

        public long SocialSecurity
        {
            get { return _SocialSecurity; }
        }
        

        public void UpdateHospitalNumber (string newHospitalNumber)
        {
            if (string.IsNullOrWhiteSpace(newHospitalNumber)) throw new ArgumentException("Hospitalnumber must not be empty.", nameof(newHospitalNumber));
            _HospitalNumber = newHospitalNumber;
        }

        public new void PrintDemographicData ()
        {
            Console.WriteLine($"PersonID: {PersonID}\nPatientID: {PatientID}\nPatientenname: {Firstname} {Lastname}\nPID: {HospitalNumber}\nFallzahl: {AccountNumber}\nGeschlecht: {Gender}\n");
        }


    }
}

