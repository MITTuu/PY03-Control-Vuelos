using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PY03___Control_de_vuelos.Programa.Modelo;

namespace PY03___Control_de_vuelos.Programa.Componets
{
    public partial class airlineComponent : Form
    {
        private Conexion conexion;

        public airlineComponent()
        {
            InitializeComponent();
            conexion = new Conexion();
            LoadData();
        }

        public void LoadData()
        {
            flowLayoutPanel.Controls.Clear(); // Clear previous content

            DataTable dataTable = conexion.GetAirlinesWithPlanes();

            if (dataTable != null)
            {
                // Añadir el título "AEROLINEAS"
                Label titleLabel = new Label
                {
                    Text = "AEROLINEAS",
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    AutoSize = true,
                    Margin = new Padding(10, 10, 10, 20)
                };
                flowLayoutPanel.Controls.Add(titleLabel);

                string currentAirline = null;
                bool hasPlanes = false;

                foreach (DataRow row in dataTable.Rows)
                {
                    string airlineName = row["AirlineName"].ToString();
                    string planeID = row["PlaneID"].ToString();
                    string brandName = row["BrandName"].ToString();
                    int capacity = row["capacity"] != DBNull.Value ? Convert.ToInt32(row["capacity"]) : 0;

                    // Crear un encabezado para la aerolínea si ha cambiado
                    if (currentAirline != airlineName)
                    {
                        if (currentAirline != null && !hasPlanes)
                        {
                            Label noPlanesLabel = new Label
                            {
                                Text = "Sin aviones",
                                Font = new Font("Arial", 12, FontStyle.Italic),
                                AutoSize = true,
                                Margin = new Padding(20, 0, 10, 10)
                            };
                            flowLayoutPanel.Controls.Add(noPlanesLabel);
                        }

                        currentAirline = airlineName;
                        hasPlanes = false;

                        Label airlineLabel = new Label
                        {
                            Text = airlineName,
                            Font = new Font("Arial", 14, FontStyle.Bold),
                            AutoSize = true,
                            Margin = new Padding(10, 20, 10, 10)
                        };
                        flowLayoutPanel.Controls.Add(airlineLabel);

                        // Añadir el subtítulo "Aviones"
                        Label planesLabel = new Label
                        {
                            Text = "Aviones",
                            Font = new Font("Arial", 12, FontStyle.Italic),
                            AutoSize = true,
                            Margin = new Padding(10, 5, 10, 10)
                        };
                        flowLayoutPanel.Controls.Add(planesLabel);
                    }

                    if (!string.IsNullOrEmpty(planeID))
                    {
                        hasPlanes = true;

                        // Crear y añadir los controles para mostrar cada avión
                        Panel planePanel = new Panel
                        {
                            Size = new Size(500, 80),
                            BorderStyle = BorderStyle.FixedSingle,
                            Margin = new Padding(10)
                        };

                        Label planeInfo = new Label
                        {
                            Text = $"{planeID} – {brandName}\nCapacity: {capacity} passengers",
                            AutoSize = true,
                            Location = new Point(10, 10)
                        };

                        Button editButton = new Button
                        {
                            Text = "Edit",
                            Location = new Point(400, 10)
                        };

                        Button deleteButton = new Button
                        {
                            Text = "Delete",
                            Location = new Point(400, 40)
                        };

                        planePanel.Controls.Add(planeInfo);
                        planePanel.Controls.Add(editButton);
                        planePanel.Controls.Add(deleteButton);

                        flowLayoutPanel.Controls.Add(planePanel);
                    }
                }

                if (currentAirline != null && !hasPlanes)
                {
                    Label noPlanesLabel = new Label
                    {
                        Text = "Sin aviones",
                        Font = new Font("Arial", 12, FontStyle.Italic),
                        AutoSize = true,
                        Margin = new Padding(20, 0, 10, 10)
                    };
                    flowLayoutPanel.Controls.Add(noPlanesLabel);
                }
            }
        }
    }
}
