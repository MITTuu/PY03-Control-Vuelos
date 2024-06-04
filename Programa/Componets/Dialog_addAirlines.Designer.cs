namespace PY03___Control_de_vuelos.Programa.Componets
{
    partial class Dialog_addAirlines
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
            this.text_motto = new System.Windows.Forms.TextBox();
            this.text_nameAirline = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lema";
            // 
            // text_motto
            // 
            this.text_motto.Location = new System.Drawing.Point(135, 137);
            this.text_motto.Name = "text_motto";
            this.text_motto.Size = new System.Drawing.Size(114, 20);
            this.text_motto.TabIndex = 7;
            // 
            // text_nameAirline
            // 
            this.text_nameAirline.Location = new System.Drawing.Point(135, 78);
            this.text_nameAirline.Name = "text_nameAirline";
            this.text_nameAirline.Size = new System.Drawing.Size(114, 20);
            this.text_nameAirline.TabIndex = 8;
            // 
            // Dialog_addAirlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 426);
            this.Controls.Add(this.text_nameAirline);
            this.Controls.Add(this.text_motto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dialog_addAirlines";
            this.Text = "Dialog_addAirlines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_motto;
        private System.Windows.Forms.TextBox text_nameAirline;
    }
}