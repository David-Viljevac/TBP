namespace TBP_Projekt_Entity
{
    partial class EmpMngmt
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
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.LabelUpravljanjeZaposlenicima = new System.Windows.Forms.Label();
            this.btnOtkaz = new System.Windows.Forms.Button();
            this.btnObracunPlace = new System.Windows.Forms.Button();
            this.btnZaposliNovogRadnika = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.buttonPromijeniMail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(12, 93);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowHeadersWidth = 51;
            this.dgvZaposlenici.RowTemplate.Height = 24;
            this.dgvZaposlenici.Size = new System.Drawing.Size(751, 372);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // LabelUpravljanjeZaposlenicima
            // 
            this.LabelUpravljanjeZaposlenicima.AutoSize = true;
            this.LabelUpravljanjeZaposlenicima.Location = new System.Drawing.Point(12, 71);
            this.LabelUpravljanjeZaposlenicima.Name = "LabelUpravljanjeZaposlenicima";
            this.LabelUpravljanjeZaposlenicima.Size = new System.Drawing.Size(77, 16);
            this.LabelUpravljanjeZaposlenicima.TabIndex = 1;
            this.LabelUpravljanjeZaposlenicima.Text = "Zaposlenici";
            // 
            // btnOtkaz
            // 
            this.btnOtkaz.Location = new System.Drawing.Point(12, 471);
            this.btnOtkaz.Name = "btnOtkaz";
            this.btnOtkaz.Size = new System.Drawing.Size(105, 31);
            this.btnOtkaz.TabIndex = 2;
            this.btnOtkaz.Text = "Daj otkaz";
            this.btnOtkaz.UseVisualStyleBackColor = true;
            this.btnOtkaz.Click += new System.EventHandler(this.btnOtkaz_Click);
            // 
            // btnObracunPlace
            // 
            this.btnObracunPlace.Location = new System.Drawing.Point(12, 12);
            this.btnObracunPlace.Name = "btnObracunPlace";
            this.btnObracunPlace.Size = new System.Drawing.Size(114, 56);
            this.btnObracunPlace.TabIndex = 3;
            this.btnObracunPlace.Text = "Obracun placa";
            this.btnObracunPlace.UseVisualStyleBackColor = true;
            this.btnObracunPlace.Click += new System.EventHandler(this.btnObracunPlace_Click);
            // 
            // btnZaposliNovogRadnika
            // 
            this.btnZaposliNovogRadnika.Location = new System.Drawing.Point(155, 12);
            this.btnZaposliNovogRadnika.Name = "btnZaposliNovogRadnika";
            this.btnZaposliNovogRadnika.Size = new System.Drawing.Size(134, 56);
            this.btnZaposliNovogRadnika.TabIndex = 4;
            this.btnZaposliNovogRadnika.Text = "Zaposli novog radnika";
            this.btnZaposliNovogRadnika.UseVisualStyleBackColor = true;
            this.btnZaposliNovogRadnika.Click += new System.EventHandler(this.btnZaposliNovogRadnika_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(645, 471);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(118, 31);
            this.btnOdjava.TabIndex = 5;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // buttonPromijeniMail
            // 
            this.buttonPromijeniMail.Location = new System.Drawing.Point(321, 12);
            this.buttonPromijeniMail.Name = "buttonPromijeniMail";
            this.buttonPromijeniMail.Size = new System.Drawing.Size(134, 56);
            this.buttonPromijeniMail.TabIndex = 6;
            this.buttonPromijeniMail.Text = "Promijeni mail radnika";
            this.buttonPromijeniMail.UseVisualStyleBackColor = true;
            this.buttonPromijeniMail.Click += new System.EventHandler(this.buttonPromijeniMail_Click);
            // 
            // EmpMngmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.buttonPromijeniMail);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnZaposliNovogRadnika);
            this.Controls.Add(this.btnObracunPlace);
            this.Controls.Add(this.btnOtkaz);
            this.Controls.Add(this.LabelUpravljanjeZaposlenicima);
            this.Controls.Add(this.dgvZaposlenici);
            this.Name = "EmpMngmt";
            this.Text = "Upravljanje zaposlenicima";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Label LabelUpravljanjeZaposlenicima;
        private System.Windows.Forms.Button btnOtkaz;
        private System.Windows.Forms.Button btnObracunPlace;
        private System.Windows.Forms.Button btnZaposliNovogRadnika;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button buttonPromijeniMail;
    }
}

