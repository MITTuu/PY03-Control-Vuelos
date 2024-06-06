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

        private void LoadChartData()
        {
            DataTable dataTable = conexion.GetFlightStatistics();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                Console.WriteLine("Datos obtenidos de GetFlightStatistics:");
                foreach (DataRow row in dataTable.Rows)
                {
                    string cityName = row["CityName"].ToString();
                    int planeCount = Convert.ToInt32(row["PlaneCount"]);
                    int flightCount = Convert.ToInt32(row["FlightCount"]);
                    Console.WriteLine($"Ciudad: {cityName}, Cantidad de Aviones: {planeCount}, Cantidad de Vuelos: {flightCount}");
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

                    Console.WriteLine($"Añadiendo al gráfico - Ciudad: {cityName}, Cantidad de Aviones: {planeCount}, Cantidad de Vuelos: {flightCount}");

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

        private void InitializeComponent()
        {
            this.chartPlanes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFlights = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTopCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPlanes
            // 
            this.chartPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            ChartArea chartArea1 = new ChartArea();
            this.chartPlanes.ChartAreas.Add(chartArea1);
            this.chartPlanes.Location = new System.Drawing.Point(12, 12);
            this.chartPlanes.Name = "chartPlanes";
            this.chartPlanes.Size = new System.Drawing.Size(400, 400);
            this.chartPlanes.TabIndex = 0;
            this.chartPlanes.Text = "chartPlanes";
            // 
            // chartFlights
            // 
            this.chartFlights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ChartArea chartArea2 = new ChartArea();
            this.chartFlights.ChartAreas.Add(chartArea2);
            this.chartFlights.Location = new System.Drawing.Point(420, 12);
            this.chartFlights.Name = "chartFlights";
            this.chartFlights.Size = new System.Drawing.Size(400, 400);
            this.chartFlights.TabIndex = 1;
            this.chartFlights.Text = "chartFlights";
            // 
            // labelTopCity
            // 
            this.labelTopCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopCity.AutoSize = true;
            this.labelTopCity.Location = new System.Drawing.Point(12, 420);
            this.labelTopCity.Name = "labelTopCity";
            this.labelTopCity.Size = new System.Drawing.Size(147, 13);
            this.labelTopCity.TabIndex = 2;
            this.labelTopCity.Text = "Ciudad con más vuelos: Ninguna";
            // 
            // FlightStatisticsForm
            // 
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.labelTopCity);
            this.Controls.Add(this.chartFlights);
            this.Controls.Add(this.chartPlanes);
            this.Name = "FlightStatisticsForm";
            this.Text = "Estadísticas de Vuelos";
            ((System.ComponentModel.ISupportInitialize)(this.chartPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlanes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlights;
        private System.Windows.Forms.Label labelTopCity;
    }
}
