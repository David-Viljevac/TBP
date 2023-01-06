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
    
    public partial class EmpMngmt : Form
    {
        public EmpMngmt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Korisnik> korisnici;
            using( var ctx = new postgresEntities())
            {
                korisnici = ctx.Korisnik.ToList();
                dgvZaposlenici.DataSource = korisnici;
                dgvZaposlenici.Columns[11].Visible = false;
                dgvZaposlenici.Columns[12].Visible = false;
                dgvZaposlenici.Columns[13].Visible = false;
                dgvZaposlenici.Columns[14].Visible = false;
                dgvZaposlenici.Columns[15].Visible = false;
            }   
        }

        private void btnOtkaz_Click(object sender, EventArgs e)
        {   
            using (var ctx = new postgresEntities())
            {
                ctx.Korisnik.Attach(dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik);
                DajOtkaz(dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik);
                ctx.SaveChanges();
            }
            
        }

        private void DajOtkaz(Korisnik korisnik)
        {
            
            korisnik.Zaposlen = false;

        }

        private void btnObracunPlace_Click(object sender, EventArgs e)
        {
            ObracunPlace form = new ObracunPlace();
            form.ShowDialog();
        }

        private void btnZaposliNovogRadnika_Click(object sender, EventArgs e)
        {
            ZaposliNovogRadnika form = new ZaposliNovogRadnika();
            form.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPromijeniMail_Click(object sender, EventArgs e)
        {
            Korisnik odabrani = new Korisnik();
            odabrani = dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik;
            EmailChange form = new EmailChange(odabrani);
            form.ShowDialog();
        }
    }
}
