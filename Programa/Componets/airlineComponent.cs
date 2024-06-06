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
        /// <summary>
        /// Carga y contruye el componente
        /// </summary>
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
                Panel currentAirlinePanel = null;
                FlowLayoutPanel currentPlanesPanel = null;

                foreach (DataRow row in dataTable.Rows)
                {
                    int airlineId = Convert.ToInt32(row["idAirline"]);
                    string airlineName = row["AirlineName"].ToString();
                    string motto = row["motto"].ToString();
                    string planeID = row["PlaneID"].ToString();
                    string brandName = row["BrandName"].ToString();
                    int capacity = row["capacity"] != DBNull.Value ? Convert.ToInt32(row["capacity"]) : 0;

                    // Crear un encabezado para la aerolínea si ha cambiado
                    if (currentAirline != airlineName)
                    {
                        currentAirline = airlineName;

                        currentAirlinePanel = new Panel
                        {
                            AutoSize = true,
                            BorderStyle = BorderStyle.FixedSingle,
                            Margin = new Padding(10),
                            Padding = new Padding(5)
                            //Width = 50
                            //MaximumSize = new Size(450) // Ajustar el tamaño máximo del panel
                        };

                        // Usar TableLayoutPanel para organizar mejor los controles
                        TableLayoutPanel tableLayout = new TableLayoutPanel
                        {
                            ColumnCount = 2,
                            RowCount = 3,
                            AutoSize = true,
                            Dock = DockStyle.Fill
                        };
                        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
                        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                        tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                        Label airlineLabel = new Label
                        {
                            Text = airlineName,
                            Font = new Font("Arial", 14, FontStyle.Bold),
                            AutoSize = true,
                            Margin = new Padding(10)
                        };
                        tableLayout.Controls.Add(airlineLabel, 0, 0);
                        //tableLayout.SetColumnSpan(airlineLabel, 2);

                        Label mottoLabel = new Label
                        {
                            Text = motto,
                            Font = new Font("Arial", 9, FontStyle.Regular),
                            AutoSize = true,
                            Margin = new Padding(5)
                        };
                        tableLayout.Controls.Add(mottoLabel, 0, 1);

                        Button editAirlineButton = new Button
                        {
                            Text = "Modificar",
                            Tag = airlineId // Almacenar el idAirline en la propiedad Tag
                        };
                        editAirlineButton.Click += EditAirlineButton_Click;
                        tableLayout.Controls.Add(editAirlineButton, 1, 0);

                        // Añadir el subtítulo "Aviones"
                        Label planesLabel = new Label
                        {
                            Text = "Aviones",
                            Font = new Font("Arial", 12, FontStyle.Italic),
                            AutoSize = true,
                            Margin = new Padding(10)
                        };
                        tableLayout.Controls.Add(planesLabel, 0, 2);
                        //tableLayout.SetColumnSpan(planesLabel, 2);

                        currentPlanesPanel = new FlowLayoutPanel
                        {
                            AutoSize = true,
                            FlowDirection = FlowDirection.TopDown,
                            WrapContents = false,
                            Margin = new Padding(5)
                        };
                        tableLayout.Controls.Add(currentPlanesPanel, 0, 3);
                        //tableLayout.SetColumnSpan(currentPlanesPanel, 2);

                        currentAirlinePanel.Controls.Add(tableLayout);
                        flowLayoutPanel.Controls.Add(currentAirlinePanel);
                    }

                    if (!string.IsNullOrEmpty(planeID))
                    {
                        // Crear y añadir los controles para mostrar cada avión
                        Panel planePanel = new Panel
                        {
                            Size = new Size(430, 80),
                            BorderStyle = BorderStyle.FixedSingle,
                            Margin = new Padding(5)
                        };

                        Label planeInfo = new Label
                        {
                            Text = $"{planeID} – {brandName}\nCapacity: {capacity} passengers",
                            AutoSize = true,
                            Location = new Point(10, 10)
                        };

                        Button editPlaneButton = new Button
                        {
                            Text = "Modificar",
                            Location = new Point(330, 10),
                            Tag = planeID // Almacenar el idPlane en la propiedad Tag
                        };
                        editPlaneButton.Click += EditPlaneButton_Click;
                        planePanel.Controls.Add(editPlaneButton);

                        planePanel.Controls.Add(planeInfo);
                        currentPlanesPanel.Controls.Add(planePanel);
                    }
                }
            }
        }
        /// <summary>
        /// Boton para editar las aerolineas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditAirlineButton_Click(object sender, EventArgs e)
        {
            Button editButton = sender as Button;
            int idAirline = (int)editButton.Tag;

            // Mostrar un formulario de edición (puede ser un nuevo formulario o un diálogo)
            // Aquí puedes crear un nuevo formulario de edición y pasarle los datos de la aerolínea para editar
            using (var form = new Dialog_editAirline(idAirline))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Recargar los datos después de editar
                }
            }
        }

        /// <summary>
        /// Boton para editar los aviones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditPlaneButton_Click(object sender, EventArgs e)
        {
            Button editButton = sender as Button;
            string planeId = editButton.Tag.ToString();

            // Mostrar un formulario de edición (puede ser un nuevo formulario o un diálogo)
            // Aquí puedes crear un nuevo formulario de edición y pasarle los datos del avión para editar
            using (var form = new Dialog_editPlane(planeId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Recargar los datos después de editar
                }
            }
        }

    }
}
