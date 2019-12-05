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
    public partial class LijekForma : Form
    {
        private bool menadzerPregled;
        private bool unosSacuvan;
        private lijek odabraniLijek;
        private ToolStripStatusLabel statusnaLabela;
        private DataGridView tabelaLijekova;

        public LijekForma(bool menadzerPregled, lijek l, ToolStripStatusLabel statusnaLabela, DataGridView tabelaLijekova)
        {
            InitializeComponent();
            this.menadzerPregled = menadzerPregled;
            this.odabraniLijek = l;
            this.statusnaLabela = statusnaLabela;
            this.tabelaLijekova = tabelaLijekova;
        }

        private void LijekForma_Load(object sender, EventArgs e)
        {
            if (odabraniLijek != null)
            {
                tbNaziv.Text = odabraniLijek.naziv;
                tbProizvodjac.Text = odabraniLijek.proizvodjac;
                tbPakovanje.Text = odabraniLijek.pakovanje;
                cbIzdavanjeNaRecept.Checked = odabraniLijek.izdavanjeNaRecept;
                tbNetoKolicina.Text = odabraniLijek.netoKolicina;
                nudKolicinaNaStanju.Value = odabraniLijek.kolicinaNaStanju;
                tbNabavnaCijena.Text = odabraniLijek.nabavnaCijena.ToString();
                tbProdajnaCijena.Text = odabraniLijek.prodajnaCijena.ToString();
                tbNamjena.Text = odabraniLijek.namjena;
                if (odabraniLijek.dozvolaVaziOd != null)
                    dtpDozvolaVaziOd.Value = odabraniLijek.dozvolaVaziOd;
                if (odabraniLijek.dozvolaVaziDo != null)
                    dtpDozvolaVaziDo.Value = odabraniLijek.dozvolaVaziDo;
            }
            OmoguciPolja();
        }

        private void LijekForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unosSacuvan)
            {
                decimal nabavnaCijenaUnos = 0;
                decimal prodajnaCijenaUnos = 0;
                bool neuspjesnaNabavna = false;
                bool neuspjesnaProdajna = false;
                string poruka = "";
                if (string.IsNullOrEmpty(tbNaziv.Text.Trim()))
                {
                    poruka += "Naziv nije unijet.\n";
                }
                if (string.IsNullOrEmpty(tbProizvodjac.Text.Trim()))
                {
                    poruka += "Proizvođač nije unijet.\n";
                }
                if (string.IsNullOrEmpty(tbPakovanje.Text.Trim()))
                {
                    poruka += "Pakovanje nije unijeto.\n";
                }
                if (string.IsNullOrEmpty(tbNetoKolicina.Text.Trim()))
                {
                    poruka += "Neto količina nije unijeta.\n";
                }
                if (dtpDozvolaVaziOd.Value > dtpDozvolaVaziDo.Value)
                {
                    poruka += "Datum od kad važi dozvola ne može biti poslije datuma isteka iste.\n";
                }
                if (!decimal.TryParse(tbNabavnaCijena.Text.Trim(), out nabavnaCijenaUnos))
                {
                    neuspjesnaNabavna = true;
                    poruka += "Nabavna cijena mora biti pozitivan broj.\n";
                }
                if (!neuspjesnaNabavna && nabavnaCijenaUnos < 0)
                {
                    poruka += "Nabavna cijena mora biti pozitivan broj.\n";
                }
                if (!decimal.TryParse(tbProdajnaCijena.Text.Trim(), out prodajnaCijenaUnos))
                {
                    neuspjesnaProdajna = true;
                    poruka += "Prodajna cijena mora biti pozitivan broj.\n";
                }
                if (!neuspjesnaProdajna && prodajnaCijenaUnos < 0)
                {
                    poruka += "Prodajna cijena mora biti pozitivan broj.\n";
                }

                if (string.IsNullOrEmpty(poruka))
                {
                    try
                    {
                        using (ApotekaDb context = new ApotekaDb())
                        {

                            var l = new lijek()
                            {
                                naziv = tbNaziv.Text.Trim(),
                                proizvodjac = tbProizvodjac.Text.Trim(),
                                pakovanje = tbPakovanje.Text.Trim(),
                                izdavanjeNaRecept = cbIzdavanjeNaRecept.Checked,
                                netoKolicina = tbNetoKolicina.Text.Trim(),
                                dozvolaVaziOd = dtpDozvolaVaziOd.Value,
                                dozvolaVaziDo = dtpDozvolaVaziDo.Value,
                                nabavnaCijena = nabavnaCijenaUnos,
                                prodajnaCijena = prodajnaCijenaUnos,
                                kolicinaNaStanju = 0,
                                namjena = tbNamjena.Text.Trim(),
                                idApoteke = 1
                            };
                            context.lijeks.Add(l);
                            context.SaveChanges();
                            statusnaLabela.Text = "Uspješno unijet novi lijek.";
                            var lijekovi = (from ljk in context.lijeks
                                            where ljk.obrisano == false
                                            select ljk).ToList();
                            PopuniTabeluLijekova(lijekovi);
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

        private void OmoguciPolja()
        {
            if (menadzerPregled)
            {
                lbKolicinaNaStanju.Hide();
                nudKolicinaNaStanju.Hide();
                foreach (Control cont in this.Controls)
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
                }
            }
            else
            {
                foreach (Control cont in this.Controls)
                {
                    if (cont is TextBox)
                    {
                        ((TextBox)cont).ReadOnly = true;
                        ((TextBox)cont).BackColor = SystemColors.Control;
                    }
                    else if (cont is Button)
                    {
                        ((Button)cont).Enabled = false;
                        ((Button)cont).Hide();
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
                }
            }
        }

        private void PopuniTabeluLijekova(List<lijek> lijekovi)
        {
            tabelaLijekova.Rows.Clear();
            foreach (var lj in lijekovi)
            {
                DataGridViewRow r = new DataGridViewRow()
                {
                    Tag = lj
                };
                r.CreateCells(tabelaLijekova);
                r.SetValues(lj.naziv, lj.dozvolaVaziOd.ToString("dd.MM.yyyy"), lj.dozvolaVaziDo.ToString("dd.MM.yyyy"), lj.izdavanjeNaRecept);
                tabelaLijekova.Rows.Add(r);
            }
            PostaviRedneBrojeveUTabeli();
        }

        private void PostaviRedneBrojeveUTabeli()
        {
            foreach (DataGridViewRow row in tabelaLijekova.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1) + ".";
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
    }
}
