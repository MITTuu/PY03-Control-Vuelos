namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class Panel_PlaneFlights
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
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.cbPlane = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFlights
            // 
            this.dgvFlights.AllowUserToAddRows = false;
            this.dgvFlights.AllowUserToDeleteRows = false;
            this.dgvFlights.AllowUserToResizeRows = false;
            this.dgvFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFlights.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(42, 111);
            this.dgvFlights.MultiSelect = false;
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.ReadOnly = true;
            this.dgvFlights.RowHeadersVisible = false;
            this.dgvFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlights.ShowCellErrors = false;
            this.dgvFlights.ShowCellToolTips = false;
            this.dgvFlights.ShowEditingIcon = false;
            this.dgvFlights.ShowRowErrors = false;
            this.dgvFlights.Size = new System.Drawing.Size(961, 481);
            this.dgvFlights.TabIndex = 23;
            // 
            // cbPlane
            // 
            this.cbPlane.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPlane.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPlane.FormattingEnabled = true;
            this.cbPlane.Location = new System.Drawing.Point(93, 73);
            this.cbPlane.Name = "cbPlane";
            this.cbPlane.Size = new System.Drawing.Size(910, 21);
            this.cbPlane.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Avión: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Vuelos por Pasajero";
            // 
            // Panel_PlaneFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 623);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.cbPlane);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Panel_PlaneFlights";
            this.Text = "Panel_PlaneFlights";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.ComboBox cbPlane;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}