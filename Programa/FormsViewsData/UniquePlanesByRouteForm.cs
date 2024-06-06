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
                Console.WriteLine("No se obtuvieron datos de GetUniquePlanesByRoute o la tabla está vacía.");
            }
        }

        private void InitializeComponent()
        {
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(776, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // UniquePlanesByRouteForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Name = "UniquePlanesByRouteForm";
            this.Text = "Cantidad de Aviones Diferentes por Ruta";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
