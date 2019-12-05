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
    public partial class NarudzbaForma : Form
    {
        private MenadzerForma menadzerForma;
        private ToolStripStatusLabel statusnaLabela;
        private ListView listaNarudzbi;
        private zaposleni prijavljenZaposleni;
        private lijek odabraniLijek;
        private narudzba kreiranaNarudzba;
        private bool izmjenaStavkeNarudzbe;
        private bool dodavanjeStavkeNarudzbe;
        private int brojacNarudzbi;
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);


        public NarudzbaForma(MenadzerForma menadzerForma, ToolStripStatusLabel sLabela, ListView listaNarudzbi, zaposleni prijavljenZaposleni)
        {
            InitializeComponent();
            this.statusnaLabela = sLabela;
            this.listaNarudzbi = listaNarudzbi;
            this.menadzerForma = menadzerForma;
            this.prijavljenZaposleni = prijavljenZaposleni;
            izmjenaStavkeNarudzbe = false;
            dodavanjeStavkeNarudzbe = false;
            this.brojacNarudzbi = 0;
            PodesiDugmad();
        }

        private void NarudzbaForma_Load(object sender, EventArgs e)
        {
            tsmiIzmjenitiStavkuNarudzbe.Enabled = false;
            tsmiObrisatiStavkuNarudzbe.Enabled = false;
            PopuniComboBoxDobavljaca();
            OmoguciPolja(true);
            SendMessage(tbNazivPretraga.Handle, EM_SETCUEBANNER, 0, "Naziv lijeka");
            SendMessage(tbKolicinaNaStanjuPretraga.Handle, EM_SETCUEBANNER, 0, "Količina na stanju manja od");
        }

        private void NarudzbaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!btnKreiratiNarudzbu.Enabled)
                {
                    if (DialogResult.Yes == MessageBox.Show("Otvorena narudžba će biti poništena zatvaranjem aplikacije! Da li želite zatvoriti aplikaciju?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
                    {
                        PonistiKreiranuNarudzbu();
                        MessageBoxManager.Unregister();
                        menadzerForma.PodesiDugmad();
                        this.Close();
                    }
                    else
                        e.Cancel = true;
                }
                else
                {
                    if (brojacNarudzbi == 1)
                    {
                        statusnaLabela.Text = "Narudžba je kreirana;";
                    }
                    else
                    {
                        statusnaLabela.Text = "Narudžbe su kreirane;";
                    }
                    MessageBoxManager.Unregister();
                    menadzerForma.PodesiDugmad();
                    this.Close();
                }

            }
        }

        private void PopuniComboBoxDobavljaca()
        {
            try
            {
                cbDobavljac.Items.Clear();
                using (ApotekaDb context = new ApotekaDb())
                {
                    var dobavljaci = (from d in context.dobavljacs
                                      where d.obrisano == false
                                      select d).ToArray();
                    cbDobavljac.Items.AddRange(dobavljaci);
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void OmoguciPolja(bool loadForme)
        {
            if (loadForme)
            {
                btnKreiratiNarudzbu.Enabled = true;
                gbPretragaLijeka.Enabled = false;
                gbPodaciStavkeNarudzbe.Enabled = false;
                dgvNarudzba.Enabled = false;
                btnZakljucitiNarudzbu.Enabled = false;
                btnPonistitiNarudzbu.Enabled = false;
            }
            else
            {
                btnKreiratiNarudzbu.Enabled = false;
                gbPretragaLijeka.Enabled = true;
                gbPodaciStavkeNarudzbe.Enabled = false;
                dgvNarudzba.Enabled = true;
                btnZakljucitiNarudzbu.Enabled = true;
                btnPonistitiNarudzbu.Enabled = true;
            }
        }

        private void PopuniTabeluLijekovaPretrazivanjem(bool pretrazivanje)
        {
            try
            {
                dgvLijekovi.Rows.Clear();
                using (ApotekaDb context = new ApotekaDb())
                {
                    List<lijek> lijekovi = new List<lijek>();
                    if (!pretrazivanje)
                    {
                        lijekovi = (from l in context.lijeks
                                    where l.obrisano == false
                                    select l).ToList();
                    }
                    else
                    {
                        string nazivLijeka = tbNazivPretraga.Text.Trim();
                        string kolicinaManjaOdString = tbKolicinaNaStanjuPretraga.Text.Trim();
                        int kolicinaManjaOd;
                        if (string.IsNullOrEmpty(kolicinaManjaOdString))
                        {
                            lijekovi = (from l in context.lijeks
                                        where l.obrisano == false && l.naziv.StartsWith(nazivLijeka)
                                        select l).ToList();
                        }
                        else
                        {
                            if (int.TryParse(kolicinaManjaOdString, out kolicinaManjaOd))
                            {
                                lijekovi = (from l in context.lijeks
                                            where l.obrisano == false && l.naziv.StartsWith(nazivLijeka) && l.kolicinaNaStanju < kolicinaManjaOd
                                            select l).ToList();
                            }
                            else
                            {
                                MessageBox.Show("Količina na stanju mora biti pozitivan cijeli broj.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    foreach (var l in lijekovi)
                    {
                        DataGridViewRow r = new DataGridViewRow()
                        {
                            Tag = l
                        };
                        r.CreateCells(dgvLijekovi);
                        r.SetValues(l.naziv, l.kolicinaNaStanju, l.proizvodjac, l.pakovanje);
                        dgvLijekovi.Rows.Add(r);
                        if (l.Equals(odabraniLijek))
                        {
                            r.Selected = true;
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
            foreach (DataGridViewRow r in dgvNarudzba.Rows)
            {
                stavkanarudzbe sn = (stavkanarudzbe)r.Tag;
                if (odabraniLijek.idLijeka == sn.idLijeka && kreiranaNarudzba.idNarudzbe == sn.idNarudzbe)
                {
                    dodanLijek = true;
                    break;
                }
            }
            if (dodanLijek)
            {
                MessageBox.Show("Odabran lijek se nalazi na stavci računa.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                gbPretragaLijeka.Enabled = false;
                gbPodaciStavkeNarudzbe.Enabled = true;
                dodavanjeStavkeNarudzbe = true;
            }

        }

        private void tbNazivPretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniTabeluLijekovaPretrazivanjem(true);
        }

        private void tbKolicinaNaStanjuPretraga_TextChanged(object sender, EventArgs e)
        {
            PopuniTabeluLijekovaPretrazivanjem(true);
        }

        private void btnOcistiPoljaPretrage_Click(object sender, EventArgs e)
        {
            tbNazivPretraga.Text = "";
            tbKolicinaNaStanjuPretraga.Text = "";
            SendMessage(tbNazivPretraga.Handle, EM_SETCUEBANNER, 0, "Naziv lijeka");
            SendMessage(tbKolicinaNaStanjuPretraga.Handle, EM_SETCUEBANNER, 0, "Količina na stanju manja od");
            PopuniTabeluLijekovaPretrazivanjem(false);
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

        private void btnKreiratiNarudzbu_Click(object sender, EventArgs e)
        {
            if (cbDobavljac.SelectedItem != null)
            {
                OmoguciPolja(false);
                PopuniTabeluLijekovaPretrazivanjem(false);
                dgvLijekovi.ClearSelection();
                dgvLijekovi.Select();
                tsmiLijekDetaljno.Enabled = false;
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        kreiranaNarudzba = new narudzba();
                        DateTime baseDate = new DateTime(1970, 1, 1);
                        TimeSpan diff = DateTime.Now - baseDate;
                        kreiranaNarudzba.datumKreiranja = DateTime.Today;
                        string miliSekundeKaoBrojNarudzbe = diff.TotalMilliseconds + "";
                        miliSekundeKaoBrojNarudzbe = miliSekundeKaoBrojNarudzbe.Replace('.', '/');
                        kreiranaNarudzba.brojNarudzbe = miliSekundeKaoBrojNarudzbe;
                        kreiranaNarudzba.ukupanIznos = 0;
                        kreiranaNarudzba.idZaposlenog = prijavljenZaposleni.idZaposlenog;
                        kreiranaNarudzba.idDobavljaca = ((dobavljac)cbDobavljac.SelectedItem).idDobavljaca;
                        context.narudzbas.Add(kreiranaNarudzba);
                        context.SaveChanges();
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
                MessageBox.Show("Dobavljač nije izabran.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOdustati_Click(object sender, EventArgs e)
        {
            gbPretragaLijeka.Enabled = true;
            gbPodaciStavkeNarudzbe.Enabled = false;
            tsmiIzmjenitiStavkuNarudzbe.Enabled = true;
            nudKolicinaNaStavciNarudzbe.Value = 1;
            if (izmjenaStavkeNarudzbe)
            {
                dgvNarudzba.Enabled = true;
                btnDodatiStavkuNarudzbe.Text = "Dodati";
                izmjenaStavkeNarudzbe = false;
            }
            if (dodavanjeStavkeNarudzbe)
                dodavanjeStavkeNarudzbe = false;
        }

        private void btnDodatiStavkuNarudzbe_Click(object sender, EventArgs e)
        {
            string poruka = "";
            int kolicinaNaStavci = 1;
            bool korektnaKolicina = false;

            if ((nudKolicinaNaStavciNarudzbe.Value.ToString()).Contains(".") || (nudKolicinaNaStavciNarudzbe.Value.ToString()).Contains(","))
            {
                poruka += "Količina na stavci mora biti cjelobrojni podatak veći od 1.";
                nudKolicinaNaStavciNarudzbe.Value = 1;
            }

            if (string.IsNullOrEmpty(poruka))
            {
                korektnaKolicina = int.TryParse(nudKolicinaNaStavciNarudzbe.Value.ToString(), out kolicinaNaStavci);
                if (!korektnaKolicina)
                {
                    poruka += "Količina na stavci mora biti cjelobrojni podatak veći od 1.";
                }
                if (kolicinaNaStavci < 1)
                {
                    poruka += "Količina na stavci mora biti cjelobrojni podatak veći od 1.";
                }
            }
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    if (string.IsNullOrEmpty(poruka))
                    {
                        if (!izmjenaStavkeNarudzbe)
                        {
                            stavkanarudzbe sNarudzbe = new stavkanarudzbe();
                            sNarudzbe.kolicina = kolicinaNaStavci;
                            sNarudzbe.iznos = odabraniLijek.nabavnaCijena * kolicinaNaStavci;
                            sNarudzbe.idLijeka = odabraniLijek.idLijeka;
                            sNarudzbe.idNarudzbe = kreiranaNarudzba.idNarudzbe;
                            context.stavkanarudzbes.Add(sNarudzbe);
                            context.SaveChanges();
                            kreiranaNarudzba = (from kNar in context.narudzbas
                                                where kNar.idNarudzbe == kreiranaNarudzba.idNarudzbe
                                                select kNar).FirstOrDefault();
                            kreiranaNarudzba.ukupanIznos = kreiranaNarudzba.ukupanIznos + sNarudzbe.iznos;
                            tbUkupanIznos.Text = kreiranaNarudzba.ukupanIznos.ToString();
                            context.SaveChanges();
                            DodajStavkuUTabeluNarudzba(sNarudzbe);
                            OmoguciPolja(false);
                            nudKolicinaNaStavciNarudzbe.Value = 1;
                            tsmiIzmjenitiStavkuNarudzbe.Enabled = true;
                            dodavanjeStavkeNarudzbe = false;
                        }
                        else
                        {
                            stavkanarudzbe sNarudzbe = (stavkanarudzbe)dgvNarudzba.SelectedRows[0].Tag;
                            lijek ljk = (from lij in context.lijeks
                                         where lij.idLijeka == sNarudzbe.idLijeka
                                         select lij).FirstOrDefault();
                            kreiranaNarudzba = (from kNar in context.narudzbas
                                                where kNar.idNarudzbe == kreiranaNarudzba.idNarudzbe
                                                select kNar).FirstOrDefault();
                            kreiranaNarudzba.ukupanIznos = kreiranaNarudzba.ukupanIznos - (ljk.nabavnaCijena * sNarudzbe.kolicina);
                            kreiranaNarudzba.ukupanIznos = kreiranaNarudzba.ukupanIznos + (ljk.nabavnaCijena * kolicinaNaStavci);
                            tbUkupanIznos.Text = kreiranaNarudzba.ukupanIznos.ToString();
                            context.SaveChanges();
                            stavkanarudzbe stavkaNarudzbe = (from sNar in context.stavkanarudzbes
                                                             where sNar.idLijeka == sNarudzbe.idLijeka && sNar.idNarudzbe == sNarudzbe.idNarudzbe
                                                             select sNar).FirstOrDefault();
                            stavkaNarudzbe.kolicina = kolicinaNaStavci;
                            stavkaNarudzbe.iznos = ljk.nabavnaCijena * kolicinaNaStavci;
                            context.SaveChanges();
                            DataGridViewRow row = dgvNarudzba.SelectedRows[0];
                            row.Tag = stavkaNarudzbe;
                            row.SetValues(ljk.naziv, ljk.nabavnaCijena, stavkaNarudzbe.kolicina, stavkaNarudzbe.iznos);
                            OmoguciPolja(false);
                            nudKolicinaNaStavciNarudzbe.Value = 1;
                            tsmiIzmjenitiStavkuNarudzbe.Enabled = true;
                            izmjenaStavkeNarudzbe = false;
                            btnDodatiStavkuNarudzbe.Text = "Dodati";
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

        private void DodajStavkuUTabeluNarudzba(stavkanarudzbe sNarudzbe)
        {
            DataGridViewRow r = new DataGridViewRow()
            {
                Tag = sNarudzbe
            };
            r.CreateCells(dgvNarudzba);
            r.SetValues(odabraniLijek.naziv, odabraniLijek.nabavnaCijena, sNarudzbe.kolicina, sNarudzbe.iznos);
            dgvNarudzba.Rows.Add(r);
            r.Selected = true;
            PostaviRedneBrojeveUTabeli(dgvNarudzba);
        }

        private void tsmiIzmjenitiStavkuNarudzbe_Click(object sender, EventArgs e)
        {
            if (dgvNarudzba.SelectedRows.Count == 1)
            {
                stavkanarudzbe sNarudzbe = (stavkanarudzbe)dgvNarudzba.SelectedRows[0].Tag;
                btnDodatiStavkuNarudzbe.Text = "Sačuvati";
                dgvNarudzba.Enabled = false;
                izmjenaStavkeNarudzbe = true;
                gbPretragaLijeka.Enabled = false;
                gbPodaciStavkeNarudzbe.Enabled = true;
                nudKolicinaNaStavciNarudzbe.Value = sNarudzbe.kolicina;
            }
        }

        private void tsmiObrisatiStavkuNarudzbe_Click(object sender, EventArgs e)
        {
            if (dgvNarudzba.SelectedRows.Count == 1)
            {
                stavkanarudzbe sNarudzbe = (stavkanarudzbe)dgvNarudzba.SelectedRows[0].Tag;
                if (DialogResult.Yes == MessageBox.Show("Da li želite obrisati stavku narudžbe?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    try
                    {
                        using (ApotekaDb context = new ApotekaDb())
                        {
                            kreiranaNarudzba = (from kNar in context.narudzbas
                                                where kNar.idNarudzbe == kreiranaNarudzba.idNarudzbe
                                                select kNar).FirstOrDefault();
                            kreiranaNarudzba.ukupanIznos = kreiranaNarudzba.ukupanIznos - sNarudzbe.iznos;
                            context.SaveChanges();
                            tbUkupanIznos.Text = kreiranaNarudzba.ukupanIznos.ToString();
                            lijek ljk = (from lij in context.lijeks
                                         where lij.idLijeka == sNarudzbe.idLijeka
                                         select lij).FirstOrDefault();
                            stavkanarudzbe stavkaNarudzbe = (from sn in context.stavkanarudzbes
                                                             where sn.idLijeka == sNarudzbe.idLijeka && sn.idNarudzbe == sNarudzbe.idNarudzbe
                                                             select sn).FirstOrDefault();
                            context.stavkanarudzbes.Remove(stavkaNarudzbe);
                            context.SaveChanges();
                            dgvNarudzba.Rows.Remove(dgvNarudzba.SelectedRows[0]);
                            if (dgvNarudzba.Rows.Count > 0)
                            {
                                PostaviRedneBrojeveUTabeli(dgvNarudzba);
                            }
                            else
                            {
                                tsmiIzmjenitiStavkuNarudzbe.Enabled = false;
                                tsmiObrisatiStavkuNarudzbe.Enabled = false;
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
        }

        private void dgvNarudzba_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNarudzba.SelectedRows.Count == 1 && dgvNarudzba.Rows.Count != 0)
            {
                if (dodavanjeStavkeNarudzbe)
                    tsmiIzmjenitiStavkuNarudzbe.Enabled = false;
                else
                    tsmiIzmjenitiStavkuNarudzbe.Enabled = true;
                tsmiObrisatiStavkuNarudzbe.Enabled = true;
            }
            else
            {
                tsmiIzmjenitiStavkuNarudzbe.Enabled = false;
                tsmiObrisatiStavkuNarudzbe.Enabled = false;
            }
        }

        private void dgvNarudzba_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tsmiIzmjenitiStavkuNarudzbe_Click(sender, e);
        }

        private void cmsTabelaNarudzba_Opening(object sender, CancelEventArgs e)
        {
            dgvNarudzba_SelectionChanged(sender, e);
        }

        private void btnPonistitiNarudzbu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Da li želite poništiti narudžbu?", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                PonistiKreiranuNarudzbu();
            }
        }

        private void PonistiKreiranuNarudzbu()
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    var listaStavkiNarudzbe = (from sn in context.stavkanarudzbes
                                               where sn.idNarudzbe == kreiranaNarudzba.idNarudzbe
                                               select sn).ToList();
                    foreach (stavkanarudzbe s in listaStavkiNarudzbe)
                    {
                        context.stavkanarudzbes.Remove(s);
                        context.SaveChanges();
                    }
                    narudzba nar = (from n in context.narudzbas
                                    where n.idNarudzbe == kreiranaNarudzba.idNarudzbe
                                    select n).FirstOrDefault();
                    context.narudzbas.Remove(nar);
                    context.SaveChanges();

                    OmoguciPolja(true);
                    nudKolicinaNaStavciNarudzbe.Value = 1;
                    dgvNarudzba.Rows.Clear();
                    dgvLijekovi.Rows.Clear();
                    tbUkupanIznos.Text = "0.00";
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZakljucitiNarudzbu_Click(object sender, EventArgs e)
        {
            if (dgvNarudzba.Rows.Count == 0)
            {
                MessageBox.Show("Narudžba se ne može zaključiti jer ne sadrži niti jednu stavku.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cbDobavljac.SelectedItem == null)
            {
                MessageBox.Show("Dobavljač nije izabran.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        kreiranaNarudzba = (from n in context.narudzbas
                                            where n.idNarudzbe == kreiranaNarudzba.idNarudzbe
                                            select n).FirstOrDefault();
                        kreiranaNarudzba.idDobavljaca = ((dobavljac)cbDobavljac.SelectedItem).idDobavljaca;
                        context.SaveChanges();
                        OmoguciPolja(true);
                        brojacNarudzbi++;
                        nudKolicinaNaStavciNarudzbe.Value = 1;
                        dgvNarudzba.Rows.Clear();
                        dgvLijekovi.Rows.Clear();
                        tbUkupanIznos.Text = "0.00";
                        PopuniListuNarudzbi();
                    }
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PopuniListuNarudzbi()
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    List<narudzba> narudzbe = new List<narudzba>();
                    narudzbe = (from n in context.narudzbas
                                where n.obrisano == false
                                select n).ToList();
                    int brojZavrsenih = 0;
                    int brojNezavrsenih = 0;
                    listaNarudzbi.Items.Clear();
                    foreach (var nar in narudzbe)
                    {
                        ListViewGroup lvg = null;
                        if (nar.kompletirano)
                        {
                            lvg = listaNarudzbi.Groups["lvgZavrsena"];
                            brojZavrsenih++;
                        }
                        else
                        {
                            lvg = listaNarudzbi.Groups["lvgNezavrsena"];
                            brojNezavrsenih++;
                        }

                        ListViewItem lvi = new ListViewItem();
                        lvi.Group = lvg;
                        lvi.Name = nar.brojNarudzbe;
                        lvi.Text = nar.brojNarudzbe;
                        lvi.Tag = nar;
                        lvi.SubItems.Add(nar.datumKreiranja.ToString("dd.MM.yyyy"));
                        string nazivDobavljaca = "";
                        var dob = (from d in context.dobavljacs
                                   where d.idDobavljaca == nar.idDobavljaca
                                   select d).FirstOrDefault();
                        nazivDobavljaca = dob.naziv;
                        lvi.SubItems.Add(nazivDobavljaca);
                        listaNarudzbi.Items.Add(lvi);
                    }
                    listaNarudzbi.Groups["lvgZavrsena"].Header = "Završene (" + brojZavrsenih + ")";
                    listaNarudzbi.Groups["lvgNezavrsena"].Header = "Nezavršene (" + brojNezavrsenih + ")";
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

