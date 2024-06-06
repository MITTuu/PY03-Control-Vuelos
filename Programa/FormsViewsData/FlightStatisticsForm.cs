using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PY03___Control_de_vuelos.Programa.Modelo;

namespace PY03___Control_de_vuelos.Programa.FormsViewsData
{
    public partial class FlightStatisticsForm : Form
    {
        private Conexion conexion;

        public FlightStatisticsForm()
        {
            InitializeComponent();
            conexion = new Conexion();
            LoadChartData();
        }
        /// <summary>
        /// Carga la información al panel 
        /// </summary>
        private void LoadChartData()
        {
            DataTable dataTable = conexion.GetFlightStatistics();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
   
                foreach (DataRow row in dataTable.Rows)
                {
                    string cityName = row["CityName"].ToString();
                    int planeCount = Convert.ToInt32(row["PlaneCount"]);
                    int flightCount = Convert.ToInt32(row["FlightCount"]);
   
                }

                // Chart para la cantidad de aviones
                chartPlanes.Series.Clear();
                chartPlanes.Titles.Clear();
                chartPlanes.Titles.Add("Cantidad de Aviones por Ciudad");

                Series planeSeries = new Series
                {
                    Name = "Cantidad de Aviones",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column // Column type for vertical bars
                };
                chartPlanes.Series.Add(planeSeries);

                // Chart para la cantidad de vuelos
                chartFlights.Series.Clear();
                chartFlights.Titles.Clear();
                chartFlights.Titles.Add("Cantidad de Vuelos por Ciudad");

                Series flightSeries = new Series
                {
                    Name = "Cantidad de Vuelos",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column // Column type for vertical bars
                };
                chartFlights.Series.Add(flightSeries);

                foreach (DataRow row in dataTable.Rows)
                {
                    string cityName = row["CityName"].ToString();
                    int planeCount = Convert.ToInt32(row["PlaneCount"]);
                    int flightCount = Convert.ToInt32(row["FlightCount"]);

                    planeSeries.Points.AddXY(cityName, planeCount);
                    flightSeries.Points.AddXY(cityName, flightCount);
                }

                planeSeries.IsValueShownAsLabel = true;
                flightSeries.IsValueShownAsLabel = true;

                chartPlanes.ChartAreas[0].AxisX.Interval = 1;
                chartPlanes.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

                chartFlights.ChartAreas[0].AxisX.Interval = 1;
                chartFlights.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

                // Mostrar la ciudad con más vuelos
                DataRow topCityRow = dataTable.Rows[0];
                string topCityName = topCityRow["CityName"].ToString();
                int topCityFlightCount = Convert.ToInt32(topCityRow["FlightCount"]);
                labelTopCity.Text = $"Ciudad con más vuelos: {topCityName} ({topCityFlightCount} vuelos)";

                chartPlanes.Invalidate();
                chartFlights.Invalidate();
            }
            else
            {
                Console.WriteLine("No se obtuvieron datos de GetFlightStatistics o la tabla está vacía.");
            }
        }
    }
}
