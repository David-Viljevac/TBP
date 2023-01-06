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
    public partial class EmailChange : Form
    {
        public Korisnik korisnik { get; set; }
        public EmailChange(Korisnik odabrani)
        {
            korisnik = odabrani;
            InitializeComponent();
        }

        private void EmailChange_Load(object sender, EventArgs e)
        {
            textBoxIme.Text = korisnik.Ime;
            textBoxPrezime.Text = korisnik.Prezime;
            textBoxKorIme.Text = korisnik.Kor_ime;
            datePickerDatumRodenja.Value = korisnik.Datum_rodenja;
            textBoxOIB.Text = korisnik.OIB;
            textBoxLozinka.Text = korisnik.Lozinka;
            checkBoxZaposlen.Checked = korisnik.Zaposlen;
            if (korisnik.ulogaID == 1)
            {
                textBoxUloga.Text = "Admin";
            }
            else
            {
                textBoxUloga.Text = "Korisnik";
            }
            if (korisnik.cijenaID == 2)
            {
                textBoxCijenaRada.Text = "50";
            }
            else
            {
                textBoxCijenaRada.Text = "32.5";
            }
        }

        private void buttonSpremiPromjene_Click(object sender, EventArgs e)
        {
            if (korisnik.Email != textBoxEmail.Text)
            {
                
                using (var ctx = new postgresEntities())
                {
                    ctx.Korisnik.Attach(korisnik);
                    korisnik.Email = textBoxEmail.Text;
                    ctx.SaveChanges();
                }
            }
        }
    }
}
