using Apoteka.EFKlase;
using Apoteka.Forme;
using Apoteka.Podrska;
using LanacApoteka.Podrska;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apoteka
{
    public partial class AdminForma : Form
    {
        private zaposleni prijavljenZaposleni;
        private zaposleni odabraniZaposleni;
        private LoginForma loginForma;
        private int idOdabranogZaposlenog;
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public AdminForma(LoginForma lf, zaposleni zap)
        {
            InitializeComponent();
            loginForma = lf;
            prijavljenZaposleni = zap;
            PodesiDugmad();
        }

        private void AdminForma_Load(object sender, EventArgs e)
        {
            tsslPrijavljenZaposleni.Text = "Prijavljen: " + prijavljenZaposleni.ime + " " + prijavljenZaposleni.prezime;
            tsmiMojNalog.Text = "Moj &nalog(" + prijavljenZaposleni.korisnickoIme + ")";
            btnOcistiPoljaPretrage.PerformClick();
            PopuniComboBoxMjesta();
            DodajAdminStavkuUComboBox(true);
            dgvZaposleni.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            new ToolTip().SetToolTip(this.btnOcistiPoljaPretrage, "Očistiti polja pretrage");
            OmoguciPoljaZaUnosZaposlenog(false);
            dgvZaposleni.Select();
            SendMessage(tbImePretraga.Handle, EM_SETCUEBANNER, 0, "Ime");
            SendMessage(tbPrezimePretraga.Handle, EM_SETCUEBANNER, 0, "Prezime");
            SendMessage(tbKorisnickoImePretraga.Handle, EM_SETCUEBANNER, 0, "Korisničko ime");
        }

        private void AdminForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                MessageBoxManager.Unregister();
                Application.Exit();
            }
        }

        private void tsmiOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBoxManager.Unregister();
            loginForma.PodesiDugmad(prijavljenZaposleni);
            loginForma.Show();
        }

        private void PopuniTabeluPretrazivanjem(bool pretrazivanjeZaposlenih, bool ukljuciStatusAktivan)
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    if (!pretrazivanjeZaposlenih)
                    {
                        var zaposleni = (from z in context.zaposlenis
                                         where z.obrisano == false
                                         orderby z.prezime
                                         select z).ToList();
                        PopuniTabeluZaposlenih(zaposleni);
                    }
                    else
                    {
                        if (ukljuciStatusAktivan)
                        {
                            string imePretraga = tbImePretraga.Text.Trim();
                            string prezimePretraga = tbPrezimePretraga.Text.Trim();
                            string korisnickoImePretraga = tbKorisnickoImePretraga.Text.Trim();
                            bool aktivanPretraga = cbAktivanPretraga.Checked;
                            var zaposleni = (from z in context.zaposlenis
                                             where z.obrisano == false &&
                                             z.ime.StartsWith(imePretraga) &&
                                             z.prezime.StartsWith(prezimePretraga) &&
                                             z.korisnickoIme.StartsWith(korisnickoImePretraga) &&
                                             z.aktivan == aktivanPretraga
                                             orderby z.prezime
                                             select z).ToList();
                            PopuniTabeluZaposlenih(zaposleni);
                        }
                        else
                        {
                            string imePretraga = tbImePretraga.Text.Trim();
                            string prezimePretraga = tbPrezimePretraga.Text.Trim();
                            string korisnickoImePretraga = tbKorisnickoImePretraga.Text.Trim();
                            bool aktivanPretraga = cbAktivanPretraga.Checked;
                            var zaposleni = (from z in context.zaposlenis
                                             where z.obrisano == false &&
                                             z.ime.StartsWith(imePretraga) &&
                                             z.prezime.StartsWith(prezimePretraga) &&
                                             z.korisnickoIme.StartsWith(korisnickoImePretraga)
                                             orderby z.prezime
                                             select z).ToList();
                            PopuniTabeluZaposlenih(zaposleni);
                        }
                    }
                    PostaviRedneBrojeveUTabeli(dgvZaposleni);
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PopuniTabeluZaposlenih(List<zaposleni> zaposleni)
        {
            dgvZaposleni.Rows.Clear();
            foreach (var zp in zaposleni)
            {
                DataGridViewRow r = new DataGridViewRow()
                {
                    Tag = zp
                };
                r.CreateCells(dgvZaposleni);
                r.SetValues(zp.ime, zp.prezime, zp.korisnickoIme, zp.aktivan);
                dgvZaposleni.Rows.Add(r);
                if (zp.idZaposlenog == idOdabranogZaposlenog)
                {
                    r.Selected = true;
                }
            }
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

        private void DodajAdminStavkuUComboBox(bool dodaj)
        {
            if (dodaj)
            {
                cbUloga.Items.Insert(2, "administrator");
            }
            else
            {
                cbUloga.Items.RemoveAt(2);
            }
        }

        private void TimerTrenutnoVrijeme_Tick(object sender, EventArgs e)
        {
            tsslDatumVrijeme.Text = DateTime.Today.ToString("d.M.yyyy") + " " + DateTime.Now.ToString("H:mm");
        }

        private void PostaviRedneBrojeveUTabeli(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1) + ".";
            }
        }

        private void dgvZaposleni_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvZaposleni.SelectedRows.Count == 1)
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        odabraniZaposleni = (zaposleni)dgvZaposleni.SelectedRows[0].Tag;
                        zaposleni zap = (from zp in context.zaposlenis
                                         where zp.idZaposlenog == odabraniZaposleni.idZaposlenog &&
                                         zp.obrisano == false
                                         select zp).FirstOrDefault();
                        if (zap.uloga == 10)
                        {
                            cbUloga.SelectedIndex = 2;
                        }
                        else if (zap.uloga == 2)
                        {
                            cbUloga.SelectedIndex = 1;
                        }
                        else
                        {
                            cbUloga.SelectedIndex = 0;
                        }
                        mtbJmbg.Text = zap.jmbg;
                        tbIme.Text = zap.ime;
                        tbPrezime.Text = zap.prezime;
                        tbAdresa.Text = zap.adresa;
                        cbMjesto.SelectedItem = zap.mjesto;
                        tbTelefon.Text = zap.telefon;
                        tbEmail.Text = zap.email;
                        tbStrucnaSprema.Text = zap.strucnaSprema;
                        tbFarmaceutskoZvanje.Text = zap.farmaceutskoZvanje;
                        tbOpisPosla.Text = zap.opisPosla;
                        cbSefApoteke.Checked = zap.sefApoteke;
                    }
                    if (odabraniZaposleni != null)
                    {
                        if (odabraniZaposleni.uloga == 10)
                        {
                            tsmiIzmjenitiZaposlenog.Enabled = true;
                            tsmiAktiviratiDeaktiviratiZaposlenog.Enabled = tsmiObrisatiZaposlenog.Enabled = false;
                        }
                        else
                        {
                            tsmiIzmjenitiZaposlenog.Enabled = tsmiAktiviratiDeaktiviratiZaposlenog.Enabled = tsmiObrisatiZaposlenog.Enabled = true;
                        }
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiIzmjenitiZaposlenog_Click(object sender, EventArgs e)
        {
            OmoguciPoljaZaUnosZaposlenog(true);
            mtbJmbg.Focus();
            tsmiDodatiZaposlenog.Enabled = false;
            if (odabraniZaposleni.uloga == 10)
            {
                cbUloga.Enabled = false;
            }
            else
            {
                DodajAdminStavkuUComboBox(false);
            }
        }

        private void btnOcistiPoljaPretrage_Click(object sender, EventArgs e)
        {
            tbImePretraga.Text = "";
            tbPrezimePretraga.Text = "";
            tbKorisnickoImePretraga.Text = "";
            cbAktivanPretraga.Checked = false;
            SendMessage(tbImePretraga.Handle, EM_SETCUEBANNER, 0, "Ime");
            SendMessage(tbPrezimePretraga.Handle, EM_SETCUEBANNER, 0, "Prezime");
            SendMessage(tbKorisnickoImePretraga.Handle, EM_SETCUEBANNER, 0, "Korisničko ime");
            PopuniTabeluPretrazivanjem(false, false);
            dgvZaposleni.ClearSelection();
            dgvZaposleni.Focus();
            mtbJmbg.Text = "";
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbAdresa.Text = "";
            cbMjesto.SelectedItem = null;
            cbUloga.SelectedItem = null;
            tbTelefon.Text = "";
            tbEmail.Text = "";
            tbStrucnaSprema.Text = "";
            tbFarmaceutskoZvanje.Text = "";
            tbOpisPosla.Text = "";
            cbSefApoteke.Checked = false;
            tsmiIzmjenitiZaposlenog.Enabled = tsmiAktiviratiDeaktiviratiZaposlenog.Enabled = tsmiObrisatiZaposlenog.Enabled = false;
        }

        private void dgvZaposleni_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tsmiIzmjenitiZaposlenog.PerformClick();
            }
        }

        private void btnSacuvati_Click(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(tbStrucnaSprema.Text.Trim()))
            {
                poruka += "Stručna sprema nije unijeta.\n";
            }

            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    var zap = (from z in context.zaposlenis
                               select z).ToList();
                    foreach (zaposleni zp in zap)
                    {
                        if (zp.jmbg.Equals(mtbJmbg.Text) && zp.idZaposlenog != odabraniZaposleni.idZaposlenog)
                        {
                            poruka += "Postoji zaposleni sa unesenim JMBG.\n";
                            break;
                        }
                    }

                    if (string.IsNullOrEmpty(poruka))
                    {
                        odabraniZaposleni = (from z in context.zaposlenis
                                             where z.idZaposlenog == odabraniZaposleni.idZaposlenog
                                             select z).FirstOrDefault();
                        if (cbUloga.Enabled)
                        {
                            if (cbUloga.SelectedItem.Equals("menadzer"))
                            {
                                odabraniZaposleni.uloga = 2;
                            }
                            else
                            {
                                odabraniZaposleni.uloga = 1;
                            }
                        }
                        odabraniZaposleni.jmbg = mtbJmbg.Text;
                        odabraniZaposleni.ime = tbIme.Text.Trim();
                        odabraniZaposleni.prezime = tbPrezime.Text.Trim();
                        odabraniZaposleni.adresa = tbAdresa.Text.Trim();
                        odabraniZaposleni.idMjesta = ((mjesto)cbMjesto.SelectedItem).idMjesta;
                        odabraniZaposleni.telefon = tbTelefon.Text.Trim();
                        odabraniZaposleni.email = tbEmail.Text.Trim();
                        odabraniZaposleni.strucnaSprema = tbStrucnaSprema.Text.Trim();
                        odabraniZaposleni.farmaceutskoZvanje = tbFarmaceutskoZvanje.Text.Trim();
                        odabraniZaposleni.opisPosla = tbOpisPosla.Text.Trim();
                        odabraniZaposleni.sefApoteke = cbSefApoteke.Checked;
                        context.SaveChanges();
                        idOdabranogZaposlenog = odabraniZaposleni.idZaposlenog;
                        PopuniTabeluPretrazivanjem(false, false);
                        OmoguciPoljaZaUnosZaposlenog(false);
                        dgvZaposleni.Focus();
                        tsmiDodatiZaposlenog.Enabled = true;
                        if (odabraniZaposleni.uloga != 10)
                            DodajAdminStavkuUComboBox(true);
                        tsslStatusnaLabela.Text = "Podaci o zaposlenom su izmjenjeni.";
                    }
                    else
                    {
                        MessageBox.Show(poruka, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdustati_Click(object sender, EventArgs e)
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    odabraniZaposleni = (zaposleni)dgvZaposleni.SelectedRows[0].Tag;
                    zaposleni zap = (from zp in context.zaposlenis
                                     where zp.jmbg == odabraniZaposleni.jmbg &&
                                     zp.obrisano == false
                                     select zp).FirstOrDefault();
                    tbIme.Text = zap.ime;
                    tbPrezime.Text = zap.prezime;
                    tbAdresa.Text = zap.adresa;
                    cbMjesto.SelectedItem = zap.mjesto;
                    tbTelefon.Text = zap.telefon;
                    tbEmail.Text = zap.email;
                    tbStrucnaSprema.Text = zap.strucnaSprema;
                    tbFarmaceutskoZvanje.Text = zap.farmaceutskoZvanje;
                    tbOpisPosla.Text = zap.opisPosla;
                    cbSefApoteke.Checked = zap.sefApoteke;
                    idOdabranogZaposlenog = odabraniZaposleni.idZaposlenog;
                    PopuniTabeluPretrazivanjem(false, false);
                    OmoguciPoljaZaUnosZaposlenog(false);
                    dgvZaposleni.Focus();
                    if (odabraniZaposleni.uloga != 10)
                        DodajAdminStavkuUComboBox(true);
                    tsmiDodatiZaposlenog.Enabled = true;
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OmoguciPoljaZaUnosZaposlenog(bool omoguceno)
        {
            if (omoguceno)
            {
                foreach (Control cont in gbPodaciZaposlenog.Controls)
                {
                    if (cont is TextBox)
                    {
                        ((TextBox)cont).ReadOnly = false;
                        ((TextBox)cont).BackColor = SystemColors.Window;
                    }
                    else if (cont is MaskedTextBox)
                    {
                        ((MaskedTextBox)cont).ReadOnly = false;
                        ((MaskedTextBox)cont).BackColor = SystemColors.Window;
                    }
                    else if (cont is Button)
                    {
                        ((Button)cont).Enabled = true;
                    }
                    else if (cont is ComboBox)
                    {
                        ((ComboBox)cont).Enabled = true;
                        ((ComboBox)cont).BackColor = SystemColors.Window;
                    }
                    else if (cont is CheckBox)
                    {
                        ((CheckBox)cont).Enabled = true;
                        ((CheckBox)cont).BackColor = SystemColors.Window;
                    }
                }

                foreach (Control cont in gbPretragaZaposlenog.Controls)
                {
                    if (cont is TextBox)
                    {
                        ((TextBox)cont).ReadOnly = true;
                        ((TextBox)cont).BackColor = SystemColors.Control;
                    }
                    else if (cont is Button)
                    {
                        ((Button)cont).Enabled = false;
                    }
                    else if (cont is DataGridView)
                    {
                        ((DataGridView)cont).Enabled = false;
                    }
                    else if (cont is CheckBox)
                    {
                        ((CheckBox)cont).Enabled = false;
                        ((CheckBox)cont).BackColor = SystemColors.Control;
                    }
                }
            }
            else
            {
                foreach (Control cont in gbPodaciZaposlenog.Controls)
                {
                    if (cont is TextBox)
                    {
                        ((TextBox)cont).ReadOnly = true;
                        ((TextBox)cont).BackColor = SystemColors.Control;
                    }
                    else if (cont is MaskedTextBox)
                    {
                        ((MaskedTextBox)cont).ReadOnly = true;
                        ((MaskedTextBox)cont).BackColor = SystemColors.Control;
                    }
                    else if (cont is Button)
                    {
                        ((Button)cont).Enabled = false;
                    }
                    else if (cont is ComboBox)
                    {
                        ((ComboBox)cont).Enabled = false;
                        ((ComboBox)cont).BackColor = SystemColors.Control;
                    }
                    else if (cont is CheckBox)
                    {
                        ((CheckBox)cont).Enabled = false;
                        ((CheckBox)cont).BackColor = SystemColors.Control;
                    }
                }

                foreach (Control cont in gbPretragaZaposlenog.Controls)
                {
                    if (cont is TextBox)
                    {
                        ((TextBox)cont).ReadOnly = false;
                        ((TextBox)cont).BackColor = SystemColors.Window;
                    }
                    else if (cont is Button)
                    {
                        ((Button)cont).Enabled = true;
                    }
                    else if (cont is DataGridView)
                    {
                        ((DataGridView)cont).Enabled = true;
                    }
                    else if (cont is CheckBox)
                    {
                        ((CheckBox)cont).Enabled = true;
                        ((CheckBox)cont).BackColor = SystemColors.Window;
                    }
                }
            }
        }

        private void tsmiAktiviratiDeaktiviratiZaposlenog_Click(object sender, EventArgs e)
        {
            string poruka = "";
            if (odabraniZaposleni.aktivan)
                poruka = "Da li želite deaktivirati zaposlenog " + odabraniZaposleni.ime + " " + odabraniZaposleni.prezime + "?";
            else
                poruka = "Da li želite aktivirati zaposlenog " + odabraniZaposleni.ime + " " + odabraniZaposleni.prezime + "?";

            if (DialogResult.Yes == MessageBox.Show(poruka, "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        odabraniZaposleni = (from z in context.zaposlenis
                                             where z.idZaposlenog == odabraniZaposleni.idZaposlenog
                                             select z).FirstOrDefault();
                        if (odabraniZaposleni.aktivan)
                            odabraniZaposleni.aktivan = false;
                        else
                            odabraniZaposleni.aktivan = true;
                        context.SaveChanges();
                        idOdabranogZaposlenog = odabraniZaposleni.idZaposlenog;
                        PopuniTabeluPretrazivanjem(false, false);
                        if (!odabraniZaposleni.aktivan)
                            tsslStatusnaLabela.Text = "Nalog zaposlenog " + odabraniZaposleni.ime + " " + odabraniZaposleni.prezime + " je deaktiviran.";
                        else
                            tsslStatusnaLabela.Text = "Nalog zaposlenog " + odabraniZaposleni.ime + " " + odabraniZaposleni.prezime + " je ponovo aktivan.";
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiObrisatiZaposlenog_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Da li želite obrisati zaposlenog " + odabraniZaposleni.ime + " " + odabraniZaposleni.prezime + "?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        odabraniZaposleni = (from z in context.zaposlenis
                                             where z.idZaposlenog == odabraniZaposleni.idZaposlenog
                                             select z).FirstOrDefault();
                        odabraniZaposleni.obrisano = true;
                        context.SaveChanges();
                        odabraniZaposleni = null;
                        tsslStatusnaLabela.Text = "Nalog zaposlenog je uspješno obrisan.";
                        btnOcistiPoljaPretrage.PerformClick();
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmsTabelaZaposleni_Opening(object sender, CancelEventArgs e)
        {
            if (odabraniZaposleni.aktivan)
                tsmiAktiviratiDeaktiviratiZaposlenog.Text = "Deaktivirati nalog";
            else
                tsmiAktiviratiDeaktiviratiZaposlenog.Text = "Aktivirati nalog";
        }

        private void cbAktivanPretraga_CheckedChanged(object sender, EventArgs e)
        {
            PopuniTabeluPretrazivanjem(true, true);
        }

        private void tbImePretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniTabeluPretrazivanjem(true, false);
        }

        private void tbPrezimePretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniTabeluPretrazivanjem(true, false);
        }

        private void tbKorisnickoImePretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniTabeluPretrazivanjem(true, false);
        }

        private void tsmiDodatiZaposlenog_Click(object sender, EventArgs e)
        {
            UnosZaposlenogForma noviZaposleni = new UnosZaposlenogForma(tsslStatusnaLabela, dgvZaposleni);
            noviZaposleni.ShowDialog();
        }

        private void tsmiDodatiMjesto_Click(object sender, EventArgs e)
        {
            MjestoForma novoMjesto = new MjestoForma();
            novoMjesto.Text = "Unos mjesta";
            if (DialogResult.OK == novoMjesto.ShowDialog())
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        var m = new mjesto()
                        {
                            brojPoste = novoMjesto.BrojPoste,
                            naziv = novoMjesto.Naziv,
                            drzava = novoMjesto.Drzava
                        };
                        context.mjestoes.Add(m);
                        context.SaveChanges();
                        cbMjesto.Items.Clear();
                        PopuniComboBoxMjesta();
                    }
                    tsslStatusnaLabela.Text = "Uspješno unijeto novo mjesto.";
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiPregledMjesta_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Unregister();
            PregledMjestaForma pregledMjesta = new PregledMjestaForma(this, tsslStatusnaLabela);
            pregledMjesta.ShowDialog();
        }

        public void PodesiDugmad()
        {
            MessageBoxManager.OK = "OK";
            MessageBoxManager.Cancel = "Otkazati";
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Abort = "Prekinuti";
            MessageBoxManager.Ignore = "Ignorisati";
            MessageBoxManager.Retry = "Ponoviti";
            MessageBoxManager.Register();
        }

        private void tsmiInformacijeOApoteci_Click(object sender, EventArgs e)
        {
            new InformacijeOApoteciForma(tsmiInformacijeOApoteci, tsslStatusnaLabela, true).Show();
            tsmiInformacijeOApoteci.Enabled = false;
        }

        private void tsmiPromjenitiLozinku_Click(object sender, EventArgs e)
        {
            PromjenaLozinkeForma plForma = new PromjenaLozinkeForma(prijavljenZaposleni);
            if (DialogResult.OK == plForma.ShowDialog())
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        prijavljenZaposleni = (from z in context.zaposlenis
                                               where z.idZaposlenog == prijavljenZaposleni.idZaposlenog
                                               select z).FirstOrDefault();
                        prijavljenZaposleni.lozinka = Enkripcija.enkriptujLozinku(plForma.Lozinka);
                        context.SaveChanges();
                        tsslStatusnaLabela.Text = "Lozinka uspješno promjenjena.";
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiInformacijeOAplikaciji_Click(object sender, EventArgs e)
        {
            new OAplikacijiForma().ShowDialog();
        }
    }
}
