using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using VaskEnTidLibrary.Model;

namespace VaskEnTid_Library.Repo
{
    public class ResidentRepo
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Database=VaskEnTid; Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\";Command Timeout=30";

        public List<Resident> GetAll()
        {
            List<Resident> residents = new List<Resident>();

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlCode = "SELECT phonenumber, firstname, lastname, adress, zipcode, city, apartno, email FROM Resident; ";

                SqlCommand command = new SqlCommand(sqlCode, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Resident resident = new Resident(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));

                    residents.Add(resident);
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

            return residents;
        }

        public void Add(Resident resident)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlCode = "INSERT INTO Resident (phonenumber, firstname, lastname, adress, zipcode, city, apartno, email) " +
                                 "VALUES (@phonenumber, @firstname, @lastname, @adress, @zipcode, @city, @apartno, @email);";

                SqlCommand command = new SqlCommand(sqlCode, connection);

                command.Parameters.AddWithValue("@phonenumber", resident.PhoneNumber);
                command.Parameters.AddWithValue("@firstname", resident.FirstName);
                command.Parameters.AddWithValue("@lastname", resident.LastName);
                command.Parameters.AddWithValue("@adress", resident.Adress);
                command.Parameters.AddWithValue("@zipcode", resident.ZipCode);
                command.Parameters.AddWithValue("@city", resident.City);
                command.Parameters.AddWithValue("@apartno", resident.ApartmentNo);
                command.Parameters.AddWithValue("@email", resident.Email);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error:\n" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Delete(string phoneNumber)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlCode = "DELETE FROM Resident WHERE phonenumber = @phonenumber;";
                SqlCommand command = new SqlCommand(sqlCode, connection);

                command.Parameters.AddWithValue("@phonenumber", phoneNumber);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error\n" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
