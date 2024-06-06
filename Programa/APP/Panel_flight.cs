using PY03___Control_de_vuelos.Programa.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PY03___Control_de_vuelos.Programa.APP
{
    public partial class Panel_flight : Form
    {
        private Conexion cnx;
        private DataTable dataTableAerolineas;
        private DataRow dataRowAerolinea;
        private DataTable dataTableAviones;
        private DataRow dataRowAvion;
        private DataTable dataTablePilotos;
        private DataRow dataRowPiloto;
        private DataTable dataTableCiudades;
        private DataRow dataRowCiudad;

        public Panel_flight()
        {
            InitializeComponent();
            cnx = new Conexion();
            dataTableAerolineas = new DataTable();
            dataTableAviones = new DataTable();
            dataTablePilotos = new DataTable(); 
            dataTableCiudades = new DataTable();
        }

        private void Panel_flight_Load(object sender, EventArgs e)
        {
            cargarAerolineas();
            setIndexCB();
            setVisibilityCBFalse();
        }

        private void setIndexCB()
        {
            cb_aerolineas.SelectedIndex = 0;
            cb_aviones.SelectedIndex = 0;
            cb_pilotos.SelectedIndex = 0;
            cb_ciudadSalida.SelectedIndex = 0;
            cb_ciudadLlegada.SelectedIndex = 0;
        }

        private void setVisibilityCBFalse()
        {
            cb_aviones.Enabled = false;
            cb_pilotos.Enabled = false;
            btn_registrarPiloto.Enabled = false;
            cb_ciudadSalida.Enabled = false;
            cb_ciudadLlegada.Enabled = false;
            dtp_fechaSalida.Enabled = false;
            dtp_fechaLlegada.Enabled = false;
            dtp_horaSalida.Enabled = false;
            dtp_horaLlegada.Enabled = false;
        }

        private void setVisibilityCBTrue()
        {
            cb_aviones.Enabled = true;
            cb_pilotos.Enabled = true;
            btn_registrarPiloto.Enabled = true;
            cb_ciudadSalida.Enabled = true;
            cb_ciudadLlegada.Enabled = true;
            dtp_fechaSalida.Enabled = true;
            dtp_fechaLlegada.Enabled = true;
            dtp_horaSalida.Enabled = true;
            dtp_horaLlegada.Enabled = true;
        }

        private void cb_aerolineas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_aerolineas.SelectedIndex == 0)
            {
                setIndexCB();
                setVisibilityCBFalse();
            }

            if (cb_aerolineas.SelectedIndex != 0)
            {
                string aerolineaSeleccionada = cb_aerolineas.SelectedItem.ToString();

                DataRow[] resultado = dataTableAerolineas.Select($"name = '{aerolineaSeleccionada}'");

                if (resultado.Length > 0)
                {
                    int idAirline = (int)resultado[0]["idAirline"];

                    cargarAviones(idAirline);
                    cargarPilotos(idAirline);
                    cargarCiudades();
                    

                }
                
                setVisibilityCBTrue();
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (cb_aerolineas.SelectedIndex != 0 &&
                cb_aviones.SelectedIndex != 0 &&
                cb_pilotos.SelectedIndex != 0 &&
                cb_ciudadSalida.SelectedIndex != 0 &&
                cb_ciudadLlegada.SelectedIndex != 0)
            {
                int idPiloto = int.Parse(cb_pilotos.SelectedItem.ToString().Split(';')[0]);

                string avionItem = cb_aviones.SelectedItem.ToString();
                string registrationNumber = avionItem.Substring(avionItem.IndexOf('(') + 1, avionItem.IndexOf(')') - avionItem.IndexOf('(') - 1);

                string selectedItem = cb_ciudadSalida.SelectedItem.ToString();
                string cityCodeSalida = selectedItem.Substring(selectedItem.IndexOf('(') + 1, selectedItem.IndexOf(')') - selectedItem.IndexOf('(') - 1);

                selectedItem = cb_ciudadLlegada.SelectedItem.ToString();
                string cityCodeLlegada = selectedItem.Substring(selectedItem.IndexOf('(') + 1, selectedItem.IndexOf(')') - selectedItem.IndexOf('(') - 1);

                string fechaSalida = dtp_fechaSalida.Value.ToString("dd-MM-yyyy");
                string horaSalida = dtp_horaSalida.Value.ToString("HH:mm:ss");

                string fechaLlegada = dtp_fechaLlegada.Value.ToString("dd-MM-yyyy"); 
                string horaLlegada = dtp_horaLlegada.Value.ToString("HH:mm:ss");

                string fechaHoraSalidaString = $"{fechaSalida} {horaSalida}";
                string fechaHoraLlegadaString = $"{fechaLlegada} {horaLlegada}";

                DateTime fechaHoraSalida = DateTime.ParseExact(fechaHoraSalidaString, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                DateTime fechaHoraLlegada = DateTime.ParseExact(fechaHoraLlegadaString, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                if (cityCodeSalida == cityCodeLlegada)
                {
                    MessageBox.Show("Seleccionaste la misma ciudad de salida que llegada, por favor cambialo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fechaHoraSalida == fechaHoraLlegada)
                {
                    MessageBox.Show("La fecha de salida no puede ser igual que la fecha de llegada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fechaHoraSalida > fechaHoraLlegada)
                {
                    MessageBox.Show("La fecha de salida no puede ser mayor que la fecha de llegada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fechaHoraSalida <= DateTime.Now)
                {
                    MessageBox.Show("La fecha de salida no puede ser menor o igual que la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fechaHoraLlegada <= DateTime.Now)
                {
                    MessageBox.Show("La fecha de llegada no puede ser menor o igual que la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isPilotAvailable = cnx.isPilotAvailable(idPiloto, fechaHoraSalida, fechaHoraLlegada);

                if (isPilotAvailable)
                {
                    MessageBox.Show("El piloto seleccionado no se encuentra disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("¿Deseas confirmar el registro?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    bool insert = cnx.InsertFlight(idPiloto, fechaHoraSalida, fechaHoraLlegada, cityCodeSalida, cityCodeLlegada, 0, registrationNumber);

                    if (insert)
                    {
                        MessageBox.Show("Vuelo registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setIndexCB();
                        return;
                    } 
                    else
                    {
                        MessageBox.Show("Error al registrar el vuelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes completar el formulario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }


        private void cargarAerolineas()
        {
            dataTableAerolineas = cnx.GetAirlines();

            cb_aerolineas.Items.Clear();
            cb_aerolineas.Items.Add("Seleccione una aerolínea");

            foreach (DataRow row in dataTableAerolineas.Rows)
            {
                cb_aerolineas.Items.Add(row["name"].ToString());
            }
            cb_aerolineas.SelectedIndex = 0;
        }

        private void cargarAviones(int idAerolinea)
        {
            dataTableAviones = cnx.GetPlaneByIdAirline(idAerolinea);

            cb_aviones.Items.Clear();
            cb_aviones.Items.Add("Seleccione un avión");

            foreach (DataRow row in dataTableAviones.Rows)
            {
                cb_aviones.Items.Add("(" + row["registrationNumber"].ToString() + ")" + " " + row["name"].ToString() + "; Capacidad: " + row["capacity"].ToString());
            }
            cb_aviones.SelectedIndex = 0;
        }

        private void cargarPilotos(int idAerolinea)
        {
            dataTablePilotos = cnx.GetPilotsByIdAirline(idAerolinea);

            cb_pilotos.Items.Clear();
            cb_pilotos.Items.Add("Seleccione un piloto");

            foreach (DataRow row in dataTablePilotos.Rows)
            {
                cb_pilotos.Items.Add(row["idPilot"].ToString() + "; " + row["name"].ToString() + " " + row["lastname1"].ToString() + " " + row["lastname2"].ToString());
            }
            cb_pilotos.SelectedIndex = 0;
        }

        private void cargarCiudades()
        {
            dataTableCiudades = cnx.GetCities();

            cb_ciudadSalida.Items.Clear();
            cb_ciudadSalida.Items.Add("Seleccione una ciudad de salida");

            cb_ciudadLlegada.Items.Clear();
            cb_ciudadLlegada.Items.Add("Seleccione una ciudad de llegada");

            foreach (DataRow row in dataTableCiudades.Rows)
            {
                cb_ciudadSalida.Items.Add(row["name"].ToString() + " (" + row["cityCode"].ToString() + ")");
                cb_ciudadLlegada.Items.Add(row["name"].ToString() + " (" + row["cityCode"].ToString() + ")");
            }
            cb_ciudadSalida.SelectedIndex = 0;
            cb_ciudadLlegada.SelectedIndex = 0;
        }

        private void btn_registrarPiloto_Click(object sender, EventArgs e)
        {
            Panel_Pilots panelPilots = new Panel_Pilots();
            panelPilots.Show();
        }
    }
}
