﻿using PY03___Control_de_vuelos.Programa.FormsViewsData;
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
            1 Vuelos activos utilizando un selector de fechas
            2 Vuelos por pasajero
            3 Aviones por aerolínea
            4 Cantidad de Aviones que volaron por ciudad
            5 Cantidad de aviones diferentes que volaron de una ciudad a otra.
            6 Cantidad de aviones, cantidad de vuelos, nombre de ciudad a la que han viajado más veces
            7 Vuelos cancelados
            8 Información de Aerolínea, vuelo, origen, destino, horas de salida y llegada.
            9 Pasajeros confirmados por vuelo
            10 Vuelos por avion
            11 Total de horas de vuelo por aerolinea
            12
            */

            int indice = cb_opciones.SelectedIndex;
            
            switch (indice)
            {
                case 1:
                    panel_cuerpo.Controls.Clear();
                    panelINF_VuelosActivos formVuelosActivos = new panelINF_VuelosActivos();
                    FormManager.OpenFormInPanel(formVuelosActivos, panel_cuerpo);
                    break;
                case 2:
                    panel_cuerpo.Controls.Clear();
                    Panel_PassengerFlights formPassengerFlights = new Panel_PassengerFlights();
                    FormManager.OpenFormInPanel(formPassengerFlights, panel_cuerpo);
                    break;
                case 3:
                    panel_cuerpo.Controls.Clear();
                    AirlineChartForm airlineChartForm = new AirlineChartForm();
                    FormManager.OpenFormInPanel(airlineChartForm, panel_cuerpo);
                    break;
                case 4:
                    panel_cuerpo.Controls.Clear();
                    PlanesByCityForm planesByCityForm = new PlanesByCityForm();
                    FormManager.OpenFormInPanel(planesByCityForm, panel_cuerpo);
                    break;
                case 5:
                    panel_cuerpo.Controls.Clear();
                    UniquePlanesByRouteForm uniquePlanesByRouteForm = new UniquePlanesByRouteForm();
                    FormManager.OpenFormInPanel(uniquePlanesByRouteForm, panel_cuerpo);
                    break;
                case 6:
                    panel_cuerpo.Controls.Clear();
                    FlightStatisticsForm flightStatisticsForm = new FlightStatisticsForm(); 
                    FormManager.OpenFormInPanel(flightStatisticsForm, panel_cuerpo);
                    break;
                case 7:
                    panel_cuerpo.Controls.Clear();
                    panelINF_VuelosCancelados formVuelosCancelados = new panelINF_VuelosCancelados();
                    FormManager.OpenFormInPanel(formVuelosCancelados, panel_cuerpo);
                    break;
                case 8:
                    panel_cuerpo.Controls.Clear();
                    panelINF_Aerolineas formAerolineas = new panelINF_Aerolineas();
                    FormManager.OpenFormInPanel(formAerolineas, panel_cuerpo);
                    break;
                case 9:
                    panel_cuerpo.Controls.Clear();
                    Panel_FlightPassengers formFlightPassengers = new Panel_FlightPassengers();
                    FormManager.OpenFormInPanel(formFlightPassengers, panel_cuerpo);
                    break;
                case 10:
                    panel_cuerpo.Controls.Clear();
                    Panel_PlaneFlights formPlaneFlights = new Panel_PlaneFlights();
                    FormManager.OpenFormInPanel(formPlaneFlights, panel_cuerpo);
                    break;
                case 11:
                    panel_cuerpo.Controls.Clear();
                    Panel_FlightHours formFlightHours = new Panel_FlightHours();
                    FormManager.OpenFormInPanel(formFlightHours, panel_cuerpo);
                    break;
                case 12:
                    panel_cuerpo.Controls.Clear();
                    PanelINF_CntVuelosAvion formCntVuelosAvion = new PanelINF_CntVuelosAvion();
                    FormManager.OpenFormInPanel(formCntVuelosAvion, panel_cuerpo);
                    break;
                default:
                    panel_cuerpo.Controls.Clear();
                    break;
            }
        }
    }
}
