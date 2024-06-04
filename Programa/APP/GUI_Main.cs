using PY03___Control_de_vuelos.Programa.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PY03___Control_de_vuelos.Programa.APP
{
    public partial class GUI_Main : Form
    {
        bool sidebarExpand;
        private System.Windows.Forms.Button ultimoBoton = null;
        private Conexion conexion;
        private System.Windows.Forms.ToolTip toolTip1;
        private bool cerrar = false;


        public GUI_Main()
        {
            InitializeComponent();
            conexion = new Conexion();
            sidebarExpand = true;
            InicializarToolTip();
        }

        /// <summary>
        /// 
        /// </summary>
        private void InicializarToolTip()
        {
            toolTip1 = new System.Windows.Forms.ToolTip();

            // Establecer los parámetros del ToolTip
            toolTip1.AutoPopDelay = 5000; // Tiempo que permanece visible el ToolTip
            toolTip1.InitialDelay = 100; // Tiempo que tarda en aparecer el ToolTip
            toolTip1.ReshowDelay = 500;   // Tiempo que tarda en volver a aparecer el ToolTip si el cursor se mueve fuera y luego vuelve a la imagen
            toolTip1.ShowAlways = true;   // Permitir que el ToolTip se muestre siempre, incluso si el control no está habilitado
        }


        /// <summary>
        /// Función para cambiar el color del botón y restaurar el color del último botón presionado
        /// </summary>
        /// <param name="botonPresionado"></param>
        private void CambiarColorBoton(System.Windows.Forms.Button botonPresionado)
        {
            if (ultimoBoton != null)
            {
                ultimoBoton.BackColor = Color.FromArgb(19, 45, 70); // Restaurar color del último botón
            }

            botonPresionado.BackColor = Color.FromArgb(1, 195, 141); // Cambiar color del botón presionado
            ultimoBoton = botonPresionado; // Actualizar el último botón presionado
        }

        /// <summary>
        /// Funcion para controlar el sidebar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // si la barra lateral está expandida, minimizar
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                    ImagenPatito.Visible = false;
                }
            }
            else
            {
                ImagenPatito.Visible = true;
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {

                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón buttonHistrial.
        /// Se ejecuta al hacer clic en el botón "Historial" y realiza acciones relacionadas.
        /// </summary>
        public void loadForm(object Form)
        {
            if (this.PanelAreaDeTrabajo.Controls.Count > 0)
                this.PanelAreaDeTrabajo.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelAreaDeTrabajo.Controls.Add(f);
            this.PanelAreaDeTrabajo.Tag = f;
            f.Show();
        }

        private void prepararCerrado(object sender, FormClosingEventArgs e)
        {
            if (this.cerrar) { Application.Exit(); }
            else
            {
                String mensaje = "¿Desea cerrar la aplicación?";
                DialogResult resultado = MessageBox.Show(mensaje, "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    this.cerrar = true;
                    Application.Exit();
                }
                else { e.Cancel = true; }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btn_flight_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(btn_flight);
            if (sidebarExpand)
            {
                btn_menu_Click(sender, e);
            }
            loadForm(new Panel_flight());
        }

        private void btn_passengers_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(btn_passengers);
            if (sidebarExpand)
            {
                btn_menu_Click(sender, e);
            }
            loadForm(new Panel_passengers());
        }

        private void btn_airlines_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(btn_airlines);
            if (sidebarExpand)
            {
                btn_menu_Click(sender, e);
            }
            loadForm(new Panel_airlines());
        }

        private void btn_viewData_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(btn_viewData);
            if (sidebarExpand)
            {
                btn_menu_Click(sender, e);
            }
            loadForm(new Panel_viewData());
        }

        private void btn_flight_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_passengers_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_airlines_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_viewData_MouseHover(object sender, EventArgs e)
        {

        }

        private void GUI_Main_Load(object sender, EventArgs e)
        {

        }
    }
}

