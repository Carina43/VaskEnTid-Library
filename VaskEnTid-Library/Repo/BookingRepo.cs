using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using VaskEnTidLibrary.Model;

namespace VaskEnTid_Library.Repo
{
    internal class BookingRepo
    {
        static string connectionString = "Data Source=(localdb)\MSSQLLocalDB; DataBase=VaskEnTid; Integrated Security = True; Encrypt=False;TrustServerCertificate=False;";

        public List<Booking> GetAll()
        {
            List<Booking> bookings = new List<Booking>();

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlCode = "SELECT BookingID, MachineID, PhoneNumber, Date, Time FROM Booking; ";

                SqlCommand command = new SqlCommand(sqlCode, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Booking booking = new Booking(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), DateOnly.FromDateTime(reader.GetDateTime(3)), TimeOnly.FromDateTime(reader.GetDateTime(4)));

                    bookings.Add(booking);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error:\n" + ex);
            }
            finally
            {
                connection.Close();
            }

            return bookings;
        }
    }
}
