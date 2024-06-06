using PY03___Control_de_vuelos.Programa.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PY03___Control_de_vuelos.Programa.APP
{
    public partial class Panel_PassengerFlights : Form
    {
        public Panel_PassengerFlights()
        {
            InitializeComponent();
            LoadPassengersIntoComboBox();
        }

        private void LoadPassengersIntoComboBox()
        {
            DataTable passengersTable = Conexion.GetAllPassengers();
            if (passengersTable != null)
            {
                for (int i = 0; i < passengersTable.Rows.Count; i++)
                {
                    string passport = passengersTable.Rows[i]["Pasaporte"].ToString();
                    string name = passengersTable.Rows[i]["Nombre"].ToString();
                    string lastname1 = passengersTable.Rows[i]["Apellido 1"].ToString();
                    string lastname2 = passengersTable.Rows[i]["Apellido 1"].ToString();
                    string email = passengersTable.Rows[i]["email"].ToString();
                    string phoneNumber = passengersTable.Rows[i]["Telefono"].ToString();

                    string passengerText = $"{passport}: {name} {lastname1} {lastname2} - {email} ({phoneNumber})";

                    cbPassenger.Items.Add(passengerText);
                }
            }
        }

        private string GetSelectedPassengerPassport()
        {
            int selectedIndex = cbPassenger.SelectedIndex;
            if (selectedIndex == -1) return null;

            string passportNumber = cbPassenger.SelectedItem.ToString();
            passportNumber = passportNumber.Split(':')[0];

            return passportNumber;
        }

        private void LoadPassengerFlightsIntoList()
        {
            string passengerPassport = GetSelectedPassengerPassport();
            if (passengerPassport == null) return;

            DataTable dataTable = Conexion.GetPassengerFlights(passengerPassport);
            if (dataTable == null) return;

            dgvFlights.DataSource = dataTable;
        }

        private void cbPassenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPassengerFlightsIntoList();
        }
    }
}
