using PY03___Control_de_vuelos.Programa.FormsViewsData;
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

            PlanesByCityForm f = new PlanesByCityForm();
            f.Show();
        }
    }
}
