using VaskEnTid_Library.Repo;
using VaskEnTidLibrary.Model;
namespace VaskEnTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookingRepo hahah = new BookingRepo();

            List<Booking> bookings = hahah.GetAll();
            foreach (Booking booking in bookings)
            {
                Console.WriteLine(booking.PhoneNumber);
            }
        }
    }
}
