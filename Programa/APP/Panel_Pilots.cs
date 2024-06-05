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
    public partial class Panel_Pilots : Form
    {
        private Conexion cnx;
        private DataTable dataTableAerolineas;
        private DataRow dataRowAerolinea;
        public Panel_Pilots()
        {
            InitializeComponent();
            cnx = new Conexion();
            dataTableAerolineas = new DataTable();
            cb_aerolineas.SelectedIndex = 0;
        }

        private void Panel_Pilots_Load(object sender, EventArgs e)
        {
            cargarAerolineas();
        }

        private void tb_nombre_Click(object sender, EventArgs e)
        {
            if (tb_nombre.Text == "Ingrese el nombre")
            {
                tb_nombre.Text = "";
            }
        }

        private void tb_nombre_Leave(object sender, EventArgs e)
        {
            if (tb_nombre.Text == "")
            {
                tb_nombre.Text = "Ingrese el nombre";
            }
        }

        private void tb_apellido1_Click(object sender, EventArgs e)
        {
            if (tb_apellido1.Text == "Ingrese el primer apellido")
            {
                tb_apellido1.Text = "";
            }
        }

        private void tb_apellido1_Leave(object sender, EventArgs e)
        {
            if (tb_apellido1.Text == "")
            {
                tb_apellido1.Text = "Ingrese el primer apellido";
            }
        }

        private void tb_apellido2_Click(object sender, EventArgs e)
        {
            if (tb_apellido2.Text == "Ingrese el segundo apellido")
            {
                tb_apellido2.Text = "";
            }
        }

        private void tb_apellido2_Leave(object sender, EventArgs e)
        {
            if (tb_apellido2.Text == "")
            {
                tb_apellido2.Text = "Ingrese el segundo apellido";
            }
        }

        private void tb_correo_Click(object sender, EventArgs e)
        {
            if (tb_correo.Text == "Ingrese el correo electróico")
            {
                tb_correo.Text = "";
            }
        }

        private void tb_correo_Leave(object sender, EventArgs e)
        {
            if (tb_correo.Text == "")
            {
                tb_correo.Text = "Ingrese el correo electróico";
            }
        }

        private void tb_telefono_Click(object sender, EventArgs e)
        {
            if (tb_telefono.Text == "Ingrese el número teléfonico")
            {
                tb_telefono.Text = "";
            }
        }

        private void tb_telefono_Leave(object sender, EventArgs e)
        {
            if (tb_telefono.Text == "Ingrese el número teléfonico")
            {
                tb_telefono.Text = "Ingrese el número teléfonico";
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

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            string nombre = tb_nombre.Text;
            string apellido1 = tb_apellido1.Text;
            string apellido2 = tb_apellido2.Text;
            string correo = tb_correo.Text;
            string telefono = tb_telefono.Text;
            int idAirline = cb_aerolineas.SelectedIndex;

            if (nombre == "Ingrese el nombre" || nombre == "" ||
                apellido1 == "Ingrese el primer apellido" || apellido1 == "" ||
                apellido2 == "Ingrese el segundo apellido" || apellido2 == "" ||
                correo == "Ingrese el correo electróico" || correo == "" ||
                telefono == "Ingrese el número teléfonico" || telefono == "" ||
                idAirline == 0)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(tb_correo.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico con una terminación válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPhoneNumber(tb_telefono.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de teléfono válido (8 dígitos sin espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool insert = cnx.InsertPilot(nombre, apellido1, apellido2, correo, telefono, idAirline);

            if (insert)
            {
                MessageBox.Show("Piloto registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                this.Close();  
            }
            else
            {
                MessageBox.Show("Error al registrar el piloto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private bool IsValidEmail(string email)
        {
            if (email.EndsWith("@gmail.com") ||
                email.EndsWith("@hotmail.com") ||
                email.EndsWith("@otrodominio.com"))
            {
                return true;
            }

            return false;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 8 && phoneNumber.All(char.IsDigit);
        }

    }
}
