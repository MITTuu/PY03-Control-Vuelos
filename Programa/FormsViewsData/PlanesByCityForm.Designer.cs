namespace PY03___Control_de_vuelos.Programa.FormsViewsData
{
    partial class PlanesByCityForm
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



        private void InitializeComponent()
        {
            this.comboBoxAirlines = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAirlines
            // 
            this.comboBoxAirlines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAirlines.FormattingEnabled = true;
            this.comboBoxAirlines.Location = new System.Drawing.Point(12, 12);
            this.comboBoxAirlines.Name = "comboBoxAirlines";
            this.comboBoxAirlines.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAirlines.TabIndex = 0;
            this.comboBoxAirlines.SelectedIndexChanged += new System.EventHandler(this.comboBoxAirlines_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.Location = new System.Drawing.Point(12, 50);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(776, 388);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // PlanesByCityForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboBoxAirlines);
            this.Name = "PlanesByCityForm";
            this.Text = "Cantidad de Aviones que Volaron por Ciudad";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAirlines;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

    }
}