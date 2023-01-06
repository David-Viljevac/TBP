namespace TBP_Projekt_Entity
{
    partial class ObracunPlace
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
            this.comboBoxOdabirRadnika = new System.Windows.Forms.ComboBox();
            this.labelOdabirRadnika = new System.Windows.Forms.Label();
            this.dgvPopisRadnihDana = new System.Windows.Forms.DataGridView();
            this.btnObracunajPlacu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisRadnihDana)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxOdabirRadnika
            // 
            this.comboBoxOdabirRadnika.FormattingEnabled = true;
            this.comboBoxOdabirRadnika.Location = new System.Drawing.Point(140, 12);
            this.comboBoxOdabirRadnika.Name = "comboBoxOdabirRadnika";
            this.comboBoxOdabirRadnika.Size = new System.Drawing.Size(232, 24);
            this.comboBoxOdabirRadnika.TabIndex = 0;
            this.comboBoxOdabirRadnika.SelectedIndexChanged += new System.EventHandler(this.comboBoxOdabirRadnika_SelectedIndexChanged);
            // 
            // labelOdabirRadnika
            // 
            this.labelOdabirRadnika.AutoSize = true;
            this.labelOdabirRadnika.Location = new System.Drawing.Point(12, 20);
            this.labelOdabirRadnika.Name = "labelOdabirRadnika";
            this.labelOdabirRadnika.Size = new System.Drawing.Size(107, 16);
            this.labelOdabirRadnika.TabIndex = 1;
            this.labelOdabirRadnika.Text = "Odaberi radnika:";
            // 
            // dgvPopisRadnihDana
            // 
            this.dgvPopisRadnihDana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisRadnihDana.Location = new System.Drawing.Point(12, 42);
            this.dgvPopisRadnihDana.Name = "dgvPopisRadnihDana";
            this.dgvPopisRadnihDana.RowHeadersWidth = 51;
            this.dgvPopisRadnihDana.RowTemplate.Height = 24;
            this.dgvPopisRadnihDana.Size = new System.Drawing.Size(761, 315);
            this.dgvPopisRadnihDana.TabIndex = 2;
            // 
            // btnObracunajPlacu
            // 
            this.btnObracunajPlacu.Location = new System.Drawing.Point(12, 376);
            this.btnObracunajPlacu.Name = "btnObracunajPlacu";
            this.btnObracunajPlacu.Size = new System.Drawing.Size(277, 34);
            this.btnObracunajPlacu.TabIndex = 3;
            this.btnObracunajPlacu.Text = "Obracunaj placu za odabranog radnika";
            this.btnObracunajPlacu.UseVisualStyleBackColor = true;
            this.btnObracunajPlacu.Click += new System.EventHandler(this.btnObracunajPlacu_Click);
            // 
            // ObracunPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObracunajPlacu);
            this.Controls.Add(this.dgvPopisRadnihDana);
            this.Controls.Add(this.labelOdabirRadnika);
            this.Controls.Add(this.comboBoxOdabirRadnika);
            this.Name = "ObracunPlace";
            this.Text = "ObracunPlace";
            this.Load += new System.EventHandler(this.ObracunPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisRadnihDana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOdabirRadnika;
        private System.Windows.Forms.Label labelOdabirRadnika;
        private System.Windows.Forms.DataGridView dgvPopisRadnihDana;
        private System.Windows.Forms.Button btnObracunajPlacu;
    }
}