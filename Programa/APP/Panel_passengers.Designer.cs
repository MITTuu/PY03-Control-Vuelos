namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class Panel_passengers
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbOrigin = new System.Windows.Forms.ComboBox();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.btnConfirmPassport = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLastname1 = new System.Windows.Forms.TextBox();
            this.tbLastname2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selección de Vuelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registro de Pasajeros";
            // 
            // dgvPassengers
            // 
            this.dgvPassengers.AllowUserToAddRows = false;
            this.dgvPassengers.AllowUserToDeleteRows = false;
            this.dgvPassengers.AllowUserToResizeRows = false;
            this.dgvPassengers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPassengers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengers.Location = new System.Drawing.Point(565, 343);
            this.dgvPassengers.MultiSelect = false;
            this.dgvPassengers.Name = "dgvPassengers";
            this.dgvPassengers.RowHeadersVisible = false;
            this.dgvPassengers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengers.ShowCellErrors = false;
            this.dgvPassengers.ShowCellToolTips = false;
            this.dgvPassengers.ShowEditingIcon = false;
            this.dgvPassengers.ShowRowErrors = false;
            this.dgvPassengers.Size = new System.Drawing.Size(452, 223);
            this.dgvPassengers.TabIndex = 1;
            // 
            // dgvFlights
            // 
            this.dgvFlights.AllowUserToAddRows = false;
            this.dgvFlights.AllowUserToDeleteRows = false;
            this.dgvFlights.AllowUserToResizeRows = false;
            this.dgvFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFlights.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(49, 146);
            this.dgvFlights.MultiSelect = false;
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.RowHeadersVisible = false;
            this.dgvFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlights.ShowCellErrors = false;
            this.dgvFlights.ShowCellToolTips = false;
            this.dgvFlights.ShowEditingIcon = false;
            this.dgvFlights.ShowRowErrors = false;
            this.dgvFlights.Size = new System.Drawing.Size(462, 420);
            this.dgvFlights.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(49, 118);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(98, 22);
            this.dtpDate.TabIndex = 5;
            // 
            // cbOrigin
            // 
            this.cbOrigin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOrigin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOrigin.FormattingEnabled = true;
            this.cbOrigin.Location = new System.Drawing.Point(153, 118);
            this.cbOrigin.Name = "cbOrigin";
            this.cbOrigin.Size = new System.Drawing.Size(176, 21);
            this.cbOrigin.TabIndex = 6;
            this.cbOrigin.SelectedIndexChanged += new System.EventHandler(this.cbOrigin_SelectedIndexChanged);
            // 
            // cbDestination
            // 
            this.cbDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(335, 118);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(176, 21);
            this.cbDestination.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha";
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPassenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPassenger.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddPassenger.Location = new System.Drawing.Point(565, 303);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(452, 34);
            this.btnAddPassenger.TabIndex = 11;
            this.btnAddPassenger.Text = "Añadir Pasajero";
            this.btnAddPassenger.UseVisualStyleBackColor = false;
            this.btnAddPassenger.Click += new System.EventHandler(this.btnAddPassenger_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(562, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pasaporte";
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(565, 118);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(245, 22);
            this.tbPassport.TabIndex = 13;
            // 
            // btnConfirmPassport
            // 
            this.btnConfirmPassport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmPassport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPassport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirmPassport.Location = new System.Drawing.Point(828, 118);
            this.btnConfirmPassport.Name = "btnConfirmPassport";
            this.btnConfirmPassport.Size = new System.Drawing.Size(189, 23);
            this.btnConfirmPassport.TabIndex = 14;
            this.btnConfirmPassport.Text = "Buscar y Rellenar";
            this.btnConfirmPassport.UseVisualStyleBackColor = false;
            this.btnConfirmPassport.Click += new System.EventHandler(this.btnConfirmPassport_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(565, 184);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(156, 22);
            this.tbName.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(562, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(741, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "1er Apellido";
            // 
            // tbLastname1
            // 
            this.tbLastname1.Location = new System.Drawing.Point(741, 184);
            this.tbLastname1.Name = "tbLastname1";
            this.tbLastname1.ReadOnly = true;
            this.tbLastname1.Size = new System.Drawing.Size(130, 22);
            this.tbLastname1.TabIndex = 18;
            // 
            // tbLastname2
            // 
            this.tbLastname2.Location = new System.Drawing.Point(889, 184);
            this.tbLastname2.Name = "tbLastname2";
            this.tbLastname2.ReadOnly = true;
            this.tbLastname2.Size = new System.Drawing.Size(128, 22);
            this.tbLastname2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(886, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "2do Apellido";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(565, 248);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(245, 22);
            this.tbEmail.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(562, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Correo";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(828, 248);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.ReadOnly = true;
            this.tbPhoneNumber.Size = new System.Drawing.Size(189, 22);
            this.tbPhoneNumber.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(825, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Telefono";
            // 
            // Panel_passengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 662);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbLastname2);
            this.Controls.Add(this.tbLastname1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnConfirmPassport);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddPassenger);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.cbOrigin);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPassengers);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel_passengers";
            this.Text = "Panel_passengers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPassengers;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbOrigin;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.Button btnConfirmPassport;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbLastname1;
        private System.Windows.Forms.TextBox tbLastname2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label11;
    }
}