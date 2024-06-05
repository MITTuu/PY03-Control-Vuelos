using PY03___Control_de_vuelos.Programa.APP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PY03___Control_de_vuelos
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Crear un objeto de GUI_Main y pasar directamente el idRol 1
            GUI_Main mainForm = new GUI_Main(null, 1);

            // Mostrar el formulario GUI_Main
            Application.Run(mainForm);
        }
    }
}
