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
        public GUI_Login()
        {
            InitializeComponent(); 
            cnx = new Conexion();
        }

        private void GUI_Login_Load(object sender, EventArgs e)
        {

        }

    }
}
