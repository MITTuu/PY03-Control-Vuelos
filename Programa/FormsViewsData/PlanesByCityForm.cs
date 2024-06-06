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
        /// <summary>
        /// Carga los datos de las aerolineas
        /// </summary>
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
        /// <summary>
        /// Filtrado de las cuidades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAirlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? selectedAirlineId = comboBoxAirlines.SelectedValue as int?;
            if (comboBoxAirlines.SelectedValue == DBNull.Value)
            {
                selectedAirlineId = null;
            }

            LoadChartData(selectedAirlineId);

        }
        /// <summary>
        /// Carga los datos al chart
        /// </summary>
        /// <param name="airlineId"></param>
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
                MessageBox.Show("Error: No hay datos que cargar", "Error", MessageBoxButtons.OK);
            }
        }

    }
}
