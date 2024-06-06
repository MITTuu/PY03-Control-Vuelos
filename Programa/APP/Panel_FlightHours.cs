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
using System.Windows.Forms.DataVisualization.Charting;

namespace PY03___Control_de_vuelos.Programa.APP
{
    public partial class Panel_FlightHours : Form
    {
        public Panel_FlightHours()
        {
            InitializeComponent();
            LoadChart();
        }

        /// <summary>
        /// Carga el grafico con base en la informacion de la BD
        /// </summary>
        private void LoadChart()
        {
            // traer info
            DataTable dt = Conexion.GetTotalFlightHoursByAirline();

            // Limpiar series anteriores
            chart.Series.Clear();

            // Crear una nueva serie
            Series series = new Series("FlightHours");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;

            // Agregar datos de DataTable a la serie
            foreach (DataRow row in dt.Rows)
            {
                string tipo = row["AirlineName"].ToString();
                int cantidad = Convert.ToInt32(row["TotalFlightHours"]);

                series.Points.AddXY(tipo, cantidad);
            }

            // Agregar la serie al Chart
            chart.Series.Add(series);
        }
    }
}
