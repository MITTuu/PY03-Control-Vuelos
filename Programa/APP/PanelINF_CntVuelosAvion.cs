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

using System;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace PY03___Control_de_vuelos.Programa.APP
{
    public partial class PanelINF_CntVuelosAvion : Form
    {
        private Conexion cnx;
        public PanelINF_CntVuelosAvion()
        {
            InitializeComponent();
            cnx = new Conexion();
        }

        private void PanelINF_CntVuelosAvion_Load(object sender, EventArgs e)
        {
            DataTable flightsByPlane = cnx.GetFlightsByPlane();

            chart1.ChartAreas[0].AxisX.Interval = 1;

            Series existingSeries = chart1.Series.FirstOrDefault(s => s.Name == "Cantidad de vuelos");

            if (existingSeries == null)
            {
                Series series = new Series("Cantidad de vuelos");
                series.ChartType = SeriesChartType.Column;
                chart1.Series.Add(series);
            }
            else
            {
                existingSeries.Points.Clear();
            }

            foreach (DataRow row in flightsByPlane.Rows)
            {
                string planeInfo = $"({row["registrationNumber"]}) {row["name"]}";
                int numberOfFlights = Convert.ToInt32(row["NumberOfFlights"]);
                chart1.Series["Cantidad de vuelos"].Points.AddXY(planeInfo, numberOfFlights);
            }
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "N0";

            chart1.Titles.Add("Cantidad de vuelos por avión");
        }

    }
}
