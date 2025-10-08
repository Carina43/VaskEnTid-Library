using VaskEnTid_Library.Repo;
using VaskEnTidLibrary.Model;
namespace VaskEnTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDatabaseRepo<Booking> hahah = new BookingRepo();

            foreach (var obj in hahah.GetAll())
            {
                Console.WriteLine($"{obj.BookingID}  {obj.PhoneNumber} {obj.BookingDate} ");
            }

            //hahah.Update(new Booking(1, 8, "12345678", new DateOnly(2025, 12, 24), new TimeOnly(8, 0, 0)));

            //foreach (var obj in hahah.GetAll())
            //{
            //    Console.WriteLine($"{obj.MachineID}  {obj.PhoneNumber} {obj.BookingDate} ");
            //}

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


            //foreach (Resident resident in residents)
            //{
            //    Console.WriteLine($"{resident.PhoneNumber}  {resident.FirstName}");
            //}

            //hahah.Add(new Resident("66677788", "Lucifer", "Schwarz","Transylvania 666", "6666" , "Transylvania", "6E", "draculasbitch@lucifer.evil"));
            //hahah.Delete("98765432");

            ////hahah.Update(new Resident("55773478", "Louise", "Louisen", "Holbækvej 215", "4300", "Holbæk", "1A", "louisebitch@live.dk"));
            ////hahah.Update(new Resident("99000022", "Louise", "Poulsen", "Holbækvej 215", "4300", "Holbæk", "1A", "louisebitch@live.dk"),"55773478");
            //hahah.Update(new Resident("33344455", "Gunnar", "Obsternasig", "Holbækvej 215", "4300", "Holbæk", "2A", "obsternasen@live.com"), "44773478");
            //hahah.Update(new Resident("33344455", "Gunnar", "Obsternosig", "Holbækvej 215", "4300", "Holbæk", "2A", "obsternasen@live.com"), "33344455");

            //machines = hahah.GetAll();



        }

    }
    
}
