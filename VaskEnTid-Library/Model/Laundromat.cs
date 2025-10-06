using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace VaskEnTidLibrary.Model
{
    public class Laundromat
    {
        private int _laundromatID;
        private string _adress;
        private string _zipCode;
        private string _city;

        internal int LaundromatID
        {
            get { return _laundromatID; }
            set { _laundromatID = value; }
        }

        internal string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        internal string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        internal string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public Laundromat(int laundromatID, string adress, string zipCode, string city)
        {
            LaundromatID = laundromatID;
            Adress = adress;
            ZipCode = zipCode;
            City = city;
        }

    }
}
