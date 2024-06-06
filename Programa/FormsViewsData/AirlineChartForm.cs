using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PY03___Control_de_vuelos.Programa.Modelo;

namespace PY03___Control_de_vuelos.Programa.FormsViewsData
{
    public partial class AirlineChartForm : Form
    {
        private Conexion conexion;

        public AirlineChartForm()
        {
            InitializeComponent();
            conexion = new Conexion();
            LoadChartData();
        }
        /// <summary>
        /// Carga los datos del chart
        /// </summary>
        private void LoadChartData()
        {
            DataTable dataTable = conexion.GetPlanesByAirline();
            if (dataTable != null)
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Aviones por Aerolínea");

                Series series = new Series
                {
                    Name = "Planes",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Pie,
                    Label = "#VALY" // Show only the plane count in labels
                };
                chart1.Series.Add(series);

                foreach (DataRow row in dataTable.Rows)
                {
                    string airlineName = row["AirlineName"].ToString();
                    int planeCount = Convert.ToInt32(row["PlaneCount"]);
                    series.Points.AddXY(airlineName, planeCount);
                }

                foreach (DataPoint point in series.Points)
                {
                    point.LegendText = point.AxisLabel; // Show airline name in the legend
                    point.Label = point.YValues[0].ToString(); // Show only plane count in data point labels
                }

                chart1.Invalidate();
            }
        }
    }
}
