using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PY03___Control_de_vuelos.Programa.Modelo
{
    internal class Conexion
    {
        private static readonly string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=AirlineControl;Integrated Security=True";

        public Conexion()
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
            }

        }

        public DataRow GetUserByEmailAndPassword(string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("GetUserByEmailAndPassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            return dataTable.Rows[0];
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
        public DataTable GetAirlinesWithPlanes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("GetAirlinesWithPlanes", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }

        public List<string> GetNameAirlines()
        {
            List<string> airlines = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("GetNameAirlines", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            airlines.Add(reader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
            }

            return airlines;
        }


        public List<string> GetNameBrands()
        {
            List<string> brands = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("GetNameBrands", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            brands.Add(reader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
            }

            return brands;
        }



        public static DataTable GetAllCities()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("GetAllCities", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }

        public static DataTable GetFlights(DateTime selectedDate, string originCityCode, string destinationCityCode)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("GetFlights", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        
                        command.Parameters.AddWithValue("@selectedOrigin", originCityCode);
                        command.Parameters.AddWithValue("@selectedDestination", destinationCityCode);
                        command.Parameters.AddWithValue("@selectedDate", selectedDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }

        public static DataRow GetPassengerByPassport(string passportNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("GetPassengerByPassport", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@passportNumber", passportNumber);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            return dataTable.Rows[0];
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }

        public int SaveAirlines(string name, string motto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SaveAirline", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@motto", motto);
                        connection.Open(); 

                        int rowsaffected = command.ExecuteNonQuery(); 

                        if (rowsaffected > 0)
                        {
                            MessageBox.Show("Aerolínea agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return 1;
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar la aerolinea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
                return -1;
            }
        }

        public int SavePlane(string registrationNumber, int idAirline, int idBrand, int capacity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SavePlane", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@registrationNumber", registrationNumber);
                        command.Parameters.AddWithValue("@idAirline", idAirline);
                        command.Parameters.AddWithValue("@idBrand", idBrand);
                        command.Parameters.AddWithValue("@capacity", capacity);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        return rowsAffected;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
                return 0;
            }
        }

        public int GetAirlineIdByName(string name)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT idAirline FROM Airline WHERE name = @name", connection))
                    {
                        command.Parameters.AddWithValue("@name", name);

                        connection.Open();
                        object result = command.ExecuteScalar();
                        connection.Close();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
                return 0;
            }
        }

        public int GetBrandIdByName(string name)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT idBrand FROM Brand WHERE name = @name", connection))
                    {
                        command.Parameters.AddWithValue("@name", name);

                        connection.Open();
                        object result = command.ExecuteScalar();
                        connection.Close();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
                return 0;
            }
        }


    }
}
