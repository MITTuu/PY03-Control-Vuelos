namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class Panel_Pilots
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellido1 = new System.Windows.Forms.TextBox();
            this.tb_apellido2 = new System.Windows.Forms.TextBox();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.tb_correo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_aerolineas = new System.Windows.Forms.ComboBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aerolínea asociada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Completa el siguiente formulario para registrar un piloto.";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(10, 19);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(355, 32);
            this.label_Title.TabIndex = 5;
            this.label_Title.Text = "Registrar un nuevo piloto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Primer Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_nombre.Location = new System.Drawing.Point(16, 182);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(556, 27);
            this.tb_nombre.TabIndex = 11;
            this.tb_nombre.Text = "Ingrese el nombre";
            this.tb_nombre.Click += new System.EventHandler(this.tb_nombre_Click);
            this.tb_nombre.Leave += new System.EventHandler(this.tb_nombre_Leave);
            // 
            // tb_apellido1
            // 
            this.tb_apellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_apellido1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_apellido1.Location = new System.Drawing.Point(16, 276);
            this.tb_apellido1.Name = "tb_apellido1";
            this.tb_apellido1.Size = new System.Drawing.Size(270, 27);
            this.tb_apellido1.TabIndex = 12;
            this.tb_apellido1.Text = "Ingrese el primer apellido";
            this.tb_apellido1.Click += new System.EventHandler(this.tb_apellido1_Click);
            this.tb_apellido1.Leave += new System.EventHandler(this.tb_apellido1_Leave);
            // 
            // tb_apellido2
            // 
            this.tb_apellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_apellido2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_apellido2.Location = new System.Drawing.Point(302, 276);
            this.tb_apellido2.Name = "tb_apellido2";
            this.tb_apellido2.Size = new System.Drawing.Size(270, 27);
            this.tb_apellido2.TabIndex = 14;
            this.tb_apellido2.Text = "Ingrese el segundo apellido";
            this.tb_apellido2.Click += new System.EventHandler(this.tb_apellido2_Click);
            this.tb_apellido2.Leave += new System.EventHandler(this.tb_apellido2_Leave);
            // 
            // tb_telefono
            // 
            this.tb_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telefono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_telefono.Location = new System.Drawing.Point(16, 476);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(556, 27);
            this.tb_telefono.TabIndex = 18;
            this.tb_telefono.Text = "Ingrese el número teléfonico";
            this.tb_telefono.Click += new System.EventHandler(this.tb_telefono_Click);
            this.tb_telefono.Leave += new System.EventHandler(this.tb_telefono_Leave);
            // 
            // tb_correo
            // 
            this.tb_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_correo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_correo.Location = new System.Drawing.Point(16, 372);
            this.tb_correo.Name = "tb_correo";
            this.tb_correo.Size = new System.Drawing.Size(556, 27);
            this.tb_correo.TabIndex = 17;
            this.tb_correo.Text = "Ingrese el correo electróico";
            this.tb_correo.Click += new System.EventHandler(this.tb_correo_Click);
            this.tb_correo.Leave += new System.EventHandler(this.tb_correo_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Correo electrónico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Teléfono";
            // 
            // cb_aerolineas
            // 
            this.cb_aerolineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aerolineas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_aerolineas.FormattingEnabled = true;
            this.cb_aerolineas.Items.AddRange(new object[] {
            "Seleccione una aerolínea"});
            this.cb_aerolineas.Location = new System.Drawing.Point(16, 574);
            this.cb_aerolineas.Name = "cb_aerolineas";
            this.cb_aerolineas.Size = new System.Drawing.Size(556, 31);
            this.cb_aerolineas.TabIndex = 19;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_registrar.Location = new System.Drawing.Point(218, 663);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(168, 39);
            this.btn_registrar.TabIndex = 21;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // Panel_Pilots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(604, 762);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.cb_aerolineas);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_correo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_apellido2);
            this.Controls.Add(this.tb_apellido1);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Title);
            this.Name = "Panel_Pilots";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel_Pilots";
            this.Load += new System.EventHandler(this.Panel_Pilots_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_apellido1;
        private System.Windows.Forms.TextBox tb_apellido2;
        private System.Windows.Forms.TextBox tb_telefono;
        private System.Windows.Forms.TextBox tb_correo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_aerolineas;
        private System.Windows.Forms.Button btn_registrar;
    }
}