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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TBP_Projekt_Entity
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogInInformation logininformation = new LogInInformation();
            logininformation.KorIme = textBoxKorIme.Text;
            logininformation.Lozinka = textBoxLozinka.Text;

            using (var ctx = new postgresEntities())
            {
                var korisnik = ctx.Korisnik.FirstOrDefault(u => u.Kor_ime == logininformation.KorIme);
                if (korisnik != null && korisnik.Lozinka == logininformation.Lozinka && korisnik.Zaposlen == true)
                {
                    logininformation.UlogaID = int.Parse(korisnik.ulogaID.ToString());
                    if (logininformation.UlogaID == 1)
                    {
                        EmpMngmt form = new EmpMngmt();
                        form.ShowDialog();
                    }
                    else if (logininformation.UlogaID == 2)
                    {
                        PrijavaNaPosao form = new PrijavaNaPosao(korisnik.korisnikID);
                        form.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Ne postojece korisnicko ime ili lozinka ili vise niste zaposleni");
                }
            }
        }
    }
}
