namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class Panel_flight
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_aerolineas = new System.Windows.Forms.ComboBox();
            this.cb_pilotos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_aviones = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_fechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.cb_ciudadSalida = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_ciudadLlegada = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.dtp_horaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtp_horaLlegada = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_registrarPiloto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(12, 19);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(235, 32);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Registrar vuelos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Completa el siguiente formulario para registrar un vuelo.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aerolíneas";
            // 
            // cb_aerolineas
            // 
            this.cb_aerolineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aerolineas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_aerolineas.FormattingEnabled = true;
            this.cb_aerolineas.Items.AddRange(new object[] {
            "Seleccione una aerolínea"});
            this.cb_aerolineas.Location = new System.Drawing.Point(18, 155);
            this.cb_aerolineas.Name = "cb_aerolineas";
            this.cb_aerolineas.Size = new System.Drawing.Size(452, 31);
            this.cb_aerolineas.TabIndex = 5;
            this.cb_aerolineas.SelectedIndexChanged += new System.EventHandler(this.cb_aerolineas_SelectedIndexChanged);
            // 
            // cb_pilotos
            // 
            this.cb_pilotos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pilotos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pilotos.FormattingEnabled = true;
            this.cb_pilotos.Items.AddRange(new object[] {
            "Seleccione un piloto"});
            this.cb_pilotos.Location = new System.Drawing.Point(18, 242);
            this.cb_pilotos.Name = "cb_pilotos";
            this.cb_pilotos.Size = new System.Drawing.Size(411, 31);
            this.cb_pilotos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pilotos";
            // 
            // cb_aviones
            // 
            this.cb_aviones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aviones.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_aviones.FormattingEnabled = true;
            this.cb_aviones.Items.AddRange(new object[] {
            "Seleccione un avión"});
            this.cb_aviones.Location = new System.Drawing.Point(524, 155);
            this.cb_aviones.Name = "cb_aviones";
            this.cb_aviones.Size = new System.Drawing.Size(452, 31);
            this.cb_aviones.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aviones";
            // 
            // dtp_fechaSalida
            // 
            this.dtp_fechaSalida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaSalida.Location = new System.Drawing.Point(18, 426);
            this.dtp_fechaSalida.Name = "dtp_fechaSalida";
            this.dtp_fechaSalida.Size = new System.Drawing.Size(300, 30);
            this.dtp_fechaSalida.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(520, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hora de salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hora de llegada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha de llegada";
            // 
            // dtp_fechaLlegada
            // 
            this.dtp_fechaLlegada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaLlegada.Location = new System.Drawing.Point(18, 518);
            this.dtp_fechaLlegada.Name = "dtp_fechaLlegada";
            this.dtp_fechaLlegada.Size = new System.Drawing.Size(300, 30);
            this.dtp_fechaLlegada.TabIndex = 13;
            // 
            // cb_ciudadSalida
            // 
            this.cb_ciudadSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ciudadSalida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ciudadSalida.FormattingEnabled = true;
            this.cb_ciudadSalida.Items.AddRange(new object[] {
            "Seleccione una ciudad de salidad"});
            this.cb_ciudadSalida.Location = new System.Drawing.Point(18, 333);
            this.cb_ciudadSalida.Name = "cb_ciudadSalida";
            this.cb_ciudadSalida.Size = new System.Drawing.Size(452, 31);
            this.cb_ciudadSalida.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ciudad de salida";
            // 
            // cb_ciudadLlegada
            // 
            this.cb_ciudadLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ciudadLlegada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ciudadLlegada.FormattingEnabled = true;
            this.cb_ciudadLlegada.Items.AddRange(new object[] {
            "Seleccione una ciudad de llegada"});
            this.cb_ciudadLlegada.Location = new System.Drawing.Point(524, 333);
            this.cb_ciudadLlegada.Name = "cb_ciudadLlegada";
            this.cb_ciudadLlegada.Size = new System.Drawing.Size(452, 31);
            this.cb_ciudadLlegada.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(520, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ciudad de llegada";
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_registrar.Location = new System.Drawing.Point(305, 595);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(416, 39);
            this.btn_registrar.TabIndex = 20;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // dtp_horaSalida
            // 
            this.dtp_horaSalida.CustomFormat = "HH:mm";
            this.dtp_horaSalida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_horaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horaSalida.Location = new System.Drawing.Point(524, 426);
            this.dtp_horaSalida.Name = "dtp_horaSalida";
            this.dtp_horaSalida.ShowUpDown = true;
            this.dtp_horaSalida.Size = new System.Drawing.Size(138, 30);
            this.dtp_horaSalida.TabIndex = 21;
            // 
            // dtp_horaLlegada
            // 
            this.dtp_horaLlegada.CustomFormat = "HH:mm";
            this.dtp_horaLlegada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_horaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horaLlegada.Location = new System.Drawing.Point(524, 518);
            this.dtp_horaLlegada.Name = "dtp_horaLlegada";
            this.dtp_horaLlegada.ShowUpDown = true;
            this.dtp_horaLlegada.Size = new System.Drawing.Size(138, 30);
            this.dtp_horaLlegada.TabIndex = 22;
            // 
            // btn_registrarPiloto
            // 
            this.btn_registrarPiloto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registrarPiloto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarPiloto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_registrarPiloto.Location = new System.Drawing.Point(435, 240);
            this.btn_registrarPiloto.Name = "btn_registrarPiloto";
            this.btn_registrarPiloto.Size = new System.Drawing.Size(35, 35);
            this.btn_registrarPiloto.TabIndex = 23;
            this.btn_registrarPiloto.Text = "+";
            this.btn_registrarPiloto.UseVisualStyleBackColor = false;
            this.btn_registrarPiloto.Click += new System.EventHandler(this.btn_registrarPiloto_Click);
            // 
            // Panel_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 662);
            this.Controls.Add(this.btn_registrarPiloto);
            this.Controls.Add(this.dtp_horaLlegada);
            this.Controls.Add(this.dtp_horaSalida);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.cb_ciudadLlegada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_ciudadSalida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_fechaLlegada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_fechaSalida);
            this.Controls.Add(this.cb_aviones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_pilotos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_aerolineas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel_flight";
            this.Text = "Panel_flight";
            this.Load += new System.EventHandler(this.Panel_flight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_aerolineas;
        private System.Windows.Forms.ComboBox cb_pilotos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_aviones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_fechaSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_fechaLlegada;
        private System.Windows.Forms.ComboBox cb_ciudadSalida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_ciudadLlegada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.DateTimePicker dtp_horaSalida;
        private System.Windows.Forms.DateTimePicker dtp_horaLlegada;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_registrarPiloto;
    }
}