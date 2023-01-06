namespace TBP_Projekt_Entity
{
    partial class PrijavaNaPosao
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
            this.timePickerPocetak = new System.Windows.Forms.DateTimePicker();
            this.timePickerZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.textBoxSatiRada = new System.Windows.Forms.TextBox();
            this.labelPocetakRada = new System.Windows.Forms.Label();
            this.labelTrajanje = new System.Windows.Forms.Label();
            this.labelKrajRada = new System.Windows.Forms.Label();
            this.btnPrijavaRadnogVremena = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.buttonDodajSate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timePickerPocetak
            // 
            this.timePickerPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerPocetak.Location = new System.Drawing.Point(2, 40);
            this.timePickerPocetak.Name = "timePickerPocetak";
            this.timePickerPocetak.Size = new System.Drawing.Size(200, 22);
            this.timePickerPocetak.TabIndex = 0;
            // 
            // timePickerZavrsetak
            // 
            this.timePickerZavrsetak.Enabled = false;
            this.timePickerZavrsetak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerZavrsetak.Location = new System.Drawing.Point(351, 40);
            this.timePickerZavrsetak.Name = "timePickerZavrsetak";
            this.timePickerZavrsetak.Size = new System.Drawing.Size(200, 22);
            this.timePickerZavrsetak.TabIndex = 1;
            // 
            // textBoxSatiRada
            // 
            this.textBoxSatiRada.Location = new System.Drawing.Point(225, 39);
            this.textBoxSatiRada.Name = "textBoxSatiRada";
            this.textBoxSatiRada.Size = new System.Drawing.Size(100, 22);
            this.textBoxSatiRada.TabIndex = 2;
            this.textBoxSatiRada.TextChanged += new System.EventHandler(this.textBoxSatiRada_TextChanged);
            // 
            // labelPocetakRada
            // 
            this.labelPocetakRada.AutoSize = true;
            this.labelPocetakRada.Location = new System.Drawing.Point(-1, 21);
            this.labelPocetakRada.Name = "labelPocetakRada";
            this.labelPocetakRada.Size = new System.Drawing.Size(88, 16);
            this.labelPocetakRada.TabIndex = 3;
            this.labelPocetakRada.Text = "Pocetak rada";
            // 
            // labelTrajanje
            // 
            this.labelTrajanje.AutoSize = true;
            this.labelTrajanje.Location = new System.Drawing.Point(222, 21);
            this.labelTrajanje.Name = "labelTrajanje";
            this.labelTrajanje.Size = new System.Drawing.Size(77, 16);
            this.labelTrajanje.TabIndex = 4;
            this.labelTrajanje.Text = "Trajanja u h";
            // 
            // labelKrajRada
            // 
            this.labelKrajRada.AutoSize = true;
            this.labelKrajRada.Location = new System.Drawing.Point(348, 21);
            this.labelKrajRada.Name = "labelKrajRada";
            this.labelKrajRada.Size = new System.Drawing.Size(61, 16);
            this.labelKrajRada.TabIndex = 5;
            this.labelKrajRada.Text = "Kraj rada";
            // 
            // btnPrijavaRadnogVremena
            // 
            this.btnPrijavaRadnogVremena.Location = new System.Drawing.Point(12, 113);
            this.btnPrijavaRadnogVremena.Name = "btnPrijavaRadnogVremena";
            this.btnPrijavaRadnogVremena.Size = new System.Drawing.Size(178, 36);
            this.btnPrijavaRadnogVremena.TabIndex = 6;
            this.btnPrijavaRadnogVremena.Text = "Prijava radnog vremena";
            this.btnPrijavaRadnogVremena.UseVisualStyleBackColor = true;
            this.btnPrijavaRadnogVremena.Click += new System.EventHandler(this.btnPrijavaRadnogVremena_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(373, 113);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(178, 36);
            this.btnOdjava.TabIndex = 7;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // buttonDodajSate
            // 
            this.buttonDodajSate.Location = new System.Drawing.Point(225, 67);
            this.buttonDodajSate.Name = "buttonDodajSate";
            this.buttonDodajSate.Size = new System.Drawing.Size(100, 36);
            this.buttonDodajSate.TabIndex = 8;
            this.buttonDodajSate.Text = "Dodaj sate";
            this.buttonDodajSate.UseVisualStyleBackColor = true;
            this.buttonDodajSate.Click += new System.EventHandler(this.buttonDodajSate_Click);
            // 
            // PrijavaNaPosao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 161);
            this.Controls.Add(this.buttonDodajSate);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnPrijavaRadnogVremena);
            this.Controls.Add(this.labelKrajRada);
            this.Controls.Add(this.labelTrajanje);
            this.Controls.Add(this.labelPocetakRada);
            this.Controls.Add(this.textBoxSatiRada);
            this.Controls.Add(this.timePickerZavrsetak);
            this.Controls.Add(this.timePickerPocetak);
            this.Name = "PrijavaNaPosao";
            this.Text = "Prijava na posao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timePickerPocetak;
        private System.Windows.Forms.DateTimePicker timePickerZavrsetak;
        private System.Windows.Forms.TextBox textBoxSatiRada;
        private System.Windows.Forms.Label labelPocetakRada;
        private System.Windows.Forms.Label labelTrajanje;
        private System.Windows.Forms.Label labelKrajRada;
        private System.Windows.Forms.Button btnPrijavaRadnogVremena;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button buttonDodajSate;
    }
}