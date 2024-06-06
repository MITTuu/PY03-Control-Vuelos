namespace PY03___Control_de_vuelos.Programa.FormsViewsData
{
    partial class FlightStatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chartPlanes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFlights = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTopCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPlanes
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPlanes.ChartAreas.Add(chartArea1);
            this.chartPlanes.Location = new System.Drawing.Point(32, 12);
            this.chartPlanes.Name = "chartPlanes";
            this.chartPlanes.Size = new System.Drawing.Size(400, 400);
            this.chartPlanes.TabIndex = 0;
            this.chartPlanes.Text = "chartPlanes";
            // 
            // chartFlights
            // 
            this.chartFlights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartFlights.ChartAreas.Add(chartArea2);
            this.chartFlights.Location = new System.Drawing.Point(400, 12);
            this.chartFlights.Name = "chartFlights";
            this.chartFlights.Size = new System.Drawing.Size(400, 400);
            this.chartFlights.TabIndex = 1;
            this.chartFlights.Text = "chartFlights";
            // 
            // labelTopCity
            // 
            this.labelTopCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTopCity.AutoSize = true;
            this.labelTopCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopCity.Location = new System.Drawing.Point(17, 381);
            this.labelTopCity.Name = "labelTopCity";
            this.labelTopCity.Size = new System.Drawing.Size(237, 21);
            this.labelTopCity.TabIndex = 2;
            this.labelTopCity.Text = "Ciudad con más vuelos: Ninguna";
            // 
            // FlightStatisticsForm
            // 
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.labelTopCity);
            this.Controls.Add(this.chartFlights);
            this.Controls.Add(this.chartPlanes);
            this.Name = "FlightStatisticsForm";
            this.Text = "Estadísticas de Vuelos";
            ((System.ComponentModel.ISupportInitialize)(this.chartPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlanes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlights;
        private System.Windows.Forms.Label labelTopCity;
    }
}