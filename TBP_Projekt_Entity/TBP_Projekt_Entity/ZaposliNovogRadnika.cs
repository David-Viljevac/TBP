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
    public partial class ZaposliNovogRadnika : Form
    {
        public ZaposliNovogRadnika()
        {
            InitializeComponent();
        }

        private void btnZaposli_Click(object sender, EventArgs e)
        {
            List<string> OIB;
            using (var ctx = new postgresEntities())
            {
                OIB = (from k in ctx.Korisnik
                       select k.OIB).ToList();
            }
            Uloga ulogaid = comboBoxUloge.SelectedItem as Uloga;
            Korisnik noviRadnik = new Korisnik();
            if (textBoxIme.Text != "" && textBoxPrezime.Text != "" && textBoxKorIme.Text != "" && textBoxOIB.Text != "" 
                && textBoxOIB.Text.Length == 11 && textBoxLozinka.Text != "" && textBoxEmail.Text != "" && !OIB.Contains(textBoxOIB.Text))
            {
                noviRadnik.Ime = textBoxIme.Text;
                noviRadnik.Prezime = textBoxPrezime.Text;
                noviRadnik.Kor_ime = textBoxKorIme.Text;
                noviRadnik.Datum_rodenja = datePickerDatumRodenja.Value;
                noviRadnik.OIB = textBoxOIB.Text;
                noviRadnik.Lozinka = textBoxLozinka.Text;
                noviRadnik.ulogaID = ulogaid.ulogaID;
                noviRadnik.Zaposlen = checkBoxZaposlen.Checked;
                noviRadnik.Email = textBoxEmail.Text;
                noviRadnik.cijenaID = int.Parse(comboBox1.SelectedItem.ToString());

                using (var ctx = new postgresEntities())
                {
                    ctx.Korisnik.Add(noviRadnik);
                    ctx.SaveChanges();
                }
                MessageBox.Show("Uspješno zaposlen radnik");
            }
            else
            {
                MessageBox.Show("Niste dobro ispunili formu, molimo provjeriti sve podatke!");
            }
        }

        private void ZaposliNovogRadnika_Load(object sender, EventArgs e)
        {
            List<Uloga> uloge = new List<Uloga>();
            using (var ctx = new postgresEntities())
            {
                uloge = ctx.Uloga.ToList();
            }

            comboBoxUloge.DataSource =uloge;
            comboBoxUloge.DisplayMember = "Ime";
        }

        private void comboBoxUloge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUloge.SelectedIndex == 1)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }
        }
    }
}
