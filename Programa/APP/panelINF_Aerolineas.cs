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
    public partial class panelINF_Aerolineas : Form
    {
        private Conexion cnx;
        public panelINF_Aerolineas()
        {
            InitializeComponent();
            cnx = new Conexion();
        }

        private void panelINF_Aerolineas_Load(object sender, EventArgs e)
        {
            cargarAerolineas();
        }

        private void cargarAerolineas()
        {
            DataTable dataTableAerolineas = cnx.GetAirlines();

            cb_aerolineas.Items.Clear();
            cb_aerolineas.Items.Add("Seleccione una aerolínea");

            foreach (DataRow row in dataTableAerolineas.Rows)
            {
                cb_aerolineas.Items.Add(row["idAirline"] + "; " + row["name"].ToString());
            }
            cb_aerolineas.SelectedIndex = 0;
        }

        private void cb_aerolineas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_aerolineas.SelectedIndex == 0)
            {
                return;
            }

            int idAirline = int.Parse(cb_aerolineas.SelectedItem.ToString().Split(';')[0]);

            DataTable consulta = cnx.GetFlightInfoByAirlineId(idAirline);
            if (consulta.Rows.Count > 0)
            {
                dgv_aerolineas.DataSource = consulta;


                dgv_aerolineas.DefaultCellStyle.ForeColor = Color.Black;

                // Ocultar
                dgv_aerolineas.Columns["name"].Visible = false;

                // Organizar las columnas
                dgv_aerolineas.Columns["idFlight"].DisplayIndex = 1;
                dgv_aerolineas.Columns["DepartureCity"].DisplayIndex = 2;
                dgv_aerolineas.Columns["ArrivalCity"].DisplayIndex = 3;
                dgv_aerolineas.Columns["DepartureDateTime"].DisplayIndex = 4;
                dgv_aerolineas.Columns["ArrivalDateTime"].DisplayIndex = 5;

                // Auto size
                dgv_aerolineas.Columns["idFlight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_aerolineas.Columns["DepartureCity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_aerolineas.Columns["ArrivalCity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_aerolineas.Columns["DepartureDateTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_aerolineas.Columns["ArrivalDateTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Cambiar el nombre de las columnas
                dgv_aerolineas.Columns["idFlight"].HeaderText = "n° de Vuelo";
                dgv_aerolineas.Columns["DepartureCity"].HeaderText = "Ciudad de salida";
                dgv_aerolineas.Columns["ArrivalCity"].HeaderText = "Ciudad de llegada";
                dgv_aerolineas.Columns["DepartureDateTime"].HeaderText = "Fecha de salida";
                dgv_aerolineas.Columns["ArrivalDateTime"].HeaderText = "Fecha de llegada";

            }
            else
            {
                MessageBox.Show("No se encontraron vuelos registrados para la aerolínea seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_aerolineas.DataSource = null;
            }
        }
    }
}
