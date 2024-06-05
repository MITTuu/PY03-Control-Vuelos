﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

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

        public static int GetAvailableSeats(int idFlight)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("GetAvailableSeats", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idFlight", idFlight);

                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
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

        public static int InsertPassenger(string passportNumber, string name, string lastName1, string lastName2, string email, string phoneNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("InsertPassenger", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@passportNumber", passportNumber);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@lastName1", lastName1);
                        command.Parameters.AddWithValue("@lastName2", lastName2);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            // Si no se encontró ningún idDocumento en la tabla
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

        public static int RegisterPassengerInFlightByPassport(int idFlight ,string passportNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("RegisterPassengerInFlightByPassport", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idFlight", idFlight);
                        command.Parameters.AddWithValue("@passportNumber", passportNumber);
                        connection.Open();

                        int rowsaffected = command.ExecuteNonQuery();

                        return 1;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
                return -1;
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




    }
}
