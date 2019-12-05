using Apoteka.EFKlase;
using Apoteka.Podrska;
using LanacApoteka.Podrska;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apoteka.Forme
{
    public partial class MenadzerForma : Form
    {
        private zaposleni prijavljenZaposleni;
        private LoginForma loginForma;
        private zaposleni odabraniZaposleni;
        private int idOdabranogZaposlenog;
        private lijek odabraniLijek;
        private int idOdabranogLijeka;
        private dobavljac odabraniDobavljac;
        private int idOdabranogDobavljaca;
        private narudzba odabranaNarudzba;
        private int idOdabraneNarudzbe;
        private racun odabranRacun;
        private stavkaracuna odabranaStavkaRacuna;
        private bool datumVazenjaDozvoleLijekaOdPretraga;
        private bool datumVazenjaDozvoleLijekaDoPretraga;
        private bool datumKreiranjaNarudzbeOdPretraga;
        private bool datumKreiranjaNarudzbeDoPretraga;
        private bool datumKreiranjaRacunaOdPretraga;
        private bool datumKreiranjaRacunaDoPretraga;
        private string fajlIzvjestaj;
        BackgroundWorker bgw = new BackgroundWorker();
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public MenadzerForma(LoginForma lForma, zaposleni zap)
        {
            InitializeComponent();
            this.prijavljenZaposleni = zap;
            this.loginForma = lForma;
            datumVazenjaDozvoleLijekaOdPretraga = false;
            datumVazenjaDozvoleLijekaDoPretraga = false;
            datumKreiranjaNarudzbeOdPretraga = false;
            datumKreiranjaNarudzbeDoPretraga = false;
            datumKreiranjaRacunaOdPretraga = false;
            datumKreiranjaRacunaDoPretraga = false;
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            PodesiDugmad();
        }

        private void MenadzerForma_Load(object sender, EventArgs e)
        {
            tsslPrijavljenZaposleni.Text = "Prijavljen: " + prijavljenZaposleni.ime + " " + prijavljenZaposleni.prezime;
            tsmiMojNalog.Text = "&Moj nalog(" + prijavljenZaposleni.korisnickoIme + ")";
            pnlZaposleniSaTabelom.Hide();
            pnlZaposleniSaListom.Hide();
            pnlDobavljaci.Hide();
            pnlNarudzbe.Hide();
            pnlRacuni.Hide();
            pnlLijekovi.Show();
            btnOcistiPoljaPretrageLijekova.PerformClick();
            OmoguciPoljaNaFormi(false, gbPodaciOLijeku, gbPretragaLijeka);
            dgvLijekovi.Select();
        }

        private void MenadzerForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                MessageBoxManager.Unregister();
                Application.Exit();
            }
        }

        private void tsmiInformacijeOAplikaciji_Click(object sender, EventArgs e)
        {
            new OAplikacijiForma().ShowDialog();
        }

        #region Podešavanja na formi
        private void TimerTrenutnoVrijeme_Tick(object sender, EventArgs e)
        {
            tsslDatumVrijeme.Text = DateTime.Today.ToString("d.M.yyyy") + " " + DateTime.Now.ToString("H:mm");

        }

        private void tsmiInformacijeOApoteci_Click(object sender, EventArgs e)
        {
            new InformacijeOApoteciForma(tsmiInformacijeOApoteci, tsslStatusnaLabela, false).Show();
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

        private void tsmiOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBoxManager.Unregister();
            loginForma.PodesiDugmad(prijavljenZaposleni);
            loginForma.Show();
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

        private void tsmiSaTabelom_Click(object sender, EventArgs e)
        {
            pnlZaposleniSaListom.Hide();
            pnlLijekovi.Hide();
            pnlDobavljaci.Hide();
            pnlNarudzbe.Hide();
            pnlRacuni.Hide();
            pnlZaposleniSaTabelom.Show();
            odabraniZaposleni = null;
            btnOcistiPoljaPretrage.PerformClick();
            dgvZaposleni.ClearSelection();
            dgvZaposleni.Focus();
            tsmiIzmjenitiZaposlenog.Enabled = false;
            PopuniComboBoxMjesta(cbMjesto);
            new ToolTip().SetToolTip(this.btnOcistiPoljaPretrage, "Očistiti polja pretrage");
            OmoguciPoljaNaFormi(false, gbPodaciZaposlenog, gbPretragaZaposlenog);
            SendMessage(tbJmbgPretraga.Handle, EM_SETCUEBANNER, 0, "JMBG");
            SendMessage(tbImePretraga.Handle, EM_SETCUEBANNER, 0, "Ime");
            SendMessage(tbPrezimePretraga.Handle, EM_SETCUEBANNER, 0, "Prezime");
            SendMessage(tbStrucnaSpremaPretraga.Handle, EM_SETCUEBANNER, 0, "Stručna sprema");
        }

        private void tsmiSaListom_Click(object sender, EventArgs e)
        {
            pnlZaposleniSaTabelom.Hide();
            pnlLijekovi.Hide();
            pnlDobavljaci.Hide();
            pnlNarudzbe.Hide();
            pnlRacuni.Hide();
            pnlZaposleniSaListom.Show();
            PopuniComboBoxMjesta(cbMjestoLista);
            odabraniZaposleni = null;
            btnOcistiPoljaPretrageLista.PerformClick();
            tsmiIzmjenitiZaposlenogLista.Enabled = false;
            new ToolTip().SetToolTip(this.btnOcistiPoljaPretrageLista, "Očistiti polja pretrage");
            OmoguciPoljaNaFormi(false, gbPodaciZaposlenogLista, gbPretragaZaposlenogLista);
            SendMessage(tbJmbgPretragaLista.Handle, EM_SETCUEBANNER, 0, "JMBG");
            SendMessage(tbImePretragaLista.Handle, EM_SETCUEBANNER, 0, "Ime");
            SendMessage(tbPrezimePretragaLista.Handle, EM_SETCUEBANNER, 0, "Prezime");
            SendMessage(tbStrucnaSpremaPretragaLista.Handle, EM_SETCUEBANNER, 0, "Stručna sprema");
        }

        private void tsmiPregledLijekova_Click(object sender, EventArgs e)
        {
            pnlZaposleniSaTabelom.Hide();
            pnlZaposleniSaListom.Hide();
            pnlDobavljaci.Hide();
            pnlNarudzbe.Hide();
            pnlRacuni.Hide();
            pnlLijekovi.Show();
            dgvLijekovi.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tsmiIzmjenitiLijek.Enabled = false;
            tsmiObrisatiLijek.Enabled = false;
            new ToolTip().SetToolTip(this.btnOcistiPoljaPretrageLijekova, "Očistiti polja pretrage");
            btnOcistiPoljaPretrageLijekova.PerformClick();
            OmoguciPoljaNaFormi(false, gbPodaciOLijeku, gbPretragaLijeka);
            SendMessage(tbNazivLijekaPretraga.Handle, EM_SETCUEBANNER, 0, "Naziv");
        }

        private void tsmiPregledDobavljaca_Click(object sender, EventArgs e)
        {
            pnlZaposleniSaTabelom.Hide();
            pnlZaposleniSaListom.Hide();
            pnlLijekovi.Hide();
            pnlNarudzbe.Hide();
            pnlRacuni.Hide();
            pnlDobavljaci.Show();
            PopuniComboBoxMjesta(cbMjestoDobavljaca);
            new ToolTip().SetToolTip(this.btnOcistiPoljaPretrageDobavljaca, "Očistiti polja pretrage");
            tsmiIzmjenitiDobavljaca.Enabled = false;
            tsmiObrisatiDobavljaca.Enabled = false;
            btnOcistiPoljaPretrageDobavljaca.PerformClick();
            OmoguciPoljaNaFormi(false, gbPodaciODobavljacu, gbPretragaDobavljaca);
            SendMessage(tbNazivDobavljacaPretraga.Handle, EM_SETCUEBANNER, 0, "Naziv");
        }

        private void tsmiPregledNarudzbaFaktura_Click(object sender, EventArgs e)
        {
            pnlZaposleniSaTabelom.Hide();
            pnlZaposleniSaListom.Hide();
            pnlLijekovi.Hide();
            pnlDobavljaci.Hide();
            pnlRacuni.Hide();
            pnlNarudzbe.Show();
            new ToolTip().SetToolTip(this.btnOcistiPoljaPretrageNarudzbe, "Očistiti polja pretrage");
            dtpKreiranaOdPretraga.MaxDate = DateTime.Today;
            dtpKreiranaDoPretraga.MaxDate = DateTime.Today;
            dtpDatumIzdavanjaFakture.MaxDate = DateTime.Today;
            btnOcistiPoljaPretrageNarudzbe.PerformClick();
            new ToolTip().SetToolTip(this.dtpKreiranaOdPretraga, "Kreirane od");
            new ToolTip().SetToolTip(this.dtpKreiranaDoPretraga, "Kreirana do");
            OmoguciPoljaNaFormi(false, gbPodaciSaFakture, gbPretragaNarudzbe);
            SendMessage(tbDobavljacPretraga.Handle, EM_SETCUEBANNER, 0, "Naziv dobavljača");
            SendMessage(tbBrojNarudzbePretraga.Handle, EM_SETCUEBANNER, 0, "Broj narudžbe");
        }

        private void tsmiPregledRacuna_Click(object sender, EventArgs e)
        {
            pnlZaposleniSaTabelom.Hide();
            pnlZaposleniSaListom.Hide();
            pnlLijekovi.Hide();
            pnlDobavljaci.Hide();
            pnlNarudzbe.Hide();
            pnlRacuni.Show();
            new ToolTip().SetToolTip(this.btnOcistiPoljaPretrageRacuna, "Očistiti polja pretrage");
            dtpDatumKreiranjaRacunaOdPretraga.MaxDate = DateTime.Today;
            dtpDatumKreiranjaRacunaDoPretraga.MaxDate = DateTime.Today;
            btnOcistiPoljaPretrageRacuna.PerformClick();
            tsmiObrisatiRacun.Enabled = false;
            new ToolTip().SetToolTip(this.dtpDatumKreiranjaRacunaOdPretraga, "Kreiran od");
            new ToolTip().SetToolTip(this.dtpDatumKreiranjaRacunaDoPretraga, "Kreiran do");
        }
        #endregion

        #region Pregled zaposlenih u tabeli

        private void PopuniTabeluZaposlenihPretrazivanjem(bool pretrazivanjeZaposlenih)
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
                        string imePretraga = tbImePretraga.Text.Trim();
                        string prezimePretraga = tbPrezimePretraga.Text.Trim();
                        string jmbgPretraga = tbJmbgPretraga.Text.Trim();
                        string strucnaSpremaPretraga = tbStrucnaSpremaPretraga.Text.Trim();
                        var zaposleni = (from z in context.zaposlenis
                                         where z.obrisano == false &&
                                         z.ime.StartsWith(imePretraga) &&
                                         z.prezime.StartsWith(prezimePretraga) &&
                                         z.jmbg.StartsWith(jmbgPretraga) &&
                                         z.strucnaSprema.StartsWith(strucnaSpremaPretraga)
                                         orderby z.prezime
                                         select z).ToList();
                        PopuniTabeluZaposlenih(zaposleni);
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
                r.SetValues(zp.jmbg, zp.ime, zp.prezime, zp.strucnaSprema);
                dgvZaposleni.Rows.Add(r);
                if (zp.idZaposlenog == idOdabranogZaposlenog)
                {
                    r.Selected = true;
                }
            }
        }

        private void PostaviRedneBrojeveUTabeli(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1) + ".";
            }
        }

        private void PopuniComboBoxMjesta(ComboBox cbM)
        {
            try
            {
                cbM.Items.Clear();
                using (ApotekaDb context = new ApotekaDb())
                {
                    var mjesta = (from m in context.mjestoes
                                  where m.obrisano == false
                                  select m).ToArray();
                    cbM.Items.AddRange(mjesta);
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        tsmiIzmjenitiZaposlenog.Enabled = true;
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
            OmoguciPoljaNaFormi(true, gbPodaciZaposlenog, gbPretragaZaposlenog);
            mtbJmbg.Focus();
        }

        private void dgvZaposleni_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tsmiIzmjenitiZaposlenog.PerformClick();
            }
        }

        private void btnOcistiPoljaPretrage_Click(object sender, EventArgs e)
        {
            tbImePretraga.Text = "";
            tbPrezimePretraga.Text = "";
            tbJmbgPretraga.Text = "";
            tbStrucnaSprema.Text = "";
            SendMessage(tbJmbgPretraga.Handle, EM_SETCUEBANNER, 0, "JMBG");
            SendMessage(tbImePretraga.Handle, EM_SETCUEBANNER, 0, "Ime");
            SendMessage(tbPrezimePretraga.Handle, EM_SETCUEBANNER, 0, "Prezime");
            SendMessage(tbStrucnaSpremaPretraga.Handle, EM_SETCUEBANNER, 0, "Stručna sprema");
            PopuniTabeluZaposlenihPretrazivanjem(false);
            dgvZaposleni.ClearSelection();
            dgvZaposleni.Focus();
            mtbJmbg.Text = "";
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbAdresa.Text = "";
            cbMjesto.SelectedItem = null;
            tbTelefon.Text = "";
            tbEmail.Text = "";
            tbStrucnaSprema.Text = "";
            tbFarmaceutskoZvanje.Text = "";
            tbOpisPosla.Text = "";
            cbSefApoteke.Checked = false;
            tsmiIzmjenitiZaposlenog.Enabled = false;
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
                        PopuniTabeluZaposlenihPretrazivanjem(false);
                        OmoguciPoljaNaFormi(false, gbPodaciZaposlenog, gbPretragaZaposlenog);
                        dgvZaposleni.Focus();
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
                                     where zp.idZaposlenog == odabraniZaposleni.idZaposlenog &&
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
                    PopuniTabeluZaposlenihPretrazivanjem(false);
                    OmoguciPoljaNaFormi(false, gbPodaciZaposlenog, gbPretragaZaposlenog);
                    dgvZaposleni.Focus();
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OmoguciPoljaNaFormi(bool omoguceno, GroupBox gbPodaci, GroupBox gbPretraga)
        {
            if (omoguceno)
            {
                foreach (Control cont in gbPodaci.Controls)
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
                    else if (cont is NumericUpDown)
                    {
                        ((NumericUpDown)cont).Enabled = true;
                        ((NumericUpDown)cont).BackColor = SystemColors.Window;
                    }
                    else if (cont is DateTimePicker)
                    {
                        ((DateTimePicker)cont).Enabled = true;
                        ((DateTimePicker)cont).BackColor = SystemColors.Window;
                    }
                    else if (cont is ListView)
                    {
                        ((ListView)cont).Enabled = true;
                        ((ListView)cont).BackColor = SystemColors.Window;
                    }
                }

                foreach (Control cont in gbPretraga.Controls)
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
                    else if (cont is DateTimePicker)
                    {
                        ((DateTimePicker)cont).Enabled = false;
                        ((DateTimePicker)cont).BackColor = SystemColors.Control;
                    }
                    else if (cont is ListView)
                    {
                        ((ListView)cont).Enabled = false;
                        ((ListView)cont).BackColor = SystemColors.Control;
                    }
                }
            }
            else
            {
                foreach (Control cont in gbPodaci.Controls)
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
                    else if (cont is NumericUpDown)
                    {
                        ((NumericUpDown)cont).Enabled = false;
                        ((NumericUpDown)cont).BackColor = SystemColors.Control;
                    }
                    else if (cont is DateTimePicker)
                    {
                        ((DateTimePicker)cont).Enabled = false;
                        ((DateTimePicker)cont).BackColor = SystemColors.Control;
                    }
                    else if (cont is ListView)
                    {
                        ((ListView)cont).Enabled = false;
                        ((ListView)cont).BackColor = SystemColors.Control;
                    }
                }

                foreach (Control cont in gbPretraga.Controls)
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
                    else if (cont is DateTimePicker)
                    {
                        ((DateTimePicker)cont).Enabled = true;
                        ((DateTimePicker)cont).BackColor = SystemColors.Window;
                    }
                    else if (cont is ListView)
                    {
                        ((ListView)cont).Enabled = true;
                        ((ListView)cont).BackColor = SystemColors.Window;
                    }
                }
            }
        }

        private void tbJmbgPretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniTabeluZaposlenihPretrazivanjem(true);
        }

        private void tbImePretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniTabeluZaposlenihPretrazivanjem(true);
        }

        private void tbPrezimePretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniTabeluZaposlenihPretrazivanjem(true);
        }

        private void tbStrucnaSpremaPretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniTabeluZaposlenihPretrazivanjem(true);
        }
        #endregion

        #region Pregled zaposlenih u listi

        private void PopuniListuZaposlenihPretrazivanjem(bool pretrazivanjeZaposlenih)
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
                        PopuniListuZaposlenih(zaposleni);
                    }
                    else
                    {
                        string imePretraga = tbImePretragaLista.Text.Trim();
                        string prezimePretraga = tbPrezimePretragaLista.Text.Trim();
                        string jmbgPretraga = tbJmbgPretragaLista.Text.Trim();
                        string strucnaSpremaPretraga = tbStrucnaSpremaPretragaLista.Text.Trim();
                        var zaposleni = (from z in context.zaposlenis
                                         where z.obrisano == false &&
                                         z.ime.StartsWith(imePretraga) &&
                                         z.prezime.StartsWith(prezimePretraga) &&
                                         z.jmbg.StartsWith(jmbgPretraga) &&
                                         z.strucnaSprema.StartsWith(strucnaSpremaPretraga)
                                         orderby z.prezime
                                         select z).ToList();
                        PopuniListuZaposlenih(zaposleni);
                    }
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopuniListuZaposlenih(List<zaposleni> zaposleni)
        {
            int brojAdmina = 0;
            int brojMenadzera = 0;
            int brojFarmaceuta = 0;
            lvZaposleni.Items.Clear();
            foreach (var zp in zaposleni)
            {
                ListViewGroup lvg = null;
                if (zp.uloga == 10)
                {
                    lvg = lvZaposleni.Groups["lvgAdmin"];
                    brojAdmina++;
                }
                else if (zp.uloga == 2)
                {
                    lvg = lvZaposleni.Groups["lvgMenadzer"];
                    brojMenadzera++;
                }
                else
                {
                    lvg = lvZaposleni.Groups["lvgFarmaceut"];
                    brojFarmaceuta++;
                }

                ListViewItem lvi = new ListViewItem();
                lvi.Group = lvg;
                lvi.Name = zp.jmbg;
                lvi.Text = zp.jmbg;
                lvi.Tag = zp;
                lvi.SubItems.Add(zp.ime);
                lvi.SubItems.Add(zp.prezime);
                lvi.SubItems.Add(zp.strucnaSprema);
                lvZaposleni.Items.Add(lvi);
                if (zp.idZaposlenog == idOdabranogZaposlenog)
                {
                    lvi.Selected = true;
                }
            }
            lvZaposleni.Groups["lvgAdmin"].Header = "Administratori (" + brojAdmina + ")";
            lvZaposleni.Groups["lvgMenadzer"].Header = "Menadžeri (" + brojMenadzera + ")";
            lvZaposleni.Groups["lvgFarmaceut"].Header = "Farmaceuti (" + brojFarmaceuta + ")";
        }

        private void lvZaposleni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvZaposleni.SelectedItems.Count == 1)
            {
                int intselectedindex = lvZaposleni.SelectedIndices[0];
                if (intselectedindex >= 0)
                {
                    odabraniZaposleni = (zaposleni)lvZaposleni.Items[intselectedindex].Tag;
                    try
                    {
                        using (ApotekaDb context = new ApotekaDb())
                        {
                            zaposleni zap = (from zp in context.zaposlenis
                                             where zp.jmbg == odabraniZaposleni.jmbg &&
                                             zp.obrisano == false
                                             select zp).FirstOrDefault();
                            mtbJmbgLista.Text = zap.jmbg;
                            tbImeLista.Text = zap.ime;
                            tbPrezimeLista.Text = zap.prezime;
                            tbAdresaLista.Text = zap.adresa;
                            cbMjestoLista.SelectedItem = zap.mjesto;
                            tbTelefonLista.Text = zap.telefon;
                            tbEmailLista.Text = zap.email;
                            tbStrucnaSpremaLista.Text = zap.strucnaSprema;
                            tbFarmaceutskoZvanjeLista.Text = zap.farmaceutskoZvanje;
                            tbOpisPoslaLista.Text = zap.opisPosla;
                            cbSefApotekeLista.Checked = zap.sefApoteke;
                        }
                        if (odabraniZaposleni != null)
                        {
                            tsmiIzmjenitiZaposlenogLista.Enabled = true;
                        }
                    }
                    catch (Exception)
                    {
                        string prk = "Došlo je do greške.";
                        MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                tsmiIzmjenitiZaposlenogLista.Enabled = false;
                mtbJmbgLista.Text = "";
                tbImeLista.Text = "";
                tbPrezimeLista.Text = "";
                tbAdresaLista.Text = "";
                cbMjestoLista.SelectedItem = null;
                tbTelefonLista.Text = "";
                tbEmailLista.Text = "";
                tbStrucnaSpremaLista.Text = "";
                tbFarmaceutskoZvanjeLista.Text = "";
                tbOpisPoslaLista.Text = "";
                cbSefApotekeLista.Checked = false;
                tbImePretragaLista.Text = "";
                tbPrezimePretragaLista.Text = "";
                tbJmbgPretragaLista.Text = "";
                tbStrucnaSpremaLista.Text = "";
            }
        }

        private void tsmiIzmjenitiZaposlenogLista_Click(object sender, EventArgs e)
        {
            OmoguciPoljaNaFormi(true, gbPodaciZaposlenogLista, gbPretragaZaposlenogLista);
            mtbJmbgLista.Focus();
        }

        private void btnOcistiPoljaPretrageLista_Click(object sender, EventArgs e)
        {
            tbImePretragaLista.Text = "";
            tbPrezimePretragaLista.Text = "";
            tbJmbgPretragaLista.Text = "";
            tbStrucnaSpremaLista.Text = "";
            SendMessage(tbJmbgPretragaLista.Handle, EM_SETCUEBANNER, 0, "JMBG");
            SendMessage(tbImePretragaLista.Handle, EM_SETCUEBANNER, 0, "Ime");
            SendMessage(tbPrezimePretragaLista.Handle, EM_SETCUEBANNER, 0, "Prezime");
            SendMessage(tbStrucnaSpremaPretragaLista.Handle, EM_SETCUEBANNER, 0, "Stručna sprema");
            PopuniListuZaposlenihPretrazivanjem(false);
            lvZaposleni.SelectedItems.Clear();
            lvZaposleni.Focus();
            mtbJmbgLista.Text = "";
            tbImeLista.Text = "";
            tbPrezimeLista.Text = "";
            tbAdresaLista.Text = "";
            cbMjestoLista.SelectedItem = null;
            tbTelefonLista.Text = "";
            tbEmailLista.Text = "";
            tbStrucnaSpremaLista.Text = "";
            tbFarmaceutskoZvanjeLista.Text = "";
            tbOpisPoslaLista.Text = "";
            cbSefApotekeLista.Checked = false;
            tsmiIzmjenitiZaposlenogLista.Enabled = false;
        }

        private void btnSacuvatiLista_Click(object sender, EventArgs e)
        {
            string poruka = "";
            if (string.IsNullOrEmpty(mtbJmbgLista.Text.Trim()))
            {
                poruka += "JMBG nije unijet.\n";
            }
            if (mtbJmbgLista.Text.Length < 13 || mtbJmbgLista.Text.Contains(" "))
            {
                poruka += "JMBG mora sadržavati 13 cifara.\n";
            }
            if (string.IsNullOrEmpty(tbImeLista.Text.Trim()))
            {
                poruka += "Ime nije unijeto.\n";
            }
            if (string.IsNullOrEmpty(tbPrezimeLista.Text.Trim()))
            {
                poruka += "Prezime nije unijeto.\n";
            }
            if (string.IsNullOrEmpty(tbAdresaLista.Text.Trim()))
            {
                poruka += "Adresa nije unijeta.\n";
            }
            if (string.IsNullOrEmpty(tbStrucnaSpremaLista.Text.Trim()))
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
                        if (zp.jmbg.Equals(mtbJmbgLista.Text) && zp.idZaposlenog != odabraniZaposleni.idZaposlenog)
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
                        odabraniZaposleni.jmbg = mtbJmbgLista.Text;
                        odabraniZaposleni.ime = tbImeLista.Text.Trim();
                        odabraniZaposleni.prezime = tbPrezimeLista.Text.Trim();
                        odabraniZaposleni.adresa = tbAdresaLista.Text.Trim();
                        odabraniZaposleni.idMjesta = ((mjesto)cbMjestoLista.SelectedItem).idMjesta;
                        odabraniZaposleni.telefon = tbTelefonLista.Text.Trim();
                        odabraniZaposleni.email = tbEmailLista.Text.Trim();
                        odabraniZaposleni.strucnaSprema = tbStrucnaSpremaLista.Text.Trim();
                        odabraniZaposleni.farmaceutskoZvanje = tbFarmaceutskoZvanjeLista.Text.Trim();
                        odabraniZaposleni.opisPosla = tbOpisPoslaLista.Text.Trim();
                        odabraniZaposleni.sefApoteke = cbSefApotekeLista.Checked;
                        context.SaveChanges();
                        idOdabranogZaposlenog = odabraniZaposleni.idZaposlenog;
                        PopuniListuZaposlenihPretrazivanjem(false);
                        OmoguciPoljaNaFormi(false, gbPodaciZaposlenogLista, gbPretragaZaposlenogLista);
                        lvZaposleni.Focus();
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

        private void btnOdustatiLista_Click(object sender, EventArgs e)
        {
            int intselectedindex = lvZaposleni.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                odabraniZaposleni = (zaposleni)lvZaposleni.Items[intselectedindex].Tag;
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        zaposleni zap = (from zp in context.zaposlenis
                                         where zp.idZaposlenog == odabraniZaposleni.idZaposlenog &&
                                         zp.obrisano == false
                                         select zp).FirstOrDefault();
                        tbImeLista.Text = zap.ime;
                        tbPrezimeLista.Text = zap.prezime;
                        tbAdresaLista.Text = zap.adresa;
                        cbMjestoLista.SelectedItem = zap.mjesto;
                        tbTelefonLista.Text = zap.telefon;
                        tbEmailLista.Text = zap.email;
                        tbStrucnaSpremaLista.Text = zap.strucnaSprema;
                        tbFarmaceutskoZvanjeLista.Text = zap.farmaceutskoZvanje;
                        tbOpisPoslaLista.Text = zap.opisPosla;
                        cbSefApotekeLista.Checked = zap.sefApoteke;
                        idOdabranogZaposlenog = odabraniZaposleni.idZaposlenog;
                        PopuniListuZaposlenihPretrazivanjem(false);
                        OmoguciPoljaNaFormi(false, gbPodaciZaposlenogLista, gbPretragaZaposlenogLista);
                        lvZaposleni.Focus();
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbJmbgPretragaLista_TextChanged(object sender, EventArgs e)
        {
            PopuniListuZaposlenihPretrazivanjem(true);
        }

        private void tbImePretragaLista_TextChanged(object sender, EventArgs e)
        {
            PopuniListuZaposlenihPretrazivanjem(true);
        }

        private void tbPrezimePretragaLista_TextChanged(object sender, EventArgs e)
        {
            PopuniListuZaposlenihPretrazivanjem(true);
        }

        private void tbStrucnaSpremaPretragaLista_TextChanged(object sender, EventArgs e)
        {
            PopuniListuZaposlenihPretrazivanjem(true);
        }
        #endregion

        #region Pregled lijekova

        private void PopuniTabeluLijekovaPretrazivanjem(bool pretrazivanjeLijekova, bool ukljuciStatusNaRecept)
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    List<lijek> lijekovi = new List<lijek>();
                    if (!pretrazivanjeLijekova)
                    {
                        lijekovi = (from l in context.lijeks
                                    where l.obrisano == false
                                    select l).ToList();
                    }
                    else
                    {
                        string nazivPretraga = tbNazivLijekaPretraga.Text.Trim();
                        DateTime datumOd = dtpDozvolaVaziOdPretraga.Value;
                        DateTime datumDo = dtpDozvolaVaziDoPretraga.Value;
                        bool naRecept = cbIzdavanjeNaReceptPretraga.Checked;
                        if (!ukljuciStatusNaRecept)
                        {
                            if (datumVazenjaDozvoleLijekaOdPretraga && datumVazenjaDozvoleLijekaDoPretraga)
                            {
                                lijekovi = (from l in context.lijeks
                                            where l.obrisano == false &&
                                            l.naziv.StartsWith(nazivPretraga) &&
                                                l.dozvolaVaziOd <= datumOd &&
                                                l.dozvolaVaziDo >= datumDo
                                            select l).ToList();
                            }
                            else if (!datumVazenjaDozvoleLijekaOdPretraga && datumVazenjaDozvoleLijekaDoPretraga)
                            {
                                lijekovi = (from l in context.lijeks
                                            where l.obrisano == false &&
                                            l.naziv.StartsWith(nazivPretraga) &&
                                                l.dozvolaVaziDo >= datumDo
                                            select l).ToList();
                            }
                            else if (datumVazenjaDozvoleLijekaOdPretraga && !datumVazenjaDozvoleLijekaDoPretraga)
                            {
                                lijekovi = (from l in context.lijeks
                                            where l.obrisano == false &&
                                            l.naziv.StartsWith(nazivPretraga) &&
                                                l.dozvolaVaziOd <= datumOd
                                            select l).ToList();
                            }
                            else
                            {
                                lijekovi = (from l in context.lijeks
                                            where l.obrisano == false &&
                                            l.naziv.StartsWith(nazivPretraga)
                                            select l).ToList();
                            }
                        }
                        else
                        {
                            if (datumVazenjaDozvoleLijekaOdPretraga && datumVazenjaDozvoleLijekaDoPretraga)
                            {
                                lijekovi = (from l in context.lijeks
                                            where l.obrisano == false &&
                                            l.naziv.StartsWith(nazivPretraga) &&
                                                l.dozvolaVaziOd <= datumOd &&
                                                l.dozvolaVaziDo >= datumDo &&
                                                l.izdavanjeNaRecept == naRecept
                                            select l).ToList();
                            }
                            else if (!datumVazenjaDozvoleLijekaOdPretraga && datumVazenjaDozvoleLijekaDoPretraga)
                            {
                                lijekovi = (from l in context.lijeks
                                            where l.obrisano == false &&
                                            l.naziv.StartsWith(nazivPretraga) &&
                                                l.dozvolaVaziDo >= datumDo &&
                                                l.izdavanjeNaRecept == naRecept
                                            select l).ToList();
                            }
                            else if (datumVazenjaDozvoleLijekaOdPretraga && !datumVazenjaDozvoleLijekaDoPretraga)
                            {
                                lijekovi = (from l in context.lijeks
                                            where l.obrisano == false &&
                                            l.naziv.StartsWith(nazivPretraga) &&
                                                l.dozvolaVaziOd <= datumOd &&
                                                l.izdavanjeNaRecept == naRecept
                                            select l).ToList();
                            }
                            else
                            {
                                lijekovi = (from l in context.lijeks
                                            where l.obrisano == false &&
                                            l.naziv.StartsWith(nazivPretraga) &&
                                                l.izdavanjeNaRecept == naRecept
                                            select l).ToList();
                            }
                        }
                    }
                    PopuniTabeluLijekova(lijekovi);
                    PostaviRedneBrojeveUTabeli(dgvLijekovi);
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopuniTabeluLijekova(List<lijek> lijekovi)
        {
            dgvLijekovi.Rows.Clear();
            foreach (var lj in lijekovi)
            {
                DataGridViewRow r = new DataGridViewRow()
                {
                    Tag = lj
                };
                r.CreateCells(dgvLijekovi);
                r.SetValues(lj.naziv, lj.dozvolaVaziOd.ToString("dd.MM.yyyy"), lj.dozvolaVaziDo.ToString("dd.MM.yyyy"), lj.izdavanjeNaRecept);
                dgvLijekovi.Rows.Add(r);
                if (lj.idLijeka == idOdabranogLijeka)
                {
                    r.Selected = true;
                }
            }
        }

        private void tbNazivLijekaPretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniTabeluLijekovaPretrazivanjem(true, false);
        }

        private void dtpDozvolaVaziOdPretraga_ValueChanged(object sender, EventArgs e)
        {
            datumVazenjaDozvoleLijekaOdPretraga = true;
            PopuniTabeluLijekovaPretrazivanjem(true, false);
        }

        private void dtpDozvolaVaziDoPretraga_ValueChanged(object sender, EventArgs e)
        {
            datumVazenjaDozvoleLijekaDoPretraga = true;
            PopuniTabeluLijekovaPretrazivanjem(true, false);
        }

        private void cbIzdavanjeNaReceptPretraga_CheckedChanged(object sender, EventArgs e)
        {
            PopuniTabeluLijekovaPretrazivanjem(true, true);
        }

        private void btnOcistiPoljaPretrageLijekova_Click(object sender, EventArgs e)
        {
            tbNazivLijekaPretraga.Text = "";
            try
            {
                dtpDozvolaVaziDoPretraga.Value = DateTime.Today;
                dtpDozvolaVaziOdPretraga.Value = DateTime.Today;
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbIzdavanjeNaReceptPretraga.Checked = false;
            datumVazenjaDozvoleLijekaDoPretraga = false;
            datumVazenjaDozvoleLijekaOdPretraga = false;
            SendMessage(tbNazivLijekaPretraga.Handle, EM_SETCUEBANNER, 0, "Naziv");
            PopuniTabeluLijekovaPretrazivanjem(false, false);
            dgvLijekovi.ClearSelection();
            dgvLijekovi.Focus();
            dgvLijekovi.Select();
            tbNazivLijeka.Text = "";
            tbProizvodjacLijeka.Text = "";
            tbPakovanjeLijeka.Text = "";
            cbIzdavanjeNaReceptLijeka.Checked = false;
            tbNetoKolicinaLijeka.Text = "";
            dtpDozvolaVaziOdLijeka.CustomFormat = " ";
            dtpDozvolaVaziDoLijeka.CustomFormat = " ";
            tbNabavnaCijenaLijeka.Text = "";
            tbProdajnaCijenaLijeka.Text = "";
            nudKolicinaNaStanjuLijeka.Value = 0;
            tbNamjenaLijeka.Text = "";
            tsmiIzmjenitiLijek.Enabled = false;
            tsmiObrisatiLijek.Enabled = false;
        }

        private void tsmiDodatiLijek_Click(object sender, EventArgs e)
        {
            LijekForma lijekForma = new LijekForma(true, null, tsslStatusnaLabela, dgvLijekovi);
            lijekForma.ShowDialog();
        }

        private void tsmiObrisatiLijek_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Da li želite obrisati lijek " + odabraniLijek.naziv + "?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        odabraniLijek = (from l in context.lijeks
                                         where l.idLijeka == odabraniLijek.idLijeka
                                         select l).FirstOrDefault();
                        odabraniLijek.obrisano = true;
                        context.SaveChanges();
                        odabraniLijek = null;
                        tsslStatusnaLabela.Text = "Lijek je uspješno obrisan.";
                        btnOcistiPoljaPretrageLijekova.PerformClick();
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLijekovi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLijekovi.SelectedRows.Count == 1)
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        odabraniLijek = (lijek)dgvLijekovi.SelectedRows[0].Tag;
                        lijek ljk = (from l in context.lijeks
                                     where l.idLijeka == odabraniLijek.idLijeka &&
                                         l.obrisano == false
                                     select l).FirstOrDefault();
                        tbNazivLijeka.Text = ljk.naziv;
                        tbProizvodjacLijeka.Text = ljk.proizvodjac;
                        tbPakovanjeLijeka.Text = ljk.pakovanje;
                        cbIzdavanjeNaReceptLijeka.Checked = ljk.izdavanjeNaRecept;
                        tbNetoKolicinaLijeka.Text = ljk.netoKolicina;
                        dtpDozvolaVaziOdLijeka.CustomFormat = "dd.MM.yyyy";
                        dtpDozvolaVaziOdLijeka.Value = ljk.dozvolaVaziOd;
                        dtpDozvolaVaziDoLijeka.CustomFormat = "dd.MM.yyyy";
                        dtpDozvolaVaziDoLijeka.Value = ljk.dozvolaVaziDo;
                        tbNabavnaCijenaLijeka.Text = ljk.nabavnaCijena.ToString();
                        tbProdajnaCijenaLijeka.Text = ljk.prodajnaCijena.ToString();
                        nudKolicinaNaStanjuLijeka.Value = ljk.kolicinaNaStanju;
                        tbNamjenaLijeka.Text = ljk.namjena;
                    }
                    if (odabraniLijek != null)
                    {
                        tsmiIzmjenitiLijek.Enabled = true;
                        tsmiObrisatiLijek.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLijekovi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tsmiIzmjenitiLijek.PerformClick();
        }

        private void tsmiIzmjenitiLijek_Click(object sender, EventArgs e)
        {
            OmoguciPoljaNaFormi(true, gbPodaciOLijeku, gbPretragaLijeka);
            tbNazivLijeka.Focus();
        }

        private void btnSacuvatiLijek_Click(object sender, EventArgs e)
        {
            decimal nabavnaCijenaUnos = 0;
            decimal prodajnaCijenaUnos = 0;
            bool neuspjesnaNabavna = false;
            bool neuspjesnaProdajna = false;
            int kolicinaLijekaNaStanju = 0;
            bool korektnaKolicina = false;
            string poruka = "";
            if (string.IsNullOrEmpty(tbNazivLijeka.Text.Trim()))
            {
                poruka += "Naziv nije unijet.\n";
            }
            if (string.IsNullOrEmpty(tbProizvodjacLijeka.Text.Trim()))
            {
                poruka += "Proizvođač nije unijet.\n";
            }
            if (string.IsNullOrEmpty(tbPakovanjeLijeka.Text.Trim()))
            {
                poruka += "Pakovanje nije unijeto.\n";
            }
            if (string.IsNullOrEmpty(tbNetoKolicinaLijeka.Text.Trim()))
            {
                poruka += "Neto količina nije unijeta.\n";
            }
            if (dtpDozvolaVaziOdLijeka.Value > dtpDozvolaVaziDoLijeka.Value)
            {
                poruka += "Datum od kad važi dozvola ne može biti poslije datuma isteka iste.\n";
            }
            if (!decimal.TryParse(tbNabavnaCijenaLijeka.Text.Trim(), out nabavnaCijenaUnos))
            {
                neuspjesnaNabavna = true;
                poruka += "Nabavna cijena mora biti pozitivan broj.\n";
            }
            if (!neuspjesnaNabavna && nabavnaCijenaUnos < 0)
            {
                poruka += "Nabavna cijena mora biti pozitivan broj.\n";
            }
            if (!decimal.TryParse(tbProdajnaCijenaLijeka.Text.Trim(), out prodajnaCijenaUnos))
            {
                neuspjesnaProdajna = true;
                poruka += "Prodajna cijena mora biti pozitivan broj.\n";
            }
            if (!neuspjesnaProdajna && prodajnaCijenaUnos < 0)
            {
                poruka += "Prodajna cijena mora biti pozitivan broj.\n";
            }
            if ((nudKolicinaNaStanjuLijeka.Value.ToString()).Contains(".") || (nudKolicinaNaStanjuLijeka.Value.ToString()).Contains(","))
            {
                poruka += "Količina lijeka na stanju mora biti pozitivan cijeli broj.";
            }

            if (string.IsNullOrEmpty(poruka))
            {
                korektnaKolicina = int.TryParse(nudKolicinaNaStanjuLijeka.Value.ToString(), out kolicinaLijekaNaStanju);
                if (!korektnaKolicina)
                {
                    poruka += "Količina lijeka na stanju mora biti pozitivan cijeli broj.";
                }
                if (kolicinaLijekaNaStanju < 0)
                {
                    poruka += "Količina lijeka na stanju mora biti pozitivan cijeli broj.";
                }
            }
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    if (string.IsNullOrEmpty(poruka))
                    {
                        odabraniLijek = (from l in context.lijeks
                                         where l.idLijeka == odabraniLijek.idLijeka
                                         select l).FirstOrDefault();
                        odabraniLijek.naziv = tbNazivLijeka.Text.Trim();
                        odabraniLijek.proizvodjac = tbProizvodjacLijeka.Text.Trim();
                        odabraniLijek.pakovanje = tbPakovanjeLijeka.Text.Trim();
                        odabraniLijek.izdavanjeNaRecept = cbIzdavanjeNaReceptLijeka.Checked;
                        odabraniLijek.netoKolicina = tbNetoKolicinaLijeka.Text.Trim();
                        odabraniLijek.dozvolaVaziOd = dtpDozvolaVaziOdLijeka.Value;
                        odabraniLijek.dozvolaVaziDo = dtpDozvolaVaziDoLijeka.Value;
                        odabraniLijek.nabavnaCijena = nabavnaCijenaUnos;
                        odabraniLijek.prodajnaCijena = prodajnaCijenaUnos;
                        odabraniLijek.kolicinaNaStanju = kolicinaLijekaNaStanju;
                        odabraniLijek.namjena = tbNamjenaLijeka.Text.Trim();
                        context.SaveChanges();
                        idOdabranogLijeka = odabraniLijek.idLijeka;
                        PopuniTabeluLijekovaPretrazivanjem(false, false);
                        OmoguciPoljaNaFormi(false, gbPodaciOLijeku, gbPretragaLijeka);
                        dgvLijekovi.Focus();
                        tsslStatusnaLabela.Text = "Podaci o lijeku uspješno izmjenjeni.";
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

        private void btnOdustatiLijek_Click(object sender, EventArgs e)
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    odabraniLijek = (lijek)dgvLijekovi.SelectedRows[0].Tag;
                    lijek ljk = (from l in context.lijeks
                                 where l.idLijeka == odabraniLijek.idLijeka &&
                                 l.obrisano == false
                                 select l).FirstOrDefault();
                    tbNazivLijeka.Text = odabraniLijek.naziv;
                    tbProizvodjacLijeka.Text = odabraniLijek.proizvodjac;
                    tbPakovanjeLijeka.Text = odabraniLijek.pakovanje;
                    cbIzdavanjeNaReceptLijeka.Checked = odabraniLijek.izdavanjeNaRecept;
                    tbNetoKolicinaLijeka.Text = odabraniLijek.netoKolicina;
                    dtpDozvolaVaziOdLijeka.Value = odabraniLijek.dozvolaVaziOd;
                    dtpDozvolaVaziDoLijeka.Value = odabraniLijek.dozvolaVaziDo;
                    tbNabavnaCijenaLijeka.Text = odabraniLijek.nabavnaCijena.ToString();
                    tbProdajnaCijenaLijeka.Text = odabraniLijek.prodajnaCijena.ToString();
                    nudKolicinaNaStanjuLijeka.Value = odabraniLijek.kolicinaNaStanju;
                    tbNamjenaLijeka.Text = odabraniLijek.namjena;
                    idOdabranogLijeka = odabraniLijek.idLijeka;
                    PopuniTabeluLijekovaPretrazivanjem(false, false);
                    OmoguciPoljaNaFormi(false, gbPodaciOLijeku, gbPretragaLijeka);
                    dgvLijekovi.Focus();
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Pregled dobavljaca

        private void PopuniTabeluDobavljacaPretrazivanjem(bool pretrazivanje)
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    if (!pretrazivanje)
                    {
                        var dobavljaci = (from d in context.dobavljacs
                                          where d.obrisano == false
                                          select d).ToList();
                        PopuniTabeluDobavljaca(dobavljaci);
                    }
                    else
                    {
                        string nazivDobavljacaPretraga = tbNazivDobavljacaPretraga.Text.Trim();
                        var dobavljaci = (from d in context.dobavljacs
                                          where d.obrisano == false &&
                                          d.naziv.StartsWith(nazivDobavljacaPretraga)
                                          select d).ToList();
                        PopuniTabeluDobavljaca(dobavljaci);
                    }
                    PostaviRedneBrojeveUTabeli(dgvDobavljaci);
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tsmiDodatiDobavljaca_Click(object sender, EventArgs e)
        {
            DobavljacForma dobavljacForma = new DobavljacForma(tsslStatusnaLabela, dgvDobavljaci);
            dobavljacForma.ShowDialog();
        }

        private void btnOcistiPoljaPretrageDobavljaca_Click(object sender, EventArgs e)
        {
            tbNazivDobavljacaPretraga.Text = "";
            tbStrucnaSprema.Text = "";
            SendMessage(tbNazivDobavljacaPretraga.Handle, EM_SETCUEBANNER, 0, "Naziv");
            PopuniTabeluDobavljacaPretrazivanjem(false);
            dgvDobavljaci.ClearSelection();
            dgvDobavljaci.Focus();
            tbNazivDobavljaca.Text = "";
            tbAdresaDobavljaca.Text = "";
            cbMjestoDobavljaca.SelectedItem = null;
            tbTelefonDobavljaca.Text = "";
            tbEmailDobavljaca.Text = "";
            tbWebSajtDobavljaca.Text = ""; ;
            cbRegistrovanKodALMS.Checked = false;
            tsmiIzmjenitiDobavljaca.Enabled = false;
            tsmiObrisatiDobavljaca.Enabled = false;
        }

        private void PopuniTabeluDobavljaca(List<dobavljac> dobavljaci)
        {
            dgvDobavljaci.Rows.Clear();
            foreach (var dob in dobavljaci)
            {
                DataGridViewRow r = new DataGridViewRow()
                {
                    Tag = dob
                };
                try
                {
                    mjesto mj = null;
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        mj = (from m in context.mjestoes
                              where m.idMjesta == dob.idMjesta
                              select m).FirstOrDefault();
                    }
                    r.CreateCells(dgvDobavljaci);
                    r.SetValues(dob.naziv, dob.adresa + ", " + mj.naziv, dob.telefon, dob.email);
                    dgvDobavljaci.Rows.Add(r);
                    if (dob.idDobavljaca == idOdabranogDobavljaca)
                    {
                        r.Selected = true;
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDobavljaci_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tsmiIzmjenitiDobavljaca.PerformClick();
        }

        private void dgvDobavljaci_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDobavljaci.SelectedRows.Count == 1)
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        odabraniDobavljac = (dobavljac)dgvDobavljaci.SelectedRows[0].Tag;
                        dobavljac dob = (from d in context.dobavljacs
                                         where d.idDobavljaca == odabraniDobavljac.idDobavljaca &&
                                         d.obrisano == false
                                         select d).FirstOrDefault();
                        tbNazivDobavljaca.Text = dob.naziv;
                        tbAdresaDobavljaca.Text = dob.adresa;
                        cbMjestoDobavljaca.SelectedItem = dob.mjesto;
                        tbTelefonDobavljaca.Text = dob.telefon;
                        tbEmailDobavljaca.Text = dob.email;
                        tbWebSajtDobavljaca.Text = dob.webSajt;
                        cbRegistrovanKodALMS.Checked = dob.regKodALMS;
                    }
                    if (odabraniDobavljac != null)
                    {
                        tsmiIzmjenitiDobavljaca.Enabled = true;
                        tsmiObrisatiDobavljaca.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiIzmjenitiDobavljaca_Click(object sender, EventArgs e)
        {
            OmoguciPoljaNaFormi(true, gbPodaciODobavljacu, gbPretragaDobavljaca);
            tbNazivDobavljaca.Focus();
        }

        private void tbNazivDobavljacaPretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniTabeluDobavljacaPretrazivanjem(true);
        }

        private void btnOdustatiDobavljac_Click(object sender, EventArgs e)
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    odabraniDobavljac = (dobavljac)dgvDobavljaci.SelectedRows[0].Tag;
                    dobavljac dob = (from d in context.dobavljacs
                                     where d.idDobavljaca == odabraniDobavljac.idDobavljaca &&
                                     d.obrisano == false
                                     select d).FirstOrDefault();
                    tbNazivDobavljaca.Text = dob.naziv;
                    tbAdresaDobavljaca.Text = dob.adresa;
                    cbMjestoDobavljaca.SelectedItem = dob.mjesto;
                    tbTelefonDobavljaca.Text = dob.telefon;
                    tbEmailDobavljaca.Text = dob.email;
                    tbWebSajtDobavljaca.Text = dob.webSajt;
                    cbRegistrovanKodALMS.Checked = dob.regKodALMS;
                    idOdabranogDobavljaca = odabraniDobavljac.idDobavljaca;
                    PopuniTabeluDobavljacaPretrazivanjem(false);
                    OmoguciPoljaNaFormi(false, gbPodaciODobavljacu, gbPretragaDobavljaca);
                    dgvDobavljaci.Focus();
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSacuvatiDobavljaca_Click(object sender, EventArgs e)
        {
            string poruka = "";
            if (string.IsNullOrEmpty(tbNazivDobavljaca.Text.Trim()))
            {
                poruka += "Naziv nije unijet.\n";
            }
            if (string.IsNullOrEmpty(tbAdresaDobavljaca.Text.Trim()))
            {
                poruka += "Adresa nije unijeta.\n";
            }
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    if (string.IsNullOrEmpty(poruka))
                    {
                        odabraniDobavljac = (from d in context.dobavljacs
                                             where d.idDobavljaca == odabraniDobavljac.idDobavljaca
                                             select d).FirstOrDefault();
                        odabraniDobavljac.naziv = tbNazivDobavljaca.Text.Trim();
                        odabraniDobavljac.adresa = tbAdresaDobavljaca.Text.Trim();
                        odabraniDobavljac.idMjesta = ((mjesto)cbMjestoDobavljaca.SelectedItem).idMjesta;
                        odabraniDobavljac.telefon = tbTelefonDobavljaca.Text.Trim();
                        odabraniDobavljac.email = tbEmailDobavljaca.Text.Trim();
                        odabraniDobavljac.webSajt = tbWebSajtDobavljaca.Text.Trim();
                        odabraniDobavljac.regKodALMS = cbRegistrovanKodALMS.Checked;
                        context.SaveChanges();
                        idOdabranogDobavljaca = odabraniDobavljac.idDobavljaca;
                        PopuniTabeluDobavljacaPretrazivanjem(false);
                        OmoguciPoljaNaFormi(false, gbPodaciODobavljacu, gbPretragaDobavljaca);
                        dgvDobavljaci.Focus();
                        tsslStatusnaLabela.Text = "Podaci o dobavljaču su izmjenjeni.";
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

        private void tsmiObrisatiDobavljaca_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Da li želite obrisati dobavljača " + odabraniDobavljac.naziv + "?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        odabraniDobavljac = (from d in context.dobavljacs
                                             where d.idDobavljaca == odabraniDobavljac.idDobavljaca
                                             select d).FirstOrDefault();
                        odabraniDobavljac.obrisano = true;
                        context.SaveChanges();
                        odabraniDobavljac = null;
                        tsslStatusnaLabela.Text = "Dobavljač je uspješno obrisan.";
                        btnOcistiPoljaPretrageDobavljaca.PerformClick();
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Ulaz/Izlaz - pregled narudzbi

        private void tsmiKreiratiNarudzbu_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Unregister();
            NarudzbaForma nForma = new NarudzbaForma(this, tsslStatusnaLabela, lvNarudzbe, prijavljenZaposleni);
            nForma.ShowDialog();
        }

        private void PopuniListuNarudzbiPretrazivanjem(bool pretrazivanjem)
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    List<narudzba> narudzbe = new List<narudzba>();
                    if (!pretrazivanjem)
                    {
                        narudzbe = (from n in context.narudzbas
                                    where n.obrisano == false
                                    select n).ToList();
                    }
                    else
                    {
                        string brojNarudzbePretraga = tbBrojNarudzbePretraga.Text.Trim();
                        DateTime datumOd = dtpKreiranaOdPretraga.Value;
                        DateTime datumDo = dtpKreiranaDoPretraga.Value;
                        string nazivDobavljacaPretraga = tbDobavljacPretraga.Text.Trim();
                        if (datumKreiranjaNarudzbeOdPretraga && datumKreiranjaNarudzbeDoPretraga)
                        {
                            narudzbe = (from nar in context.narudzbas
                                        join dob in context.dobavljacs
                                        on nar.idDobavljaca equals dob.idDobavljaca
                                        where nar.obrisano == false &&
                                        nar.brojNarudzbe.StartsWith(brojNarudzbePretraga) &&
                                        dob.naziv.StartsWith(nazivDobavljacaPretraga) &&
                                            nar.datumKreiranja >= datumOd &&
                                            nar.datumKreiranja <= datumDo
                                        select nar).ToList();
                        }
                        else if (!datumKreiranjaNarudzbeOdPretraga && datumKreiranjaNarudzbeDoPretraga)
                        {
                            narudzbe = (from nar in context.narudzbas
                                        join dob in context.dobavljacs
                                        on nar.idDobavljaca equals dob.idDobavljaca
                                        where nar.obrisano == false &&
                                        nar.brojNarudzbe.StartsWith(brojNarudzbePretraga) &&
                                        dob.naziv.StartsWith(nazivDobavljacaPretraga) &&
                                            nar.datumKreiranja <= datumDo
                                        select nar).ToList();
                        }
                        else if (datumKreiranjaNarudzbeOdPretraga && !datumKreiranjaNarudzbeDoPretraga)
                        {
                            narudzbe = (from nar in context.narudzbas
                                        join dob in context.dobavljacs
                                        on nar.idDobavljaca equals dob.idDobavljaca
                                        where nar.obrisano == false &&
                                        nar.brojNarudzbe.StartsWith(brojNarudzbePretraga) &&
                                        dob.naziv.StartsWith(nazivDobavljacaPretraga) &&
                                            nar.datumKreiranja >= datumOd
                                        select nar).ToList();
                        }
                        else
                        {
                            narudzbe = (from nar in context.narudzbas
                                        join dob in context.dobavljacs
                                        on nar.idDobavljaca equals dob.idDobavljaca
                                        where nar.obrisano == false &&
                                        nar.brojNarudzbe.StartsWith(brojNarudzbePretraga) &&
                                        dob.naziv.StartsWith(nazivDobavljacaPretraga)
                                        select nar).ToList();
                        }
                    }
                    PopuniListuNarudzbi(narudzbe);
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopuniListuNarudzbi(List<narudzba> narudzbe)
        {
            int brojZavrsenih = 0;
            int brojNezavrsenih = 0;
            lvNarudzbe.Items.Clear();
            foreach (var nar in narudzbe)
            {
                ListViewGroup lvg = null;
                if (nar.kompletirano)
                {
                    lvg = lvNarudzbe.Groups["lvgZavrsena"];
                    brojZavrsenih++;
                }
                else
                {
                    lvg = lvNarudzbe.Groups["lvgNezavrsena"];
                    brojNezavrsenih++;
                }

                ListViewItem lvi = new ListViewItem();
                lvi.Group = lvg;
                lvi.Name = nar.brojNarudzbe;
                lvi.Text = nar.brojNarudzbe;
                lvi.Tag = nar;
                lvi.SubItems.Add(nar.datumKreiranja.ToString("dd.MM.yyyy"));
                string nazivDobavljaca = "";
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        var dob = (from d in context.dobavljacs
                                   where d.idDobavljaca == nar.idDobavljaca
                                   select d).FirstOrDefault();
                        nazivDobavljaca = dob.naziv;
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lvi.SubItems.Add(nazivDobavljaca);
                lvNarudzbe.Items.Add(lvi);
                if (nar.idNarudzbe == idOdabraneNarudzbe)
                {
                    lvi.Selected = true;
                }
            }
            lvNarudzbe.Groups["lvgZavrsena"].Header = "Završene (" + brojZavrsenih + ")";
            lvNarudzbe.Groups["lvgNezavrsena"].Header = "Nezavršene (" + brojNezavrsenih + ")";
        }

        private void btnOcistiPoljaPretrageNarudzbe_Click(object sender, EventArgs e)
        {
            try
            {
                tbBrojNarudzbePretraga.Text = "";
                dtpKreiranaOdPretraga.Value = DateTime.Today;
                dtpKreiranaDoPretraga.Value = DateTime.Today;
                datumKreiranjaNarudzbeOdPretraga = false;
                datumKreiranjaNarudzbeDoPretraga = false;
                tbDobavljacPretraga.Text = "";
                SendMessage(tbDobavljacPretraga.Handle, EM_SETCUEBANNER, 0, "Naziv dobavljača");
                SendMessage(tbBrojNarudzbePretraga.Handle, EM_SETCUEBANNER, 0, "Broj narudžbe");
                PopuniListuNarudzbiPretrazivanjem(false);
                lvNarudzbe.SelectedItems.Clear();
                lvNarudzbe.Focus();
                dgvStavkeNarudzbe.Rows.Clear();
                lbKreiraoNarudzbuZaposleni.Text = "";
                lbPrimioFakturuZaposleni.Text = "";
                tbUkupanIznosNarudzba.Text = "0.00";
                tbBrojFakture.Text = "";
                dtpDatumIzdavanjaFakture.CustomFormat = " ";
                dtpDatumIzdavanjaFakture.Value = DateTime.Today;
                tbMjestoIzdavanjaFakture.Text = "";
                tbNacinPlacanjaFakture.Text = "";
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbBrojNarudzbePretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniListuNarudzbiPretrazivanjem(true);
        }

        private void tbDobavljacPretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniListuNarudzbiPretrazivanjem(true);
        }

        private void dtpKreiranaOdPretraga_ValueChanged(object sender, EventArgs e)
        {
            datumKreiranjaNarudzbeOdPretraga = true;
            PopuniListuNarudzbiPretrazivanjem(true);
            tbUkupanIznosNarudzba.Text = "0.00";
            dgvStavkeNarudzbe.Rows.Clear();
        }

        private void dtpKreiranaDoPretraga_ValueChanged(object sender, EventArgs e)
        {
            datumKreiranjaNarudzbeDoPretraga = true;
            PopuniListuNarudzbiPretrazivanjem(true);
            if(lvNarudzbe.Items.Count == 0)
            {
                tbUkupanIznosNarudzba.Text = "0.00";
                dgvStavkeNarudzbe.Rows.Clear();
            }
        }

        private void lvNarudzbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNarudzbe.SelectedItems.Count == 1)
            {
                int intselectedindex = lvNarudzbe.SelectedIndices[0];
                if (intselectedindex >= 0)
                {
                    odabranaNarudzba = (narudzba)lvNarudzbe.Items[intselectedindex].Tag;
                    try
                    {
                        using (ApotekaDb context = new ApotekaDb())
                        {
                            narudzba nar = (from n in context.narudzbas
                                            where n.idNarudzbe == odabranaNarudzba.idNarudzbe &&
                                            n.obrisano == false
                                            select n).FirstOrDefault();
                            odabranaNarudzba = nar;
                            faktura fakt = null;
                            if (nar.idFakture != null)
                            {
                                fakt = (from f in context.fakturas
                                        where f.idFakture == nar.idFakture && f.obrisano == false
                                        select f).FirstOrDefault();
                            }
                            dtpDatumIzdavanjaFakture.MaxDate = DateTime.Today;
                            dtpDatumIzdavanjaFakture.MinDate = nar.datumKreiranja;
                            if (fakt != null)
                            {
                                tbBrojFakture.Text = fakt.brojFakture;
                                tbMjestoIzdavanjaFakture.Text = fakt.mjestoIzdavanja;
                                tbNacinPlacanjaFakture.Text = fakt.nacinPlacanja;
                                dtpDatumIzdavanjaFakture.CustomFormat = "dd.MM.yyyy";
                                dtpDatumIzdavanjaFakture.Value = fakt.datumIzdavanja;
                                zaposleni zaposleniPrimio = (from z in context.zaposlenis
                                                             where z.idZaposlenog == fakt.idZaposlenog
                                                             select z).FirstOrDefault();
                                lbPrimioFakturuZaposleni.Text = zaposleniPrimio.ime + " " + zaposleniPrimio.prezime;
                            }
                            else
                            {
                                tbBrojFakture.Text = "";
                                tbMjestoIzdavanjaFakture.Text = "";
                                tbNacinPlacanjaFakture.Text = "";
                                dtpDatumIzdavanjaFakture.CustomFormat = " ";
                                lbPrimioFakturuZaposleni.Text = "";
                            }
                            var stavkeNarudzbe = (from sn in context.stavkanarudzbes
                                                  where sn.idNarudzbe == nar.idNarudzbe
                                                  select sn).ToList();
                            DodajStavkeUTabelu(stavkeNarudzbe);
                            zaposleni zaposl = (from z in context.zaposlenis
                                                where z.idZaposlenog == nar.idZaposlenog
                                                select z).FirstOrDefault();
                            lbKreiraoNarudzbuZaposleni.Text = zaposl.ime + " " + zaposl.prezime;
                            tbUkupanIznosNarudzba.Text = nar.ukupanIznos.ToString();
                        }
                        if (odabranaNarudzba != null)
                        {
                            tsmiZavrsitiNarudzbu.Enabled = true;
                            tsmiObrisatiNarudzbu.Enabled = true;
                        }
                    }
                    catch (Exception)
                    {
                        string prk = "Došlo je do greške.";
                        MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                lbKreiraoNarudzbuZaposleni.Text = "";
                tbUkupanIznosNarudzba.Text = "0.00";
                tbBrojFakture.Text = "";
                dtpDatumIzdavanjaFakture.CustomFormat = " ";
                try
                {
                    dtpDatumIzdavanjaFakture.Value = DateTime.Today;
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tbMjestoIzdavanjaFakture.Text = "";
                tbNacinPlacanjaFakture.Text = "";
                tsmiZavrsitiNarudzbu.Enabled = false;
                tsmiObrisatiNarudzbu.Enabled = false;
            }
        }

        private void DodajStavkeUTabelu(List<stavkanarudzbe> sNarudzbe)
        {
            dgvStavkeNarudzbe.Rows.Clear();
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    foreach (stavkanarudzbe sn in sNarudzbe)
                    {
                        DataGridViewRow r = new DataGridViewRow()
                        {
                            Tag = sn
                        };
                        r.CreateCells(dgvStavkeNarudzbe);
                        lijek lj = (from l in context.lijeks
                                    where l.idLijeka == sn.idLijeka
                                    select l).FirstOrDefault();
                        r.SetValues(lj.naziv, sn.kolicina, sn.iznos);
                        dgvStavkeNarudzbe.Rows.Add(r);
                    }
                    PostaviRedneBrojeveUTabeli(dgvStavkeNarudzbe);
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSacuvatiFaktura_Click(object sender, EventArgs e)
        {
            string poruka = "";
            if (string.IsNullOrEmpty(tbBrojFakture.Text.Trim()))
            {
                poruka += "Broj fakture nije unijet.\n";
            }
            if (string.IsNullOrEmpty(tbMjestoIzdavanjaFakture.Text.Trim()))
            {
                poruka += "Mjesto izdavanja fakture nije unijeto.\n";
            }
            if (string.IsNullOrEmpty(tbNacinPlacanjaFakture.Text.Trim()))
            {
                poruka += "Način plaćanja fakture nije unijet.\n";
            }

            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    if (string.IsNullOrEmpty(poruka))
                    {
                        odabranaNarudzba = (from n in context.narudzbas
                                            where n.idNarudzbe == odabranaNarudzba.idNarudzbe &&
                                            n.obrisano == false
                                            select n).FirstOrDefault();
                        if (odabranaNarudzba.kompletirano)
                        {
                            faktura fakt = (from f in context.fakturas
                                            where f.idFakture == odabranaNarudzba.idFakture &&
                                            f.obrisano == false
                                            select f).FirstOrDefault();
                            fakt.brojFakture = tbBrojFakture.Text.Trim();
                            fakt.mjestoIzdavanja = tbMjestoIzdavanjaFakture.Text.Trim();
                            fakt.nacinPlacanja = tbNacinPlacanjaFakture.Text.Trim();
                            fakt.datumIzdavanja = dtpDatumIzdavanjaFakture.Value;
                            context.SaveChanges();
                            PopuniListuNarudzbiPretrazivanjem(false);
                            OmoguciPoljaNaFormi(false, gbPodaciSaFakture, gbPretragaNarudzbe);
                            lvNarudzbe.Focus();
                            tsslStatusnaLabela.Text = "Faktura za narudžbu je izmijenja.";
                        }
                        else
                        {
                            faktura fakt = new faktura
                            {
                                brojFakture = tbBrojFakture.Text.Trim(),
                                mjestoIzdavanja = tbMjestoIzdavanjaFakture.Text.Trim(),
                                nacinPlacanja = tbNacinPlacanjaFakture.Text.Trim(),
                                datumIzdavanja = dtpDatumIzdavanjaFakture.Value,
                                ukupanIznos = odabranaNarudzba.ukupanIznos,
                                idZaposlenog = prijavljenZaposleni.idZaposlenog
                            };
                            context.fakturas.Add(fakt);
                            context.SaveChanges();
                            var sNarudzbe = (from sn in context.stavkanarudzbes
                                             where sn.idNarudzbe == odabranaNarudzba.idNarudzbe
                                             select sn).ToList();
                            foreach (stavkanarudzbe sNar in sNarudzbe)
                            {
                                lijek lj = (from l in context.lijeks
                                            where l.idLijeka == sNar.idLijeka
                                            select l).FirstOrDefault();
                                lj.kolicinaNaStanju += sNar.kolicina;
                                context.SaveChanges();
                            }
                            int idFakture = fakt.idFakture;
                            idOdabraneNarudzbe = odabranaNarudzba.idNarudzbe;
                            odabranaNarudzba.kompletirano = true;
                            odabranaNarudzba.idFakture = idFakture;
                            context.SaveChanges();
                            PopuniListuNarudzbiPretrazivanjem(false);
                            OmoguciPoljaNaFormi(false, gbPodaciSaFakture, gbPretragaNarudzbe);
                            lvNarudzbe.Focus();
                            tsslStatusnaLabela.Text = "Faktura za narudžbu je dodata. Narudžba završena.";
                        }
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

        private void btnOdustatiFaktura_Click(object sender, EventArgs e)
        {
            int intselectedindex = lvNarudzbe.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                odabranaNarudzba = (narudzba)lvNarudzbe.Items[intselectedindex].Tag;
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        narudzba nar = (from n in context.narudzbas
                                        where n.idNarudzbe == odabranaNarudzba.idNarudzbe &&
                                        n.obrisano == false
                                        select n).FirstOrDefault();
                        tbBrojFakture.Text = "";
                        tbMjestoIzdavanjaFakture.Text = "";
                        tbNacinPlacanjaFakture.Text = "";
                        dtpDatumIzdavanjaFakture.Value = DateTime.Today;
                        dtpDatumIzdavanjaFakture.CustomFormat = " ";
                        idOdabraneNarudzbe = odabranaNarudzba.idNarudzbe;
                        PopuniListuNarudzbiPretrazivanjem(false);
                        OmoguciPoljaNaFormi(false, gbPodaciSaFakture, gbPretragaNarudzbe);
                        lvNarudzbe.Focus();
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiZavrsitiNarudzbu_Click(object sender, EventArgs e)
        {
            try
            {
                OmoguciPoljaNaFormi(true, gbPodaciSaFakture, gbPretragaNarudzbe);
                dtpDatumIzdavanjaFakture.Value = DateTime.Today;
                dtpDatumIzdavanjaFakture.MaxDate = DateTime.Today;
                dtpDatumIzdavanjaFakture.MinDate = odabranaNarudzba.datumKreiranja;
                dtpDatumIzdavanjaFakture.CustomFormat = "dd.MM.yyyy";
                tbBrojFakture.Focus();
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiObrisatiNarudzbu_Click(object sender, EventArgs e)
        {
            if (lvNarudzbe.SelectedItems.Count == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Da li želite obrisati narudžbu?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
                {
                    int intselectedindex = lvNarudzbe.SelectedIndices[0];
                    if (intselectedindex >= 0)
                    {
                        odabranaNarudzba = (narudzba)lvNarudzbe.Items[intselectedindex].Tag;
                        try
                        {
                            using (ApotekaDb context = new ApotekaDb())
                            {
                                narudzba nar = (from n in context.narudzbas
                                                where n.idNarudzbe == odabranaNarudzba.idNarudzbe &&
                                                n.obrisano == false
                                                select n).FirstOrDefault();
                                faktura fakt = null;
                                if (nar.idFakture != null)
                                {
                                    fakt = (from f in context.fakturas
                                            where f.idFakture == nar.idFakture && f.obrisano == false
                                            select f).FirstOrDefault();
                                }
                                if (fakt != null)
                                {
                                    fakt.obrisano = true;
                                    context.SaveChanges();
                                }

                                var stavkeNarudzbe = (from sn in context.stavkanarudzbes
                                                      where sn.idNarudzbe == nar.idNarudzbe
                                                      select sn).ToList();
                                foreach (stavkanarudzbe sn in stavkeNarudzbe)
                                {
                                    sn.obrisano = true;
                                    context.SaveChanges();
                                }
                                nar.obrisano = true;
                                context.SaveChanges();
                                btnOcistiPoljaPretrageNarudzbe.PerformClick();
                                tsslStatusnaLabela.Text = "Narudžba uspješno obrisana.";
                            }
                        }
                        catch (Exception)
                        {
                            string prk = "Došlo je do greške.";
                            MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void cmsListaNarudzbi_Opening(object sender, CancelEventArgs e)
        {
            if (odabranaNarudzba != null)
            {
                if (odabranaNarudzba.kompletirano)
                {
                    tsmiZavrsitiNarudzbu.Text = "Izmjeniti fakturu";
                }
                else
                {
                    tsmiZavrsitiNarudzbu.Text = "Završiti narudžbu";
                }
            }
        }
        #endregion

        #region Ulaz/Izlaz - pregled racuna

        private void PopuniTabeluRacunaPretrazivanjem(bool pretrazivanje)
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    List<racun> racuni = new List<racun>();
                    if (!pretrazivanje)
                    {
                        racuni = (from r in context.racuns
                                  where r.obrisano == false
                                  select r).ToList();
                    }
                    else
                    {
                        DateTime datumOd = dtpDatumKreiranjaRacunaOdPretraga.Value;
                        DateTime datumDo = dtpDatumKreiranjaRacunaDoPretraga.Value;
                        if (datumKreiranjaRacunaOdPretraga && datumKreiranjaRacunaDoPretraga)
                        {
                            racuni = (from r in context.racuns
                                      where r.obrisano == false &&
                                          r.datumKreiranja >= datumOd &&
                                          r.datumKreiranja <= datumDo
                                      select r).ToList();
                        }
                        else if (!datumKreiranjaRacunaOdPretraga && datumKreiranjaRacunaDoPretraga)
                        {
                            racuni = (from r in context.racuns
                                      where r.obrisano == false &&
                                          r.datumKreiranja <= datumDo
                                      select r).ToList();
                        }
                        else if (datumKreiranjaRacunaOdPretraga && !datumKreiranjaRacunaDoPretraga)
                        {
                            racuni = (from r in context.racuns
                                      where r.obrisano == false &&
                                          r.datumKreiranja >= datumOd
                                      select r).ToList();
                        }
                        else
                        {
                            racuni = (from r in context.racuns
                                      where r.obrisano == false
                                      select r).ToList();
                        }

                    }
                    PopuniTabeluRacuna(racuni);
                    PostaviRedneBrojeveUTabeli(dgvRacuni);
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopuniTabeluRacuna(List<racun> racuni)
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    dgvRacuni.Rows.Clear();
                    foreach (var rac in racuni)
                    {
                        DataGridViewRow r = new DataGridViewRow()
                        {
                            Tag = rac
                        };
                        r.CreateCells(dgvRacuni);
                        zaposleni zap = (from z in context.zaposlenis
                                         where z.idZaposlenog == rac.idZaposlenog
                                         select z).FirstOrDefault();
                        r.SetValues(rac.datumKreiranja.ToString("dd.MM.yyyy"), zap.jmbg + " - " + zap.ime + " " + zap.prezime);
                        dgvRacuni.Rows.Add(r);
                    }
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOcistiPoljaPretrageRacuna_Click(object sender, EventArgs e)
        {
            try
            {
                dtpDatumKreiranjaRacunaOdPretraga.Value = DateTime.Today;
                dtpDatumKreiranjaRacunaDoPretraga.Value = DateTime.Today;
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PopuniTabeluRacunaPretrazivanjem(false);
            dgvRacuni.ClearSelection();
            dgvRacuni.Focus();
            dgvRacuni.Select();
            tbUkupanIznosRacuna.Text = "0.00";
            dgvStavkeRacuna.Rows.Clear();
            datumKreiranjaRacunaOdPretraga = false;
            datumKreiranjaRacunaDoPretraga = false;
            tsmiObrisatiRacun.Enabled = false;
        }

        private void dgvRacuni_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRacuni.SelectedRows.Count == 1)
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        odabranRacun = (racun)dgvRacuni.SelectedRows[0].Tag;
                        racun rac = (from r in context.racuns
                                     where r.idRacuna == odabranRacun.idRacuna
                                     select r).FirstOrDefault();
                        tbUkupanIznosRacuna.Text = rac.ukupanIznos.ToString();
                        var stavkeRacuna = (from sr in context.stavkaracunas
                                            where sr.idRacuna == rac.idRacuna
                                            select sr).ToList();
                        DodajStavkeRacunaUTabelu(stavkeRacuna);
                    }
                    if (odabranRacun != null)
                    {
                        tsmiObrisatiRacun.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DodajStavkeRacunaUTabelu(List<stavkaracuna> sRacuna)
        {
            try
            {
                dgvStavkeRacuna.Rows.Clear();
                using (ApotekaDb context = new ApotekaDb())
                {
                    foreach (stavkaracuna sr in sRacuna)
                    {
                        DataGridViewRow r = new DataGridViewRow()
                        {
                            Tag = sr
                        };
                        r.CreateCells(dgvStavkeRacuna);
                        lijek lj = (from l in context.lijeks
                                    where l.idLijeka == sr.idLijeka
                                    select l).FirstOrDefault();
                        r.SetValues(lj.naziv, sr.kolicina, sr.iznos);
                        dgvStavkeRacuna.Rows.Add(r);
                    }
                    PostaviRedneBrojeveUTabeli(dgvStavkeRacuna);
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpDatumKreiranjaRacunaOdPretraga_ValueChanged(object sender, EventArgs e)
        {
            datumKreiranjaRacunaOdPretraga = true;
            PopuniTabeluRacunaPretrazivanjem(true);
            if(dgvRacuni.Rows.Count == 0)
            {
                dgvStavkeRacuna.Rows.Clear();
                tbUkupanIznosRacuna.Text = "0.00";
            }
        }

        private void dtpDatumKreiranjaRacunaDoPretraga_ValueChanged(object sender, EventArgs e)
        {
            datumKreiranjaRacunaDoPretraga = true;
            PopuniTabeluRacunaPretrazivanjem(true);
            if (dgvRacuni.Rows.Count == 0)
            {
                dgvStavkeRacuna.Rows.Clear();
                tbUkupanIznosRacuna.Text = "0.00";
            }
        }

        private void tsmiObrisatiRacun_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Da li želite obrisati račun?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                if (dgvRacuni.SelectedRows.Count == 1)
                {
                    odabranRacun = (racun)dgvRacuni.SelectedRows[0].Tag;
                    try
                    {
                        using (ApotekaDb context = new ApotekaDb())
                        {
                            racun rac = (from r in context.racuns
                                         where r.idRacuna == odabranRacun.idRacuna &&
                                         r.obrisano == false
                                         select r).FirstOrDefault();


                            var stavkeRacuna = (from sr in context.stavkaracunas
                                                where sr.idRacuna == rac.idRacuna
                                                select sr).ToList();
                            foreach (stavkaracuna sRacuna in stavkeRacuna)
                            {
                                int? idReceptaSaStavke = sRacuna.idRecepta;
                                if (idReceptaSaStavke != null)
                                {
                                    recept rcpt = (from rec in context.recepts
                                                   where rec.idRecepta == idReceptaSaStavke
                                                   select rec).FirstOrDefault();
                                    rcpt.obrisano = true;
                                    context.SaveChanges();
                                }
                                sRacuna.obrisano = true;
                                context.SaveChanges();
                            }
                            rac.obrisano = true;
                            context.SaveChanges();
                            btnOcistiPoljaPretrageRacuna.PerformClick();
                            tsslStatusnaLabela.Text = "Račun uspješno obrisan.";
                        }
                    }
                    catch (Exception)
                    {
                        string prk = "Došlo je do greške.";
                        MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tsmiPregledatiRecept_Click(object sender, EventArgs e)
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    odabranaStavkaRacuna = (stavkaracuna)dgvStavkeRacuna.SelectedRows[0].Tag;
                    stavkaracuna srac = (from sr in context.stavkaracunas
                                         where sr.idRacuna == odabranaStavkaRacuna.idRacuna &&
                                         sr.idLijeka == odabranaStavkaRacuna.idLijeka
                                         select sr).FirstOrDefault();
                    if (srac.idRecepta != null)
                    {
                        recept rec = (from re in context.recepts
                                      where re.idRecepta == srac.idRecepta
                                      select re).FirstOrDefault();
                        ReceptForma recForma = new ReceptForma(rec);
                        recForma.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStavkeRacuna_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStavkeRacuna.SelectedRows.Count == 1)
            {
                odabranaStavkaRacuna = (stavkaracuna)dgvStavkeRacuna.SelectedRows[0].Tag;
                if (odabranaStavkaRacuna != null)
                {
                    tsmiPregledatiRecept.Enabled = true;
                }
            }
        }

        private void cmsTabelaStavkeRacuna_Opening(object sender, CancelEventArgs e)
        {
            if (odabranaStavkaRacuna.idRecepta != null)
            {
                tsmiPregledatiRecept.Enabled = true;
            }
            else
            {
                tsmiPregledatiRecept.Enabled = false;
            }
        }

        private void btnKreiratiPdfIzvjestaj_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxManager.Unregister();
                MessageBoxManager.Cancel = "Cancel";
                MessageBoxManager.Register();
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Title = "Save as...",
                    Filter = "PDF|*.pdf",
                    FileName = "Izvjestaj_" + DateTime.Now.ToFileTime()
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fajlIzvjestaj = sfd.FileName;
                    tspbProgresBar.Visible = true;
                    tspbProgresBar.Value = 0;
                    tsslStatusnaLabela.Text = "Izvještaj se kreira...";
                    bgw.RunWorkerAsync();
                }
                MessageBoxManager.Unregister();
                MessageBoxManager.Cancel = "Otkazati";
                MessageBoxManager.Register();
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            List<racun> racuni = new List<racun>();
            foreach (DataGridViewRow row in dgvRacuni.Rows)
            {
                racun r = (racun)row.Tag;
                racuni.Add(r);
            }
            DateTime? datumOd = null;
            DateTime? datumDo = null;
            if (datumKreiranjaRacunaOdPretraga)
            {
                datumOd = dtpDatumKreiranjaRacunaOdPretraga.Value;
            }
            if (datumKreiranjaRacunaDoPretraga)
            {
                datumDo = dtpDatumKreiranjaRacunaDoPretraga.Value;
            }
            PDFGenerator.kreirajIzvjestajRacun(fajlIzvjestaj, racuni, datumOd, datumDo, prijavljenZaposleni, bgw);
        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if ("greska".Equals((string)e.UserState))
            {
                MessageBox.Show("Greška prilikom generisanja izvještaja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tspbProgresBar.Value = 0;
            }
            else
            {
                tspbProgresBar.Value = e.ProgressPercentage;
            }
        }

        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tsslStatusnaLabela.Text = "Izvještaj je kreiran.";
            bgw.Dispose();
        }

        private void msMeni_MouseMove(object sender, MouseEventArgs e)
        {
            if (tspbProgresBar.Value == 100)
            {
                tspbProgresBar.Visible = false;
                tspbProgresBar.Value = 0;
            }
        }
        #endregion
    }
}
