using Apoteka.EFKlase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apoteka.Forme
{
    public partial class MjestoForma : Form
    {
        private int idMjesta;
        private int brojPoste;
        private string naziv;
        private string drzava;
        private bool unosSacuvan;
        private List<mjesto> mjesta;

        public int IdMjesta { get => idMjesta; set => idMjesta = value; }
        public int BrojPoste { get => brojPoste; set => brojPoste = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Drzava { get => drzava; set => drzava = value; }

        public MjestoForma()
        {
            InitializeComponent();
            this.unosSacuvan = false;
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    mjesta = (from c in context.mjestoes
                              select c).ToList();
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MjestoForma_Load(object sender, EventArgs e)
        {
            tbNazivMjesta.Text = Naziv;
            tbDrzava.Text = drzava;
            if (brojPoste != 0)
                mtbPostanskiBroj.Text = BrojPoste.ToString();
        }

        private void DodavanjeMjestaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unosSacuvan)
            {
                string poruka = "";
                int brojPosteVr = 0;
                if (string.IsNullOrEmpty(mtbPostanskiBroj.Text.Trim()))
                {
                    poruka += "Poštanski broj nije unijet.\n";
                }
                else if (!int.TryParse(mtbPostanskiBroj.Text.Trim(), out brojPosteVr))
                {
                    poruka += "Poštanski broj nije validan.\n";
                }
                if (string.IsNullOrEmpty(tbNazivMjesta.Text.Trim()))
                {
                    poruka += "Naziv mjesta nije unijet.\n";
                }
                if (string.IsNullOrEmpty(tbDrzava.Text.Trim()))
                {
                    poruka += "Naziv države nije unijet.\n";
                }

                foreach (mjesto m in mjesta)
                {
                    if (m.brojPoste == brojPosteVr && m.idMjesta != idMjesta)
                    {
                        poruka += "Postoji mjesto sa unesenim poštanskim brojem.\n";
                        break;
                    }
                }

                if (string.IsNullOrEmpty(poruka))
                {
                    BrojPoste = brojPosteVr;
                    Naziv = tbNazivMjesta.Text.Trim();
                    drzava = tbDrzava.Text.Trim();
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show(poruka, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                unosSacuvan = false;
            }
        }

        private void btnSacuvati_Click(object sender, EventArgs e)
        {
            unosSacuvan = true;
        }
    }
}
