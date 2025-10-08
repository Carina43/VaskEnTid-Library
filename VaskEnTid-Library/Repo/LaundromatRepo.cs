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
    public class LaundromatRepo : IDatabaseRepo<Laundromat, int>
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Database=VaskEnTid; Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\";Command Timeout=30";

        public List<Laundromat> GetAll()
        {
            List<Laundromat> laundromats = new List<Laundromat>();

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlCode = "SELECT laundromatID, adress, zipcode, city FROM Laundromat; ";

                SqlCommand command = new SqlCommand(sqlCode, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Laundromat laundromat = new Laundromat(reader.GetByte(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    laundromats.Add(laundromat);
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

            return laundromats;
        }

        public void Add(Laundromat laundromat)
        {
            throw new NotImplementedException();
        }

        public void Delete(int laundromatID)
        {
            throw new NotImplementedException();
        }

        public void Update(Laundromat laundromat, int id)
        {
            throw new NotImplementedException();
        }
    }
}
