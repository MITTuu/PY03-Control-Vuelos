namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class panelINF_Aerolineas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_aerolineas = new System.Windows.Forms.DataGridView();
            this.cb_aerolineas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aerolineas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.cb_aerolineas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 80);
            this.panel1.TabIndex = 27;
            // 
            // dgv_aerolineas
            // 
            this.dgv_aerolineas.AllowUserToAddRows = false;
            this.dgv_aerolineas.AllowUserToDeleteRows = false;
            this.dgv_aerolineas.AllowUserToResizeColumns = false;
            this.dgv_aerolineas.AllowUserToResizeRows = false;
            this.dgv_aerolineas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_aerolineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aerolineas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_aerolineas.Location = new System.Drawing.Point(0, 80);
            this.dgv_aerolineas.Name = "dgv_aerolineas";
            this.dgv_aerolineas.RowHeadersWidth = 51;
            this.dgv_aerolineas.RowTemplate.Height = 24;
            this.dgv_aerolineas.Size = new System.Drawing.Size(1051, 473);
            this.dgv_aerolineas.TabIndex = 28;
            // 
            // cb_aerolineas
            // 
            this.cb_aerolineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aerolineas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_aerolineas.FormattingEnabled = true;
            this.cb_aerolineas.Items.AddRange(new object[] {
            "Seleccione una aerolínea"});
            this.cb_aerolineas.Location = new System.Drawing.Point(12, 43);
            this.cb_aerolineas.Name = "cb_aerolineas";
            this.cb_aerolineas.Size = new System.Drawing.Size(452, 31);
            this.cb_aerolineas.TabIndex = 7;
            this.cb_aerolineas.SelectedIndexChanged += new System.EventHandler(this.cb_aerolineas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aerolíneas";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buscar.Location = new System.Drawing.Point(486, 38);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(40, 40);
            this.btn_buscar.TabIndex = 26;
            this.btn_buscar.Text = "🔍";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // panelINF_Aerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 553);
            this.Controls.Add(this.dgv_aerolineas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelINF_Aerolineas";
            this.Text = "panelINF_Aerolineas";
            this.Load += new System.EventHandler(this.panelINF_Aerolineas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aerolineas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_aerolineas;
        private System.Windows.Forms.ComboBox cb_aerolineas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar;
    }
}