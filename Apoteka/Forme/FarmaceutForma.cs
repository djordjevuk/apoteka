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
    public partial class FarmaceutForma : Form
    {
        private zaposleni prijavljenZaposleni;
        private LoginForma loginForma;
        private lijek odabraniLijek;
        private racun kreiranRacun;
        private bool izmjenaStavkeRacuna;
        private bool dodavanjeStavkeRacuna;
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public FarmaceutForma(LoginForma lForma, zaposleni zap)
        {
            InitializeComponent();
            this.prijavljenZaposleni = zap;
            this.loginForma = lForma;
            PodesiDugmad();
            izmjenaStavkeRacuna = false;
            dodavanjeStavkeRacuna = false;
        }

        private void FarmaceutForma_Load(object sender, EventArgs e)
        {
            tsslPrijavljenZaposleni.Text = "Prijavljen: " + prijavljenZaposleni.ime + " " + prijavljenZaposleni.prezime;
            tsmiMojNalog.Text = "&Moj nalog(" + prijavljenZaposleni.korisnickoIme + ")";
            new ToolTip().SetToolTip(this.btnOcistiPoljaPretrage, "Očistiti polja pretrage");
            lbFokus.Focus();
            dtpDatumIzdavanja.MaxDate = DateTime.Today;
            tsmiIzmjenitiStavkuRacuna.Enabled = false;
            tsmiObrisatiStavkuRacuna.Enabled = false;
            dgvLijekovi.Columns["kolicinaNaStanju"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            OmoguciPolja(true, false);
            SendMessage(tbNazivPretraga.Handle, EM_SETCUEBANNER, 0, "Naziv lijeka");
        }

        private void FarmaceutForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!btnKreiratiRacun.Enabled)
                {
                    if (DialogResult.Yes == MessageBox.Show("Otvoren račun će biti poništen zatvaranjem aplikacije! Da li želite zatvoriti aplikaciju?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
                    {
                        PonistiKreiranRacun();
                        MessageBoxManager.Unregister();
                        Application.Exit();
                    }
                    else
                        e.Cancel = true;
                }
                else
                {
                    MessageBoxManager.Unregister();
                    Application.Exit();
                }

            }
        }

        private void tsmiOdjava_Click(object sender, EventArgs e)
        {
            if (!btnKreiratiRacun.Enabled)
            {
                if (DialogResult.Yes == MessageBox.Show("Otvoren račun će biti poništen odjavom!\nDa li želite da se odjavite sa sistema?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
                {
                    PonistiKreiranRacun();
                    this.Hide();
                    MessageBoxManager.Unregister();
                    loginForma.PodesiDugmad(prijavljenZaposleni);
                    loginForma.Show();
                }
            }
            else
            {
                this.Hide();
                MessageBoxManager.Unregister();
                loginForma.PodesiDugmad(prijavljenZaposleni);
                loginForma.Show();
            }
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

        private void OmoguciPolja(bool loadForme, bool kreirajRacun)
        {
            if (loadForme)
            {
                gbPretragaLijeka.Enabled = false;
                gbPodaciStavkeRacuna.Enabled = false;
                gbPodaciSaRecepta.Enabled = false;
                dgvRacun.Enabled = false;
                btnKreiratiRacun.Enabled = true;
                btnZakljucitiRacun.Enabled = false;
                btnPonistitiRacun.Enabled = false;
            }
            if (kreirajRacun)
            {
                gbPretragaLijeka.Enabled = true;
                gbPodaciStavkeRacuna.Enabled = false;
                gbPodaciSaRecepta.Enabled = false;
                dgvRacun.Enabled = true;
                btnKreiratiRacun.Enabled = false;
                btnZakljucitiRacun.Enabled = true;
                btnPonistitiRacun.Enabled = true;
            }
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

        private void tsmiInformacijeOApoteci_Click(object sender, EventArgs e)
        {
            new InformacijeOApoteciForma(tsmiInformacijeOApoteci, tsslStatusnaLabela, false).Show();
            tsmiInformacijeOApoteci.Enabled = false;
        }

        private void TimerTrenutnoVrijeme_Tick(object sender, EventArgs e)
        {
            tsslDatumVrijeme.Text = DateTime.Today.ToString("d.M.yyyy") + " " + DateTime.Now.ToString("H:mm");
        }

        private void btnKreiratiRacun_Click(object sender, EventArgs e)
        {
            OmoguciPolja(false, true);
            PopuniTabeluLijekova("");
            dgvLijekovi.ClearSelection();
            tsmiLijekDetaljno.Enabled = false;
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    kreiranRacun = new racun();
                    kreiranRacun.datumKreiranja = DateTime.Today;
                    kreiranRacun.ukupanIznos = 0;
                    kreiranRacun.idZaposlenog = prijavljenZaposleni.idZaposlenog;
                    context.racuns.Add(kreiranRacun);
                    context.SaveChanges();
                }
                tsslStatusnaLabela.Text = "Račun je otvoren.";
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZakljucitiRacun_Click(object sender, EventArgs e)
        {
            if (dgvRacun.Rows.Count == 0)
            {
                MessageBox.Show("Račun se ne može zaključiti jer ne sadrži niti jednu stavku.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OmoguciPolja(true, false);
                OcistiPoljaStavkeRacuna();
                dgvRacun.Rows.Clear();
                dgvLijekovi.Rows.Clear();
                tsslStatusnaLabela.Text = "Račun je zaključen.";
                tbUkupanIznos.Text = "0.00";
            }
        }

        private void btnPonistitiRacun_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Da li želite poništiti račun?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                PonistiKreiranRacun();
            }
        }

        private void PonistiKreiranRacun()
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    var listaStavkiRacuna = (from sr in context.stavkaracunas
                                             where sr.idRacuna == kreiranRacun.idRacuna
                                             select sr).ToList();
                    foreach (stavkaracuna s in listaStavkiRacuna)
                    {
                        lijek ljk = (from lij in context.lijeks
                                     where lij.idLijeka == s.idLijeka
                                     select lij).FirstOrDefault();
                        ljk.kolicinaNaStanju = ljk.kolicinaNaStanju + s.kolicina;
                        context.SaveChanges();
                        int? idReceptaSaStavke = s.idRecepta;
                        context.stavkaracunas.Remove(s);
                        context.SaveChanges();
                        if (idReceptaSaStavke != null)
                        {
                            recept rcpt = (from rec in context.recepts
                                           where rec.idRecepta == idReceptaSaStavke
                                           select rec).FirstOrDefault();
                            context.recepts.Remove(rcpt);
                            context.SaveChanges();
                        }
                    }
                    racun rac = (from r in context.racuns
                                 where r.idRacuna == kreiranRacun.idRacuna
                                 select r).FirstOrDefault();
                    context.racuns.Remove(rac);
                    context.SaveChanges();

                    OmoguciPolja(true, false);
                    OcistiPoljaStavkeRacuna();
                    dgvRacun.Rows.Clear();
                    dgvLijekovi.Rows.Clear();
                    tsslStatusnaLabela.Text = "Račun je poništen.";
                    tbUkupanIznos.Text = "0.00";
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopuniTabeluLijekova(string nazivLijeka)
        {
            nazivLijeka = nazivLijeka.Trim();
            dgvLijekovi.Rows.Clear();
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    var lijekovi = (from l in context.lijeks
                                    where l.naziv.StartsWith(nazivLijeka) && l.obrisano == false
                                    select l).ToList();
                    foreach (var l in lijekovi)
                    {
                        DataGridViewRow r = new DataGridViewRow()
                        {
                            Tag = l
                        };
                        r.CreateCells(dgvLijekovi);
                        r.SetValues(l.naziv, l.proizvodjac, l.pakovanje, l.kolicinaNaStanju);
                        dgvLijekovi.Rows.Add(r);
                        if (l.Equals(odabraniLijek))
                        {
                            r.Selected = true;
                        }
                        if (l.kolicinaNaStanju == 0)
                        {
                            r.DefaultCellStyle.ForeColor = Color.DimGray;
                        }
                    }
                    PostaviRedneBrojeveUTabeli(dgvLijekovi);
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PostaviRedneBrojeveUTabeli(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1) + ".";
            }
        }

        private void dgvLijekovi_SelectionChanged(object sender, EventArgs e)
        {
            tsmiLijekDetaljno.Enabled = true;
        }

        private void dgvLijekovi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            odabraniLijek = (lijek)dgvLijekovi.SelectedRows[0].Tag;
            bool dodanLijek = false;
            foreach (DataGridViewRow r in dgvRacun.Rows)
            {
                stavkaracuna sr = (stavkaracuna)r.Tag;
                if (odabraniLijek.idLijeka == sr.idLijeka && kreiranRacun.idRacuna == sr.idRacuna)
                {
                    dodanLijek = true;
                    break;
                }
            }
            if (odabraniLijek.kolicinaNaStanju == 0)
            {
                MessageBox.Show("Nema više na stanju lijeka '" + odabraniLijek.naziv + "'", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dodanLijek)
            {
                MessageBox.Show("Odabran lijek se nalazi na stavci računa.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                gbPretragaLijeka.Enabled = false;
                gbPodaciStavkeRacuna.Enabled = true;
                dodavanjeStavkeRacuna = true;
                if (odabraniLijek.izdavanjeNaRecept)
                    gbPodaciSaRecepta.Enabled = true;
            }
        }

        private void tbNazivPretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniTabeluLijekova(tbNazivPretraga.Text.Trim());
            dgvLijekovi.ClearSelection();
            tsmiLijekDetaljno.Enabled = false;
        }

        private void btnOcistiPoljaPretrage_Click(object sender, EventArgs e)
        {
            tbNazivPretraga.Text = "";
            SendMessage(tbNazivPretraga.Handle, EM_SETCUEBANNER, 0, "Naziv lijeka");
            PopuniTabeluLijekova(tbNazivPretraga.Text.Trim());
            dgvLijekovi.ClearSelection();
            tsmiLijekDetaljno.Enabled = false;
        }

        private void tsmiLijekDetaljno_Click(object sender, EventArgs e)
        {
            if (dgvLijekovi.SelectedRows.Count == 1)
            {
                lijek l = (lijek)dgvLijekovi.SelectedRows[0].Tag;
                LijekForma lijekForma = new LijekForma(false, l, null, null);
                lijekForma.ShowDialog();
            }
        }

        private void btnOdustati_Click(object sender, EventArgs e)
        {
            gbPretragaLijeka.Enabled = true;
            gbPodaciStavkeRacuna.Enabled = false;
            gbPodaciSaRecepta.Enabled = false;
            tsmiIzmjenitiStavkuRacuna.Enabled = true;
            OcistiPoljaStavkeRacuna();
            if (izmjenaStavkeRacuna)
            {
                dgvRacun.Enabled = true;
                btnDodatiStavkuNaRacun.Text = "Dodati";
                izmjenaStavkeRacuna = false;
            }
            if (dodavanjeStavkeRacuna)
                dodavanjeStavkeRacuna = false;
        }

        private void btnDodatiStavkuNaRacun_Click(object sender, EventArgs e)
        {
            string poruka = "";
            int kolicinaNaStavci = 1;
            bool korektnaKolicina = false;

            if (gbPodaciSaRecepta.Enabled)
            {
                if (string.IsNullOrEmpty(mtbJmbg.Text.Trim()))
                {
                    poruka += "JMBG nije unijet.\n";
                }
                if (mtbJmbg.Text.Length < 13 || mtbJmbg.Text.Contains(" "))
                {
                    poruka += "JMBG mora sadržavati 13 cifara.\n";
                }
                if (string.IsNullOrEmpty(tbPacijent.Text.Trim()))
                {
                    poruka += "Ime i prezime pacijenta nije unijeto.\n";
                }
                if (string.IsNullOrEmpty(tbAdresa.Text.Trim()))
                {
                    poruka += "Adresa pacijenta nije unijeto.\n";
                }
                if (string.IsNullOrEmpty(tbIzdatOdUstanove.Text.Trim()))
                {
                    poruka += "Ime ustanove koja je izdala recept nije unijeto.\n";
                }
                if (string.IsNullOrEmpty(tbIzdatOdDoktora.Text.Trim()))
                {
                    poruka += "Ime doktor koji je izdao recept nije unijeto.\n";
                }
            }
            if ((nudKolicinaNaStavciRacuna.Value.ToString()).Contains(".") || (nudKolicinaNaStavciRacuna.Value.ToString()).Contains(","))
            {
                poruka += "Količina na stavci mora biti cjelobrojni podatak veći od 1.";
                nudKolicinaNaStavciRacuna.Value = 1;
            }

            if (string.IsNullOrEmpty(poruka))
            {
                korektnaKolicina = int.TryParse(nudKolicinaNaStavciRacuna.Value.ToString(), out kolicinaNaStavci);
                if (!korektnaKolicina)
                {
                    poruka += "Količina na stavci mora biti cjelobrojni podatak veći od 1.";
                }
                if (kolicinaNaStavci < 1)
                {
                    poruka += "Količina na stavci mora biti cjelobrojni podatak veći od 1.";
                }
            }
            if (kolicinaNaStavci > odabraniLijek.kolicinaNaStanju)
            {
                poruka += "Unesena količina lijeka nije na stanju.";
            }
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    if (string.IsNullOrEmpty(poruka))
                    {
                        if (!izmjenaStavkeRacuna)
                        {
                            recept rec = new recept();
                            stavkaracuna sRacuna = new stavkaracuna();
                            sRacuna.kolicina = kolicinaNaStavci;
                            sRacuna.iznos = odabraniLijek.prodajnaCijena * kolicinaNaStavci;
                            sRacuna.idLijeka = odabraniLijek.idLijeka;
                            sRacuna.idRacuna = kreiranRacun.idRacuna;
                            if (gbPodaciSaRecepta.Enabled)
                            {
                                rec.jmbg = mtbJmbg.Text;
                                rec.pacijent = tbPacijent.Text;
                                rec.adresa = tbAdresa.Text;
                                rec.izdatOdUstanove = tbIzdatOdUstanove.Text;
                                rec.izdatOdDoktora = tbIzdatOdDoktora.Text;
                                rec.datumIzdavanja = dtpDatumIzdavanja.Value;
                                rec.nazivLijeka = odabraniLijek.naziv;
                                rec.kolicina = kolicinaNaStavci;
                                rec.napomena = tbNapomena.Text.Trim();
                                context.recepts.Add(rec);
                                context.SaveChanges();
                                sRacuna.idRecepta = rec.idRecepta;
                            }
                            context.stavkaracunas.Add(sRacuna);
                            context.SaveChanges();
                            odabraniLijek = (from lij in context.lijeks
                                             where lij.idLijeka == odabraniLijek.idLijeka
                                             select lij).FirstOrDefault();
                            odabraniLijek.kolicinaNaStanju = odabraniLijek.kolicinaNaStanju - kolicinaNaStavci;
                            context.SaveChanges();
                            kreiranRacun = (from kRac in context.racuns
                                            where kRac.idRacuna == kreiranRacun.idRacuna
                                            select kRac).FirstOrDefault();
                            kreiranRacun.ukupanIznos = kreiranRacun.ukupanIznos + sRacuna.iznos;
                            tbUkupanIznos.Text = kreiranRacun.ukupanIznos.ToString();
                            context.SaveChanges();
                            DodajStavkuUTabeluRacun(sRacuna);
                            PopuniTabeluLijekova("");
                            OmoguciPolja(false, true);
                            OcistiPoljaStavkeRacuna();
                            tsmiIzmjenitiStavkuRacuna.Enabled = true;
                            dodavanjeStavkeRacuna = false;
                            tsslStatusnaLabela.Text = "Stavka računa je dodata.";
                        }
                        else
                        {
                            stavkaracuna sracuna = (stavkaracuna)dgvRacun.SelectedRows[0].Tag;
                            if (sracuna.idRecepta != null)
                            {
                                gbPodaciSaRecepta.Enabled = true;
                                recept rcpt = (from rec in context.recepts
                                               where rec.idRecepta == sracuna.idRecepta
                                               select rec).FirstOrDefault();
                                rcpt.jmbg = mtbJmbg.Text;
                                rcpt.pacijent = tbPacijent.Text;
                                rcpt.adresa = tbAdresa.Text;
                                rcpt.izdatOdUstanove = tbIzdatOdUstanove.Text;
                                rcpt.izdatOdDoktora = tbIzdatOdDoktora.Text;
                                rcpt.datumIzdavanja = dtpDatumIzdavanja.Value;
                                rcpt.kolicina = kolicinaNaStavci;
                                rcpt.napomena = tbNapomena.Text;
                                context.SaveChanges();
                            }
                            lijek ljk = (from lij in context.lijeks
                                         where lij.idLijeka == sracuna.idLijeka
                                         select lij).FirstOrDefault();
                            kreiranRacun = (from kRac in context.racuns
                                            where kRac.idRacuna == kreiranRacun.idRacuna
                                            select kRac).FirstOrDefault();
                            kreiranRacun.ukupanIznos = kreiranRacun.ukupanIznos - (ljk.prodajnaCijena * sracuna.kolicina);
                            kreiranRacun.ukupanIznos = kreiranRacun.ukupanIznos + (ljk.prodajnaCijena * kolicinaNaStavci);
                            tbUkupanIznos.Text = kreiranRacun.ukupanIznos.ToString();
                            context.SaveChanges();

                            ljk.kolicinaNaStanju = ljk.kolicinaNaStanju + (sracuna.kolicina - kolicinaNaStavci);
                            context.SaveChanges();
                            stavkaracuna stavkaRacuna = (from sr in context.stavkaracunas
                                                         where sr.idLijeka == sracuna.idLijeka && sr.idRacuna == sracuna.idRacuna
                                                         select sr).FirstOrDefault();
                            stavkaRacuna.kolicina = kolicinaNaStavci;
                            stavkaRacuna.iznos = ljk.prodajnaCijena * kolicinaNaStavci;
                            context.SaveChanges();
                            DataGridViewRow row = dgvRacun.SelectedRows[0];
                            row.Tag = stavkaRacuna;
                            row.SetValues(ljk.naziv, ljk.prodajnaCijena, stavkaRacuna.kolicina, stavkaRacuna.iznos);
                            OmoguciPolja(false, true);
                            PopuniTabeluLijekova("");
                            OcistiPoljaStavkeRacuna();
                            tsmiIzmjenitiStavkuRacuna.Enabled = true;
                            izmjenaStavkeRacuna = false;
                            btnDodatiStavkuNaRacun.Text = "Dodati";
                            tsslStatusnaLabela.Text = "Stavka računa je izmjenjena.";
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

        private void DodajStavkuUTabeluRacun(stavkaracuna sRacuna)
        {
            DataGridViewRow r = new DataGridViewRow()
            {
                Tag = sRacuna
            };
            r.CreateCells(dgvRacun);
            r.SetValues(odabraniLijek.naziv, odabraniLijek.prodajnaCijena, sRacuna.kolicina, sRacuna.iznos);
            dgvRacun.Rows.Add(r);
            r.Selected = true;
            PostaviRedneBrojeveUTabeli(dgvRacun);
        }



        private void OcistiPoljaStavkeRacuna()
        {
            nudKolicinaNaStavciRacuna.Value = 1;
            try
            {
                foreach (Control cont in gbPodaciSaRecepta.Controls)
                {
                    if (cont is TextBox)
                    {
                        ((TextBox)cont).Text = "";
                    }
                    else if (cont is MaskedTextBox)
                    {
                        ((MaskedTextBox)cont).Text = "";
                    }
                    else if (cont is DateTimePicker)
                    {
                        ((DateTimePicker)cont).Value = DateTime.Today;
                    }
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiIzmjenitiStavkuRacuna_Click(object sender, EventArgs e)
        {
            if (dgvRacun.SelectedRows.Count == 1)
            {
                stavkaracuna sracuna = (stavkaracuna)dgvRacun.SelectedRows[0].Tag;
                btnDodatiStavkuNaRacun.Text = "Sačuvati";
                dgvRacun.Enabled = false;
                izmjenaStavkeRacuna = true;
                gbPretragaLijeka.Enabled = false;
                gbPodaciStavkeRacuna.Enabled = true;
                recept rcpt = null;
                nudKolicinaNaStavciRacuna.Value = sracuna.kolicina;
                if (sracuna.idRecepta != null)
                {
                    gbPodaciSaRecepta.Enabled = true;
                    try
                    {
                        using (ApotekaDb context = new ApotekaDb())
                        {
                            rcpt = (from rec in context.recepts
                                    where rec.idRecepta == sracuna.idRecepta
                                    select rec).FirstOrDefault();
                            mtbJmbg.Text = rcpt.jmbg;
                            tbPacijent.Text = rcpt.pacijent;
                            tbAdresa.Text = rcpt.adresa;
                            tbIzdatOdUstanove.Text = rcpt.izdatOdUstanove;
                            tbIzdatOdDoktora.Text = rcpt.izdatOdDoktora;
                            dtpDatumIzdavanja.Text = rcpt.datumIzdavanja.ToString();
                            tbNapomena.Text = rcpt.napomena;
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

        private void tsmiObrisatiStavkuRacuna_Click(object sender, EventArgs e)
        {
            if (dgvRacun.SelectedRows.Count == 1)
            {
                stavkaracuna sracuna = (stavkaracuna)dgvRacun.SelectedRows[0].Tag;
                if (DialogResult.Yes == MessageBox.Show("Da li želite obrisati stavku računa?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    try
                    {
                        using (ApotekaDb context = new ApotekaDb())
                        {
                            kreiranRacun = (from kRac in context.racuns
                                            where kRac.idRacuna == kreiranRacun.idRacuna
                                            select kRac).FirstOrDefault();
                            kreiranRacun.ukupanIznos = kreiranRacun.ukupanIznos - sracuna.iznos;
                            context.SaveChanges();
                            tbUkupanIznos.Text = kreiranRacun.ukupanIznos.ToString();
                            lijek ljk = (from lij in context.lijeks
                                         where lij.idLijeka == sracuna.idLijeka
                                         select lij).FirstOrDefault();
                            ljk.kolicinaNaStanju = ljk.kolicinaNaStanju + sracuna.kolicina;
                            context.SaveChanges();
                            PopuniTabeluLijekova("");
                            stavkaracuna stavkaRacuna = (from sr in context.stavkaracunas
                                                         where sr.idLijeka == sracuna.idLijeka && sr.idRacuna == sracuna.idRacuna
                                                         select sr).FirstOrDefault();
                            bool imaRecept = stavkaRacuna.idRecepta != null;
                            int? idReceptaZaBrisanje = 0;
                            if (imaRecept)
                            {
                                idReceptaZaBrisanje = stavkaRacuna.idRecepta;
                            }
                            context.stavkaracunas.Remove(stavkaRacuna);
                            context.SaveChanges();
                            if (imaRecept)
                            {
                                recept rcpt = (from rec in context.recepts
                                               where rec.idRecepta == idReceptaZaBrisanje
                                               select rec).FirstOrDefault();
                                if (rcpt != null)
                                {
                                    context.recepts.Remove(rcpt);
                                    context.SaveChanges();
                                }
                            }
                            dgvRacun.Rows.Remove(dgvRacun.SelectedRows[0]);
                            if (dgvRacun.Rows.Count > 0)
                            {
                                PostaviRedneBrojeveUTabeli(dgvRacun);
                            }
                            else
                            {
                                tsmiIzmjenitiStavkuRacuna.Enabled = false;
                                tsmiObrisatiStavkuRacuna.Enabled = false;
                            }
                            tsslStatusnaLabela.Text = "Stavka računa je obrisana.";
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

        private void dgvRacun_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRacun.SelectedRows.Count == 1 && dgvRacun.Rows.Count != 0)
            {
                if (dodavanjeStavkeRacuna)
                    tsmiIzmjenitiStavkuRacuna.Enabled = false;
                else
                    tsmiIzmjenitiStavkuRacuna.Enabled = true;
                tsmiObrisatiStavkuRacuna.Enabled = true;
            }
            else
            {
                tsmiIzmjenitiStavkuRacuna.Enabled = false;
                tsmiObrisatiStavkuRacuna.Enabled = false;
            }
        }

        private void cmsTabelaRacun_Opening(object sender, CancelEventArgs e)
        {
            dgvRacun_SelectionChanged(sender, e);
        }

        private void dgvRacun_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tsmiIzmjenitiStavkuRacuna_Click(sender, e);
        }

        private void tsmiInformacijeOAplikaciji_Click(object sender, EventArgs e)
        {
            new OAplikacijiForma().ShowDialog();
        }
    }
}
