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
            // Traer info
            DataTable dt = Conexion.GetTotalFlightHoursByAirline();

            // Limpiar series anteriores
            chart.Series.Clear();

            // Crear una nueva serie
            Series series = new Series("FlightHours");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.Black;
            series.Palette = ChartColorPalette.SeaGreen;

            // Configurar el gráfico para mostrar etiquetas dentro de las secciones del pie
            series.Label = "#VALX (#PERCENT)"; // Muestra el nombre de la aerolínea y el porcentaje
            series.ToolTip = "#VALX: #VALY horas"; // Tooltip con el nombre de la aerolínea y las horas totales

            series["PieLabelStyle"] = "Outside"; // Coloca las etiquetas afuera del gráfico
            series["PieLineColor"] = "Black"; // Color de la línea que conecta las etiquetas

            // Agregar datos de DataTable a la serie
            foreach (DataRow row in dt.Rows)
            {
                string airlineName = row["AirlineName"].ToString();
                int totalFlightHours = Convert.ToInt32(row["TotalFlightHours"]);

                DataPoint point = new DataPoint();
                point.AxisLabel = airlineName;
                point.YValues = new double[] { totalFlightHours };
                point.Label = airlineName + ": " + totalFlightHours + " horas";

                series.Points.Add(point);
            }

            // Agregar la serie al Chart
            chart.Series.Add(series);

            // Ajustar las propiedades del gráfico para mejorar la visualización
            chart.Legends.Clear(); // Opcional: si no quieres mostrar la leyenda a un lado
            chart.Titles.Clear();
            chart.Titles.Add("Total de horas de vuelo por aerolínea");
        }

    }
}
