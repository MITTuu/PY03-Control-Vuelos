namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class GUI_Login
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
            this.panel_Body = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_Body.Controls.Add(this.btn_login);
            this.panel_Body.Controls.Add(this.tb_password);
            this.panel_Body.Controls.Add(this.label3);
            this.panel_Body.Controls.Add(this.tb_email);
            this.panel_Body.Controls.Add(this.label2);
            this.panel_Body.Controls.Add(this.label1);
            this.panel_Body.Controls.Add(this.label_Title);
            this.panel_Body.Location = new System.Drawing.Point(83, 37);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(466, 523);
            this.panel_Body.TabIndex = 0;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(19, 24);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(300, 32);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Bienvenido de vuelta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa tu correo y contraseña para iniciar \r\nsesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_email.Location = new System.Drawing.Point(25, 207);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(416, 27);
            this.tb_email.TabIndex = 3;
            this.tb_email.Text = "Ingresa tu correo";
            this.tb_email.Click += new System.EventHandler(this.tb_email_Click);
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_password.Location = new System.Drawing.Point(25, 296);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(416, 27);
            this.tb_password.TabIndex = 5;
            this.tb_password.Text = "Ingresa tu contraseña";
            this.tb_password.Click += new System.EventHandler(this.tb_password_Click);
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(25, 399);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(416, 39);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // GUI_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(634, 599);
            this.Controls.Add(this.panel_Body);
            this.Name = "GUI_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_Login";
            this.Load += new System.EventHandler(this.GUI_Login_Load);
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label2;
    }
}