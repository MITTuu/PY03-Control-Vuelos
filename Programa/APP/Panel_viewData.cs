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
    public partial class Panel_viewData : Form
    {
        public Panel_viewData()
        {
            InitializeComponent();
            cb_opciones.SelectedIndex = 0;
        }

        private void cb_aerolineas_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Seleccione la información que desea visualizar
            Vuelos activos utilizando un selector de fechas
            Vuelos por pasajero
            Aviones por aerolínea
            Cantidad de Aviones que volaron por ciudad
            Cantidad de aviones diferentes que volaron de una ciudad a otra.
            Cantidad de aviones, cantidad de vuelos, nombre de ciudad a la que han
            viajado más veces
            Vuelos cancelados
            Información de Aerolínea, vuelo, origen, destino, horas de salida y llegada.
            Pasajeros confirmados por vuelo
            */

            int indice = cb_opciones.SelectedIndex;
            
            if (indice == 1)
            {
                panel_cuerpo.Controls.Clear();
                panelINF_VuelosActivos formVuelosActivos = new panelINF_VuelosActivos();
                FormManager.OpenFormInPanel(formVuelosActivos, panel_cuerpo);
            }
            else
            {
                panel_cuerpo.Controls.Clear();
            }
        }
    }
}
