namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class panelINF_VuelosActivos
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
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_fechaFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fechaIni = new System.Windows.Forms.DateTimePicker();
            this.dgv_vuelos = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(342, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fecha final";
            // 
            // dtp_fechaFin
            // 
            this.dtp_fechaFin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaFin.Location = new System.Drawing.Point(346, 36);
            this.dtp_fechaFin.Name = "dtp_fechaFin";
            this.dtp_fechaFin.Size = new System.Drawing.Size(300, 30);
            this.dtp_fechaFin.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha inicial";
            // 
            // dtp_fechaIni
            // 
            this.dtp_fechaIni.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaIni.Location = new System.Drawing.Point(12, 36);
            this.dtp_fechaIni.Name = "dtp_fechaIni";
            this.dtp_fechaIni.Size = new System.Drawing.Size(300, 30);
            this.dtp_fechaIni.TabIndex = 15;
            // 
            // dgv_vuelos
            // 
            this.dgv_vuelos.AllowUserToAddRows = false;
            this.dgv_vuelos.AllowUserToDeleteRows = false;
            this.dgv_vuelos.AllowUserToResizeColumns = false;
            this.dgv_vuelos.AllowUserToResizeRows = false;
            this.dgv_vuelos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vuelos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vuelos.Location = new System.Drawing.Point(0, 80);
            this.dgv_vuelos.Name = "dgv_vuelos";
            this.dgv_vuelos.RowHeadersWidth = 51;
            this.dgv_vuelos.RowTemplate.Height = 24;
            this.dgv_vuelos.Size = new System.Drawing.Size(1051, 497);
            this.dgv_vuelos.TabIndex = 19;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buscar.Location = new System.Drawing.Point(728, 30);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(40, 40);
            this.btn_buscar.TabIndex = 25;
            this.btn_buscar.Text = "🔍";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_registrarPiloto_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 80);
            this.panel1.TabIndex = 26;
            // 
            // panelINF_VuelosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1051, 577);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dgv_vuelos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_fechaFin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_fechaIni);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelINF_VuelosActivos";
            this.Text = "panelINF_VuelosActivos";
            this.Load += new System.EventHandler(this.panelINF_VuelosActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_fechaFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_fechaIni;
        private System.Windows.Forms.DataGridView dgv_vuelos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Panel panel1;
    }
}