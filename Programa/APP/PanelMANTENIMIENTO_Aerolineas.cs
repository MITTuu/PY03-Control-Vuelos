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
    public partial class PanelMANTENIMIENTO_Aerolineas : Form
    {

        // Muestra los detalles en un MessageBox
        private Conexion cnx;

        private int idFlight;
        private string airline;
        private string registrationNumber;
        private int idPilot;
        private string codeDepartureCity;
        private string codeArrivalCity;
        private DateTime departureDate;
        private DateTime arrivalDate;




        public PanelMANTENIMIENTO_Aerolineas(int idFlight, string airline, string registrationNumber, int idPilot, string codeDepartureCity, string codeArrivalCity, DateTime departureDate, DateTime arrivalDate)
        {
            InitializeComponent();
            cnx = new Conexion();
            this.idFlight = idFlight;
            this.airline = airline;
            this.registrationNumber = registrationNumber;
            this.idPilot = idPilot;
            this.codeDepartureCity = codeDepartureCity;
            this.codeArrivalCity = codeArrivalCity;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
        }

        private void PanelMANTENIMIENTO_Aerolineas_Load(object sender, EventArgs e)
        {
            int idAirline = int.Parse(airline.Split(';')[0]);

            setData();

            cargarAviones(idAirline);
            cargarPilotos(idAirline);
            cargarCiudades();
        }

        private void setData()
        {
            label_info.Text = "Completa el siguiente formulario para actualizar el vuelo n° " + idFlight.ToString() + " de la aerolínea " + airline.Split(';')[1];

            string DepartureDate = departureDate.ToString("yyyy-MM-dd");
            string DepartureTime = departureDate.ToString("HH:mm:ss");

            string ArrivalDate = arrivalDate.ToString("yyyy-MM-dd");
            string ArrivalTime = arrivalDate.ToString("HH:mm:ss");

            dtp_fechaSalida.Value = DateTime.Parse(DepartureDate);
            dtp_horaSalida.Value = DateTime.Parse(DepartureTime);

            dtp_fechaLlegada.Value = DateTime.Parse(ArrivalDate);
            dtp_horaLlegada.Value = DateTime.Parse(ArrivalTime);
        }

        private void cargarAviones(int idAerolinea)
        {
            DataTable dataTableAviones = cnx.GetPlaneByIdAirline(idAerolinea);

            cb_aviones.Items.Clear();
            cb_aviones.Items.Add("Seleccione un avión");

            foreach (DataRow row in dataTableAviones.Rows)
            {
                cb_aviones.Items.Add("(" + row["registrationNumber"].ToString() + ")" + " " + row["name"].ToString() + "; Capacidad: " + row["capacity"].ToString());
            }

            for (int i = 0; i < cb_aviones.Items.Count; i++)
            {
                if (cb_aviones.Items[i].ToString().Contains(registrationNumber))
                {
                    cb_aviones.SelectedIndex = i;
                    break;
                }
            }
        }

        private void cargarPilotos(int idAerolinea)
        {
            DataTable dataTablePilotos = cnx.GetPilotsByIdAirline(idAerolinea);

            cb_pilotos.Items.Clear();
            cb_pilotos.Items.Add("Seleccione un piloto");

            foreach (DataRow row in dataTablePilotos.Rows)
            {
                cb_pilotos.Items.Add(row["idPilot"].ToString() + "; " + row["name"].ToString() + " " + row["lastname1"].ToString() + " " + row["lastname2"].ToString());
            }

            for (int i = 0; i < cb_pilotos.Items.Count; i++)
            {
                if (cb_pilotos.Items[i].ToString().StartsWith(idPilot.ToString() + ";"))
                {
                    cb_pilotos.SelectedIndex = i;
                    break;
                }
            }
        }

        private void cargarCiudades()
        {
            DataTable dataTableCiudades = cnx.GetCities();

            cb_ciudadSalida.Items.Clear();
            cb_ciudadSalida.Items.Add("Seleccione una ciudad de salida");

            cb_ciudadLlegada.Items.Clear();
            cb_ciudadLlegada.Items.Add("Seleccione una ciudad de llegada");

            foreach (DataRow row in dataTableCiudades.Rows)
            {
                cb_ciudadSalida.Items.Add(row["name"].ToString() + " (" + row["cityCode"].ToString() + ")");
                cb_ciudadLlegada.Items.Add(row["name"].ToString() + " (" + row["cityCode"].ToString() + ")");
            }

            for (int i = 0; i < cb_ciudadSalida.Items.Count; i++)
            {
                if (cb_ciudadSalida.Items[i].ToString().Contains("(" + codeDepartureCity + ")"))
                {
                    cb_ciudadSalida.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cb_ciudadLlegada.Items.Count; i++)
            {
                if (cb_ciudadLlegada.Items[i].ToString().Contains("(" + codeArrivalCity + ")"))
                {
                    cb_ciudadLlegada.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (cb_aviones.SelectedIndex != 0 &&
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

                    bool updated = cnx.UpdateFlight(idFlight, registrationNumber, idPiloto, fechaHoraSalida, fechaHoraLlegada, cityCodeSalida, cityCodeLlegada, 0);

                    if (updated)
                    {
                        MessageBox.Show("Vuelo actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Deseas cancelar el vuelo?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool cancelled = cnx.CancelFlightById(idFlight);

                if (cancelled)
                {
                    MessageBox.Show("Vuelo cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Error al cancelar el vuelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }
    }
}
