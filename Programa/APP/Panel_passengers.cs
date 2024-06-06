using PY03___Control_de_vuelos.Programa.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PY03___Control_de_vuelos.Programa.APP
{
    public partial class Panel_passengers : Form
    {
        public Panel_passengers()
        {
            InitializeComponent();
            LoadCitiesIntoComboBoxes();
            initializePassengersDataGridView();
        }

        /// <summary>
        /// Carga las cuidades de la BD en los comboBox para seleccionar el origen y el destino
        /// </summary>
        private void LoadCitiesIntoComboBoxes()
        {

            DataTable citiesTable = Conexion.GetAllCities();
            if (citiesTable != null)
            {
                for (int i = 0; i < citiesTable.Rows.Count; i++)
                {
                    string cityCode = citiesTable.Rows[i]["cityCode"].ToString();
                    string cityName = citiesTable.Rows[i]["name"].ToString();
                    string text = $"{cityName} ({cityCode})";

                    cbOrigin.Items.Add(text);
                    cbDestination.Items.Add(text);
                }
            }
        }

        /// <summary>
        /// Carga los vuelos disponibles según los filtros seleccionados de fecha y cuidades en la interfaz
        /// </summary>
        private void LoadFlights()
        {
            DateTime selectedDate = dtpDate.Value;

            string selectedOrigin = cbOrigin.Text;
            string selectedDestination = cbDestination.Text;

            if (selectedOrigin == "" || selectedDestination == "") return;

            selectedOrigin = selectedOrigin.Split('(')[1].TrimEnd(')');
            selectedDestination = selectedDestination.Split('(')[1].TrimEnd(')');

            Console.WriteLine(selectedDate.ToString() + " - " + selectedOrigin + " - " + selectedDestination);

            DataTable dataTable = Conexion.GetFlights(selectedDate, selectedOrigin, selectedDestination);
            if (dataTable != null)
            {
                dgvFlights.DataSource = dataTable;
            }
        }

        /// <summary>
        /// Cargar la información de los pasajeros en los campos para rellenar y bloquea los campos.
        /// En caso de no poder, se habilitan los campos para la inserción de la nueva info.
        /// </summary>
        private void LoadPassengerInfo()
        {
            string passportNumber = tbPassport.Text;
            DataRow dataRow = Conexion.GetPassengerByPassport(passportNumber);

            if (dataRow == null)
            {
                MessageBox.Show("No hay coincidencias en la base de datos, por favor agregue manualmente la información del nuevo pasajero", "Sin coincidencias", MessageBoxButtons.OK);

                tbName.Text = "";
                tbLastname1.Text = "";
                tbLastname2.Text = "";
                tbEmail.Text = "";
                tbPhoneNumber.Text = "";

                tbName.ReadOnly = false;
                tbLastname1.ReadOnly = false;
                tbLastname2.ReadOnly = false;
                tbEmail.ReadOnly = false;
                tbPhoneNumber.ReadOnly = false;

                btnAddPassenger.Text = "Registrar y Añadir Pasajero";
            }
            else
            {
                string nombre = dataRow["Nombre"].ToString();
                string apellido1 = dataRow["Apellido 1"].ToString();
                string apellido2 = dataRow["Apellido 2"].ToString();
                string email = dataRow["email"].ToString();
                string telefono = dataRow["Telefono"].ToString();

                tbName.Text = nombre;
                tbLastname1.Text = apellido1;
                tbLastname2.Text = apellido2;
                tbEmail.Text = email;
                tbPhoneNumber.Text = telefono;

                tbName.ReadOnly = true;
                tbLastname1.ReadOnly = true;
                tbLastname2.ReadOnly = true;
                tbEmail.ReadOnly = true;
                tbPhoneNumber.ReadOnly = true;

                btnAddPassenger.Text = "Añadir Pasajero";
            }
        }

        /// <summary>
        /// inicializa las columnas de la lista de los pasajeros
        /// </summary>
        private void initializePassengersDataGridView()
        {
            dgvPassengers.Columns.Clear();
            dgvPassengers.ColumnCount = 2;
            dgvPassengers.Columns[0].Name = "Pasaporte";
            dgvPassengers.Columns[1].Name = "Nombre";
        }

        /// <summary>
        /// Itera en la lista de pasajeros de la interfaz para verifica la existencia del numero de pasaporte
        /// </summary>
        /// <param name="passportNumber">numero de pasaporte a buscar</param>
        /// <returns><c>true</c> si está en la lista, <c>false</c> de lo contrario</returns>
        private bool PassportAlreadyInList(string passportNumber)
        {
            for (int i = 0; i < dgvPassengers.RowCount; i++)
            {
                string listPassportNumber = dgvPassengers.Rows[i].Cells["Pasaporte"].Value.ToString();

                if (passportNumber.ToUpper() == listPassportNumber.ToUpper()) return true;
            }

            return false;
        }

        /// <summary>
        /// Añade el pasajero a la lista de la interfaz, 
        /// </summary>
        private void AddPassengerToList()
        {
            string passportNumber = tbPassport.Text.ToUpper();
            string name = tbName.Text + " " + tbLastname1.Text + " " + tbLastname2.Text;

            dgvPassengers.Rows.Add(passportNumber, name);
        }

        /// <summary>
        /// Verifica si el passaporte ingresado en la interfaz existe en la base de datos
        /// </summary>
        /// <returns><c>true</c> si está en la BD, <c>fasle</c> de lo contrario</returns>
        private bool PassportIsRegistrated()
        {
            Console.WriteLine("PassportIsRegistrated()");
            string passportNumber = tbPassport.Text;
            DataRow dataRow = Conexion.GetPassengerByPassport(passportNumber);

            if (dataRow == null) return false;
            return true;
        }

        /// <summary>
        /// Valida que los campos de información de pasajero tengan información
        /// </summary>
        /// <returns></returns>
        private bool ValidatePassengerInfo(string passport, string name, string lastName1, string lastName2, string email, string phoneNumber)
        {
            bool valid = true;

            if (passport == "") valid = false;
            if (name == "") valid = false;
            if (lastName1 == "") valid = false;
            if (lastName2 == "") valid = false;
            if (email == "") valid = false;
            if (phoneNumber == "") valid = false;
            
            if (!valid)
            {
                MessageBox.Show("Debe rellenar todos los campos de información para agregar un pasajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Registra un nuevo pasajero en la base de datos
        /// </summary>
        /// <returns>el id del nuevo pasajero</returns>
        private int RegisterPassengerIntoBD()
        {
            string passport = tbPassport.Text;
            string name = tbName.Text;
            string lastName1 = tbLastname1.Text;
            string lastName2= tbLastname2.Text;
            string email = tbEmail.Text;
            string phoneNumber = tbPhoneNumber.Text;

            if (!ValidatePassengerInfo(passport, name, lastName1, lastName2, email, phoneNumber)) return -1;

            int id = Conexion.InsertPassenger(passport, name, lastName1, lastName2, email, phoneNumber);

            return id;
        }

        /// <summary>
        /// Validates and returns the selected flight ID
        /// </summary>
        /// <returns>the selected flight ID from the DataGridView</returns>
        private int GetValidatedFlightId()
        {
            int passengersToRegister = dgvPassengers.RowCount;

            // one flight selected validation
            if (dgvFlights.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleecionar vuelo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            
            int idFlight = (int)dgvFlights.SelectedRows[0].Cells["Num"].Value;
            int availableSeats = Conexion.GetAvailableSeats(idFlight);

            // check if there is enough space left in the plane
            if (availableSeats < passengersToRegister)
            {
                MessageBox.Show("No hay sufucientes espacios para registrar todos los pasajeros\n" +
                    $"Se quieren registrar {passengersToRegister} pasajeros, pero solo hay {availableSeats} asientos disponibles",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            return idFlight;
        }

        /// <summary>
        /// Takes all the passengers from the DataGridView an associates them with the selected flight
        /// </summary>
        /// <returns></returns>
        private int RegisterPassengerListInFlight()
        {
            if (dgvPassengers.Rows.Count == 0) return -1;

            int idFlight = GetValidatedFlightId();
            if (idFlight == -1) return -1;

            for (int i = 0; i < dgvPassengers.RowCount; i++)
            {
                string passengerPassport = dgvPassengers.Rows[i].Cells["Pasaporte"].Value.ToString();
                Conexion.RegisterPassengerInFlightByPassport(idFlight, passengerPassport);
            }


            return 1;
        }

        /// <summary>
        /// Bloquea la escritura de datos no decimales positivos en un TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckOnlyDecimalKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // para aceptar solo un punto decimal!
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Arregla un numero escrito en un TextBox para no sobrepasar <c>max</c>
        /// y no tener más de 2 decimales
        /// </summary>
        /// <param name="tb">Textbox que ajustar</param>
        /// <param name="max">valor maximo que puede tener el número</param>
        /// <param name="decimalDigits">cantidad de digitos decimales</param>
        private void FixDecimalTextBox(System.Windows.Forms.TextBox tb, double max, int decimalDigits)
        {
            Double.TryParse(tb.Text, out Double value);
            if (value > max) tb.Text = max.ToString();
            else
            {
                tb.Text = value.ToString("0." + new string('#', decimalDigits));
            }
        }

        // Event Handlers


        private void cbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFlights();
        }

        private void btnConfirmPassport_Click(object sender, EventArgs e)
        {
            LoadPassengerInfo();
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            Console.WriteLine('0');
            // register the passenger if it isn't already created in the DB
            if (!PassportIsRegistrated())
            {
                Console.WriteLine('1');
                if (RegisterPassengerIntoBD() == -1) return;
            }

            Console.WriteLine('2');

            // now that we are sure that it exist in the database, we load the information
            LoadPassengerInfo();

            // we check for the existance in the list
            if (PassportAlreadyInList(tbPassport.Text))
            {
                MessageBox.Show("El pasajero ya está en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // finally, we add the passanger to the list of passengers of the flight to later add to the DB
            AddPassengerToList();
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckOnlyDecimalKeyPress(sender, e);
        }

        private void tbPhoneNumber_Leave(object sender, EventArgs e)
        {
            FixDecimalTextBox(sender as System.Windows.Forms.TextBox, 999999999999999, 0);
        }

        private void cbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFlights();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadFlights();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RegisterPassengerListInFlight() != -1)
            {
                MessageBox.Show("Los pasajeros han sido registrados al vuelo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPassengers.Rows.Clear();
            }
        }

        private void dgvPassengers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvPassengers.Rows.RemoveAt(e.RowIndex);
        }
    }
}
