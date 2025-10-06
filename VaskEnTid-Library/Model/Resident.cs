using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskEnTidLibrary.Model
{
    public class Resident
    {
        private string _phoneNumber;
        private string _firstName;
        private string _lastName;
        private string _adress;
        private string _zipCode;
        private string _city;
        private string _apartmentNo;
        private string _email;

        internal string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        internal string FirstName { get { return _firstName; } set { _firstName = value; } }
        internal string LastName { get { return _lastName; } set { _lastName = value; } }
        internal string Adress { get { return _adress; } set { _adress = value; } }
        internal string ZipCode { get { return _zipCode; } set { _zipCode = value; } }
        internal string City { get { return _city; } set { _city = value; } }
        internal string ApartmentNo { get { return _apartmentNo; } set { _apartmentNo = value; } }
        internal string Email { get { return _email; } set { _email = value; } }

        public Resident(string phoneNumber, string firstName, string lastName, string adress, string zipCode, string city, string apartmentNo, string email)
        {
            PhoneNumber = phoneNumber;
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
            ZipCode = zipCode;
            City = city;
            ApartmentNo = apartmentNo;
            Email = email;
        }
    }
}
