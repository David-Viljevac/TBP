using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TBP_Projekt_Entity
{
    public partial class ObracunPlace : Form
    {
        List<Korisnik> korisnici;
        List<int> korisniciZaObracun;
        List<Radno_vrijeme> radnaVremena;
        double cijena;
        int korisnikOdabrani;
        public ObracunPlace()
        {
            
            InitializeComponent();
        }

        private void ObracunPlace_Load(object sender, EventArgs e)
        {
            
            using (var ctx = new postgresEntities())
            {
                korisnici = ctx.Korisnik.ToList();
                korisniciZaObracun = (from k in ctx.Korisnik
                                      join r in ctx.Radno_vrijeme on k.korisnikID equals r.korisnikID
                                      select k.korisnikID).Distinct().ToList();
                radnaVremena = ctx.Radno_vrijeme.ToList();
                
            }
            comboBoxOdabirRadnika.DataSource = korisniciZaObracun;
            dgvPopisRadnihDana.DataSource = radnaVremena;
            dgvPopisRadnihDana.Columns[6].Visible = false;
        }

        private void comboBoxOdabirRadnika_SelectedIndexChanged(object sender, EventArgs e)
        {
            korisnikOdabrani = int.Parse(comboBoxOdabirRadnika.SelectedItem.ToString());
            dgvPopisRadnihDana.DataSource = radnaVremena.FindAll(x => x.korisnikID == korisnikOdabrani);
            Console.WriteLine(korisnikOdabrani);
        }

        private void btnObracunajPlacu_Click(object sender, EventArgs e)
        {
            using (var ctx = new postgresEntities())
            {
                List<double> korisnikCijena;
                korisnikCijena =  (from k in ctx.Korisnik
                                   from c in ctx.Cijena_rada
                                  where k.korisnikID == korisnikOdabrani && k.cijenaID == c.cijenaID
                                  select c.Redovna).ToList();
                cijena = korisnikCijena.First();
                DateTime? pocetakMjeseca = new DateTime(2200, 12, 12);
                DateTime? krajMjeseca = new DateTime(1900, 12, 12);
                Placa placa = new Placa();
                placa.korisnikID = korisnikOdabrani;
                foreach (var item in radnaVremena)
                {
                    if (item.korisnikID == korisnikOdabrani)
                    {
                        placa.Ukupan_Iznos += item.Trajanje_rada.Value.Hours * cijena;
                        if (item.Datum_rada <= pocetakMjeseca)
                        {
                            pocetakMjeseca = item.Datum_rada;
                        }
                        if (item.Datum_rada >= krajMjeseca)
                        {
                            krajMjeseca = item.Datum_rada;
                        }
                        ctx.Radno_vrijeme.Attach(item);
                        ctx.Radno_vrijeme.Remove(item);
                    }
                    
                }
                
                placa.Pocetak_mjeseca = DateTime.Parse(pocetakMjeseca.ToString());
                placa.Kraj_mjeseca = DateTime.Parse(krajMjeseca.ToString());
                ctx.Placa.Add(placa);
                ctx.SaveChanges();
            }
            using (var ctx = new postgresEntities())
            {
                korisnici = ctx.Korisnik.ToList();
                korisniciZaObracun = (from k in ctx.Korisnik
                                      join r in ctx.Radno_vrijeme on k.korisnikID equals r.korisnikID
                                      select k.korisnikID).Distinct().ToList();
                radnaVremena = ctx.Radno_vrijeme.ToList();

            }
            comboBoxOdabirRadnika.DataSource = korisniciZaObracun;
            dgvPopisRadnihDana.DataSource = radnaVremena;
            dgvPopisRadnihDana.Columns[6].Visible = false;
        }
    }
}
