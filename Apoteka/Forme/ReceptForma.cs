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
    public partial class ReceptForma : Form
    {
        private recept rec;
        public ReceptForma(recept rcpt)
        {
            InitializeComponent();
            this.rec = rcpt;
        }

        private void ReceptForma_Load(object sender, EventArgs e)
        {
            PopuniPolja();
            OmoguciPoljaNaFormi(false, gbPodaciSaRecepta);
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

        private void PopuniPolja()
        {
            mtbJmbg.Text = rec.jmbg;
            tbPacijent.Text = rec.pacijent;
            tbAdresa.Text = rec.adresa;
            tbIzdatOdUstanove.Text = rec.izdatOdUstanove;
            tbIzdatOdDoktora.Text = rec.izdatOdDoktora;
            dtpDatumIzdavanja.Value = rec.datumIzdavanja;
            tbNapomena.Text = rec.napomena;
        }

        
    }
}
