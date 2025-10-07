using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskEnTidLibrary.Model
{
    public class Booking
    {
        private int _bookingID;
        private int _machineID;
        private string _phoneNumber;
        private DateOnly _bookingDate;
        private TimeOnly _bookingTime;

        internal int BookingID
        {
            get { return _bookingID; }
            set { _bookingID = value; }
        }

        internal int MachineID
        {
            get { return _machineID; }
            set { _machineID = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        internal DateOnly BookingDate
        {
            get { return _bookingDate; }
            set { _bookingDate = value; }
        }

        internal TimeOnly BookingTime
        {
            get { return _bookingTime; }
            set { _bookingTime = value; }
        }

        public Booking(int bookingID, int machineID, string phoneNumber, DateOnly bookingDate, TimeOnly bookingTime)
        {
            BookingID = bookingID;
            MachineID = machineID;
            PhoneNumber = phoneNumber;
            BookingDate = bookingDate;
            BookingTime = bookingTime;
        }

    }
}
