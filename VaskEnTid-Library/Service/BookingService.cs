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

        public List<Booking> GetAllBookings()
        {
            List<Booking> bookings = _bookingRepo.GetAll();

            return bookings;
        }
    }
}
