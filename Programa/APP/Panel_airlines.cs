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
        airlineComponent PanelViewAP;

        /// <summary>
        /// Contructor de la clase
        /// </summary>
        public Panel_airlines()
        {
            InitializeComponent();
            conexion = new Conexion();
            PanelAddArlines = new Dialog_addAirlines();
            PanelAddPlanes = new Dialog_addPlanes();
            PanelViewAP = new airlineComponent();
        }
        /// <summary>
        /// Carga los datos al panel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_airlines_Load(object sender, EventArgs e)
        {
            loadFormScroll(PanelViewAP);
            btn_SaveAirline.Visible = false;
            btn_SavePlane.Visible = false;
            LoadNameAirlines();
            LoadNameBrands();
        }
        /// <summary>
        /// Guarda las aerolíneas 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveAirline_Click(object sender, EventArgs e)
        {
            string name = PanelAddArlines.text_nameAirline.Text;
            string motto = PanelAddArlines.text_motto.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(motto))
            {
                MessageBox.Show("Todos los campos son obligatorios y deben tener valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            int result = conexion.SaveAirlines(name, motto);

            if (result ==  1)
            {
                LoadNameAirlines();
                PanelAddArlines.text_nameAirline.Text = "";
                PanelAddArlines.text_motto.Text = "";
                PanelViewAP.LoadData();

            } 
            
        }
        /// <summary>
        /// Guarda los aviones 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SavePlane_Click(object sender, EventArgs e)
        {
            string airline = PanelAddPlanes.comboBox_Arlines.Text;
            string brand = PanelAddPlanes.comboBox_brand.Text;
            string number = PanelAddPlanes.text_resNumber.Text;
            int capacity = (int)PanelAddPlanes.numeric_capacity.Value;

            if (string.IsNullOrWhiteSpace(airline) || string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(number) || capacity <= 0)
            {
                MessageBox.Show("Todos los campos son obligatorios y deben tener valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtén los IDs correspondientes de las aerolíneas y marcas
            int idAirline = conexion.GetAirlineIdByName(airline);
            int idBrand = conexion.GetBrandIdByName(brand);

            if (idAirline == 0 || idBrand == 0)
            {
                MessageBox.Show("Aerolínea o marca no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = conexion.SavePlane(number, idAirline, idBrand, capacity);

            if (result == 1)
            {
                MessageBox.Show("Avión guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNameAirlines();
                LoadNameBrands();
                PanelAddPlanes.text_resNumber.Text = "";
                PanelAddPlanes.numeric_capacity.Value = 1;
                PanelViewAP.LoadData(); // Actualiza el componente
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddAirline_Click(object sender, EventArgs e)
        {
            ShowButtons(false, true, true, false);

            loadForm(PanelAddArlines);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddPlane_Click(object sender, EventArgs e)
        {
            ShowButtons(true, false, false, true);

            loadForm(PanelAddPlanes);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="AddAirline"></param>
        /// <param name="SaveAirline"></param>
        /// <param name="AddPlane"></param>
        /// <param name="SavePlane"></param>
        private void ShowButtons(bool AddAirline, bool SaveAirline, bool AddPlane, bool SavePlane)
        {
            btn_AddAirline.Visible = AddAirline;
            btn_SaveAirline.Visible = SaveAirline;
            btn_AddPlane.Visible = AddPlane;
            btn_SavePlane.Visible = SavePlane;
        }

        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Form"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Form"></param>
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
