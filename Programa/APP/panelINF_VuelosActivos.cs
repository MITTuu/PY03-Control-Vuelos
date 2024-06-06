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
    public partial class panelINF_VuelosActivos : Form
    {
        private Conexion cnx;
        private DataTable dtVuelos;
        public panelINF_VuelosActivos()
        {
            InitializeComponent();
            cnx = new Conexion();
            dtVuelos = new DataTable();
        }

        private void panelINF_VuelosActivos_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrarPiloto_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtp_fechaIni.Value.Date;
            DateTime endDate = dtp_fechaFin.Value.Date;

            startDate = startDate.Date;
            endDate = endDate.Date.AddDays(1).AddTicks(-1);

            if (startDate > endDate)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor a la final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable consulta = cnx.GetActiveFlights(startDate, endDate);
            if (consulta.Rows.Count > 0)
            {
                dtVuelos = consulta;
                dgv_vuelos.DataSource = dtVuelos;


                dgv_vuelos.DefaultCellStyle.ForeColor = Color.Black;

                // Organizar las columnas
                dgv_vuelos.Columns["AirlineName"].DisplayIndex = 0;
                dgv_vuelos.Columns["RegistrationNumber"].DisplayIndex = 1;
                dgv_vuelos.Columns["PilotFullName"].DisplayIndex = 2;
                dgv_vuelos.Columns["DepartureCity"].DisplayIndex = 3;
                dgv_vuelos.Columns["ArrivalCity"].DisplayIndex = 4;
                dgv_vuelos.Columns["DepartureDate"].DisplayIndex = 5;
                dgv_vuelos.Columns["ArrivalDate"].DisplayIndex = 6;

                // Auto size
                dgv_vuelos.Columns["AirlineName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_vuelos.Columns["RegistrationNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_vuelos.Columns["PilotFullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_vuelos.Columns["DepartureCity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_vuelos.Columns["ArrivalCity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_vuelos.Columns["DepartureDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_vuelos.Columns["ArrivalDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Cambiar el nombre de las columnas
                dgv_vuelos.Columns["AirlineName"].HeaderText = "Aerolínea";
                dgv_vuelos.Columns["RegistrationNumber"].HeaderText = "Código del avión";
                dgv_vuelos.Columns["PilotFullName"].HeaderText = "Nombre completo del piloto";
                dgv_vuelos.Columns["DepartureCity"].HeaderText = "Ciudad de salida";
                dgv_vuelos.Columns["ArrivalCity"].HeaderText = "Ciudad de llegada";
                dgv_vuelos.Columns["DepartureDate"].HeaderText = "Fecha de salida";
                dgv_vuelos.Columns["ArrivalDate"].HeaderText = "Fecha de llegada";

            }
            else
            {
                MessageBox.Show("No se encontraron vuelos activos en el rango de fechas especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_vuelos.DataSource = null;
            }
        }


    }
}
