namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class Panel_airlines
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
            this.PanelComponet = new System.Windows.Forms.Panel();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.btn_AddAirline = new System.Windows.Forms.Button();
            this.btn_SavePlane = new System.Windows.Forms.Button();
            this.btn_SaveAirline = new System.Windows.Forms.Button();
            this.btn_AddPlane = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelComponet
            // 
            this.PanelComponet.Location = new System.Drawing.Point(30, 86);
            this.PanelComponet.Name = "PanelComponet";
            this.PanelComponet.Size = new System.Drawing.Size(621, 542);
            this.PanelComponet.TabIndex = 0;
            // 
            // PanelAdd
            // 
            this.PanelAdd.Controls.Add(this.label1);
            this.PanelAdd.Location = new System.Drawing.Point(657, 86);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(400, 465);
            this.PanelAdd.TabIndex = 1;
            // 
            // btn_AddAirline
            // 
            this.btn_AddAirline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.btn_AddAirline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAirline.ForeColor = System.Drawing.Color.White;
            this.btn_AddAirline.Location = new System.Drawing.Point(677, 577);
            this.btn_AddAirline.Name = "btn_AddAirline";
            this.btn_AddAirline.Size = new System.Drawing.Size(173, 41);
            this.btn_AddAirline.TabIndex = 8;
            this.btn_AddAirline.Text = "Agregar aerolínea";
            this.btn_AddAirline.UseVisualStyleBackColor = false;
            this.btn_AddAirline.Click += new System.EventHandler(this.btn_AddAirline_Click);
            // 
            // btn_SavePlane
            // 
            this.btn_SavePlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(195)))), ((int)(((byte)(141)))));
            this.btn_SavePlane.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SavePlane.ForeColor = System.Drawing.Color.Black;
            this.btn_SavePlane.Location = new System.Drawing.Point(867, 577);
            this.btn_SavePlane.Name = "btn_SavePlane";
            this.btn_SavePlane.Size = new System.Drawing.Size(173, 41);
            this.btn_SavePlane.TabIndex = 9;
            this.btn_SavePlane.Text = "Guardar avión";
            this.btn_SavePlane.UseVisualStyleBackColor = false;
            this.btn_SavePlane.Click += new System.EventHandler(this.btn_SavePlane_Click);
            // 
            // btn_SaveAirline
            // 
            this.btn_SaveAirline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(195)))), ((int)(((byte)(141)))));
            this.btn_SaveAirline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveAirline.ForeColor = System.Drawing.Color.Black;
            this.btn_SaveAirline.Location = new System.Drawing.Point(677, 577);
            this.btn_SaveAirline.Name = "btn_SaveAirline";
            this.btn_SaveAirline.Size = new System.Drawing.Size(173, 41);
            this.btn_SaveAirline.TabIndex = 10;
            this.btn_SaveAirline.Text = "Guardar aerolínea";
            this.btn_SaveAirline.UseVisualStyleBackColor = false;
            this.btn_SaveAirline.Click += new System.EventHandler(this.btn_SaveAirline_Click);
            // 
            // btn_AddPlane
            // 
            this.btn_AddPlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.btn_AddPlane.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPlane.ForeColor = System.Drawing.Color.White;
            this.btn_AddPlane.Location = new System.Drawing.Point(867, 577);
            this.btn_AddPlane.Name = "btn_AddPlane";
            this.btn_AddPlane.Size = new System.Drawing.Size(173, 41);
            this.btn_AddPlane.TabIndex = 11;
            this.btn_AddPlane.Text = "Agregar avión";
            this.btn_AddPlane.UseVisualStyleBackColor = false;
            this.btn_AddPlane.Click += new System.EventHandler(this.btn_AddPlane_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar aerolínea (tal vez):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "       Agrega una aerolínea o avión\r\n          para dezplegar la ventana\r\n";
            // 
            // Panel_airlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AddAirline);
            this.Controls.Add(this.btn_SaveAirline);
            this.Controls.Add(this.btn_AddPlane);
            this.Controls.Add(this.btn_SavePlane);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.PanelComponet);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel_airlines";
            this.Text = "Panel_airlines";
            this.Load += new System.EventHandler(this.Panel_airlines_Load);
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelComponet;
        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.Button btn_AddAirline;
        private System.Windows.Forms.Button btn_SavePlane;
        private System.Windows.Forms.Button btn_SaveAirline;
        private System.Windows.Forms.Button btn_AddPlane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}