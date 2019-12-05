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
    public partial class InformacijeOApoteciForma : Form
    {
        private apoteka apot;
        private sertifikat sertif;
        private ToolStripStatusLabel statusnaLabela;
        private ToolStripMenuItem infoOApoteci;
        private bool adminPregled;

        public InformacijeOApoteciForma(ToolStripMenuItem infoOApoteci, ToolStripStatusLabel statusnaLabela, bool adminPregled)
        {
            InitializeComponent();
            this.statusnaLabela = statusnaLabela;
            this.infoOApoteci = infoOApoteci;
            this.adminPregled = adminPregled;
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    apot = (apoteka)(from a in context.apotekas
                                     where a.idApoteke == 1
                                     select a).FirstOrDefault();
                    sertif = (sertifikat)(from s in context.sertifikats
                                          where s.idApoteke == apot.idApoteke
                                          select s).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InformacijeOApoteciForma_Load(object sender, EventArgs e)
        {
            PopuniComboBoxMjesta();
            PopuniPolja();
            dtpDatumOsnivanja.MaxDate = DateTime.Today;
            OmoguciPoljaNaFormi(false, gbPodaciOApoteci);
            OmoguciPoljaNaFormi(false, gbPodaciOSertifikatu);
            lbFokus.Select();
            if (adminPregled)
            {
                this.Height = 387;
                btnIzmjeniti.Enabled = true;
                btnSacuvati.Enabled = false;
                btnOdustati.Enabled = false;
            }
            else
            {
                this.Height = 346;
                btnIzmjeniti.Enabled = false;
                lbNaziv.Text = "Naziv:";
                lbAdresa.Text = "Adresa:";
                lbTelefon.Text = "Telefon:";
                lbMjesto.Text = "Mjesto:";
                lbDatumOsnivanja.Text = "Datum osnivanja:";
                lbStandard.Text = "Standard:";
                lbIzdatOd.Text = "Izdat od:";
                lbPodrucjePrimjene.Text = "Područje primjene:";
                lbDatumIsteka.Text = "Datum isteka:";
                lbDatumSertifikovanja.Text = "Datum sertifikovanja:";
                btnIzmjeniti.Enabled = false;
                btnSacuvati.Enabled = false;
                btnOdustati.Enabled = false;
            }
        }

        private void OmoguciPoljaNaFormi(bool omoguceno, GroupBox gbPodaci)
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
                    else if (cont is DateTimePicker)
                    {
                        ((DateTimePicker)cont).Enabled = true;
                        ((DateTimePicker)cont).BackColor = SystemColors.Window;
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
                    else if (cont is DateTimePicker)
                    {
                        ((DateTimePicker)cont).Enabled = false;
                        ((DateTimePicker)cont).BackColor = SystemColors.Control;
                    }
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

        private void PopuniPolja()
        {
            tbNaziv.Text = apot.nazivApoteke;
            tbAdresa.Text = apot.adresa;
            tbTelefon.Text = apot.telefon;
            tbEmail.Text = apot.email;
            tbWebSajt.Text = apot.webSajt;
            tbRadnoVrijeme.Text = apot.radnoVrijeme;
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    apot = (apoteka)(from a in context.apotekas
                                     where a.idApoteke == 1
                                     select a).FirstOrDefault();
                    cbMjesto.SelectedItem = apot.mjesto;
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dtpDatumOsnivanja.Text = apot.datumOsnivanja.ToString();
            cbDezurnaApoteka.Checked = apot.dezurnaApoteka;
            tbStandard.Text = sertif.standard;
            tbIzdatOd.Text = sertif.izdatOd;
            tbPodrucjePrimjene.Text = sertif.podrucjePrimjene;
            dtpDatumIsteka.Value = sertif.datumIsteka;
            dtpDatumSertifikovanja.Value = sertif.datumSertifikovanja;
        }

        private void btnIzmjeniti_Click(object sender, EventArgs e)
        {
            lbFokus.Select();
            OmoguciPoljaNaFormi(true, gbPodaciOApoteci);
            OmoguciPoljaNaFormi(true, gbPodaciOSertifikatu);
            btnIzmjeniti.Enabled = false;
            btnSacuvati.Enabled = true;
            btnOdustati.Enabled = true;
        }

        private void btnOdustati_Click(object sender, EventArgs e)
        {
            PopuniPolja();
            lbFokus.Select();
            OmoguciPoljaNaFormi(false, gbPodaciOApoteci);
            OmoguciPoljaNaFormi(false, gbPodaciOSertifikatu);
            btnIzmjeniti.Enabled = true;
            btnSacuvati.Enabled = false;
            btnOdustati.Enabled = false;
        }

        private void btnSacuvati_Click(object sender, EventArgs e)
        {
            string poruka = "";
            if (string.IsNullOrEmpty(tbNaziv.Text.Trim()))
            {
                poruka += "Naziv nije unijet.\n";
            }
            if (string.IsNullOrEmpty(tbAdresa.Text.Trim()))
            {
                poruka += "Ime nije unijeto.\n";
            }
            if (string.IsNullOrEmpty(tbTelefon.Text.Trim()))
            {
                poruka += "Telefon nije unijeto.\n";
            }
            if (string.IsNullOrEmpty(tbStandard.Text.Trim()))
            {
                poruka += "Standard nije unijet.\n";
            }
            if (string.IsNullOrEmpty(tbIzdatOd.Text.Trim()))
            {
                poruka += "Izdat od nije unijeto.\n";
            }
            if (string.IsNullOrEmpty(tbPodrucjePrimjene.Text.Trim()))
            {
                poruka += "Područje primjene nije unijeto.\n";
            }
            if (cbMjesto.SelectedItem == null)
            {
                poruka += "Mjesto nije izabrato.\n";
            }
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    if (string.IsNullOrEmpty(poruka))
                    {
                        apot = (apoteka)(from a in context.apotekas
                                         where a.idApoteke == 1
                                         select a).FirstOrDefault();
                        sertif = (sertifikat)(from s in context.sertifikats
                                              where s.idApoteke == apot.idApoteke
                                              select s).FirstOrDefault();
                        apot.nazivApoteke = tbNaziv.Text.Trim();
                        apot.adresa = tbAdresa.Text.Trim();
                        apot.telefon = tbTelefon.Text.Trim();
                        apot.email = tbEmail.Text.Trim();
                        apot.webSajt = tbWebSajt.Text.Trim();
                        apot.radnoVrijeme = tbRadnoVrijeme.Text.Trim();
                        apot.idMjesta = ((mjesto)cbMjesto.SelectedItem).idMjesta;
                        apot.datumOsnivanja = dtpDatumOsnivanja.Value;
                        apot.dezurnaApoteka = cbDezurnaApoteka.Checked;
                        context.SaveChanges();
                        sertif.standard = tbStandard.Text.Trim();
                        sertif.izdatOd = tbIzdatOd.Text.Trim();
                        sertif.podrucjePrimjene = tbPodrucjePrimjene.Text.Trim();
                        sertif.datumIsteka = dtpDatumIsteka.Value;
                        sertif.datumSertifikovanja = dtpDatumSertifikovanja.Value;
                        statusnaLabela.Text = "Podaci o apoteci su uspješno izmjenjeni.";
                        context.SaveChanges();
                        lbFokus.Select();
                        OmoguciPoljaNaFormi(false, gbPodaciOApoteci);
                        OmoguciPoljaNaFormi(false, gbPodaciOSertifikatu);
                        btnIzmjeniti.Enabled = true;
                        btnSacuvati.Enabled = false;
                        btnOdustati.Enabled = false;
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

        private void InformacijeOApoteciForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            infoOApoteci.Enabled = true;
        }
    }
}
