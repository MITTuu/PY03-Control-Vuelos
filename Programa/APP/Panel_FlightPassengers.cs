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
    public partial class Panel_FlightPassengers : Form
    {
        public Panel_FlightPassengers()
        {
            InitializeComponent();
            LoadFlightsIntoComboBox();
        }

        private void LoadFlightsIntoComboBox()
        {
            DataTable flightsTable = Conexion.GetAllFlightsInfo();
            if (flightsTable != null)
            {
                for (int i = 0; i < flightsTable.Rows.Count; i++)
                {
                    string numVuelo = flightsTable.Rows[i]["Num"].ToString();
                    string salida = flightsTable.Rows[i]["Salida"].ToString();
                    string llegada = flightsTable.Rows[i]["Llegada"].ToString();
                    string ciudadPartida = flightsTable.Rows[i]["Ciudad Partida"].ToString();
                    string ciudadLlegada = flightsTable.Rows[i]["Ciudad Llegada"].ToString();
                    string avion = flightsTable.Rows[i]["Avion"].ToString();

                    string flightText = $"{numVuelo}: {ciudadPartida} - {ciudadLlegada} ({salida})";

                    cbFlight.Items.Add(flightText);
                }
            }
        }

        private int GetSelectedFlightId()
        {
            int selectedIndex = cbFlight.SelectedIndex;
            if (selectedIndex == -1) return -1;

            string selectedtext = cbFlight.SelectedItem.ToString();
            selectedtext = selectedtext.Split(':')[0];
            if (!Int32.TryParse(selectedtext, out int id)) return -1;

            return id;
        }

        private void LoadFlightPasssengerIntoList()
        {
            int idFlight = GetSelectedFlightId();
            if (idFlight == -1) return;

            DataTable dataTable = Conexion.GetFlightPassengers(idFlight);
            if (dataTable == null) return;

            dgvPassengers.DataSource = dataTable;
        }

        private void cbFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFlightPasssengerIntoList();
        }
    }
}
