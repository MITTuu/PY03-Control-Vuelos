using PY03___Control_de_vuelos.Programa.Componets;
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
    public partial class Panel_airlines : Form
    {

        private Conexion conexion;
        Dialog_addAirlines PanelAddArlines;
        Dialog_addPlanes PanelAddPlanes;


        public Panel_airlines()
        {
            InitializeComponent();
            conexion = new Conexion();
            PanelAddArlines = new Dialog_addAirlines();
            PanelAddPlanes = new Dialog_addPlanes();
            LoadNameAirlines();
            LoadNameBrands();
        }

        private void Panel_airlines_Load(object sender, EventArgs e)
        {
            loadFormScroll(new airlineComponent());
            btn_SaveAirline.Visible = false;
            btn_SavePlane.Visible = false;
        }

        private void btn_SaveAirline_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_SavePlane_Click(object sender, EventArgs e)
        {


        }

        private void btn_AddAirline_Click(object sender, EventArgs e)
        {
            ShowButtons(false, true, true, false);

            loadForm(PanelAddArlines);
        }

        private void btn_AddPlane_Click(object sender, EventArgs e)
        {
            ShowButtons(true, false, false, true);

            loadForm(PanelAddPlanes);
        }

        private void ShowButtons(bool AddAirline, bool SaveAirline, bool AddPlane, bool SavePlane)
        {
            btn_AddAirline.Visible = AddAirline;
            btn_SaveAirline.Visible = SaveAirline;
            btn_AddPlane.Visible = AddPlane;
            btn_SavePlane.Visible = SavePlane;
        }


        private void LoadNameAirlines()
        {

            // Limpia el comboBox
            PanelAddPlanes.comboBox_Arlines.Items.Clear();

            // Obtiene los nombres de las aerolíneas
            List<string> airlines = conexion.GetNameAirlines();

           

            // Añade los nombres de las aerolíneas al comboBox
            foreach (string airline in airlines)
            {
                Console.WriteLine(airline);
                PanelAddPlanes.comboBox_Arlines.Items.Add(airline);
            }
        }

        public void LoadNameBrands()
        {
            // Limpia el comboBox
            PanelAddPlanes.comboBox_brand.Items.Clear();

            // Obtiene los nombres de las marcas
            List<string> brands = conexion.GetNameBrands();

            // Añade los nombres de las marcas al comboBox
            foreach (string brand in brands)
            {
                PanelAddPlanes.comboBox_brand.Items.Add(brand);
            }
        }


        public void loadForm(object Form)
        {
            if (this.PanelAdd.Controls.Count > 0)
                this.PanelAdd.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelAdd.Controls.Add(f);
            this.PanelAdd.Tag = f;
            f.Show();
        }

        public void loadFormScroll(object Form)
        {
            if (this.PanelComponet.Controls.Count > 0)
                this.PanelComponet.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.AutoScroll = true;
            this.PanelComponet.Controls.Add(f);
            this.PanelComponet.Tag = f;
            f.Show();
        }

    }
}
