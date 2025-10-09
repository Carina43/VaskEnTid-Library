using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaskEnTidLibrary.Model;
using VaskEnTid_Library.Repo;

namespace VaskEnTid_Library.Service
{
    public class BookingService
    {
        private IDatabaseRepo<Booking, int> _bookingRepo = new BookingRepo();
        private IDatabaseRepo<Resident, string> _residentRepo = new ResidentRepo();
        private IDatabaseRepo<Machine, int> _machineRepo = new MachineRepo();
        private IDatabaseRepo<Laundromat, int> _laundromatRepo = new LaundromatRepo();

        public List<Booking> _bookings = new List<Booking>();
        public List<Resident> _residents = new List<Resident>(); 
        public List<Machine> _machines = new List<Machine>(); 
        public List<Laundromat> _laundromats = new List<Laundromat>();

        public List<Booking> GetAllBookings()
        {
            _bookings = _bookingRepo.GetAll();
            return _bookings;
        }

        public List<Resident> GetAllResidents()
        {
            _residents = _residentRepo.GetAll();
            return _residents;
        }

        public List<Machine> GetAllMachines()
        {
            _machines = _machineRepo.GetAll();
            return _machines;
        }

        public List<Laundromat> GetAllLaundromats()
        {
            _laundromats = _laundromatRepo.GetAll();
            return _laundromats;
        }

        public void CreateBooking(Booking booking)
        {

            _bookingRepo.Add(booking);
        }

        public void CancelBooking(int bookingID)
        {
            _bookingRepo.Delete(bookingID);
        }



    }
}
