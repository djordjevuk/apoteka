using Apoteka.EFKlase;
using Apoteka.Podrska;
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
    public partial class PromjenaLozinkeForma : Form
    {
        private bool unosSacuvan;
        private string lozinka;
        private zaposleni prijavljenZaposlen;

        public string Lozinka { get => lozinka; set => lozinka = value; }

        public PromjenaLozinkeForma(zaposleni z)
        {
            InitializeComponent();
            this.unosSacuvan = false;
            this.prijavljenZaposlen = z;
        }

        private void PromjenaLozinkeForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unosSacuvan)
            {
                string poruka = "";
                if (string.IsNullOrEmpty(tbStaraLozinka.Text.Trim()))
                {
                    poruka += "Stara lozinka nije unijeta.\n";
                }
                if (string.IsNullOrEmpty(tbLozinka.Text.Trim()))
                {
                    poruka += "Nova lozinka nije unijeta.\n";
                }
                if (string.IsNullOrEmpty(tbPonovljenaLozinka.Text.Trim()))
                {
                    poruka += "Nova lozinka nije ponovo unijeta.\n";
                }
                if (!string.IsNullOrEmpty(tbLozinka.Text.Trim()))
                {
                    if (!prijavljenZaposlen.lozinka.Equals(Enkripcija.enkriptujLozinku(tbStaraLozinka.Text)))
                        poruka += "Stara lozinka je pogrešna.\n";
                }
                if (!string.IsNullOrEmpty(tbPonovljenaLozinka.Text) && !string.IsNullOrEmpty(tbLozinka.Text) && !tbLozinka.Text.Equals(tbPonovljenaLozinka.Text))
                {
                    poruka += "Ponovljena lozinka se ne poklapa sa unosom nove.\n";
                }

                if (string.IsNullOrEmpty(poruka))
                {
                    Lozinka = tbLozinka.Text;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show(poruka, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                unosSacuvan = false;
            }
        }

        private void btnOdustati_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvati_Click(object sender, EventArgs e)
        {
            unosSacuvan = true;
            this.Close();
        }
    }
}
