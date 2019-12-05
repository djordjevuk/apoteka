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
    public partial class UnosZaposlenogForma : Form
    {
        private bool unosSacuvan;
        ToolStripStatusLabel statusnaLabela;
        List<zaposleni> listaZaposlenih;
        DataGridView tabelaZaposlenih;

        public UnosZaposlenogForma(ToolStripStatusLabel sLabela, DataGridView tabelaZaposlenih)
        {
            InitializeComponent();
            this.unosSacuvan = false;
            this.statusnaLabela = sLabela;
            this.tabelaZaposlenih = tabelaZaposlenih;
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    listaZaposlenih = (from z in context.zaposlenis
                                       select z).ToList();
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnosZaposlenogForma_Load(object sender, EventArgs e)
        {
            PopuniComboBoxMjesta();
            mtbJmbg.Select();
        }

        private void PopuniComboBoxMjesta()
        {
            try
            {
                cbMjesto.Items.Clear();
                using (ApotekaDb context = new ApotekaDb())
                {
                    var mjesta = (from m in context.mjestoes
                                  where m.obrisano == false
                                  select m).ToArray();
                    cbMjesto.Items.AddRange(mjesta);
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnosZaposlenogForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unosSacuvan)
            {
                string poruka = "";
                if (string.IsNullOrEmpty(mtbJmbg.Text.Trim()))
                {
                    poruka += "JMBG nije unijet.\n";
                }
                if (mtbJmbg.Text.Length < 13 || mtbJmbg.Text.Contains(" "))
                {
                    poruka += "JMBG mora sadržavati 13 cifara.\n";
                }
                if (string.IsNullOrEmpty(tbIme.Text.Trim()))
                {
                    poruka += "Ime nije unijeto.\n";
                }
                if (string.IsNullOrEmpty(tbPrezime.Text.Trim()))
                {
                    poruka += "Prezime nije unijeto.\n";
                }
                if (string.IsNullOrEmpty(tbAdresa.Text.Trim()))
                {
                    poruka += "Adresa nije unijeta.\n";
                }
                if (cbMjesto.SelectedItem == null)
                {
                    poruka += "Mjesto nije izabrato.\n";
                }
                if (cbUloga.SelectedItem == null)
                {
                    poruka += "Uloga zaposlenog nije izabrata.\n";
                }
                if (string.IsNullOrEmpty(tbStrucnaSprema.Text.Trim()))
                {
                    poruka += "Stručna sprema nije unijeta.\n";
                }
                if (string.IsNullOrEmpty(tbKorisnickoIme.Text.Trim()))
                {
                    poruka += "Korisničko ime nije unijeto.\n";
                }
                if (string.IsNullOrEmpty(tbLozinka.Text.Trim()))
                {
                    poruka += "Lozinka nije unijeta.\n";
                }
                if (string.IsNullOrEmpty(tbPonovljenaLozinka.Text.Trim()))
                {
                    poruka += "Ponovljena lozinka nije unijeta.\n";
                }
                if (!string.IsNullOrEmpty(tbLozinka.Text.Trim()) && !string.IsNullOrEmpty(tbPonovljenaLozinka.Text.Trim()))
                    if (!(tbLozinka.Text.Trim()).Equals(tbPonovljenaLozinka.Text.Trim()))
                    {
                        poruka += "Lozinke se ne poklapaju.\n";
                    }
                foreach (zaposleni zp in listaZaposlenih)
                {
                    if (zp.jmbg.Equals(mtbJmbg.Text))
                    {
                        poruka += "Postoji zaposleni sa unesenim JMBG.\n";
                        break;
                    }
                }

                foreach (zaposleni zp in listaZaposlenih)
                {
                    if (zp.korisnickoIme.Equals(tbKorisnickoIme.Text.Trim()))
                    {
                        poruka += "Postoji zaposleni sa unesenim korisničkim imenom.\n";
                        break;
                    }
                }
                if (string.IsNullOrEmpty(poruka))
                {
                    try
                    {
                        using (ApotekaDb context = new ApotekaDb())
                        {
                            int ulogaZap = 1;
                            if (cbUloga.SelectedItem.Equals("menadzer"))
                            {
                                ulogaZap = 2;
                            }
                            var z = new zaposleni()
                            {
                                jmbg = mtbJmbg.Text.Trim(),
                                ime = tbIme.Text.Trim(),
                                prezime = tbPrezime.Text.Trim(),
                                adresa = tbAdresa.Text.Trim(),
                                idMjesta = ((mjesto)cbMjesto.SelectedItem).idMjesta,
                                telefon = tbTelefon.Text.Trim(),
                                email = tbEmail.Text.Trim(),
                                strucnaSprema = tbStrucnaSprema.Text.Trim(),
                                farmaceutskoZvanje = tbFarmaceutskoZvanje.Text.Trim(),
                                sefApoteke = cbSefApoteke.Checked,
                                opisPosla = tbOpisPosla.Text.Trim(),
                                korisnickoIme = tbKorisnickoIme.Text.Trim(),
                                lozinka = Enkripcija.enkriptujLozinku(tbLozinka.Text.Trim()),
                                uloga = ulogaZap,
                                aktivan = true
                            };
                            context.zaposlenis.Add(z);
                            context.SaveChanges();
                            statusnaLabela.Text = "Uspješno unijet novi zaposleni.";
                            listaZaposlenih = (from zap in context.zaposlenis
                                               where zap.obrisano == false
                                               orderby zap.prezime
                                               select zap).ToList();
                            PopuniTabeluZaposlenih(listaZaposlenih);
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
                    e.Cancel = true;
                    MessageBox.Show(poruka, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                unosSacuvan = false;
            }
        }

        private void btnSacuvati_Click(object sender, EventArgs e)
        {
            unosSacuvan = true;
            this.Close();
        }

        private void btnOdustati_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopuniTabeluZaposlenih(List<zaposleni> zaposleni)
        {
            tabelaZaposlenih.Rows.Clear();
            foreach (var zp in zaposleni)
            {
                DataGridViewRow r = new DataGridViewRow()
                {
                    Tag = zp
                };
                r.CreateCells(tabelaZaposlenih);
                r.SetValues(zp.ime, zp.prezime, zp.korisnickoIme, zp.aktivan);
                tabelaZaposlenih.Rows.Add(r);
            }
            PostaviRedneBrojeveUTabeli();
        }

        private void PostaviRedneBrojeveUTabeli()
        {
            foreach (DataGridViewRow row in tabelaZaposlenih.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1) + ".";
            }

        }
    }
}

