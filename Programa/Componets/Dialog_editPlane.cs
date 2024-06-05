using PY03___Control_de_vuelos.Programa.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PY03___Control_de_vuelos.Programa.Componets
{
    public partial class Dialog_editPlane : Form
    {
        private string registrationNumber;
        private Conexion conexion;

        public Dialog_editPlane(string idPlane)
        {
            InitializeComponent();
            this.registrationNumber = idPlane;
            this.conexion = new Conexion();
            LoadNameAirlines();
            LoadNameBrands();
            LoadPlaneData(idPlane);

        }

        private void LoadPlaneData(string registrationNumber)
        {
            try
            {
                // Obtener datos del avión con el número de registro proporcionado
                DataTable dataTable = conexion.GetPlaneByRegistrationNumber(registrationNumber);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    comboBox_Arlines.SelectedItem = row["Airline"].ToString();
                    comboBox_brand.SelectedItem = row["Brand"].ToString();
                    text_resNumber.Text = row["registrationNumber"].ToString();
                    numeric_capacity.Value = Convert.ToInt32(row["capacity"]);
                }
                else
                {
                    MessageBox.Show("No se encontraron datos del avión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del avión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            string airline = comboBox_Arlines.Text;
            string brand = comboBox_brand.Text;
            string number = text_resNumber.Text;
            int capacity = (int)numeric_capacity.Value;

            if (string.IsNullOrWhiteSpace(airline) || string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(number) || capacity <= 0)
            {
                MessageBox.Show("Todos los campos son obligatorios y deben tener valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                
                int idAirline = conexion.GetAirlineIdByName(airline);
                int idBrand = conexion.GetBrandIdByName(brand);

                if (idAirline == 0 || idBrand == 0)
                {
                    MessageBox.Show("Aerolínea o marca no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int rowsAffected = conexion.UpdatePlane(number,idAirline, idBrand, capacity); // Llamada a la función de actualización

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Avión actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error al actualizar el avión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNameAirlines()
        {

            // Limpia el comboBox
            comboBox_Arlines.Items.Clear();

            // Obtiene los nombres de las aerolíneas
            List<string> airlines = conexion.GetNameAirlines();

            // Añade los nombres de las aerolíneas al comboBox
            foreach (string airline in airlines)
            {
                Console.WriteLine(airline);
                comboBox_Arlines.Items.Add(airline);
            }
        }

        public void LoadNameBrands()
        {
            // Limpia el comboBox
            comboBox_brand.Items.Clear();

            // Obtiene los nombres de las marcas
            List<string> brands = conexion.GetNameBrands();

            // Añade los nombres de las marcas al comboBox
            foreach (string brand in brands)
            {
                comboBox_brand.Items.Add(brand);
            }
        }
    }
}

