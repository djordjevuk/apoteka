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
    public partial class DobavljacForma : Form
    {
        private bool unosSacuvan;
        private ToolStripStatusLabel statusnaLabela;
        private DataGridView tabelaDobavljaca;
        private List<mjesto> mjesta;

        public DobavljacForma(ToolStripStatusLabel statusnaLabela, DataGridView tabelaDobavljaca)
        {
            InitializeComponent();
            this.statusnaLabela = statusnaLabela;
            this.tabelaDobavljaca = tabelaDobavljaca;
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    mjesta = (from m in context.mjestoes
                              where m.obrisano == false
                              select m).ToList();
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DobavljacForma_Load(object sender, EventArgs e)
        {
            PopuniComboBoxMjesta();
        }

        private void PopuniComboBoxMjesta()
        {
            cbMjesto.Items.Clear();
            cbMjesto.Items.AddRange(mjesta.ToArray());
        }

        private void DobavljacForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unosSacuvan)
            {
                string poruka = "";
                if (string.IsNullOrEmpty(tbNaziv.Text.Trim()))
                {
                    poruka += "Naziv nije unijet.\n";
                }
                if (string.IsNullOrEmpty(tbAdresa.Text.Trim()))
                {
                    poruka += "Adresa nije unijeta.\n";
                }
                if (cbMjesto.SelectedItem == null)
                {
                    poruka += "Mjesto nije izabrato.\n";
                }

                if (string.IsNullOrEmpty(poruka))
                {
                    try
                    {
                        using (ApotekaDb context = new ApotekaDb())
                        {
                            var dob = new dobavljac()
                            {
                                naziv = tbNaziv.Text.Trim(),
                                adresa = tbAdresa.Text.Trim(),
                                idMjesta = ((mjesto)cbMjesto.SelectedItem).idMjesta,
                                telefon = tbTelefon.Text.Trim(),
                                email = tbEmail.Text.Trim(),
                                webSajt = tbWebSajt.Text.Trim(),
                                regKodALMS = cbRegistrovanKodALMS.Checked
                            };
                            context.dobavljacs.Add(dob);
                            context.SaveChanges();
                            statusnaLabela.Text = "Uspješno unijet novi dobavljac.";
                            var dobavljaci = (from d in context.dobavljacs
                                              where d.obrisano == false
                                              select d).ToList();
                            PopuniTabeluDobavljaca(dobavljaci);
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

        private void PopuniTabeluDobavljaca(List<dobavljac> dobavljaci)
        {
            tabelaDobavljaca.Rows.Clear();
            foreach (var dob in dobavljaci)
            {
                DataGridViewRow r = new DataGridViewRow()
                {
                    Tag = dob
                };
                mjesto mj = null;
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        mj = (from m in context.mjestoes
                              where m.idMjesta == dob.idMjesta
                              select m).FirstOrDefault();
                    }

                    r.CreateCells(tabelaDobavljaca);
                    r.SetValues(dob.naziv, dob.adresa + ", " + mj.naziv, dob.telefon, dob.email);
                    tabelaDobavljaca.Rows.Add(r);
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PostaviRedneBrojeveUTabeli();
        }

        private void PostaviRedneBrojeveUTabeli()
        {
            foreach (DataGridViewRow row in tabelaDobavljaca.Rows)
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
