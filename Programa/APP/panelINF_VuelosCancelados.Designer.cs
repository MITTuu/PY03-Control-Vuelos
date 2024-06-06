namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class panelINF_VuelosCancelados
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
            this.dgv_vuelos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vuelos)).BeginInit();
            this.SuspendLayout();
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
            this.dgv_vuelos.Location = new System.Drawing.Point(0, 0);
            this.dgv_vuelos.Name = "dgv_vuelos";
            this.dgv_vuelos.RowHeadersWidth = 51;
            this.dgv_vuelos.RowTemplate.Height = 24;
            this.dgv_vuelos.Size = new System.Drawing.Size(1069, 618);
            this.dgv_vuelos.TabIndex = 20;
            // 
            // panelINF_VuelosCancelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1069, 618);
            this.Controls.Add(this.dgv_vuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelINF_VuelosCancelados";
            this.Text = "panelINF_VuelosCancelados";
            this.Load += new System.EventHandler(this.panelINF_VuelosCancelados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vuelos;
    }
}