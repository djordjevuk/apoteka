using Apoteka.EFKlase;
using LanacApoteka.Podrska;
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
    public partial class PregledMjestaForma : Form
    {
        private mjesto odabranoMjesto;
        private AdminForma adminForma;
        private ToolStripStatusLabel statusnaLabela;

        public PregledMjestaForma(AdminForma adminForma, ToolStripStatusLabel statusnaLabela)
        {
            InitializeComponent();
            this.adminForma = adminForma;
            this.statusnaLabela = statusnaLabela;
            MessageBoxManager.OK = "OK";
            MessageBoxManager.Cancel = "Otkazati";
            MessageBoxManager.Yes = "Da";
            MessageBoxManager.No = "Ne";
            MessageBoxManager.Abort = "Prekinuti";
            MessageBoxManager.Ignore = "Ignorisati";
            MessageBoxManager.Retry = "Ponoviti";
            MessageBoxManager.Register();
        }

        private void PregledMjestaForma_Load(object sender, EventArgs e)
        {
            try
            {
                using (ApotekaDb context = new ApotekaDb())
                {
                    var mjesta = (from m in context.mjestoes
                                  where m.obrisano == false
                                  select m).ToList();
                    PopuniTabeluMjesta(mjesta);
                    PostaviRedneBrojeveUTabeli(dgvMjesta);
                }
            }
            catch (Exception)
            {
                string prk = "Došlo je do greške.";
                MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PregledMjestaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxManager.Unregister();
            adminForma.PodesiDugmad();
        }

        private void PopuniTabeluMjesta(List<mjesto> mjesta)
        {
            foreach (var mj in mjesta)
            {
                DataGridViewRow r = new DataGridViewRow()
                {
                    Tag = mj
                };
                r.CreateCells(dgvMjesta);
                r.SetValues(mj.naziv, mj.brojPoste, mj.drzava);
                dgvMjesta.Rows.Add(r);
                if (mj.Equals(odabranoMjesto))
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

        private void dgvMjesta_SelectionChanged(object sender, EventArgs e)
        {
            tsmiIzmjenitiMjesto.Enabled = tsmiObrisatiMjesto.Enabled = dgvMjesta.SelectedRows.Count == 1;
        }

        private void tsmiIzmjenitiMjesto_Click(object sender, EventArgs e)
        {
            odabranoMjesto = (mjesto)dgvMjesta.SelectedRows[0].Tag;
            MjestoForma novoMjesto = new MjestoForma()
            {
                IdMjesta = odabranoMjesto.idMjesta,
                Naziv = odabranoMjesto.naziv,
                Drzava = odabranoMjesto.drzava,
                BrojPoste = odabranoMjesto.brojPoste
            };
            novoMjesto.Text = "Izmjena mjesta";
            if (DialogResult.OK == novoMjesto.ShowDialog())
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        context.mjestoes.Attach(odabranoMjesto);
                        odabranoMjesto.brojPoste = novoMjesto.BrojPoste;
                        odabranoMjesto.naziv = novoMjesto.Naziv;
                        odabranoMjesto.drzava = novoMjesto.Drzava;
                        context.SaveChanges();
                        var mjesta = (from mj in context.mjestoes
                                      where mj.obrisano == false
                                      select mj).ToList();
                        dgvMjesta.Rows.Clear();
                        PopuniTabeluMjesta(mjesta);
                        PostaviRedneBrojeveUTabeli(dgvMjesta);
                    }
                    statusnaLabela.Text = "Mjesto je uspješno izmjenjeno.";
                }
                catch (Exception)
                {
                    string prk = "Došlo je do greške.";
                    MessageBox.Show(prk, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiObrisatiMjesto_Click(object sender, EventArgs e)
        {
            odabranoMjesto = (mjesto)dgvMjesta.SelectedRows[0].Tag;
            if (DialogResult.Yes == MessageBox.Show("Da li želite obrisati mjesto " + odabranoMjesto.naziv + "?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    using (ApotekaDb context = new ApotekaDb())
                    {
                        string poruka = "";
                        var zap = (from z in context.zaposlenis
                                   where z.obrisano == false
                                   select z).ToList();
                        foreach (zaposleni zapos in zap)
                        {
                            if (zapos.idMjesta == odabranoMjesto.idMjesta)
                            {
                                poruka += "Nije moguće obrisati mjesto, jer postoje zaposleni iz tog mjesta.\n";
                                break;
                            }
                        }
                        var dobavljaci = (from d in context.dobavljacs
                                          where d.obrisano == false
                                          select d).ToList();
                        foreach (dobavljac dob in dobavljaci)
                        {
                            if (dob.idMjesta == odabranoMjesto.idMjesta)
                            {
                                poruka += "Nije moguće obrisati mjesto, jer postoje dobavljači iz tog mjesta.";
                                break;
                            }
                        }
                        if (string.IsNullOrEmpty(poruka))
                        {
                            context.mjestoes.Attach(odabranoMjesto);
                            odabranoMjesto.obrisano = true;
                            context.SaveChanges();
                            odabranoMjesto = null;
                            statusnaLabela.Text = "Mjesto je uspješno obrisano.";
                            var mjesta = (from m in context.mjestoes
                                          where m.obrisano == false
                                          select m).ToList();
                            PopuniTabeluMjesta(mjesta);
                            PostaviRedneBrojeveUTabeli(dgvMjesta);
                            dgvMjesta.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show(poruka, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
