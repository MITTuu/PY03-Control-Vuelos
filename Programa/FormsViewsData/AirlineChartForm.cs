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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(800, 450);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // AirlineChartForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Name = "AirlineChartForm";
            this.Text = "Aviones por Aerolínea";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
