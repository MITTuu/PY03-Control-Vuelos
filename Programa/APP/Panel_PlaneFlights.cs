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

namespace PY03___Control_de_vuelos.Programa.APP
{
    public partial class Panel_PlaneFlights : Form
    {
        public Panel_PlaneFlights()
        {
            InitializeComponent();
            LoadPlanesIntoComboBox();
        }

        private void LoadPlanesIntoComboBox()
        {
            DataTable dataTable = Conexion.GetAllPlanes();
            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string registrationNumber = dataTable.Rows[i]["registrationNumber"].ToString();
                    string airline = dataTable.Rows[i]["Airline"].ToString();
                    string brand = dataTable.Rows[i]["Brand"].ToString();
                    string capacity = dataTable.Rows[i]["capacity"].ToString();

                    string passengerText = $"{registrationNumber}: {brand} de {capacity} asientos [{airline}]";

                    cbPlane.Items.Add(passengerText);
                }
            }
        }

        private string GetSelectedPlaneNumber()
        {
            int selectedIndex = cbPlane.SelectedIndex;
            if (selectedIndex == -1) return null;

            string planeNumber = cbPlane.SelectedItem.ToString();
            planeNumber = planeNumber.Split(':')[0];

            return planeNumber;
        }

        private void LoadPlaneFlightsIntoList()
        {
            string registrationNumber = GetSelectedPlaneNumber();
            if (registrationNumber == null) return;

            DataTable dataTable = Conexion.GetPlaneFlights(registrationNumber);
            if (dataTable == null) return;

            dgvFlights.DataSource = dataTable;
        }

        private void cbPlane_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlaneFlightsIntoList();
        }
    }
}
