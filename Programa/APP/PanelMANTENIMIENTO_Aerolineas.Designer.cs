namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class PanelMANTENIMIENTO_Aerolineas
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
            this.dtp_horaLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtp_horaSalida = new System.Windows.Forms.DateTimePicker();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.cb_ciudadLlegada = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_ciudadSalida = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_fechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.cb_aviones = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_pilotos = new System.Windows.Forms.ComboBox();
            this.label_info = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_horaLlegada
            // 
            this.dtp_horaLlegada.CustomFormat = "HH:mm";
            this.dtp_horaLlegada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_horaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horaLlegada.Location = new System.Drawing.Point(524, 460);
            this.dtp_horaLlegada.Name = "dtp_horaLlegada";
            this.dtp_horaLlegada.ShowUpDown = true;
            this.dtp_horaLlegada.Size = new System.Drawing.Size(138, 30);
            this.dtp_horaLlegada.TabIndex = 44;
            // 
            // dtp_horaSalida
            // 
            this.dtp_horaSalida.CustomFormat = "HH:mm";
            this.dtp_horaSalida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_horaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horaSalida.Location = new System.Drawing.Point(524, 357);
            this.dtp_horaSalida.Name = "dtp_horaSalida";
            this.dtp_horaSalida.ShowUpDown = true;
            this.dtp_horaSalida.Size = new System.Drawing.Size(138, 30);
            this.dtp_horaSalida.TabIndex = 43;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_actualizar.Location = new System.Drawing.Point(241, 585);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(416, 39);
            this.btn_actualizar.TabIndex = 42;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // cb_ciudadLlegada
            // 
            this.cb_ciudadLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ciudadLlegada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ciudadLlegada.FormattingEnabled = true;
            this.cb_ciudadLlegada.Items.AddRange(new object[] {
            "Seleccione una ciudad de llegada"});
            this.cb_ciudadLlegada.Location = new System.Drawing.Point(524, 259);
            this.cb_ciudadLlegada.Name = "cb_ciudadLlegada";
            this.cb_ciudadLlegada.Size = new System.Drawing.Size(452, 31);
            this.cb_ciudadLlegada.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(520, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Ciudad de llegada";
            // 
            // cb_ciudadSalida
            // 
            this.cb_ciudadSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ciudadSalida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ciudadSalida.FormattingEnabled = true;
            this.cb_ciudadSalida.Items.AddRange(new object[] {
            "Seleccione una ciudad de salidad"});
            this.cb_ciudadSalida.Location = new System.Drawing.Point(18, 259);
            this.cb_ciudadSalida.Name = "cb_ciudadSalida";
            this.cb_ciudadSalida.Size = new System.Drawing.Size(452, 31);
            this.cb_ciudadSalida.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Ciudad de salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Hora de llegada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Fecha de llegada";
            // 
            // dtp_fechaLlegada
            // 
            this.dtp_fechaLlegada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaLlegada.Location = new System.Drawing.Point(18, 460);
            this.dtp_fechaLlegada.Name = "dtp_fechaLlegada";
            this.dtp_fechaLlegada.Size = new System.Drawing.Size(300, 30);
            this.dtp_fechaLlegada.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(520, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Hora de salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Fecha de salida";
            // 
            // dtp_fechaSalida
            // 
            this.dtp_fechaSalida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaSalida.Location = new System.Drawing.Point(18, 357);
            this.dtp_fechaSalida.Name = "dtp_fechaSalida";
            this.dtp_fechaSalida.Size = new System.Drawing.Size(300, 30);
            this.dtp_fechaSalida.TabIndex = 32;
            // 
            // cb_aviones
            // 
            this.cb_aviones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aviones.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_aviones.FormattingEnabled = true;
            this.cb_aviones.Items.AddRange(new object[] {
            "Seleccione un avión"});
            this.cb_aviones.Location = new System.Drawing.Point(524, 152);
            this.cb_aviones.Name = "cb_aviones";
            this.cb_aviones.Size = new System.Drawing.Size(452, 31);
            this.cb_aviones.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Aviones";
            // 
            // cb_pilotos
            // 
            this.cb_pilotos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pilotos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pilotos.FormattingEnabled = true;
            this.cb_pilotos.Items.AddRange(new object[] {
            "Seleccione un piloto"});
            this.cb_pilotos.Location = new System.Drawing.Point(18, 152);
            this.cb_pilotos.Name = "cb_pilotos";
            this.cb_pilotos.Size = new System.Drawing.Size(411, 31);
            this.cb_pilotos.TabIndex = 29;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_info.Location = new System.Drawing.Point(14, 61);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(589, 22);
            this.label_info.TabIndex = 25;
            this.label_info.Text = "Completa el siguiente formulario para actualizar  un vuelo en la aerolínea";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(354, 32);
            this.label_Title.TabIndex = 24;
            this.label_Title.Text = "Mantenimiento de vuelos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(691, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 45;
            this.button1.Text = "🗑️";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pilotos";
            // 
            // PanelMANTENIMIENTO_Aerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1051, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_horaLlegada);
            this.Controls.Add(this.dtp_horaSalida);
            this.Controls.Add(this.btn_actualizar);
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
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_Title);
            this.Name = "PanelMANTENIMIENTO_Aerolineas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelMANTENIMIENTO_Aerolineas";
            this.Load += new System.EventHandler(this.PanelMANTENIMIENTO_Aerolineas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_horaLlegada;
        private System.Windows.Forms.DateTimePicker dtp_horaSalida;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.ComboBox cb_ciudadLlegada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_ciudadSalida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_fechaLlegada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_fechaSalida;
        private System.Windows.Forms.ComboBox cb_aviones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_pilotos;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}