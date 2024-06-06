namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class Panel_FlightPassengers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFlight = new System.Windows.Forms.ComboBox();
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pasajeros Confirmados por Vuelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vuelo: ";
            // 
            // cbFlight
            // 
            this.cbFlight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFlight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFlight.FormattingEnabled = true;
            this.cbFlight.Location = new System.Drawing.Point(98, 73);
            this.cbFlight.Name = "cbFlight";
            this.cbFlight.Size = new System.Drawing.Size(905, 21);
            this.cbFlight.TabIndex = 14;
            this.cbFlight.SelectedIndexChanged += new System.EventHandler(this.cbFlight_SelectedIndexChanged);
            // 
            // dgvPassengers
            // 
            this.dgvPassengers.AllowUserToAddRows = false;
            this.dgvPassengers.AllowUserToDeleteRows = false;
            this.dgvPassengers.AllowUserToResizeRows = false;
            this.dgvPassengers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPassengers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengers.Location = new System.Drawing.Point(42, 111);
            this.dgvPassengers.MultiSelect = false;
            this.dgvPassengers.Name = "dgvPassengers";
            this.dgvPassengers.ReadOnly = true;
            this.dgvPassengers.RowHeadersVisible = false;
            this.dgvPassengers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengers.ShowCellErrors = false;
            this.dgvPassengers.ShowCellToolTips = false;
            this.dgvPassengers.ShowEditingIcon = false;
            this.dgvPassengers.ShowRowErrors = false;
            this.dgvPassengers.Size = new System.Drawing.Size(961, 481);
            this.dgvPassengers.TabIndex = 15;
            // 
            // Panel_FlightPassengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 623);
            this.Controls.Add(this.dgvPassengers);
            this.Controls.Add(this.cbFlight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Panel_FlightPassengers";
            this.Text = "Panel_FlightPassengers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFlight;
        private System.Windows.Forms.DataGridView dgvPassengers;
    }
}