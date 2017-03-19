using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]

    public class Tests
    {
        [Test]

        public void CanNotCreatePatientWithoutLastname()
        {
            Assert.Catch(() =>
            {
                var x = new Patient("", "Test", "1234", "1234", 19000101, 1234, 'M');
            });          
        }

        [Test]

        public void CanNotCreatePatientWithoutFirstname()
        {
            Assert.Catch(() =>
            {
                var x = new Patient("Test", "", "1234", "1234", 19000101, 1234, 'M');
            });
        }

        [Test]

        public void CanNotCreatePatientWithoutHospitalNumber()
        {
            Assert.Catch(() =>
            {
                var x = new Patient("Test", "Test", "", "1234", 19000101, 1234, 'M');
            });
        }

        [Test]

        public void CanNotCreatePatientWithoutAccountNumber()
        {
            Assert.Catch(() =>
            {
                var x = new Patient("Test", "Test", "1234", "", 19000101, 1234, 'M');
            });
        }

        [Test]

        public void CanNotCreatePatientWithWrongGender()
        {
            Assert.Catch(() =>
            {
                var x = new Patient("Test", "Test", "1234", "1234", 19000101, 1234, 'Z');
            });
        }

        [Test]

        public void PatientIDIsNotNULL()
        {
            var x = new Patient("Test", "Test", "1234", "1234", 19000101, 1234, 'M');
            Assert.IsNotNull(x.PatientID);
        }

        [Test]

        public void PersonIDIsNotNULL()
        {
            var x = new Patient("Test", "Test", "1234", "1234", 19000101, 1234, 'M');
            Assert.IsNotNull(x.PersonID);
        }

        [Test]

        public void CanNotUpdateHospitalNumberToNULL()
        {
            var x = new Patient("Test", "Test", "1234", "1234", 19000101, 1234, 'M');
            Assert.Catch(() =>
            {
                x.UpdateHospitalNumber("");
            });
        }

    }
}
