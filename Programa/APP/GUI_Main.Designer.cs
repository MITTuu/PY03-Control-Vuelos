﻿namespace PY03___Control_de_vuelos.Programa.APP
{
    partial class GUI_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Main));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_viewData = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_flight = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_passengers = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_airlines = new System.Windows.Forms.Button();
            this.ImagenPatito = new System.Windows.Forms.PictureBox();
            this.PanelAreaDeTrabajo = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPatito)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.ImagenPatito);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(240, 662);
            this.sidebar.MinimumSize = new System.Drawing.Size(65, 662);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(240, 662);
            this.sidebar.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 121);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // btn_menu
            // 
            this.btn_menu.BackgroundImage = global::PY03___Control_de_vuelos.Properties.Resources.iconMenu;
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu.Location = new System.Drawing.Point(2, 24);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(40, 40);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            this.btn_menu.MouseHover += new System.EventHandler(this.btn_menu_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_viewData);
            this.panel3.Location = new System.Drawing.Point(3, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 73);
            this.panel3.TabIndex = 2;
            // 
            // btn_viewData
            // 
            this.btn_viewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_viewData.FlatAppearance.BorderSize = 0;
            this.btn_viewData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewData.ForeColor = System.Drawing.Color.White;
            this.btn_viewData.Image = global::PY03___Control_de_vuelos.Properties.Resources.iconViewData;
            this.btn_viewData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewData.Location = new System.Drawing.Point(0, 0);
            this.btn_viewData.Name = "btn_viewData";
            this.btn_viewData.Size = new System.Drawing.Size(237, 73);
            this.btn_viewData.TabIndex = 0;
            this.btn_viewData.Text = "               Vista de datos";
            this.btn_viewData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewData.UseVisualStyleBackColor = true;
            this.btn_viewData.Click += new System.EventHandler(this.btn_viewData_Click);
            this.btn_viewData.MouseHover += new System.EventHandler(this.btn_viewData_MouseHover);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_flight);
            this.panel4.Location = new System.Drawing.Point(3, 209);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 68);
            this.panel4.TabIndex = 3;
            // 
            // btn_flight
            // 
            this.btn_flight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_flight.FlatAppearance.BorderSize = 0;
            this.btn_flight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_flight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_flight.ForeColor = System.Drawing.Color.White;
            this.btn_flight.Image = ((System.Drawing.Image)(resources.GetObject("btn_flight.Image")));
            this.btn_flight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_flight.Location = new System.Drawing.Point(0, 0);
            this.btn_flight.Margin = new System.Windows.Forms.Padding(0);
            this.btn_flight.Name = "btn_flight";
            this.btn_flight.Size = new System.Drawing.Size(234, 68);
            this.btn_flight.TabIndex = 0;
            this.btn_flight.Text = "               Gestor de vuelos";
            this.btn_flight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_flight.UseVisualStyleBackColor = true;
            this.btn_flight.Click += new System.EventHandler(this.btn_flight_Click);
            this.btn_flight.MouseHover += new System.EventHandler(this.btn_flight_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_passengers);
            this.panel2.Location = new System.Drawing.Point(3, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 67);
            this.panel2.TabIndex = 4;
            // 
            // btn_passengers
            // 
            this.btn_passengers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_passengers.FlatAppearance.BorderSize = 0;
            this.btn_passengers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_passengers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_passengers.ForeColor = System.Drawing.Color.White;
            this.btn_passengers.Image = global::PY03___Control_de_vuelos.Properties.Resources.iconePassengers;
            this.btn_passengers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_passengers.Location = new System.Drawing.Point(0, 0);
            this.btn_passengers.Name = "btn_passengers";
            this.btn_passengers.Size = new System.Drawing.Size(234, 67);
            this.btn_passengers.TabIndex = 0;
            this.btn_passengers.Text = "               Gestor de pasajeros";
            this.btn_passengers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_passengers.UseVisualStyleBackColor = true;
            this.btn_passengers.Click += new System.EventHandler(this.btn_passengers_Click);
            this.btn_passengers.MouseHover += new System.EventHandler(this.btn_passengers_MouseHover);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_airlines);
            this.panel5.Location = new System.Drawing.Point(3, 356);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 71);
            this.panel5.TabIndex = 3;
            // 
            // btn_airlines
            // 
            this.btn_airlines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_airlines.FlatAppearance.BorderSize = 0;
            this.btn_airlines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_airlines.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_airlines.ForeColor = System.Drawing.Color.White;
            this.btn_airlines.Image = global::PY03___Control_de_vuelos.Properties.Resources.iconAirlines;
            this.btn_airlines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_airlines.Location = new System.Drawing.Point(0, 0);
            this.btn_airlines.Name = "btn_airlines";
            this.btn_airlines.Size = new System.Drawing.Size(237, 71);
            this.btn_airlines.TabIndex = 0;
            this.btn_airlines.Text = "               Vista de aerolíneas";
            this.btn_airlines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_airlines.UseVisualStyleBackColor = true;
            this.btn_airlines.Click += new System.EventHandler(this.btn_airlines_Click);
            this.btn_airlines.MouseHover += new System.EventHandler(this.btn_airlines_MouseHover);
            // 
            // ImagenPatito
            // 
            this.ImagenPatito.Image = ((System.Drawing.Image)(resources.GetObject("ImagenPatito.Image")));
            this.ImagenPatito.Location = new System.Drawing.Point(3, 433);
            this.ImagenPatito.Name = "ImagenPatito";
            this.ImagenPatito.Size = new System.Drawing.Size(234, 187);
            this.ImagenPatito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenPatito.TabIndex = 5;
            this.ImagenPatito.TabStop = false;
            // 
            // PanelAreaDeTrabajo
            // 
            this.PanelAreaDeTrabajo.BackColor = System.Drawing.Color.White;
            this.PanelAreaDeTrabajo.Location = new System.Drawing.Point(69, 0);
            this.PanelAreaDeTrabajo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelAreaDeTrabajo.Name = "PanelAreaDeTrabajo";
            this.PanelAreaDeTrabajo.Size = new System.Drawing.Size(1065, 662);
            this.PanelAreaDeTrabajo.TabIndex = 3;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // GUI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 660);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.PanelAreaDeTrabajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GUI_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de vuelos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_Main_FormClosing);
            this.Load += new System.EventHandler(this.GUI_Main_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPatito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_viewData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_flight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_passengers;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_airlines;
        private System.Windows.Forms.PictureBox ImagenPatito;
        private System.Windows.Forms.Panel PanelAreaDeTrabajo;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}