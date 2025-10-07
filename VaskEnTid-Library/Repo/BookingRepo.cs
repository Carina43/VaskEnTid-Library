using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using VaskEnTidLibrary.Model;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VaskEnTid_Library.Repo
{
    public class BookingRepo
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Database=VaskEnTid; Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\";Command Timeout=30";


        public List<Booking> GetAll()
        {
            List<Booking> bookings = new List<Booking>();

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlCode = "SELECT bookingID, machineID, phonenumber, bookingdate, bookingtime FROM Booking; ";

                SqlCommand command = new SqlCommand(sqlCode, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Booking booking = new Booking(reader.GetInt32(0), reader.GetInt16(1), reader.GetString(2), DateOnly.FromDateTime(reader.GetDateTime(3)), TimeOnly.FromTimeSpan(reader.GetTimeSpan(4)));

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
