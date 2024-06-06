using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PY03___Control_de_vuelos.Programa.Modelo;

namespace PY03___Control_de_vuelos.Programa.FormsViewsData
{
    public partial class PlanesByCityForm : Form
    {
        private Conexion conexion;

        public PlanesByCityForm()
        {
            InitializeComponent();
            conexion = new Conexion();
            LoadAirlines();
            LoadChartData(null);
        }

        private void LoadAirlines()
        {
            DataTable airlinesTable = conexion.GetAirlines();
            DataRow newRow = airlinesTable.NewRow();
            newRow["idAirline"] = DBNull.Value;
            newRow["name"] = "Todas";
            airlinesTable.Rows.InsertAt(newRow, 0);

            comboBoxAirlines.DataSource = airlinesTable;
            comboBoxAirlines.DisplayMember = "name";
            comboBoxAirlines.ValueMember = "idAirline";
        }

        private void comboBoxAirlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? selectedAirlineId = comboBoxAirlines.SelectedValue as int?;
            if (comboBoxAirlines.SelectedValue == DBNull.Value)
            {
                selectedAirlineId = null;
            }

            LoadChartData(selectedAirlineId);

        }

        private void LoadChartData(int? airlineId)
        {
            DataTable dataTable = conexion.GetPlanesByCity(airlineId);
            if (dataTable != null)
            {
     
                foreach (DataRow row in dataTable.Rows)
                {
                    string cityName = row["CityName"].ToString();
                    int planeCount = Convert.ToInt32(row["PlaneCount"]);
                   
                }

                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Cantidad de Aviones por Ciudad");

                // Limpiar las áreas de gráfico existentes
                chart1.ChartAreas.Clear();

                // Crear una nueva área de gráfico
                ChartArea chartArea = new ChartArea();
                chart1.ChartAreas.Add(chartArea);

                // Configurar el eje X
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisX.Title = "Ciudades";

                // Configurar el eje Y
                chartArea.AxisY.MajorGrid.Enabled = false;
                chartArea.AxisY.Title = "Cantidad de Aviones";

                Series series = new Series
                {
                    Name = "Planes",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Bar,
                };
                chart1.Series.Add(series);

                foreach (DataRow row in dataTable.Rows)
                {
                    string cityName = row["CityName"].ToString();
                    int planeCount = Convert.ToInt32(row["PlaneCount"]);
                    series.Points.AddXY(cityName, planeCount);
                }

                // Mostrar los valores en las etiquetas del gráfico
                series.IsValueShownAsLabel = true;

                chart1.Invalidate();
            }
            else
            {
                // Console.WriteLine("No se obtuvieron datos de GetPlanesByCity.");
            }
        }



        private void InitializeComponent()
        {
            this.comboBoxAirlines = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAirlines
            // 
            this.comboBoxAirlines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAirlines.FormattingEnabled = true;
            this.comboBoxAirlines.Location = new System.Drawing.Point(12, 12);
            this.comboBoxAirlines.Name = "comboBoxAirlines";
            this.comboBoxAirlines.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAirlines.TabIndex = 0;
            this.comboBoxAirlines.SelectedIndexChanged += new System.EventHandler(this.comboBoxAirlines_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.Location = new System.Drawing.Point(12, 50);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(776, 388);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // PlanesByCityForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboBoxAirlines);
            this.Name = "PlanesByCityForm";
            this.Text = "Cantidad de Aviones que Volaron por Ciudad";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox comboBoxAirlines;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;


    }
}
