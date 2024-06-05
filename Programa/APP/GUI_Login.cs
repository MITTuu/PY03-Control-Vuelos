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
    public partial class GUI_Login : Form
    {
        private Conexion cnx;
        private DataRow usuario;

        public GUI_Login()
        {
            InitializeComponent(); 
            cnx = new Conexion();
        }

        private void tb_email_Click(object sender, EventArgs e)
        {
            if (tb_email.Text == "Ingresa tu correo")
            {
                tb_email.Text = "";
            }
        }

        private void tb_password_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == "Ingresa tu contraseña")
            {
                tb_password.Text = "";
                tb_password.PasswordChar = '*';
            }
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            if (tb_email.Text == "")
            {
                tb_email.Text = "Ingresa tu correo";
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.PasswordChar = '\0';
                tb_password.Text = "Ingresa tu contraseña";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_email.Text == "" || tb_email.Text == "Ingresa tu correo")
            {
                MessageBox.Show("Debes ingresar tu correo electrónico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tb_password.Text == "" || tb_password.Text == "Ingresa tu contraseña")
            {
                MessageBox.Show("Debes ingresar tu contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string correo = tb_email.Text;
            string contrasena = tb_password.Text;

            usuario = cnx.GetUserByEmailAndPassword(correo, contrasena);

            if (usuario == null)
            {
                MessageBox.Show("Error al obtener la información del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idRole = (int)usuario["idRole"];

            this.Hide();

            GUI_Main secondaryForm = new GUI_Main(this, idRole);

            secondaryForm.Show();

        }

        private void GUI_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
