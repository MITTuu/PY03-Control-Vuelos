using PY03___Control_de_vuelos.Programa.Modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace PY03___Control_de_vuelos.Programa.Componets
{
    public partial class Dialog_editAirline : Form
    {
        private int _idAirline;

        public Dialog_editAirline(int idAirline)
        {
            InitializeComponent();
            _idAirline = idAirline;
            LoadAirlineData();
        }

        private void LoadAirlineData()
        {
            Conexion conexion = new Conexion();
            DataTable airlineData = conexion.GetAirlineById(_idAirline);

            if (airlineData.Rows.Count > 0)
            {
                DataRow row = airlineData.Rows[0];
                text_nameAirline.Text = row["name"].ToString();
                text_motto.Text = row["motto"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontraron datos para esta aerolínea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = text_nameAirline.Text;
            string motto = text_motto.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(motto))
            {
                MessageBox.Show("Todos los campos son obligatorios y deben tener valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Conexion conexion = new Conexion();
            int rowsAffected = conexion.UpdateAirline(_idAirline, name, motto);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Aerolínea actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error al actualizar la aerolínea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
