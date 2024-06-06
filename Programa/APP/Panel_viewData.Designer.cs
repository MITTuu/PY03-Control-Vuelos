namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class Panel_viewData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Title = new System.Windows.Forms.Label();
            this.cb_opciones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_cuerpo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(251, 26);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "Visualización de datos";
            // 
            // cb_opciones
            // 
            this.cb_opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_opciones.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_opciones.FormattingEnabled = true;
            this.cb_opciones.Items.AddRange(new object[] {
            "Seleccione la información que desea visualizar",
            "Vuelos activos utilizando un selector de fechas ",
            "Vuelos por pasajero",
            "Aviones por aerolínea",
            "Cantidad de Aviones que volaron por ciudad",
            "Cantidad de aviones diferentes que volaron de una ciudad a otra.",
            "Cantidad de aviones, cantidad de vuelos, nombre de ciudad a la que han viajado má" +
                "s veces",
            "Vuelos cancelados",
            "Información de Aerolínea, vuelo, origen, destino, horas de salida y llegada.",
            "Pasajeros confirmados por vuelo",
            "Vuelos por avion"});
            this.cb_opciones.Location = new System.Drawing.Point(12, 80);
            this.cb_opciones.Name = "cb_opciones";
            this.cb_opciones.Size = new System.Drawing.Size(958, 27);
            this.cb_opciones.TabIndex = 7;
            this.cb_opciones.SelectedIndexChanged += new System.EventHandler(this.cb_aerolineas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Información";
            // 
            // panel_cuerpo
            // 
            this.panel_cuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cuerpo.Location = new System.Drawing.Point(0, 121);
            this.panel_cuerpo.Name = "panel_cuerpo";
            this.panel_cuerpo.Size = new System.Drawing.Size(1069, 541);
            this.panel_cuerpo.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 121);
            this.panel1.TabIndex = 26;
            // 
            // Panel_viewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 662);
            this.Controls.Add(this.panel_cuerpo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_opciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel_viewData";
            this.Text = "Panel_viewData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.ComboBox cb_opciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_cuerpo;
        private System.Windows.Forms.Panel panel1;
    }
}