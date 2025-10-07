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
    public class MachineRepo
    {

        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Database=VaskEnTid; Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\";Command Timeout=30";

        public List<Machine> GetAll()
        {
            List<Machine> machines = new List<Machine>();

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string sqlCode = "SELECT machineID, laundromatID, machinetype FROM Machine; ";

                SqlCommand command = new SqlCommand(sqlCode, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    switch(reader.GetString(2))
                    {
                        case "Vaskemaskine":
                            
                            break; 




                    }
                    Machine machine = new Machine(reader.GetInt16(0), reader.GetInt16(1), reader.GetString(2));

                    machines.Add(machine);
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
    }
}
