using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP_Projekt_Entity
{
    public partial class PrijavaNaPosao : Form
    {
        public int KorisnikID { get; set; }
        public PrijavaNaPosao(int korisnikID)
        {
            KorisnikID = korisnikID;
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrijavaRadnogVremena_Click(object sender, EventArgs e)
        {
            Radno_vrijeme novoRadnoVrijeme = new Radno_vrijeme();
            novoRadnoVrijeme.Pocetak_rada = TimeSpan.Parse(timePickerPocetak.Value.TimeOfDay.ToString());
            TimeSpan timeSpan = new TimeSpan(int.Parse(textBoxSatiRada.Text), 0, 0);
            novoRadnoVrijeme.Trajanje_rada = timeSpan;
            Console.WriteLine(novoRadnoVrijeme.Trajanje_rada);
            novoRadnoVrijeme.ZavrĹˇetak_rada = TimeSpan.Parse(timePickerZavrsetak.Value.TimeOfDay.ToString());
            novoRadnoVrijeme.korisnikID = KorisnikID; 
            novoRadnoVrijeme.Datum_rada = DateTime.Now;
            using (var ctx = new postgresEntities())
            {
                ctx.Radno_vrijeme.Add(novoRadnoVrijeme);
                ctx.SaveChanges();
            }
        }

        private void textBoxSatiRada_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void buttonDodajSate_Click(object sender, EventArgs e)
        {
            
            timePickerZavrsetak.Value = timePickerPocetak.Value.AddHours(double.Parse(textBoxSatiRada.Text));
            timePickerZavrsetak.Refresh();
        }
    }
}
