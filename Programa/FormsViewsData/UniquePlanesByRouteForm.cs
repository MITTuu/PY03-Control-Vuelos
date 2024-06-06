using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PY03___Control_de_vuelos.Programa.Modelo;

namespace PY03___Control_de_vuelos.Programa.FormsViewsData
{
    public partial class UniquePlanesByRouteForm : Form
    {
        private Conexion conexion;

        public UniquePlanesByRouteForm()
        {
            InitializeComponent();
            conexion = new Conexion();
            LoadChartData();
        }
        /// <summary>
        /// Carga los datos al chart
        /// </summary>
        private void LoadChartData()
        {
            DataTable dataTable = conexion.GetUniquePlanesByRoute();

            // Check if dataTable is null or empty
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                Console.WriteLine("Datos obtenidos de GetUniquePlanesByRoute:");
                foreach (DataRow row in dataTable.Rows)
                {
                    string departureCityCode = row["departureCityCode"].ToString();
                    string arrivalCityCode = row["arrivalCityCode"].ToString();
                    int uniquePlanesCount = Convert.ToInt32(row["UniquePlanesCount"]);
                    Console.WriteLine($"Ruta: {departureCityCode} - {arrivalCityCode}, Cantidad de Aviones Diferentes: {uniquePlanesCount}");
                }

                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Cantidad de Aviones Diferentes por Ruta");

                Series series = new Series
                {
                    Name = "UniquePlanes",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Bar
                };
                chart1.Series.Add(series);

                foreach (DataRow row in dataTable.Rows)
                {
                    string route = $"{row["departureCityCode"]} - {row["arrivalCityCode"]}";
                    int uniquePlanesCount = Convert.ToInt32(row["UniquePlanesCount"]);
                    Console.WriteLine($"Añadiendo al gráfico - Ruta: {route}, Cantidad de Aviones Diferentes: {uniquePlanesCount}");
                    series.Points.AddXY(route, uniquePlanesCount);
                }

                series.IsValueShownAsLabel = true;

                chart1.ChartAreas[0].AxisX.Interval = 1; // Ensure X axis labels are not skipped
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rotate X axis labels for better readability

                chart1.Invalidate();
            }
            else
            {
                MessageBox.Show("Error: No hay datos que cargar", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
