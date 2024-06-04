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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PY03___Control_de_vuelos.Programa.APP
{
    public partial class Panel_passengers : Form
    {
        public Panel_passengers()
        {
            InitializeComponent();
            LoadCitiesIntoComboBoxes();
            initializePassengersDataGridView();
        }

        private void LoadCitiesIntoComboBoxes()
        {

            DataTable citiesTable = Conexion.GetAllCities();
            if (citiesTable != null)
            {
                for (int i = 0; i < citiesTable.Rows.Count; i++)
                {
                    string cityCode = citiesTable.Rows[i]["cityCode"].ToString();
                    string cityName = citiesTable.Rows[i]["name"].ToString();
                    string text = $"{cityName} ({cityCode})";

                    cbOrigin.Items.Add(text);
                    cbDestination.Items.Add(text);
                }
            }
        }

        private void LoadFlights()
        {
            DateTime selectedDate = dtpDate.Value;
            string selectedOrigin = cbOrigin.Text.Split('(')[1].TrimEnd(')');
            string selectedDestination = cbDestination.Text.Split('(')[1].TrimEnd(')');

            Console.WriteLine(selectedDate.ToString() + " - " + selectedOrigin + " - " + selectedDestination);

            DataTable dataTable = Conexion.GetFlights(selectedDate, selectedOrigin, selectedDestination);
            if (dataTable != null)
            {
                dgvFlights.DataSource = dataTable;
            }
        }

        private void LoadPassengerInfo()
        {
            string passportNumber = tbPassport.Text;
            DataRow dataRow = Conexion.GetPassengerByPassport(passportNumber);

            if (dataRow == null)
            {
                MessageBox.Show("No hay coincidencias en la base de datos, por favor agregue manualmente la información del nuevo pasajero", "Sin coincidencias", MessageBoxButtons.OK);

                tbName.Text = "";
                tbLastname1.Text = "";
                tbLastname2.Text = "";
                tbEmail.Text = "";
                tbPhoneNumber.Text = "";

                tbName.ReadOnly = false;
                tbLastname1.ReadOnly = false;
                tbLastname2.ReadOnly = false;
                tbEmail.ReadOnly = false;
                tbPhoneNumber.ReadOnly = false;

                btnAddPassenger.Text = "Registrar y Añadir Pasajero";
            }
            else
            {
                string nombre = dataRow["Nombre"].ToString();
                string apellido1 = dataRow["Apellido 1"].ToString();
                string apellido2 = dataRow["Apellido 2"].ToString();
                string email = dataRow["email"].ToString();
                string telefono = dataRow["Telefono"].ToString();

                tbName.Text = nombre;
                tbLastname1.Text = apellido1;
                tbLastname2.Text = apellido2;
                tbEmail.Text = email;
                tbPhoneNumber.Text = telefono;

                tbName.ReadOnly = true;
                tbLastname1.ReadOnly = true;
                tbLastname2.ReadOnly = true;
                tbEmail.ReadOnly = true;
                tbPhoneNumber.ReadOnly = true;

                btnAddPassenger.Text = "Añadir Pasajero";
            }
        }

        private void initializePassengersDataGridView()
        {
            dgvPassengers.Columns.Clear();
            dgvPassengers.ColumnCount = 3;
            dgvPassengers.Columns[0].Name = "Pasaporte";
            dgvPassengers.Columns[1].Name = "Nombre";
            dgvPassengers.Columns[2].Name = "ID";
            dgvPassengers.Columns[2].Visible = false;
        }

        // TODO: make all the validations
        private void AddPassengerToList()
        {
            string passportNumber = tbPassport.Text;
            string name = tbName.Text + " " + tbLastname1.Text + " " + tbLastname2.Text;

            dgvPassengers.Rows.Add(passportNumber, name);
        }

        private void cbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFlights();
        }

        private void btnConfirmPassport_Click(object sender, EventArgs e)
        {
            LoadPassengerInfo();
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            AddPassengerToList();
        }
    }
}
