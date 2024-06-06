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

namespace PY03___Control_de_vuelos.Programa.APP
{
    public partial class panelINF_Aerolineas : Form
    {
        private Conexion cnx;
        public panelINF_Aerolineas()
        {
            InitializeComponent();
            cnx = new Conexion();
        }

        private void panelINF_Aerolineas_Load(object sender, EventArgs e)
        {
            cb_aerolineas.SelectedIndex = 0;
            cargarAerolineas();
        }

        private void cargarAerolineas()
        {
            DataTable dataTableAerolineas = cnx.GetAirlines();

            cb_aerolineas.Items.Clear();
            cb_aerolineas.Items.Add("Seleccione una aerolínea");

            foreach (DataRow row in dataTableAerolineas.Rows)
            {
                cb_aerolineas.Items.Add(row["idAirline"] + "; " + row["name"].ToString());
            }
            cb_aerolineas.SelectedIndex = 0;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cb_aerolineas.SelectedIndex == 0)
            {
                MessageBox.Show("Debes seleccionar una aerolínea para ver su información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cb_aerolineas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
