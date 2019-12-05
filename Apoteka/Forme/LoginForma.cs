using Apoteka.EFKlase;
using Apoteka.Forme;
using Apoteka.Podrska;
using LanacApoteka.Podrska;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apoteka
{
    public partial class LoginForma : Form
    {
        public LoginForma()
        {
            InitializeComponent();
        }

        private void LoginForma_Load(object sender, EventArgs e)
        {
            PodesiDugmad(null);
            MessageBoxManager.Register();
            cbPrijavitiSeKao.SelectedIndex = 0;
        }

        private void LoginForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxManager.Unregister();
            Application.Exit();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = tbKorisnickoIme.Text;
            string lozinka = tbLozinka.Text;
            if (!string.IsNullOrEmpty(korisnickoIme) && !string.IsNullOrEmpty(lozinka))
            {
                try
                {
                    using (ApotekaDb kontekst = new ApotekaDb())
                    {
                        var zaposleni = (from c in kontekst.zaposlenis
                                         where c.korisnickoIme == korisnickoIme && c.obrisano == false
                                         select c).FirstOrDefault();

                        if (zaposleni != null)
                        {
                            if (zaposleni.aktivan)
                            {
                                if (Enkripcija.enkriptujLozinku(lozinka).Equals(zaposleni.lozinka))
                                {
                                    if (zaposleni.uloga == 10)
                                    {
                                        MessageBoxManager.Unregister();
                                        if (cbPrijavitiSeKao.SelectedIndex == 0)
                                        {
                                            FarmaceutForma kForma = new FarmaceutForma(this, zaposleni);
                                            pbLogin.Image = Properties.Resources.loginUnlock;
                                            pbLogin.Refresh();
                                            Thread.Sleep(500);
                                            this.Hide();
                                            kForma.Show();
                                        }
                                        else if (cbPrijavitiSeKao.SelectedIndex == 1)
                                        {
                                            MenadzerForma mForma = new MenadzerForma(this, zaposleni);
                                            pbLogin.Image = Properties.Resources.loginUnlock;
                                            pbLogin.Refresh();
                                            Thread.Sleep(500);
                                            this.Hide();
                                            mForma.Show();
                                        }
                                        else
                                        {
                                            AdminForma aForma = new AdminForma(this, zaposleni);
                                            pbLogin.Image = Properties.Resources.loginUnlock;
                                            pbLogin.Refresh();
                                            Thread.Sleep(500);
                                            this.Hide();
                                            aForma.Show();
                                        }
                                        tbLozinka.Clear();
                                    }
                                    else if (zaposleni.uloga == 2)
                                    {
                                        if (cbPrijavitiSeKao.SelectedIndex == 0)
                                        {
                                            MessageBox.Show("Ne možete se prijaviti kao farmaceut sa ovim nalogom.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cbPrijavitiSeKao.Select();
                                        }
                                        else if (cbPrijavitiSeKao.SelectedIndex == 2)
                                        {
                                            MessageBox.Show("Ne možete se prijaviti kao administrator sa ovim nalogom.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cbPrijavitiSeKao.Select();
                                        }
                                        else
                                        {
                                            MenadzerForma mForma = new MenadzerForma(this, zaposleni);
                                            pbLogin.Image = Properties.Resources.loginUnlock;
                                            pbLogin.Refresh();
                                            Thread.Sleep(500);
                                            tbLozinka.Clear();
                                            this.Hide();
                                            mForma.Show();
                                        }
                                    }
                                    else if (zaposleni.uloga == 1)
                                    {
                                        if (cbPrijavitiSeKao.SelectedIndex == 1)
                                        {
                                            MessageBox.Show("Ne možete se prijaviti kao menadžer sa ovim nalogom.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cbPrijavitiSeKao.Select();
                                        }
                                        else if (cbPrijavitiSeKao.SelectedIndex == 2)
                                        {
                                            MessageBox.Show("Ne možete se prijaviti kao administrator sa ovim nalogom.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cbPrijavitiSeKao.Select();
                                        }
                                        else
                                        {
                                            FarmaceutForma kForma = new FarmaceutForma(this, zaposleni);
                                            pbLogin.Image = Properties.Resources.loginUnlock;
                                            pbLogin.Refresh();
                                            Thread.Sleep(500);
                                            tbLozinka.Clear();
                                            this.Hide();
                                            kForma.Show();
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Pogrešna lozinka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tbLozinka.Clear();
                                    tbLozinka.Select();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nalog je deaktiviran.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tbKorisnickoIme.Select();
                            }
                        }
                        else
                        {

                            MessageBox.Show("Ne postoji registrovan korisnik sa unesenim korisničkim imenom.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbKorisnickoIme.Select();
                        }
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string poruka = "";
                if ("".Equals(korisnickoIme))
                {
                    poruka += "Korisničko ime nije unijeto.\n";
                    tbKorisnickoIme.Select();
                }
                if ("".Equals(lozinka))
                {
                    if (!"".Equals(korisnickoIme))
                    {
                        tbLozinka.Select();
                    }
                    poruka += "Lozinka nije unijeta.";

                }
                MessageBox.Show(poruka, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PodesiDugmad(zaposleni z)
        {
            pbLogin.Image = Properties.Resources.loginLock;
            MessageBoxManager.OK = "OK";
            MessageBoxManager.Cancel = "Otkazati";
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Abort = "Prekinuti";
            MessageBoxManager.Ignore = "Ignorisati";
            MessageBoxManager.Retry = "Ponoviti";
            MessageBoxManager.Register();
            if (z != null)
                tbKorisnickoIme.Text = z.korisnickoIme;
            tbKorisnickoIme.Select();
        }

        private void LoginForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPrijava.PerformClick();
            }
        }

        private void tbLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            LoginForma_KeyDown(sender, e);
        }

        private void tbKorisnickoIme_KeyDown(object sender, KeyEventArgs e)
        {
            LoginForma_KeyDown(sender, e);
        }

        private void cbPrijavitiSeKao_KeyDown(object sender, KeyEventArgs e)
        {
            LoginForma_KeyDown(sender, e);
        }
    }
}
