using VaskEnTid_Library.Repo;
using VaskEnTidLibrary.Model;
namespace VaskEnTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BookingRepo hahah = new BookingRepo();

            //List<Booking> bookings = hahah.GetAll();
            //foreach (Booking booking in bookings)
            //{
            //    Console.WriteLine($"{booking.BookingID}  {booking.PhoneNumber}");
            //}

            ////hahah.Add(new Booking(1, 3, "55773478", new DateOnly(2025, 11, 03), new TimeOnly(8, 0, 0)));
            //hahah.Delete(1);

            //bookings = hahah.GetAll();
            //foreach (Booking booking in bookings)
            //{
            //    Console.WriteLine($"{booking.BookingID}  {booking.PhoneNumber}");
            //}

            ResidentRepo hahah = new ResidentRepo();

            List<Resident> residents = hahah.GetAll();
            foreach (Resident resident in residents)
            {
                Console.WriteLine($"{resident.PhoneNumber}  {resident.FirstName}");
            }

            hahah.Add(new Resident("66677788", "Lucifer", "Schwarz","Transylvania 666", "6666" , "Transylvania", "6E", "draculasbitch@lucifer.evil"));
            hahah.Delete("98765432");

            residents = hahah.GetAll();
            foreach (Resident resident in residents)
            {
                Console.WriteLine($"{resident.PhoneNumber}  {resident.FirstName}");
            }
        }
    }
    
}
