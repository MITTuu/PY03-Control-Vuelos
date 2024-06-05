namespace PY03___Control_de_vuelos.Programa.Componets
{
    partial class Dialog_editPlane
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
            this.numeric_capacity = new System.Windows.Forms.NumericUpDown();
            this.text_resNumber = new System.Windows.Forms.TextBox();
            this.comboBox_brand = new System.Windows.Forms.ComboBox();
            this.comboBox_Arlines = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_capacity)).BeginInit();
            this.SuspendLayout();
            // 
            // numeric_capacity
            // 
            this.numeric_capacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_capacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_capacity.Location = new System.Drawing.Point(232, 218);
            this.numeric_capacity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_capacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_capacity.Name = "numeric_capacity";
            this.numeric_capacity.Size = new System.Drawing.Size(139, 29);
            this.numeric_capacity.TabIndex = 15;
            this.numeric_capacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // text_resNumber
            // 
            this.text_resNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_resNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_resNumber.Location = new System.Drawing.Point(233, 78);
            this.text_resNumber.Name = "text_resNumber";
            this.text_resNumber.Size = new System.Drawing.Size(140, 29);
            this.text_resNumber.TabIndex = 14;
            // 
            // comboBox_brand
            // 
            this.comboBox_brand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_brand.FormattingEnabled = true;
            this.comboBox_brand.Location = new System.Drawing.Point(232, 148);
            this.comboBox_brand.Name = "comboBox_brand";
            this.comboBox_brand.Size = new System.Drawing.Size(139, 29);
            this.comboBox_brand.TabIndex = 13;
            // 
            // comboBox_Arlines
            // 
            this.comboBox_Arlines.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Arlines.FormattingEnabled = true;
            this.comboBox_Arlines.Location = new System.Drawing.Point(233, 8);
            this.comboBox_Arlines.Name = "comboBox_Arlines";
            this.comboBox_Arlines.Size = new System.Drawing.Size(139, 29);
            this.comboBox_Arlines.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Aerolínea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número de registro";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(120, 283);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(137, 41);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Dialog_editPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 355);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.numeric_capacity);
            this.Controls.Add(this.text_resNumber);
            this.Controls.Add(this.comboBox_brand);
            this.Controls.Add(this.comboBox_Arlines);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dialog_editPlane";
            this.Text = "Dialog_editPlane";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_capacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown numeric_capacity;
        public System.Windows.Forms.TextBox text_resNumber;
        public System.Windows.Forms.ComboBox comboBox_brand;
        public System.Windows.Forms.ComboBox comboBox_Arlines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
    }
}