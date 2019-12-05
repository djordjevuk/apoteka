namespace Apoteka.Forme
{
    partial class MenadzerForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenadzerForma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Nezavršena", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Završena", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Farmaceuti", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Menadžeri", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Administratori", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ssStatusnaLinija = new System.Windows.Forms.StatusStrip();
            this.tsslStatusnaLabela = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbProgresBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslPrijavljenZaposleni = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDatumVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlDobavljaci = new System.Windows.Forms.Panel();
            this.gbPretragaDobavljaca = new System.Windows.Forms.GroupBox();
            this.dgvDobavljaci = new System.Windows.Forms.DataGridView();
            this.nazivDobavljaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDobavljaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDobavljaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTabelaDobavljaci = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiIzmjenitiDobavljaca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiObrisatiDobavljaca = new System.Windows.Forms.ToolStripMenuItem();
            this.tbNazivDobavljacaPretraga = new System.Windows.Forms.TextBox();
            this.btnOcistiPoljaPretrageDobavljaca = new System.Windows.Forms.Button();
            this.gbPodaciODobavljacu = new System.Windows.Forms.GroupBox();
            this.tbWebSajtDobavljaca = new System.Windows.Forms.TextBox();
            this.lbWebSajtDobavljaca = new System.Windows.Forms.Label();
            this.tbEmailDobavljaca = new System.Windows.Forms.TextBox();
            this.lbEmailDobavljaca = new System.Windows.Forms.Label();
            this.lbAdresaDobavljaca = new System.Windows.Forms.Label();
            this.cbMjestoDobavljaca = new System.Windows.Forms.ComboBox();
            this.tbAdresaDobavljaca = new System.Windows.Forms.TextBox();
            this.lbMjestoDobavljaca = new System.Windows.Forms.Label();
            this.lbTelefonDobavljaca = new System.Windows.Forms.Label();
            this.tbTelefonDobavljaca = new System.Windows.Forms.TextBox();
            this.cbRegistrovanKodALMS = new System.Windows.Forms.CheckBox();
            this.lbRegKodALMSDobavljac = new System.Windows.Forms.Label();
            this.tbNazivDobavljaca = new System.Windows.Forms.TextBox();
            this.lbNazivDobavljaca = new System.Windows.Forms.Label();
            this.btnOdustatiDobavljac = new System.Windows.Forms.Button();
            this.btnSacuvatiDobavljaca = new System.Windows.Forms.Button();
            this.pnlRacuni = new System.Windows.Forms.Panel();
            this.gbPretragaRacuna = new System.Windows.Forms.GroupBox();
            this.btnKreiratiPdfIzvjestaj = new System.Windows.Forms.Button();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.dgvcDatumKreiranjaRacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIzdatOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTabelaRacuna = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiObrisatiRacun = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpDatumKreiranjaRacunaDoPretraga = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumKreiranjaRacunaOdPretraga = new System.Windows.Forms.DateTimePicker();
            this.btnOcistiPoljaPretrageRacuna = new System.Windows.Forms.Button();
            this.gbStavkeRacuna = new System.Windows.Forms.GroupBox();
            this.tbUkupanIznosRacuna = new System.Windows.Forms.TextBox();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.gdvcNazivLijeka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcKolicinaLijekaNaStavci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIznosNaStavci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTabelaStavkeRacuna = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPregledatiRecept = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlZaposleniSaTabelom = new System.Windows.Forms.Panel();
            this.gbPretragaZaposlenog = new System.Windows.Forms.GroupBox();
            this.tbStrucnaSpremaPretraga = new System.Windows.Forms.TextBox();
            this.dgvZaposleni = new System.Windows.Forms.DataGridView();
            this.jmbgTabelaZaposleni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeTabelaZaposleni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeTabelaZaposleni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strucnaSpremaTabelaZaposleni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTabelaZaposleni = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiIzmjenitiZaposlenog = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPrezimePretraga = new System.Windows.Forms.TextBox();
            this.tbImePretraga = new System.Windows.Forms.TextBox();
            this.tbJmbgPretraga = new System.Windows.Forms.TextBox();
            this.btnOcistiPoljaPretrage = new System.Windows.Forms.Button();
            this.gbPodaciZaposlenog = new System.Windows.Forms.GroupBox();
            this.mtbJmbg = new System.Windows.Forms.MaskedTextBox();
            this.lbJmbg = new System.Windows.Forms.Label();
            this.cbMjesto = new System.Windows.Forms.ComboBox();
            this.lbMjesto = new System.Windows.Forms.Label();
            this.btnOdustati = new System.Windows.Forms.Button();
            this.btnSacuvati = new System.Windows.Forms.Button();
            this.tbOpisPosla = new System.Windows.Forms.TextBox();
            this.lbOpisPosla = new System.Windows.Forms.Label();
            this.cbSefApoteke = new System.Windows.Forms.CheckBox();
            this.lbSefApoteke = new System.Windows.Forms.Label();
            this.tbFarmaceutskoZvanje = new System.Windows.Forms.TextBox();
            this.lbFarmaceutskoZvanje = new System.Windows.Forms.Label();
            this.tbStrucnaSprema = new System.Windows.Forms.TextBox();
            this.lbStrucnaSprema = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lbIme = new System.Windows.Forms.Label();
            this.pnlNarudzbe = new System.Windows.Forms.Panel();
            this.gbPodaciSaFakture = new System.Windows.Forms.GroupBox();
            this.lbPrimioFakturuZaposleni = new System.Windows.Forms.Label();
            this.lbPrimioFakturu = new System.Windows.Forms.Label();
            this.btnOdustatiFaktura = new System.Windows.Forms.Button();
            this.lbDatumIzdavanja = new System.Windows.Forms.Label();
            this.btnSacuvatiFaktura = new System.Windows.Forms.Button();
            this.dtpDatumIzdavanjaFakture = new System.Windows.Forms.DateTimePicker();
            this.tbNacinPlacanjaFakture = new System.Windows.Forms.TextBox();
            this.tbBrojFakture = new System.Windows.Forms.TextBox();
            this.lbMjestoIzdavanja = new System.Windows.Forms.Label();
            this.lbNacinPlacanja = new System.Windows.Forms.Label();
            this.lbBrojFakture = new System.Windows.Forms.Label();
            this.tbMjestoIzdavanjaFakture = new System.Windows.Forms.TextBox();
            this.gbPretragaNarudzbe = new System.Windows.Forms.GroupBox();
            this.dtpKreiranaDoPretraga = new System.Windows.Forms.DateTimePicker();
            this.dtpKreiranaOdPretraga = new System.Windows.Forms.DateTimePicker();
            this.lvNarudzbe = new System.Windows.Forms.ListView();
            this.brojNarudzbeKolona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datumKreiranjaKolona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobavljacKolona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsListaNarudzbi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiZavrsitiNarudzbu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiObrisatiNarudzbu = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDobavljacPretraga = new System.Windows.Forms.TextBox();
            this.tbBrojNarudzbePretraga = new System.Windows.Forms.TextBox();
            this.btnOcistiPoljaPretrageNarudzbe = new System.Windows.Forms.Button();
            this.gbStavkeNarudzbe = new System.Windows.Forms.GroupBox();
            this.tbUkupanIznosNarudzba = new System.Windows.Forms.TextBox();
            this.lbKreiraoNarudzbuZaposleni = new System.Windows.Forms.Label();
            this.lbKreiraoNarudzbu = new System.Windows.Forms.Label();
            this.dgvStavkeNarudzbe = new System.Windows.Forms.DataGridView();
            this.lijek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlZaposleniSaListom = new System.Windows.Forms.Panel();
            this.gbPretragaZaposlenogLista = new System.Windows.Forms.GroupBox();
            this.lvZaposleni = new System.Windows.Forms.ListView();
            this.jmbgListaZaposleni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imeListaZaposleni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezimeListaZaposleni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.strucnaSpremaListaZaposleni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsListaZaposleni = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiIzmjenitiZaposlenogLista = new System.Windows.Forms.ToolStripMenuItem();
            this.tbStrucnaSpremaPretragaLista = new System.Windows.Forms.TextBox();
            this.tbPrezimePretragaLista = new System.Windows.Forms.TextBox();
            this.tbImePretragaLista = new System.Windows.Forms.TextBox();
            this.tbJmbgPretragaLista = new System.Windows.Forms.TextBox();
            this.btnOcistiPoljaPretrageLista = new System.Windows.Forms.Button();
            this.gbPodaciZaposlenogLista = new System.Windows.Forms.GroupBox();
            this.mtbJmbgLista = new System.Windows.Forms.MaskedTextBox();
            this.lbJmbgLista = new System.Windows.Forms.Label();
            this.cbMjestoLista = new System.Windows.Forms.ComboBox();
            this.lbMjestoLista = new System.Windows.Forms.Label();
            this.btnOdustatiLista = new System.Windows.Forms.Button();
            this.btnSacuvatiLista = new System.Windows.Forms.Button();
            this.tbOpisPoslaLista = new System.Windows.Forms.TextBox();
            this.lbOpisPoslaLista = new System.Windows.Forms.Label();
            this.cbSefApotekeLista = new System.Windows.Forms.CheckBox();
            this.lbSefApotekeLista = new System.Windows.Forms.Label();
            this.tbFarmaceutskoZvanjeLista = new System.Windows.Forms.TextBox();
            this.lbFarmaceutskoZvanjeLista = new System.Windows.Forms.Label();
            this.tbStrucnaSpremaLista = new System.Windows.Forms.TextBox();
            this.lbStrucnaSpremaLista = new System.Windows.Forms.Label();
            this.tbEmailLista = new System.Windows.Forms.TextBox();
            this.lbEmailLista = new System.Windows.Forms.Label();
            this.tbTelefonLista = new System.Windows.Forms.TextBox();
            this.lbTelefonLista = new System.Windows.Forms.Label();
            this.tbAdresaLista = new System.Windows.Forms.TextBox();
            this.lbAdresaLista = new System.Windows.Forms.Label();
            this.tbPrezimeLista = new System.Windows.Forms.TextBox();
            this.lbPrezimeLista = new System.Windows.Forms.Label();
            this.tbImeLista = new System.Windows.Forms.TextBox();
            this.lbImeLista = new System.Windows.Forms.Label();
            this.pnlLijekovi = new System.Windows.Forms.Panel();
            this.gbPretragaLijeka = new System.Windows.Forms.GroupBox();
            this.dtpDozvolaVaziDoPretraga = new System.Windows.Forms.DateTimePicker();
            this.dtpDozvolaVaziOdPretraga = new System.Windows.Forms.DateTimePicker();
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.nazivLijeka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dozvolaVaziOdLijek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dozvolaVaziDoLijek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naReceptLijek = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsTabelaLijekova = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiIzmjenitiLijek = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiObrisatiLijek = new System.Windows.Forms.ToolStripMenuItem();
            this.cbIzdavanjeNaReceptPretraga = new System.Windows.Forms.CheckBox();
            this.tbNazivLijekaPretraga = new System.Windows.Forms.TextBox();
            this.btnOcistiPoljaPretrageLijekova = new System.Windows.Forms.Button();
            this.gbPodaciOLijeku = new System.Windows.Forms.GroupBox();
            this.tbNamjenaLijeka = new System.Windows.Forms.TextBox();
            this.lbNamjenaLijeka = new System.Windows.Forms.Label();
            this.dtpDozvolaVaziDoLijeka = new System.Windows.Forms.DateTimePicker();
            this.lbDozvolaVaziDoLijeka = new System.Windows.Forms.Label();
            this.dtpDozvolaVaziOdLijeka = new System.Windows.Forms.DateTimePicker();
            this.lbDozvolaVaziOdLijeka = new System.Windows.Forms.Label();
            this.lbKolicinaNaStanjuLijeka = new System.Windows.Forms.Label();
            this.nudKolicinaNaStanjuLijeka = new System.Windows.Forms.NumericUpDown();
            this.cbIzdavanjeNaReceptLijeka = new System.Windows.Forms.CheckBox();
            this.lbIzdavanjeNaReceptLijeka = new System.Windows.Forms.Label();
            this.tbPakovanjeLijeka = new System.Windows.Forms.TextBox();
            this.lbPakovanjeLijeka = new System.Windows.Forms.Label();
            this.tbProdajnaCijenaLijeka = new System.Windows.Forms.TextBox();
            this.lbProdajnaCijenaLijeka = new System.Windows.Forms.Label();
            this.tbNabavnaCijenaLijeka = new System.Windows.Forms.TextBox();
            this.lbNabavnaCijenaLijeka = new System.Windows.Forms.Label();
            this.tbNetoKolicinaLijeka = new System.Windows.Forms.TextBox();
            this.lbNetoKolicinaLijeka = new System.Windows.Forms.Label();
            this.tbProizvodjacLijeka = new System.Windows.Forms.TextBox();
            this.lbProizvodjacLijeka = new System.Windows.Forms.Label();
            this.tbNazivLijeka = new System.Windows.Forms.TextBox();
            this.lbNazivLijeka = new System.Windows.Forms.Label();
            this.btnOdustatiLijek = new System.Windows.Forms.Button();
            this.btnSacuvatiLijek = new System.Windows.Forms.Button();
            this.msMeni = new System.Windows.Forms.MenuStrip();
            this.tsmiZaposleni = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPregledatiZaposlene = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaTabelom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaListom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLijek = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPregledLijekova = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDodatiLijek = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDobavljaci = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPregledDobavljaca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDodatiDobavljaca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUlazIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNarudzbeFakture = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPregledNarudzbaFaktura = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKreiratiNarudzbu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRacuni = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPregledRacuna = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiApoteka = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInformacijeOApoteci = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMojNalog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPromjenitiLozinku = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInformacijeOAplikaciji = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerTrenutnoVrijeme = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.ssStatusnaLinija.SuspendLayout();
            this.pnlDobavljaci.SuspendLayout();
            this.gbPretragaDobavljaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            this.cmsTabelaDobavljaci.SuspendLayout();
            this.gbPodaciODobavljacu.SuspendLayout();
            this.pnlRacuni.SuspendLayout();
            this.gbPretragaRacuna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.cmsTabelaRacuna.SuspendLayout();
            this.gbStavkeRacuna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            this.cmsTabelaStavkeRacuna.SuspendLayout();
            this.pnlZaposleniSaTabelom.SuspendLayout();
            this.gbPretragaZaposlenog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            this.cmsTabelaZaposleni.SuspendLayout();
            this.gbPodaciZaposlenog.SuspendLayout();
            this.pnlNarudzbe.SuspendLayout();
            this.gbPodaciSaFakture.SuspendLayout();
            this.gbPretragaNarudzbe.SuspendLayout();
            this.cmsListaNarudzbi.SuspendLayout();
            this.gbStavkeNarudzbe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbe)).BeginInit();
            this.pnlZaposleniSaListom.SuspendLayout();
            this.gbPretragaZaposlenogLista.SuspendLayout();
            this.cmsListaZaposleni.SuspendLayout();
            this.gbPodaciZaposlenogLista.SuspendLayout();
            this.pnlLijekovi.SuspendLayout();
            this.gbPretragaLijeka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            this.cmsTabelaLijekova.SuspendLayout();
            this.gbPodaciOLijeku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicinaNaStanjuLijeka)).BeginInit();
            this.msMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.ssStatusnaLinija);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlDobavljaci);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlRacuni);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlZaposleniSaTabelom);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlNarudzbe);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlZaposleniSaListom);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlLijekovi);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(831, 393);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(831, 441);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.msMeni);
            // 
            // ssStatusnaLinija
            // 
            this.ssStatusnaLinija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(206)))), ((int)(((byte)(184)))));
            this.ssStatusnaLinija.Dock = System.Windows.Forms.DockStyle.None;
            this.ssStatusnaLinija.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatusnaLabela,
            this.tspbProgresBar,
            this.tsslPrijavljenZaposleni,
            this.tsslDatumVrijeme});
            this.ssStatusnaLinija.Location = new System.Drawing.Point(0, 0);
            this.ssStatusnaLinija.Name = "ssStatusnaLinija";
            this.ssStatusnaLinija.Size = new System.Drawing.Size(831, 24);
            this.ssStatusnaLinija.SizingGrip = false;
            this.ssStatusnaLinija.TabIndex = 0;
            // 
            // tsslStatusnaLabela
            // 
            this.tsslStatusnaLabela.Name = "tsslStatusnaLabela";
            this.tsslStatusnaLabela.Size = new System.Drawing.Size(619, 19);
            this.tsslStatusnaLabela.Spring = true;
            this.tsslStatusnaLabela.Text = "Aplikacija je spremna";
            this.tsslStatusnaLabela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tspbProgresBar
            // 
            this.tspbProgresBar.MarqueeAnimationSpeed = 20;
            this.tspbProgresBar.Name = "tspbProgresBar";
            this.tspbProgresBar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tspbProgresBar.Size = new System.Drawing.Size(100, 18);
            this.tspbProgresBar.Step = 100;
            this.tspbProgresBar.Visible = false;
            // 
            // tsslPrijavljenZaposleni
            // 
            this.tsslPrijavljenZaposleni.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsslPrijavljenZaposleni.Name = "tsslPrijavljenZaposleni";
            this.tsslPrijavljenZaposleni.Size = new System.Drawing.Size(110, 19);
            this.tsslPrijavljenZaposleni.Text = "PrijavljenZaposleni";
            this.tsslPrijavljenZaposleni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsslDatumVrijeme
            // 
            this.tsslDatumVrijeme.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsslDatumVrijeme.Name = "tsslDatumVrijeme";
            this.tsslDatumVrijeme.Size = new System.Drawing.Size(87, 19);
            this.tsslDatumVrijeme.Text = "DatumVrijeme";
            this.tsslDatumVrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDobavljaci
            // 
            this.pnlDobavljaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.pnlDobavljaci.Controls.Add(this.gbPretragaDobavljaca);
            this.pnlDobavljaci.Controls.Add(this.gbPodaciODobavljacu);
            this.pnlDobavljaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDobavljaci.Location = new System.Drawing.Point(0, 0);
            this.pnlDobavljaci.Name = "pnlDobavljaci";
            this.pnlDobavljaci.Size = new System.Drawing.Size(831, 393);
            this.pnlDobavljaci.TabIndex = 3;
            // 
            // gbPretragaDobavljaca
            // 
            this.gbPretragaDobavljaca.Controls.Add(this.dgvDobavljaci);
            this.gbPretragaDobavljaca.Controls.Add(this.tbNazivDobavljacaPretraga);
            this.gbPretragaDobavljaca.Controls.Add(this.btnOcistiPoljaPretrageDobavljaca);
            this.gbPretragaDobavljaca.Location = new System.Drawing.Point(12, 3);
            this.gbPretragaDobavljaca.Name = "gbPretragaDobavljaca";
            this.gbPretragaDobavljaca.Size = new System.Drawing.Size(487, 387);
            this.gbPretragaDobavljaca.TabIndex = 0;
            this.gbPretragaDobavljaca.TabStop = false;
            this.gbPretragaDobavljaca.Text = "Pretraga dobavljača";
            // 
            // dgvDobavljaci
            // 
            this.dgvDobavljaci.AllowUserToAddRows = false;
            this.dgvDobavljaci.AllowUserToDeleteRows = false;
            this.dgvDobavljaci.AllowUserToOrderColumns = true;
            this.dgvDobavljaci.AllowUserToResizeRows = false;
            this.dgvDobavljaci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDobavljaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDobavljaci.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDobavljaca,
            this.adresaDobavljaca,
            this.telefonDobavljaca});
            this.dgvDobavljaci.ContextMenuStrip = this.cmsTabelaDobavljaci;
            this.dgvDobavljaci.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDobavljaci.Location = new System.Drawing.Point(6, 45);
            this.dgvDobavljaci.MultiSelect = false;
            this.dgvDobavljaci.Name = "dgvDobavljaci";
            this.dgvDobavljaci.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDobavljaci.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDobavljaci.RowHeadersWidth = 49;
            this.dgvDobavljaci.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDobavljaci.Size = new System.Drawing.Size(475, 336);
            this.dgvDobavljaci.TabIndex = 0;
            this.dgvDobavljaci.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDobavljaci_CellMouseDoubleClick);
            this.dgvDobavljaci.SelectionChanged += new System.EventHandler(this.dgvDobavljaci_SelectionChanged);
            // 
            // nazivDobavljaca
            // 
            this.nazivDobavljaca.FillWeight = 105F;
            this.nazivDobavljaca.HeaderText = "Naziv";
            this.nazivDobavljaca.Name = "nazivDobavljaca";
            this.nazivDobavljaca.ReadOnly = true;
            this.nazivDobavljaca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // adresaDobavljaca
            // 
            this.adresaDobavljaca.FillWeight = 105F;
            this.adresaDobavljaca.HeaderText = "Adresa";
            this.adresaDobavljaca.Name = "adresaDobavljaca";
            this.adresaDobavljaca.ReadOnly = true;
            this.adresaDobavljaca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // telefonDobavljaca
            // 
            this.telefonDobavljaca.HeaderText = "Telefon";
            this.telefonDobavljaca.Name = "telefonDobavljaca";
            this.telefonDobavljaca.ReadOnly = true;
            this.telefonDobavljaca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cmsTabelaDobavljaci
            // 
            this.cmsTabelaDobavljaci.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIzmjenitiDobavljaca,
            this.tsmiObrisatiDobavljaca});
            this.cmsTabelaDobavljaci.Name = "cmsTabelaZaposleni";
            this.cmsTabelaDobavljaci.Size = new System.Drawing.Size(120, 48);
            // 
            // tsmiIzmjenitiDobavljaca
            // 
            this.tsmiIzmjenitiDobavljaca.Image = global::Apoteka.Properties.Resources.edit;
            this.tsmiIzmjenitiDobavljaca.Name = "tsmiIzmjenitiDobavljaca";
            this.tsmiIzmjenitiDobavljaca.Size = new System.Drawing.Size(119, 22);
            this.tsmiIzmjenitiDobavljaca.Text = "Izmjeniti";
            this.tsmiIzmjenitiDobavljaca.Click += new System.EventHandler(this.tsmiIzmjenitiDobavljaca_Click);
            // 
            // tsmiObrisatiDobavljaca
            // 
            this.tsmiObrisatiDobavljaca.Image = global::Apoteka.Properties.Resources.trash;
            this.tsmiObrisatiDobavljaca.Name = "tsmiObrisatiDobavljaca";
            this.tsmiObrisatiDobavljaca.Size = new System.Drawing.Size(119, 22);
            this.tsmiObrisatiDobavljaca.Text = "Obrisati";
            this.tsmiObrisatiDobavljaca.Click += new System.EventHandler(this.tsmiObrisatiDobavljaca_Click);
            // 
            // tbNazivDobavljacaPretraga
            // 
            this.tbNazivDobavljacaPretraga.Location = new System.Drawing.Point(54, 19);
            this.tbNazivDobavljacaPretraga.Name = "tbNazivDobavljacaPretraga";
            this.tbNazivDobavljacaPretraga.Size = new System.Drawing.Size(140, 20);
            this.tbNazivDobavljacaPretraga.TabIndex = 0;
            this.tbNazivDobavljacaPretraga.TextChanged += new System.EventHandler(this.tbNazivDobavljacaPretraga_TextChanged);
            // 
            // btnOcistiPoljaPretrageDobavljaca
            // 
            this.btnOcistiPoljaPretrageDobavljaca.Image = global::Apoteka.Properties.Resources.eraser;
            this.btnOcistiPoljaPretrageDobavljaca.Location = new System.Drawing.Point(6, 16);
            this.btnOcistiPoljaPretrageDobavljaca.Name = "btnOcistiPoljaPretrageDobavljaca";
            this.btnOcistiPoljaPretrageDobavljaca.Size = new System.Drawing.Size(42, 25);
            this.btnOcistiPoljaPretrageDobavljaca.TabIndex = 1;
            this.btnOcistiPoljaPretrageDobavljaca.UseVisualStyleBackColor = true;
            this.btnOcistiPoljaPretrageDobavljaca.Click += new System.EventHandler(this.btnOcistiPoljaPretrageDobavljaca_Click);
            // 
            // gbPodaciODobavljacu
            // 
            this.gbPodaciODobavljacu.Controls.Add(this.tbWebSajtDobavljaca);
            this.gbPodaciODobavljacu.Controls.Add(this.lbWebSajtDobavljaca);
            this.gbPodaciODobavljacu.Controls.Add(this.tbEmailDobavljaca);
            this.gbPodaciODobavljacu.Controls.Add(this.lbEmailDobavljaca);
            this.gbPodaciODobavljacu.Controls.Add(this.lbAdresaDobavljaca);
            this.gbPodaciODobavljacu.Controls.Add(this.cbMjestoDobavljaca);
            this.gbPodaciODobavljacu.Controls.Add(this.tbAdresaDobavljaca);
            this.gbPodaciODobavljacu.Controls.Add(this.lbMjestoDobavljaca);
            this.gbPodaciODobavljacu.Controls.Add(this.lbTelefonDobavljaca);
            this.gbPodaciODobavljacu.Controls.Add(this.tbTelefonDobavljaca);
            this.gbPodaciODobavljacu.Controls.Add(this.cbRegistrovanKodALMS);
            this.gbPodaciODobavljacu.Controls.Add(this.lbRegKodALMSDobavljac);
            this.gbPodaciODobavljacu.Controls.Add(this.tbNazivDobavljaca);
            this.gbPodaciODobavljacu.Controls.Add(this.lbNazivDobavljaca);
            this.gbPodaciODobavljacu.Controls.Add(this.btnOdustatiDobavljac);
            this.gbPodaciODobavljacu.Controls.Add(this.btnSacuvatiDobavljaca);
            this.gbPodaciODobavljacu.Location = new System.Drawing.Point(505, 3);
            this.gbPodaciODobavljacu.Name = "gbPodaciODobavljacu";
            this.gbPodaciODobavljacu.Size = new System.Drawing.Size(314, 387);
            this.gbPodaciODobavljacu.TabIndex = 0;
            this.gbPodaciODobavljacu.TabStop = false;
            this.gbPodaciODobavljacu.Text = "Podaci o dobavljaču";
            // 
            // tbWebSajtDobavljaca
            // 
            this.tbWebSajtDobavljaca.Location = new System.Drawing.Point(120, 220);
            this.tbWebSajtDobavljaca.MaxLength = 80;
            this.tbWebSajtDobavljaca.Name = "tbWebSajtDobavljaca";
            this.tbWebSajtDobavljaca.Size = new System.Drawing.Size(188, 20);
            this.tbWebSajtDobavljaca.TabIndex = 5;
            // 
            // lbWebSajtDobavljaca
            // 
            this.lbWebSajtDobavljaca.AutoSize = true;
            this.lbWebSajtDobavljaca.Location = new System.Drawing.Point(6, 223);
            this.lbWebSajtDobavljaca.Name = "lbWebSajtDobavljaca";
            this.lbWebSajtDobavljaca.Size = new System.Drawing.Size(52, 13);
            this.lbWebSajtDobavljaca.TabIndex = 104;
            this.lbWebSajtDobavljaca.Text = "Web sajt:";
            // 
            // tbEmailDobavljaca
            // 
            this.tbEmailDobavljaca.Location = new System.Drawing.Point(120, 180);
            this.tbEmailDobavljaca.MaxLength = 80;
            this.tbEmailDobavljaca.Name = "tbEmailDobavljaca";
            this.tbEmailDobavljaca.Size = new System.Drawing.Size(188, 20);
            this.tbEmailDobavljaca.TabIndex = 4;
            // 
            // lbEmailDobavljaca
            // 
            this.lbEmailDobavljaca.AutoSize = true;
            this.lbEmailDobavljaca.Location = new System.Drawing.Point(6, 183);
            this.lbEmailDobavljaca.Name = "lbEmailDobavljaca";
            this.lbEmailDobavljaca.Size = new System.Drawing.Size(35, 13);
            this.lbEmailDobavljaca.TabIndex = 102;
            this.lbEmailDobavljaca.Text = "Email:";
            // 
            // lbAdresaDobavljaca
            // 
            this.lbAdresaDobavljaca.AutoSize = true;
            this.lbAdresaDobavljaca.Location = new System.Drawing.Point(6, 61);
            this.lbAdresaDobavljaca.Name = "lbAdresaDobavljaca";
            this.lbAdresaDobavljaca.Size = new System.Drawing.Size(47, 13);
            this.lbAdresaDobavljaca.TabIndex = 98;
            this.lbAdresaDobavljaca.Text = "Adresa:*";
            // 
            // cbMjestoDobavljaca
            // 
            this.cbMjestoDobavljaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMjestoDobavljaca.FormattingEnabled = true;
            this.cbMjestoDobavljaca.Location = new System.Drawing.Point(120, 97);
            this.cbMjestoDobavljaca.Name = "cbMjestoDobavljaca";
            this.cbMjestoDobavljaca.Size = new System.Drawing.Size(188, 21);
            this.cbMjestoDobavljaca.TabIndex = 2;
            // 
            // tbAdresaDobavljaca
            // 
            this.tbAdresaDobavljaca.Location = new System.Drawing.Point(120, 58);
            this.tbAdresaDobavljaca.MaxLength = 100;
            this.tbAdresaDobavljaca.Name = "tbAdresaDobavljaca";
            this.tbAdresaDobavljaca.Size = new System.Drawing.Size(188, 20);
            this.tbAdresaDobavljaca.TabIndex = 1;
            // 
            // lbMjestoDobavljaca
            // 
            this.lbMjestoDobavljaca.AutoSize = true;
            this.lbMjestoDobavljaca.Location = new System.Drawing.Point(6, 100);
            this.lbMjestoDobavljaca.Name = "lbMjestoDobavljaca";
            this.lbMjestoDobavljaca.Size = new System.Drawing.Size(45, 13);
            this.lbMjestoDobavljaca.TabIndex = 100;
            this.lbMjestoDobavljaca.Text = "Mjesto:*";
            // 
            // lbTelefonDobavljaca
            // 
            this.lbTelefonDobavljaca.AutoSize = true;
            this.lbTelefonDobavljaca.Location = new System.Drawing.Point(6, 142);
            this.lbTelefonDobavljaca.Name = "lbTelefonDobavljaca";
            this.lbTelefonDobavljaca.Size = new System.Drawing.Size(46, 13);
            this.lbTelefonDobavljaca.TabIndex = 99;
            this.lbTelefonDobavljaca.Text = "Telefon:";
            // 
            // tbTelefonDobavljaca
            // 
            this.tbTelefonDobavljaca.Location = new System.Drawing.Point(120, 139);
            this.tbTelefonDobavljaca.MaxLength = 100;
            this.tbTelefonDobavljaca.Name = "tbTelefonDobavljaca";
            this.tbTelefonDobavljaca.Size = new System.Drawing.Size(188, 20);
            this.tbTelefonDobavljaca.TabIndex = 3;
            // 
            // cbRegistrovanKodALMS
            // 
            this.cbRegistrovanKodALMS.AutoSize = true;
            this.cbRegistrovanKodALMS.Location = new System.Drawing.Point(120, 255);
            this.cbRegistrovanKodALMS.Name = "cbRegistrovanKodALMS";
            this.cbRegistrovanKodALMS.Size = new System.Drawing.Size(15, 14);
            this.cbRegistrovanKodALMS.TabIndex = 6;
            this.cbRegistrovanKodALMS.UseVisualStyleBackColor = true;
            // 
            // lbRegKodALMSDobavljac
            // 
            this.lbRegKodALMSDobavljac.AutoSize = true;
            this.lbRegKodALMSDobavljac.Location = new System.Drawing.Point(6, 255);
            this.lbRegKodALMSDobavljac.Name = "lbRegKodALMSDobavljac";
            this.lbRegKodALMSDobavljac.Size = new System.Drawing.Size(108, 13);
            this.lbRegKodALMSDobavljac.TabIndex = 94;
            this.lbRegKodALMSDobavljac.Text = "Registrovan u ALMS:";
            // 
            // tbNazivDobavljaca
            // 
            this.tbNazivDobavljaca.Location = new System.Drawing.Point(120, 19);
            this.tbNazivDobavljaca.MaxLength = 60;
            this.tbNazivDobavljaca.Name = "tbNazivDobavljaca";
            this.tbNazivDobavljaca.Size = new System.Drawing.Size(188, 20);
            this.tbNazivDobavljaca.TabIndex = 0;
            // 
            // lbNazivDobavljaca
            // 
            this.lbNazivDobavljaca.AutoSize = true;
            this.lbNazivDobavljaca.Location = new System.Drawing.Point(6, 22);
            this.lbNazivDobavljaca.Name = "lbNazivDobavljaca";
            this.lbNazivDobavljaca.Size = new System.Drawing.Size(41, 13);
            this.lbNazivDobavljaca.TabIndex = 92;
            this.lbNazivDobavljaca.Text = "Naziv:*";
            // 
            // btnOdustatiDobavljac
            // 
            this.btnOdustatiDobavljac.Image = global::Apoteka.Properties.Resources.cancel;
            this.btnOdustatiDobavljac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustatiDobavljac.Location = new System.Drawing.Point(220, 354);
            this.btnOdustatiDobavljac.Name = "btnOdustatiDobavljac";
            this.btnOdustatiDobavljac.Size = new System.Drawing.Size(87, 27);
            this.btnOdustatiDobavljac.TabIndex = 8;
            this.btnOdustatiDobavljac.Text = "Odustati";
            this.btnOdustatiDobavljac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustatiDobavljac.UseVisualStyleBackColor = true;
            this.btnOdustatiDobavljac.Click += new System.EventHandler(this.btnOdustatiDobavljac_Click);
            // 
            // btnSacuvatiDobavljaca
            // 
            this.btnSacuvatiDobavljaca.Image = ((System.Drawing.Image)(resources.GetObject("btnSacuvatiDobavljaca.Image")));
            this.btnSacuvatiDobavljaca.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSacuvatiDobavljaca.Location = new System.Drawing.Point(120, 354);
            this.btnSacuvatiDobavljaca.Name = "btnSacuvatiDobavljaca";
            this.btnSacuvatiDobavljaca.Size = new System.Drawing.Size(87, 27);
            this.btnSacuvatiDobavljaca.TabIndex = 7;
            this.btnSacuvatiDobavljaca.Text = "Sačuvati";
            this.btnSacuvatiDobavljaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSacuvatiDobavljaca.UseVisualStyleBackColor = true;
            this.btnSacuvatiDobavljaca.Click += new System.EventHandler(this.btnSacuvatiDobavljaca_Click);
            // 
            // pnlRacuni
            // 
            this.pnlRacuni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.pnlRacuni.Controls.Add(this.gbPretragaRacuna);
            this.pnlRacuni.Controls.Add(this.gbStavkeRacuna);
            this.pnlRacuni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRacuni.Location = new System.Drawing.Point(0, 0);
            this.pnlRacuni.Name = "pnlRacuni";
            this.pnlRacuni.Size = new System.Drawing.Size(831, 393);
            this.pnlRacuni.TabIndex = 5;
            // 
            // gbPretragaRacuna
            // 
            this.gbPretragaRacuna.Controls.Add(this.btnKreiratiPdfIzvjestaj);
            this.gbPretragaRacuna.Controls.Add(this.dgvRacuni);
            this.gbPretragaRacuna.Controls.Add(this.dtpDatumKreiranjaRacunaDoPretraga);
            this.gbPretragaRacuna.Controls.Add(this.dtpDatumKreiranjaRacunaOdPretraga);
            this.gbPretragaRacuna.Controls.Add(this.btnOcistiPoljaPretrageRacuna);
            this.gbPretragaRacuna.Location = new System.Drawing.Point(12, 3);
            this.gbPretragaRacuna.Name = "gbPretragaRacuna";
            this.gbPretragaRacuna.Size = new System.Drawing.Size(487, 387);
            this.gbPretragaRacuna.TabIndex = 0;
            this.gbPretragaRacuna.TabStop = false;
            this.gbPretragaRacuna.Text = "Pretraga računa";
            // 
            // btnKreiratiPdfIzvjestaj
            // 
            this.btnKreiratiPdfIzvjestaj.Image = global::Apoteka.Properties.Resources.export_to_pdf;
            this.btnKreiratiPdfIzvjestaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKreiratiPdfIzvjestaj.Location = new System.Drawing.Point(371, 16);
            this.btnKreiratiPdfIzvjestaj.Name = "btnKreiratiPdfIzvjestaj";
            this.btnKreiratiPdfIzvjestaj.Size = new System.Drawing.Size(110, 25);
            this.btnKreiratiPdfIzvjestaj.TabIndex = 6;
            this.btnKreiratiPdfIzvjestaj.Text = "Kreirati izvještaj";
            this.btnKreiratiPdfIzvjestaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKreiratiPdfIzvjestaj.UseVisualStyleBackColor = true;
            this.btnKreiratiPdfIzvjestaj.Click += new System.EventHandler(this.btnKreiratiPdfIzvjestaj_Click);
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToAddRows = false;
            this.dgvRacuni.AllowUserToDeleteRows = false;
            this.dgvRacuni.AllowUserToOrderColumns = true;
            this.dgvRacuni.AllowUserToResizeRows = false;
            this.dgvRacuni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcDatumKreiranjaRacuna,
            this.dgvcIzdatOd});
            this.dgvRacuni.ContextMenuStrip = this.cmsTabelaRacuna;
            this.dgvRacuni.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRacuni.Location = new System.Drawing.Point(6, 47);
            this.dgvRacuni.MultiSelect = false;
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuni.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRacuni.RowHeadersWidth = 49;
            this.dgvRacuni.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(475, 334);
            this.dgvRacuni.TabIndex = 5;
            this.dgvRacuni.TabStop = false;
            this.dgvRacuni.SelectionChanged += new System.EventHandler(this.dgvRacuni_SelectionChanged);
            // 
            // dgvcDatumKreiranjaRacuna
            // 
            this.dgvcDatumKreiranjaRacuna.FillWeight = 118.8985F;
            this.dgvcDatumKreiranjaRacuna.HeaderText = "Datum kreiranja";
            this.dgvcDatumKreiranjaRacuna.Name = "dgvcDatumKreiranjaRacuna";
            this.dgvcDatumKreiranjaRacuna.ReadOnly = true;
            this.dgvcDatumKreiranjaRacuna.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvcIzdatOd
            // 
            this.dgvcIzdatOd.FillWeight = 120F;
            this.dgvcIzdatOd.HeaderText = "Račun izdao";
            this.dgvcIzdatOd.Name = "dgvcIzdatOd";
            this.dgvcIzdatOd.ReadOnly = true;
            this.dgvcIzdatOd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cmsTabelaRacuna
            // 
            this.cmsTabelaRacuna.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiObrisatiRacun});
            this.cmsTabelaRacuna.Name = "cmsTabelaZaposleni";
            this.cmsTabelaRacuna.Size = new System.Drawing.Size(116, 26);
            // 
            // tsmiObrisatiRacun
            // 
            this.tsmiObrisatiRacun.Image = global::Apoteka.Properties.Resources.trash;
            this.tsmiObrisatiRacun.Name = "tsmiObrisatiRacun";
            this.tsmiObrisatiRacun.Size = new System.Drawing.Size(115, 22);
            this.tsmiObrisatiRacun.Text = "Obrisati";
            this.tsmiObrisatiRacun.Click += new System.EventHandler(this.tsmiObrisatiRacun_Click);
            // 
            // dtpDatumKreiranjaRacunaDoPretraga
            // 
            this.dtpDatumKreiranjaRacunaDoPretraga.CustomFormat = "dd.MM.yyyy";
            this.dtpDatumKreiranjaRacunaDoPretraga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumKreiranjaRacunaDoPretraga.Location = new System.Drawing.Point(155, 19);
            this.dtpDatumKreiranjaRacunaDoPretraga.Name = "dtpDatumKreiranjaRacunaDoPretraga";
            this.dtpDatumKreiranjaRacunaDoPretraga.Size = new System.Drawing.Size(95, 20);
            this.dtpDatumKreiranjaRacunaDoPretraga.TabIndex = 2;
            this.dtpDatumKreiranjaRacunaDoPretraga.ValueChanged += new System.EventHandler(this.dtpDatumKreiranjaRacunaDoPretraga_ValueChanged);
            // 
            // dtpDatumKreiranjaRacunaOdPretraga
            // 
            this.dtpDatumKreiranjaRacunaOdPretraga.CustomFormat = "dd.MM.yyyy";
            this.dtpDatumKreiranjaRacunaOdPretraga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumKreiranjaRacunaOdPretraga.Location = new System.Drawing.Point(54, 19);
            this.dtpDatumKreiranjaRacunaOdPretraga.Name = "dtpDatumKreiranjaRacunaOdPretraga";
            this.dtpDatumKreiranjaRacunaOdPretraga.Size = new System.Drawing.Size(95, 20);
            this.dtpDatumKreiranjaRacunaOdPretraga.TabIndex = 1;
            this.dtpDatumKreiranjaRacunaOdPretraga.ValueChanged += new System.EventHandler(this.dtpDatumKreiranjaRacunaOdPretraga_ValueChanged);
            // 
            // btnOcistiPoljaPretrageRacuna
            // 
            this.btnOcistiPoljaPretrageRacuna.Image = global::Apoteka.Properties.Resources.eraser;
            this.btnOcistiPoljaPretrageRacuna.Location = new System.Drawing.Point(6, 16);
            this.btnOcistiPoljaPretrageRacuna.Name = "btnOcistiPoljaPretrageRacuna";
            this.btnOcistiPoljaPretrageRacuna.Size = new System.Drawing.Size(42, 25);
            this.btnOcistiPoljaPretrageRacuna.TabIndex = 4;
            this.btnOcistiPoljaPretrageRacuna.UseVisualStyleBackColor = true;
            this.btnOcistiPoljaPretrageRacuna.Click += new System.EventHandler(this.btnOcistiPoljaPretrageRacuna_Click);
            // 
            // gbStavkeRacuna
            // 
            this.gbStavkeRacuna.Controls.Add(this.tbUkupanIznosRacuna);
            this.gbStavkeRacuna.Controls.Add(this.dgvStavkeRacuna);
            this.gbStavkeRacuna.Location = new System.Drawing.Point(505, 3);
            this.gbStavkeRacuna.Name = "gbStavkeRacuna";
            this.gbStavkeRacuna.Size = new System.Drawing.Size(314, 387);
            this.gbStavkeRacuna.TabIndex = 0;
            this.gbStavkeRacuna.TabStop = false;
            this.gbStavkeRacuna.Text = "Stavke računa";
            // 
            // tbUkupanIznosRacuna
            // 
            this.tbUkupanIznosRacuna.Enabled = false;
            this.tbUkupanIznosRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUkupanIznosRacuna.Location = new System.Drawing.Point(200, 16);
            this.tbUkupanIznosRacuna.Multiline = true;
            this.tbUkupanIznosRacuna.Name = "tbUkupanIznosRacuna";
            this.tbUkupanIznosRacuna.Size = new System.Drawing.Size(108, 27);
            this.tbUkupanIznosRacuna.TabIndex = 20;
            this.tbUkupanIznosRacuna.Text = "0.00";
            this.tbUkupanIznosRacuna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.AllowUserToAddRows = false;
            this.dgvStavkeRacuna.AllowUserToDeleteRows = false;
            this.dgvStavkeRacuna.AllowUserToOrderColumns = true;
            this.dgvStavkeRacuna.AllowUserToResizeRows = false;
            this.dgvStavkeRacuna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStavkeRacuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkeRacuna.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gdvcNazivLijeka,
            this.dgvcKolicinaLijekaNaStavci,
            this.dgvcIznosNaStavci});
            this.dgvStavkeRacuna.ContextMenuStrip = this.cmsTabelaStavkeRacuna;
            this.dgvStavkeRacuna.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(6, 48);
            this.dgvStavkeRacuna.MultiSelect = false;
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStavkeRacuna.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStavkeRacuna.RowHeadersWidth = 49;
            this.dgvStavkeRacuna.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStavkeRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(302, 333);
            this.dgvStavkeRacuna.TabIndex = 2;
            this.dgvStavkeRacuna.SelectionChanged += new System.EventHandler(this.dgvStavkeRacuna_SelectionChanged);
            // 
            // gdvcNazivLijeka
            // 
            this.gdvcNazivLijeka.FillWeight = 105.8985F;
            this.gdvcNazivLijeka.HeaderText = "Lijek";
            this.gdvcNazivLijeka.Name = "gdvcNazivLijeka";
            this.gdvcNazivLijeka.ReadOnly = true;
            this.gdvcNazivLijeka.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvcKolicinaLijekaNaStavci
            // 
            this.dgvcKolicinaLijekaNaStavci.FillWeight = 60.8985F;
            this.dgvcKolicinaLijekaNaStavci.HeaderText = "Količina";
            this.dgvcKolicinaLijekaNaStavci.Name = "dgvcKolicinaLijekaNaStavci";
            this.dgvcKolicinaLijekaNaStavci.ReadOnly = true;
            this.dgvcKolicinaLijekaNaStavci.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvcIznosNaStavci
            // 
            this.dgvcIznosNaStavci.FillWeight = 100.8985F;
            this.dgvcIznosNaStavci.HeaderText = "Iznos";
            this.dgvcIznosNaStavci.Name = "dgvcIznosNaStavci";
            this.dgvcIznosNaStavci.ReadOnly = true;
            this.dgvcIznosNaStavci.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cmsTabelaStavkeRacuna
            // 
            this.cmsTabelaStavkeRacuna.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPregledatiRecept});
            this.cmsTabelaStavkeRacuna.Name = "cmsTabelaZaposleni";
            this.cmsTabelaStavkeRacuna.Size = new System.Drawing.Size(164, 26);
            this.cmsTabelaStavkeRacuna.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTabelaStavkeRacuna_Opening);
            // 
            // tsmiPregledatiRecept
            // 
            this.tsmiPregledatiRecept.Name = "tsmiPregledatiRecept";
            this.tsmiPregledatiRecept.Size = new System.Drawing.Size(163, 22);
            this.tsmiPregledatiRecept.Text = "Pregledati recept";
            this.tsmiPregledatiRecept.Click += new System.EventHandler(this.tsmiPregledatiRecept_Click);
            // 
            // pnlZaposleniSaTabelom
            // 
            this.pnlZaposleniSaTabelom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.pnlZaposleniSaTabelom.Controls.Add(this.gbPretragaZaposlenog);
            this.pnlZaposleniSaTabelom.Controls.Add(this.gbPodaciZaposlenog);
            this.pnlZaposleniSaTabelom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlZaposleniSaTabelom.Location = new System.Drawing.Point(0, 0);
            this.pnlZaposleniSaTabelom.Name = "pnlZaposleniSaTabelom";
            this.pnlZaposleniSaTabelom.Size = new System.Drawing.Size(831, 393);
            this.pnlZaposleniSaTabelom.TabIndex = 2;
            // 
            // gbPretragaZaposlenog
            // 
            this.gbPretragaZaposlenog.Controls.Add(this.tbStrucnaSpremaPretraga);
            this.gbPretragaZaposlenog.Controls.Add(this.dgvZaposleni);
            this.gbPretragaZaposlenog.Controls.Add(this.tbPrezimePretraga);
            this.gbPretragaZaposlenog.Controls.Add(this.tbImePretraga);
            this.gbPretragaZaposlenog.Controls.Add(this.tbJmbgPretraga);
            this.gbPretragaZaposlenog.Controls.Add(this.btnOcistiPoljaPretrage);
            this.gbPretragaZaposlenog.Location = new System.Drawing.Point(12, 3);
            this.gbPretragaZaposlenog.Name = "gbPretragaZaposlenog";
            this.gbPretragaZaposlenog.Size = new System.Drawing.Size(487, 387);
            this.gbPretragaZaposlenog.TabIndex = 0;
            this.gbPretragaZaposlenog.TabStop = false;
            this.gbPretragaZaposlenog.Text = "Pretraga zaposlenih";
            // 
            // tbStrucnaSpremaPretraga
            // 
            this.tbStrucnaSpremaPretraga.Location = new System.Drawing.Point(381, 19);
            this.tbStrucnaSpremaPretraga.Name = "tbStrucnaSpremaPretraga";
            this.tbStrucnaSpremaPretraga.Size = new System.Drawing.Size(100, 20);
            this.tbStrucnaSpremaPretraga.TabIndex = 0;
            this.tbStrucnaSpremaPretraga.TextChanged += new System.EventHandler(this.tbStrucnaSpremaPretraga_TextChanged);
            // 
            // dgvZaposleni
            // 
            this.dgvZaposleni.AllowUserToAddRows = false;
            this.dgvZaposleni.AllowUserToDeleteRows = false;
            this.dgvZaposleni.AllowUserToOrderColumns = true;
            this.dgvZaposleni.AllowUserToResizeRows = false;
            this.dgvZaposleni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvZaposleni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZaposleni.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposleni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jmbgTabelaZaposleni,
            this.imeTabelaZaposleni,
            this.prezimeTabelaZaposleni,
            this.strucnaSpremaTabelaZaposleni});
            this.dgvZaposleni.ContextMenuStrip = this.cmsTabelaZaposleni;
            this.dgvZaposleni.GridColor = System.Drawing.SystemColors.Control;
            this.dgvZaposleni.Location = new System.Drawing.Point(6, 45);
            this.dgvZaposleni.MultiSelect = false;
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZaposleni.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZaposleni.RowHeadersWidth = 49;
            this.dgvZaposleni.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvZaposleni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposleni.Size = new System.Drawing.Size(475, 336);
            this.dgvZaposleni.TabIndex = 0;
            this.dgvZaposleni.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvZaposleni_CellMouseDoubleClick);
            this.dgvZaposleni.SelectionChanged += new System.EventHandler(this.dgvZaposleni_SelectionChanged);
            // 
            // jmbgTabelaZaposleni
            // 
            this.jmbgTabelaZaposleni.FillWeight = 105F;
            this.jmbgTabelaZaposleni.HeaderText = "JMBG";
            this.jmbgTabelaZaposleni.Name = "jmbgTabelaZaposleni";
            this.jmbgTabelaZaposleni.ReadOnly = true;
            this.jmbgTabelaZaposleni.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // imeTabelaZaposleni
            // 
            this.imeTabelaZaposleni.FillWeight = 105F;
            this.imeTabelaZaposleni.HeaderText = "Ime";
            this.imeTabelaZaposleni.Name = "imeTabelaZaposleni";
            this.imeTabelaZaposleni.ReadOnly = true;
            this.imeTabelaZaposleni.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // prezimeTabelaZaposleni
            // 
            this.prezimeTabelaZaposleni.HeaderText = "Prezime";
            this.prezimeTabelaZaposleni.Name = "prezimeTabelaZaposleni";
            this.prezimeTabelaZaposleni.ReadOnly = true;
            this.prezimeTabelaZaposleni.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // strucnaSpremaTabelaZaposleni
            // 
            this.strucnaSpremaTabelaZaposleni.HeaderText = "Stručna sprema";
            this.strucnaSpremaTabelaZaposleni.Name = "strucnaSpremaTabelaZaposleni";
            this.strucnaSpremaTabelaZaposleni.ReadOnly = true;
            this.strucnaSpremaTabelaZaposleni.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cmsTabelaZaposleni
            // 
            this.cmsTabelaZaposleni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIzmjenitiZaposlenog});
            this.cmsTabelaZaposleni.Name = "cmsTabelaZaposleni";
            this.cmsTabelaZaposleni.Size = new System.Drawing.Size(120, 26);
            // 
            // tsmiIzmjenitiZaposlenog
            // 
            this.tsmiIzmjenitiZaposlenog.Image = global::Apoteka.Properties.Resources.edit;
            this.tsmiIzmjenitiZaposlenog.Name = "tsmiIzmjenitiZaposlenog";
            this.tsmiIzmjenitiZaposlenog.Size = new System.Drawing.Size(119, 22);
            this.tsmiIzmjenitiZaposlenog.Text = "Izmjeniti";
            this.tsmiIzmjenitiZaposlenog.Click += new System.EventHandler(this.tsmiIzmjenitiZaposlenog_Click);
            // 
            // tbPrezimePretraga
            // 
            this.tbPrezimePretraga.Location = new System.Drawing.Point(272, 19);
            this.tbPrezimePretraga.Name = "tbPrezimePretraga";
            this.tbPrezimePretraga.Size = new System.Drawing.Size(102, 20);
            this.tbPrezimePretraga.TabIndex = 2;
            this.tbPrezimePretraga.TextChanged += new System.EventHandler(this.tbPrezimePretraga_TextChanged);
            // 
            // tbImePretraga
            // 
            this.tbImePretraga.Location = new System.Drawing.Point(163, 19);
            this.tbImePretraga.Name = "tbImePretraga";
            this.tbImePretraga.Size = new System.Drawing.Size(103, 20);
            this.tbImePretraga.TabIndex = 1;
            this.tbImePretraga.TextChanged += new System.EventHandler(this.tbImePretraga_TextChanged);
            // 
            // tbJmbgPretraga
            // 
            this.tbJmbgPretraga.Location = new System.Drawing.Point(54, 19);
            this.tbJmbgPretraga.Name = "tbJmbgPretraga";
            this.tbJmbgPretraga.Size = new System.Drawing.Size(103, 20);
            this.tbJmbgPretraga.TabIndex = 0;
            this.tbJmbgPretraga.TextChanged += new System.EventHandler(this.tbJmbgPretraga_TextChanged);
            // 
            // btnOcistiPoljaPretrage
            // 
            this.btnOcistiPoljaPretrage.Image = global::Apoteka.Properties.Resources.eraser;
            this.btnOcistiPoljaPretrage.Location = new System.Drawing.Point(6, 16);
            this.btnOcistiPoljaPretrage.Name = "btnOcistiPoljaPretrage";
            this.btnOcistiPoljaPretrage.Size = new System.Drawing.Size(42, 25);
            this.btnOcistiPoljaPretrage.TabIndex = 4;
            this.btnOcistiPoljaPretrage.UseVisualStyleBackColor = true;
            this.btnOcistiPoljaPretrage.Click += new System.EventHandler(this.btnOcistiPoljaPretrage_Click);
            // 
            // gbPodaciZaposlenog
            // 
            this.gbPodaciZaposlenog.Controls.Add(this.mtbJmbg);
            this.gbPodaciZaposlenog.Controls.Add(this.lbJmbg);
            this.gbPodaciZaposlenog.Controls.Add(this.cbMjesto);
            this.gbPodaciZaposlenog.Controls.Add(this.lbMjesto);
            this.gbPodaciZaposlenog.Controls.Add(this.btnOdustati);
            this.gbPodaciZaposlenog.Controls.Add(this.btnSacuvati);
            this.gbPodaciZaposlenog.Controls.Add(this.tbOpisPosla);
            this.gbPodaciZaposlenog.Controls.Add(this.lbOpisPosla);
            this.gbPodaciZaposlenog.Controls.Add(this.cbSefApoteke);
            this.gbPodaciZaposlenog.Controls.Add(this.lbSefApoteke);
            this.gbPodaciZaposlenog.Controls.Add(this.tbFarmaceutskoZvanje);
            this.gbPodaciZaposlenog.Controls.Add(this.lbFarmaceutskoZvanje);
            this.gbPodaciZaposlenog.Controls.Add(this.tbStrucnaSprema);
            this.gbPodaciZaposlenog.Controls.Add(this.lbStrucnaSprema);
            this.gbPodaciZaposlenog.Controls.Add(this.tbEmail);
            this.gbPodaciZaposlenog.Controls.Add(this.lbEmail);
            this.gbPodaciZaposlenog.Controls.Add(this.tbTelefon);
            this.gbPodaciZaposlenog.Controls.Add(this.lbTelefon);
            this.gbPodaciZaposlenog.Controls.Add(this.tbAdresa);
            this.gbPodaciZaposlenog.Controls.Add(this.lbAdresa);
            this.gbPodaciZaposlenog.Controls.Add(this.tbPrezime);
            this.gbPodaciZaposlenog.Controls.Add(this.lbPrezime);
            this.gbPodaciZaposlenog.Controls.Add(this.tbIme);
            this.gbPodaciZaposlenog.Controls.Add(this.lbIme);
            this.gbPodaciZaposlenog.Location = new System.Drawing.Point(505, 3);
            this.gbPodaciZaposlenog.Name = "gbPodaciZaposlenog";
            this.gbPodaciZaposlenog.Size = new System.Drawing.Size(314, 387);
            this.gbPodaciZaposlenog.TabIndex = 0;
            this.gbPodaciZaposlenog.TabStop = false;
            this.gbPodaciZaposlenog.Text = "Podaci o zaposlenom";
            // 
            // mtbJmbg
            // 
            this.mtbJmbg.Location = new System.Drawing.Point(116, 19);
            this.mtbJmbg.Mask = "0000000000000";
            this.mtbJmbg.Name = "mtbJmbg";
            this.mtbJmbg.Size = new System.Drawing.Size(87, 20);
            this.mtbJmbg.TabIndex = 0;
            // 
            // lbJmbg
            // 
            this.lbJmbg.AutoSize = true;
            this.lbJmbg.Location = new System.Drawing.Point(6, 22);
            this.lbJmbg.Name = "lbJmbg";
            this.lbJmbg.Size = new System.Drawing.Size(43, 13);
            this.lbJmbg.TabIndex = 0;
            this.lbJmbg.Text = "JMBG:*";
            // 
            // cbMjesto
            // 
            this.cbMjesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMjesto.FormattingEnabled = true;
            this.cbMjesto.Location = new System.Drawing.Point(116, 123);
            this.cbMjesto.Name = "cbMjesto";
            this.cbMjesto.Size = new System.Drawing.Size(187, 21);
            this.cbMjesto.TabIndex = 4;
            // 
            // lbMjesto
            // 
            this.lbMjesto.AutoSize = true;
            this.lbMjesto.Location = new System.Drawing.Point(6, 126);
            this.lbMjesto.Name = "lbMjesto";
            this.lbMjesto.Size = new System.Drawing.Size(45, 13);
            this.lbMjesto.TabIndex = 18;
            this.lbMjesto.Text = "Mjesto:*";
            // 
            // btnOdustati
            // 
            this.btnOdustati.Image = global::Apoteka.Properties.Resources.cancel;
            this.btnOdustati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustati.Location = new System.Drawing.Point(216, 354);
            this.btnOdustati.Name = "btnOdustati";
            this.btnOdustati.Size = new System.Drawing.Size(87, 27);
            this.btnOdustati.TabIndex = 12;
            this.btnOdustati.Text = "Odustati";
            this.btnOdustati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustati.UseVisualStyleBackColor = true;
            this.btnOdustati.Click += new System.EventHandler(this.btnOdustati_Click);
            // 
            // btnSacuvati
            // 
            this.btnSacuvati.Image = ((System.Drawing.Image)(resources.GetObject("btnSacuvati.Image")));
            this.btnSacuvati.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSacuvati.Location = new System.Drawing.Point(116, 354);
            this.btnSacuvati.Name = "btnSacuvati";
            this.btnSacuvati.Size = new System.Drawing.Size(87, 27);
            this.btnSacuvati.TabIndex = 11;
            this.btnSacuvati.Text = "Sačuvati";
            this.btnSacuvati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSacuvati.UseVisualStyleBackColor = true;
            this.btnSacuvati.Click += new System.EventHandler(this.btnSacuvati_Click);
            // 
            // tbOpisPosla
            // 
            this.tbOpisPosla.Location = new System.Drawing.Point(116, 275);
            this.tbOpisPosla.MaxLength = 150;
            this.tbOpisPosla.Multiline = true;
            this.tbOpisPosla.Name = "tbOpisPosla";
            this.tbOpisPosla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOpisPosla.Size = new System.Drawing.Size(187, 53);
            this.tbOpisPosla.TabIndex = 10;
            // 
            // lbOpisPosla
            // 
            this.lbOpisPosla.AutoSize = true;
            this.lbOpisPosla.Location = new System.Drawing.Point(6, 278);
            this.lbOpisPosla.Name = "lbOpisPosla";
            this.lbOpisPosla.Size = new System.Drawing.Size(59, 13);
            this.lbOpisPosla.TabIndex = 17;
            this.lbOpisPosla.Text = "Opis posla:";
            // 
            // cbSefApoteke
            // 
            this.cbSefApoteke.AutoSize = true;
            this.cbSefApoteke.Location = new System.Drawing.Point(116, 255);
            this.cbSefApoteke.Name = "cbSefApoteke";
            this.cbSefApoteke.Size = new System.Drawing.Size(15, 14);
            this.cbSefApoteke.TabIndex = 9;
            this.cbSefApoteke.UseVisualStyleBackColor = true;
            // 
            // lbSefApoteke
            // 
            this.lbSefApoteke.AutoSize = true;
            this.lbSefApoteke.Location = new System.Drawing.Point(6, 255);
            this.lbSefApoteke.Name = "lbSefApoteke";
            this.lbSefApoteke.Size = new System.Drawing.Size(68, 13);
            this.lbSefApoteke.TabIndex = 15;
            this.lbSefApoteke.Text = "Šef apoteke:";
            // 
            // tbFarmaceutskoZvanje
            // 
            this.tbFarmaceutskoZvanje.Location = new System.Drawing.Point(116, 229);
            this.tbFarmaceutskoZvanje.MaxLength = 50;
            this.tbFarmaceutskoZvanje.Name = "tbFarmaceutskoZvanje";
            this.tbFarmaceutskoZvanje.Size = new System.Drawing.Size(187, 20);
            this.tbFarmaceutskoZvanje.TabIndex = 8;
            // 
            // lbFarmaceutskoZvanje
            // 
            this.lbFarmaceutskoZvanje.AutoSize = true;
            this.lbFarmaceutskoZvanje.Location = new System.Drawing.Point(6, 232);
            this.lbFarmaceutskoZvanje.Name = "lbFarmaceutskoZvanje";
            this.lbFarmaceutskoZvanje.Size = new System.Drawing.Size(111, 13);
            this.lbFarmaceutskoZvanje.TabIndex = 13;
            this.lbFarmaceutskoZvanje.Text = "Farmaceutsko zvanje:";
            // 
            // tbStrucnaSprema
            // 
            this.tbStrucnaSprema.Location = new System.Drawing.Point(116, 203);
            this.tbStrucnaSprema.MaxLength = 40;
            this.tbStrucnaSprema.Name = "tbStrucnaSprema";
            this.tbStrucnaSprema.Size = new System.Drawing.Size(187, 20);
            this.tbStrucnaSprema.TabIndex = 7;
            // 
            // lbStrucnaSprema
            // 
            this.lbStrucnaSprema.AutoSize = true;
            this.lbStrucnaSprema.Location = new System.Drawing.Point(6, 206);
            this.lbStrucnaSprema.Name = "lbStrucnaSprema";
            this.lbStrucnaSprema.Size = new System.Drawing.Size(88, 13);
            this.lbStrucnaSprema.TabIndex = 11;
            this.lbStrucnaSprema.Text = "Stručna sprema:*";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(116, 177);
            this.tbEmail.MaxLength = 80;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(187, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(6, 180);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(116, 151);
            this.tbTelefon.MaxLength = 100;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(187, 20);
            this.tbTelefon.TabIndex = 5;
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(6, 154);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(46, 13);
            this.lbTelefon.TabIndex = 6;
            this.lbTelefon.Text = "Telefon:";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(116, 97);
            this.tbAdresa.MaxLength = 100;
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(187, 20);
            this.tbAdresa.TabIndex = 3;
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Location = new System.Drawing.Point(6, 100);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(47, 13);
            this.lbAdresa.TabIndex = 4;
            this.lbAdresa.Text = "Adresa:*";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(116, 71);
            this.tbPrezime.MaxLength = 40;
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(187, 20);
            this.tbPrezime.TabIndex = 2;
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Location = new System.Drawing.Point(6, 74);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(51, 13);
            this.lbPrezime.TabIndex = 2;
            this.lbPrezime.Text = "Prezime:*";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(116, 45);
            this.tbIme.MaxLength = 40;
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(187, 20);
            this.tbIme.TabIndex = 1;
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(6, 48);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(31, 13);
            this.lbIme.TabIndex = 0;
            this.lbIme.Text = "Ime:*";
            // 
            // pnlNarudzbe
            // 
            this.pnlNarudzbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.pnlNarudzbe.Controls.Add(this.gbPodaciSaFakture);
            this.pnlNarudzbe.Controls.Add(this.gbPretragaNarudzbe);
            this.pnlNarudzbe.Controls.Add(this.gbStavkeNarudzbe);
            this.pnlNarudzbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNarudzbe.Location = new System.Drawing.Point(0, 0);
            this.pnlNarudzbe.Name = "pnlNarudzbe";
            this.pnlNarudzbe.Size = new System.Drawing.Size(831, 393);
            this.pnlNarudzbe.TabIndex = 4;
            // 
            // gbPodaciSaFakture
            // 
            this.gbPodaciSaFakture.Controls.Add(this.lbPrimioFakturuZaposleni);
            this.gbPodaciSaFakture.Controls.Add(this.lbPrimioFakturu);
            this.gbPodaciSaFakture.Controls.Add(this.btnOdustatiFaktura);
            this.gbPodaciSaFakture.Controls.Add(this.lbDatumIzdavanja);
            this.gbPodaciSaFakture.Controls.Add(this.btnSacuvatiFaktura);
            this.gbPodaciSaFakture.Controls.Add(this.dtpDatumIzdavanjaFakture);
            this.gbPodaciSaFakture.Controls.Add(this.tbNacinPlacanjaFakture);
            this.gbPodaciSaFakture.Controls.Add(this.tbBrojFakture);
            this.gbPodaciSaFakture.Controls.Add(this.lbMjestoIzdavanja);
            this.gbPodaciSaFakture.Controls.Add(this.lbNacinPlacanja);
            this.gbPodaciSaFakture.Controls.Add(this.lbBrojFakture);
            this.gbPodaciSaFakture.Controls.Add(this.tbMjestoIzdavanjaFakture);
            this.gbPodaciSaFakture.Location = new System.Drawing.Point(12, 272);
            this.gbPodaciSaFakture.Name = "gbPodaciSaFakture";
            this.gbPodaciSaFakture.Size = new System.Drawing.Size(487, 118);
            this.gbPodaciSaFakture.TabIndex = 1;
            this.gbPodaciSaFakture.TabStop = false;
            this.gbPodaciSaFakture.Text = "Podaci sa fakture";
            // 
            // lbPrimioFakturuZaposleni
            // 
            this.lbPrimioFakturuZaposleni.AutoSize = true;
            this.lbPrimioFakturuZaposleni.Location = new System.Drawing.Point(359, 16);
            this.lbPrimioFakturuZaposleni.Name = "lbPrimioFakturuZaposleni";
            this.lbPrimioFakturuZaposleni.Size = new System.Drawing.Size(53, 13);
            this.lbPrimioFakturuZaposleni.TabIndex = 17;
            this.lbPrimioFakturuZaposleni.Text = "Zaposleni";
            // 
            // lbPrimioFakturu
            // 
            this.lbPrimioFakturu.AutoSize = true;
            this.lbPrimioFakturu.Location = new System.Drawing.Point(316, 16);
            this.lbPrimioFakturu.Name = "lbPrimioFakturu";
            this.lbPrimioFakturu.Size = new System.Drawing.Size(38, 13);
            this.lbPrimioFakturu.TabIndex = 16;
            this.lbPrimioFakturu.Text = "Primio:";
            // 
            // btnOdustatiFaktura
            // 
            this.btnOdustatiFaktura.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustatiFaktura.Image = global::Apoteka.Properties.Resources.cancel;
            this.btnOdustatiFaktura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustatiFaktura.Location = new System.Drawing.Point(394, 82);
            this.btnOdustatiFaktura.Name = "btnOdustatiFaktura";
            this.btnOdustatiFaktura.Size = new System.Drawing.Size(87, 27);
            this.btnOdustatiFaktura.TabIndex = 5;
            this.btnOdustatiFaktura.Text = "Odustati";
            this.btnOdustatiFaktura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustatiFaktura.UseVisualStyleBackColor = true;
            this.btnOdustatiFaktura.Click += new System.EventHandler(this.btnOdustatiFaktura_Click);
            // 
            // lbDatumIzdavanja
            // 
            this.lbDatumIzdavanja.AutoSize = true;
            this.lbDatumIzdavanja.Location = new System.Drawing.Point(6, 43);
            this.lbDatumIzdavanja.Name = "lbDatumIzdavanja";
            this.lbDatumIzdavanja.Size = new System.Drawing.Size(93, 13);
            this.lbDatumIzdavanja.TabIndex = 15;
            this.lbDatumIzdavanja.Text = "Datum izdavanja:*";
            // 
            // btnSacuvatiFaktura
            // 
            this.btnSacuvatiFaktura.Image = global::Apoteka.Properties.Resources.save;
            this.btnSacuvatiFaktura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvatiFaktura.Location = new System.Drawing.Point(394, 52);
            this.btnSacuvatiFaktura.Name = "btnSacuvatiFaktura";
            this.btnSacuvatiFaktura.Size = new System.Drawing.Size(87, 27);
            this.btnSacuvatiFaktura.TabIndex = 4;
            this.btnSacuvatiFaktura.Text = "Sačuvati";
            this.btnSacuvatiFaktura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSacuvatiFaktura.UseVisualStyleBackColor = true;
            this.btnSacuvatiFaktura.Click += new System.EventHandler(this.btnSacuvatiFaktura_Click);
            // 
            // dtpDatumIzdavanjaFakture
            // 
            this.dtpDatumIzdavanjaFakture.CustomFormat = "dd.MM.yyyy";
            this.dtpDatumIzdavanjaFakture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumIzdavanjaFakture.Location = new System.Drawing.Point(105, 39);
            this.dtpDatumIzdavanjaFakture.Name = "dtpDatumIzdavanjaFakture";
            this.dtpDatumIzdavanjaFakture.Size = new System.Drawing.Size(187, 20);
            this.dtpDatumIzdavanjaFakture.TabIndex = 1;
            // 
            // tbNacinPlacanjaFakture
            // 
            this.tbNacinPlacanjaFakture.Location = new System.Drawing.Point(105, 89);
            this.tbNacinPlacanjaFakture.MaxLength = 60;
            this.tbNacinPlacanjaFakture.Name = "tbNacinPlacanjaFakture";
            this.tbNacinPlacanjaFakture.Size = new System.Drawing.Size(187, 20);
            this.tbNacinPlacanjaFakture.TabIndex = 3;
            // 
            // tbBrojFakture
            // 
            this.tbBrojFakture.Location = new System.Drawing.Point(105, 13);
            this.tbBrojFakture.MaxLength = 30;
            this.tbBrojFakture.Name = "tbBrojFakture";
            this.tbBrojFakture.Size = new System.Drawing.Size(187, 20);
            this.tbBrojFakture.TabIndex = 0;
            // 
            // lbMjestoIzdavanja
            // 
            this.lbMjestoIzdavanja.AutoSize = true;
            this.lbMjestoIzdavanja.Location = new System.Drawing.Point(6, 66);
            this.lbMjestoIzdavanja.Name = "lbMjestoIzdavanja";
            this.lbMjestoIzdavanja.Size = new System.Drawing.Size(93, 13);
            this.lbMjestoIzdavanja.TabIndex = 2;
            this.lbMjestoIzdavanja.Text = "Mjesto izdavanja:*";
            // 
            // lbNacinPlacanja
            // 
            this.lbNacinPlacanja.AutoSize = true;
            this.lbNacinPlacanja.Location = new System.Drawing.Point(6, 92);
            this.lbNacinPlacanja.Name = "lbNacinPlacanja";
            this.lbNacinPlacanja.Size = new System.Drawing.Size(85, 13);
            this.lbNacinPlacanja.TabIndex = 4;
            this.lbNacinPlacanja.Text = "Način plaćanja:*";
            // 
            // lbBrojFakture
            // 
            this.lbBrojFakture.AutoSize = true;
            this.lbBrojFakture.Location = new System.Drawing.Point(6, 16);
            this.lbBrojFakture.Name = "lbBrojFakture";
            this.lbBrojFakture.Size = new System.Drawing.Size(68, 13);
            this.lbBrojFakture.TabIndex = 0;
            this.lbBrojFakture.Text = "Broj fakture:*";
            // 
            // tbMjestoIzdavanjaFakture
            // 
            this.tbMjestoIzdavanjaFakture.Location = new System.Drawing.Point(105, 63);
            this.tbMjestoIzdavanjaFakture.MaxLength = 80;
            this.tbMjestoIzdavanjaFakture.Name = "tbMjestoIzdavanjaFakture";
            this.tbMjestoIzdavanjaFakture.Size = new System.Drawing.Size(187, 20);
            this.tbMjestoIzdavanjaFakture.TabIndex = 2;
            // 
            // gbPretragaNarudzbe
            // 
            this.gbPretragaNarudzbe.Controls.Add(this.dtpKreiranaDoPretraga);
            this.gbPretragaNarudzbe.Controls.Add(this.dtpKreiranaOdPretraga);
            this.gbPretragaNarudzbe.Controls.Add(this.lvNarudzbe);
            this.gbPretragaNarudzbe.Controls.Add(this.tbDobavljacPretraga);
            this.gbPretragaNarudzbe.Controls.Add(this.tbBrojNarudzbePretraga);
            this.gbPretragaNarudzbe.Controls.Add(this.btnOcistiPoljaPretrageNarudzbe);
            this.gbPretragaNarudzbe.Location = new System.Drawing.Point(12, 3);
            this.gbPretragaNarudzbe.Name = "gbPretragaNarudzbe";
            this.gbPretragaNarudzbe.Size = new System.Drawing.Size(487, 268);
            this.gbPretragaNarudzbe.TabIndex = 0;
            this.gbPretragaNarudzbe.TabStop = false;
            this.gbPretragaNarudzbe.Text = "Pretraga narudžbi";
            // 
            // dtpKreiranaDoPretraga
            // 
            this.dtpKreiranaDoPretraga.CustomFormat = "dd.MM.yyyy";
            this.dtpKreiranaDoPretraga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKreiranaDoPretraga.Location = new System.Drawing.Point(264, 19);
            this.dtpKreiranaDoPretraga.Name = "dtpKreiranaDoPretraga";
            this.dtpKreiranaDoPretraga.Size = new System.Drawing.Size(95, 20);
            this.dtpKreiranaDoPretraga.TabIndex = 2;
            this.dtpKreiranaDoPretraga.ValueChanged += new System.EventHandler(this.dtpKreiranaDoPretraga_ValueChanged);
            // 
            // dtpKreiranaOdPretraga
            // 
            this.dtpKreiranaOdPretraga.CustomFormat = "dd.MM.yyyy";
            this.dtpKreiranaOdPretraga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKreiranaOdPretraga.Location = new System.Drawing.Point(163, 19);
            this.dtpKreiranaOdPretraga.Name = "dtpKreiranaOdPretraga";
            this.dtpKreiranaOdPretraga.Size = new System.Drawing.Size(95, 20);
            this.dtpKreiranaOdPretraga.TabIndex = 1;
            this.dtpKreiranaOdPretraga.ValueChanged += new System.EventHandler(this.dtpKreiranaOdPretraga_ValueChanged);
            // 
            // lvNarudzbe
            // 
            this.lvNarudzbe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.brojNarudzbeKolona,
            this.datumKreiranjaKolona,
            this.dobavljacKolona});
            this.lvNarudzbe.ContextMenuStrip = this.cmsListaNarudzbi;
            this.lvNarudzbe.FullRowSelect = true;
            listViewGroup3.Header = "Nezavršena";
            listViewGroup3.Name = "lvgNezavrsena";
            listViewGroup4.Header = "Završena";
            listViewGroup4.Name = "lvgZavrsena";
            this.lvNarudzbe.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.lvNarudzbe.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvNarudzbe.HideSelection = false;
            this.lvNarudzbe.Location = new System.Drawing.Point(6, 48);
            this.lvNarudzbe.MultiSelect = false;
            this.lvNarudzbe.Name = "lvNarudzbe";
            this.lvNarudzbe.Size = new System.Drawing.Size(475, 214);
            this.lvNarudzbe.TabIndex = 7;
            this.lvNarudzbe.TabStop = false;
            this.lvNarudzbe.UseCompatibleStateImageBehavior = false;
            this.lvNarudzbe.View = System.Windows.Forms.View.Details;
            this.lvNarudzbe.SelectedIndexChanged += new System.EventHandler(this.lvNarudzbe_SelectedIndexChanged);
            // 
            // brojNarudzbeKolona
            // 
            this.brojNarudzbeKolona.Text = "Broj narudžbe";
            this.brojNarudzbeKolona.Width = 149;
            // 
            // datumKreiranjaKolona
            // 
            this.datumKreiranjaKolona.Text = "Datum kreiranja";
            this.datumKreiranjaKolona.Width = 204;
            // 
            // dobavljacKolona
            // 
            this.dobavljacKolona.Text = "Dobavljač";
            this.dobavljacKolona.Width = 118;
            // 
            // cmsListaNarudzbi
            // 
            this.cmsListaNarudzbi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZavrsitiNarudzbu,
            this.tsmiObrisatiNarudzbu});
            this.cmsListaNarudzbi.Name = "cmsTabelaNarudzbe";
            this.cmsListaNarudzbi.Size = new System.Drawing.Size(166, 48);
            this.cmsListaNarudzbi.Opening += new System.ComponentModel.CancelEventHandler(this.cmsListaNarudzbi_Opening);
            // 
            // tsmiZavrsitiNarudzbu
            // 
            this.tsmiZavrsitiNarudzbu.Name = "tsmiZavrsitiNarudzbu";
            this.tsmiZavrsitiNarudzbu.Size = new System.Drawing.Size(165, 22);
            this.tsmiZavrsitiNarudzbu.Text = "Završiti narudžbu";
            this.tsmiZavrsitiNarudzbu.Click += new System.EventHandler(this.tsmiZavrsitiNarudzbu_Click);
            // 
            // tsmiObrisatiNarudzbu
            // 
            this.tsmiObrisatiNarudzbu.Image = global::Apoteka.Properties.Resources.trash;
            this.tsmiObrisatiNarudzbu.Name = "tsmiObrisatiNarudzbu";
            this.tsmiObrisatiNarudzbu.Size = new System.Drawing.Size(165, 22);
            this.tsmiObrisatiNarudzbu.Text = "Obrisati";
            this.tsmiObrisatiNarudzbu.Click += new System.EventHandler(this.tsmiObrisatiNarudzbu_Click);
            // 
            // tbDobavljacPretraga
            // 
            this.tbDobavljacPretraga.Location = new System.Drawing.Point(365, 19);
            this.tbDobavljacPretraga.Name = "tbDobavljacPretraga";
            this.tbDobavljacPretraga.Size = new System.Drawing.Size(116, 20);
            this.tbDobavljacPretraga.TabIndex = 3;
            this.tbDobavljacPretraga.TextChanged += new System.EventHandler(this.tbDobavljacPretraga_TextChanged);
            // 
            // tbBrojNarudzbePretraga
            // 
            this.tbBrojNarudzbePretraga.Location = new System.Drawing.Point(54, 19);
            this.tbBrojNarudzbePretraga.Name = "tbBrojNarudzbePretraga";
            this.tbBrojNarudzbePretraga.Size = new System.Drawing.Size(103, 20);
            this.tbBrojNarudzbePretraga.TabIndex = 0;
            this.tbBrojNarudzbePretraga.TextChanged += new System.EventHandler(this.tbBrojNarudzbePretraga_TextChanged);
            // 
            // btnOcistiPoljaPretrageNarudzbe
            // 
            this.btnOcistiPoljaPretrageNarudzbe.Image = global::Apoteka.Properties.Resources.eraser;
            this.btnOcistiPoljaPretrageNarudzbe.Location = new System.Drawing.Point(6, 16);
            this.btnOcistiPoljaPretrageNarudzbe.Name = "btnOcistiPoljaPretrageNarudzbe";
            this.btnOcistiPoljaPretrageNarudzbe.Size = new System.Drawing.Size(42, 25);
            this.btnOcistiPoljaPretrageNarudzbe.TabIndex = 4;
            this.btnOcistiPoljaPretrageNarudzbe.UseVisualStyleBackColor = true;
            this.btnOcistiPoljaPretrageNarudzbe.Click += new System.EventHandler(this.btnOcistiPoljaPretrageNarudzbe_Click);
            // 
            // gbStavkeNarudzbe
            // 
            this.gbStavkeNarudzbe.Controls.Add(this.tbUkupanIznosNarudzba);
            this.gbStavkeNarudzbe.Controls.Add(this.lbKreiraoNarudzbuZaposleni);
            this.gbStavkeNarudzbe.Controls.Add(this.lbKreiraoNarudzbu);
            this.gbStavkeNarudzbe.Controls.Add(this.dgvStavkeNarudzbe);
            this.gbStavkeNarudzbe.Location = new System.Drawing.Point(505, 3);
            this.gbStavkeNarudzbe.Name = "gbStavkeNarudzbe";
            this.gbStavkeNarudzbe.Size = new System.Drawing.Size(314, 387);
            this.gbStavkeNarudzbe.TabIndex = 0;
            this.gbStavkeNarudzbe.TabStop = false;
            this.gbStavkeNarudzbe.Text = "Stavke narudžbe";
            // 
            // tbUkupanIznosNarudzba
            // 
            this.tbUkupanIznosNarudzba.Enabled = false;
            this.tbUkupanIznosNarudzba.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUkupanIznosNarudzba.Location = new System.Drawing.Point(200, 16);
            this.tbUkupanIznosNarudzba.Multiline = true;
            this.tbUkupanIznosNarudzba.Name = "tbUkupanIznosNarudzba";
            this.tbUkupanIznosNarudzba.Size = new System.Drawing.Size(108, 27);
            this.tbUkupanIznosNarudzba.TabIndex = 20;
            this.tbUkupanIznosNarudzba.Text = "0.00";
            this.tbUkupanIznosNarudzba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbKreiraoNarudzbuZaposleni
            // 
            this.lbKreiraoNarudzbuZaposleni.AutoSize = true;
            this.lbKreiraoNarudzbuZaposleni.Location = new System.Drawing.Point(55, 23);
            this.lbKreiraoNarudzbuZaposleni.Name = "lbKreiraoNarudzbuZaposleni";
            this.lbKreiraoNarudzbuZaposleni.Size = new System.Drawing.Size(53, 13);
            this.lbKreiraoNarudzbuZaposleni.TabIndex = 4;
            this.lbKreiraoNarudzbuZaposleni.Text = "Zaposleni";
            // 
            // lbKreiraoNarudzbu
            // 
            this.lbKreiraoNarudzbu.AutoSize = true;
            this.lbKreiraoNarudzbu.Location = new System.Drawing.Point(6, 23);
            this.lbKreiraoNarudzbu.Name = "lbKreiraoNarudzbu";
            this.lbKreiraoNarudzbu.Size = new System.Drawing.Size(43, 13);
            this.lbKreiraoNarudzbu.TabIndex = 3;
            this.lbKreiraoNarudzbu.Text = "Kreirao:";
            // 
            // dgvStavkeNarudzbe
            // 
            this.dgvStavkeNarudzbe.AllowUserToAddRows = false;
            this.dgvStavkeNarudzbe.AllowUserToDeleteRows = false;
            this.dgvStavkeNarudzbe.AllowUserToOrderColumns = true;
            this.dgvStavkeNarudzbe.AllowUserToResizeRows = false;
            this.dgvStavkeNarudzbe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStavkeNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkeNarudzbe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStavkeNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lijek,
            this.kolicina,
            this.iznos});
            this.dgvStavkeNarudzbe.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStavkeNarudzbe.Location = new System.Drawing.Point(6, 48);
            this.dgvStavkeNarudzbe.MultiSelect = false;
            this.dgvStavkeNarudzbe.Name = "dgvStavkeNarudzbe";
            this.dgvStavkeNarudzbe.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStavkeNarudzbe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStavkeNarudzbe.RowHeadersWidth = 49;
            this.dgvStavkeNarudzbe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStavkeNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeNarudzbe.Size = new System.Drawing.Size(302, 333);
            this.dgvStavkeNarudzbe.TabIndex = 2;
            // 
            // lijek
            // 
            this.lijek.FillWeight = 105.8985F;
            this.lijek.HeaderText = "Lijek";
            this.lijek.Name = "lijek";
            this.lijek.ReadOnly = true;
            this.lijek.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // kolicina
            // 
            this.kolicina.FillWeight = 60.8985F;
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            this.kolicina.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // iznos
            // 
            this.iznos.FillWeight = 100.8985F;
            this.iznos.HeaderText = "Iznos";
            this.iznos.Name = "iznos";
            this.iznos.ReadOnly = true;
            this.iznos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pnlZaposleniSaListom
            // 
            this.pnlZaposleniSaListom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.pnlZaposleniSaListom.Controls.Add(this.gbPretragaZaposlenogLista);
            this.pnlZaposleniSaListom.Controls.Add(this.gbPodaciZaposlenogLista);
            this.pnlZaposleniSaListom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlZaposleniSaListom.Location = new System.Drawing.Point(0, 0);
            this.pnlZaposleniSaListom.Name = "pnlZaposleniSaListom";
            this.pnlZaposleniSaListom.Size = new System.Drawing.Size(831, 393);
            this.pnlZaposleniSaListom.TabIndex = 3;
            // 
            // gbPretragaZaposlenogLista
            // 
            this.gbPretragaZaposlenogLista.Controls.Add(this.lvZaposleni);
            this.gbPretragaZaposlenogLista.Controls.Add(this.tbStrucnaSpremaPretragaLista);
            this.gbPretragaZaposlenogLista.Controls.Add(this.tbPrezimePretragaLista);
            this.gbPretragaZaposlenogLista.Controls.Add(this.tbImePretragaLista);
            this.gbPretragaZaposlenogLista.Controls.Add(this.tbJmbgPretragaLista);
            this.gbPretragaZaposlenogLista.Controls.Add(this.btnOcistiPoljaPretrageLista);
            this.gbPretragaZaposlenogLista.Location = new System.Drawing.Point(12, 3);
            this.gbPretragaZaposlenogLista.Name = "gbPretragaZaposlenogLista";
            this.gbPretragaZaposlenogLista.Size = new System.Drawing.Size(487, 387);
            this.gbPretragaZaposlenogLista.TabIndex = 0;
            this.gbPretragaZaposlenogLista.TabStop = false;
            this.gbPretragaZaposlenogLista.Text = "Pretraga zaposlenih";
            // 
            // lvZaposleni
            // 
            this.lvZaposleni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jmbgListaZaposleni,
            this.imeListaZaposleni,
            this.prezimeListaZaposleni,
            this.strucnaSpremaListaZaposleni});
            this.lvZaposleni.ContextMenuStrip = this.cmsListaZaposleni;
            this.lvZaposleni.FullRowSelect = true;
            listViewGroup5.Header = "Farmaceuti";
            listViewGroup5.Name = "lvgFarmaceut";
            listViewGroup6.Header = "Menadžeri";
            listViewGroup6.Name = "lvgMenadzer";
            listViewGroup7.Header = "Administratori";
            listViewGroup7.Name = "lvgAdmin";
            this.lvZaposleni.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6,
            listViewGroup7});
            this.lvZaposleni.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvZaposleni.Location = new System.Drawing.Point(6, 48);
            this.lvZaposleni.MultiSelect = false;
            this.lvZaposleni.Name = "lvZaposleni";
            this.lvZaposleni.Size = new System.Drawing.Size(475, 333);
            this.lvZaposleni.TabIndex = 7;
            this.lvZaposleni.TabStop = false;
            this.lvZaposleni.UseCompatibleStateImageBehavior = false;
            this.lvZaposleni.View = System.Windows.Forms.View.Details;
            this.lvZaposleni.SelectedIndexChanged += new System.EventHandler(this.lvZaposleni_SelectedIndexChanged);
            // 
            // jmbgListaZaposleni
            // 
            this.jmbgListaZaposleni.Text = "JMBG";
            this.jmbgListaZaposleni.Width = 115;
            // 
            // imeListaZaposleni
            // 
            this.imeListaZaposleni.Text = "Ime";
            this.imeListaZaposleni.Width = 115;
            // 
            // prezimeListaZaposleni
            // 
            this.prezimeListaZaposleni.Text = "Prezime";
            this.prezimeListaZaposleni.Width = 137;
            // 
            // strucnaSpremaListaZaposleni
            // 
            this.strucnaSpremaListaZaposleni.Text = "Stručna sprema";
            this.strucnaSpremaListaZaposleni.Width = 100;
            // 
            // cmsListaZaposleni
            // 
            this.cmsListaZaposleni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIzmjenitiZaposlenogLista});
            this.cmsListaZaposleni.Name = "cmsTabelaZaposleni";
            this.cmsListaZaposleni.Size = new System.Drawing.Size(120, 26);
            // 
            // tsmiIzmjenitiZaposlenogLista
            // 
            this.tsmiIzmjenitiZaposlenogLista.Image = global::Apoteka.Properties.Resources.edit;
            this.tsmiIzmjenitiZaposlenogLista.Name = "tsmiIzmjenitiZaposlenogLista";
            this.tsmiIzmjenitiZaposlenogLista.Size = new System.Drawing.Size(119, 22);
            this.tsmiIzmjenitiZaposlenogLista.Text = "Izmjeniti";
            this.tsmiIzmjenitiZaposlenogLista.Click += new System.EventHandler(this.tsmiIzmjenitiZaposlenogLista_Click);
            // 
            // tbStrucnaSpremaPretragaLista
            // 
            this.tbStrucnaSpremaPretragaLista.Location = new System.Drawing.Point(381, 19);
            this.tbStrucnaSpremaPretragaLista.Name = "tbStrucnaSpremaPretragaLista";
            this.tbStrucnaSpremaPretragaLista.Size = new System.Drawing.Size(100, 20);
            this.tbStrucnaSpremaPretragaLista.TabIndex = 3;
            this.tbStrucnaSpremaPretragaLista.TextChanged += new System.EventHandler(this.tbStrucnaSpremaPretragaLista_TextChanged);
            // 
            // tbPrezimePretragaLista
            // 
            this.tbPrezimePretragaLista.Location = new System.Drawing.Point(272, 19);
            this.tbPrezimePretragaLista.Name = "tbPrezimePretragaLista";
            this.tbPrezimePretragaLista.Size = new System.Drawing.Size(102, 20);
            this.tbPrezimePretragaLista.TabIndex = 2;
            this.tbPrezimePretragaLista.TextChanged += new System.EventHandler(this.tbPrezimePretragaLista_TextChanged);
            // 
            // tbImePretragaLista
            // 
            this.tbImePretragaLista.Location = new System.Drawing.Point(163, 19);
            this.tbImePretragaLista.Name = "tbImePretragaLista";
            this.tbImePretragaLista.Size = new System.Drawing.Size(103, 20);
            this.tbImePretragaLista.TabIndex = 1;
            this.tbImePretragaLista.TextChanged += new System.EventHandler(this.tbImePretragaLista_TextChanged);
            // 
            // tbJmbgPretragaLista
            // 
            this.tbJmbgPretragaLista.Location = new System.Drawing.Point(54, 19);
            this.tbJmbgPretragaLista.Name = "tbJmbgPretragaLista";
            this.tbJmbgPretragaLista.Size = new System.Drawing.Size(103, 20);
            this.tbJmbgPretragaLista.TabIndex = 0;
            this.tbJmbgPretragaLista.TextChanged += new System.EventHandler(this.tbJmbgPretragaLista_TextChanged);
            // 
            // btnOcistiPoljaPretrageLista
            // 
            this.btnOcistiPoljaPretrageLista.Image = global::Apoteka.Properties.Resources.eraser;
            this.btnOcistiPoljaPretrageLista.Location = new System.Drawing.Point(6, 16);
            this.btnOcistiPoljaPretrageLista.Name = "btnOcistiPoljaPretrageLista";
            this.btnOcistiPoljaPretrageLista.Size = new System.Drawing.Size(42, 25);
            this.btnOcistiPoljaPretrageLista.TabIndex = 4;
            this.btnOcistiPoljaPretrageLista.UseVisualStyleBackColor = true;
            this.btnOcistiPoljaPretrageLista.Click += new System.EventHandler(this.btnOcistiPoljaPretrageLista_Click);
            // 
            // gbPodaciZaposlenogLista
            // 
            this.gbPodaciZaposlenogLista.Controls.Add(this.mtbJmbgLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.lbJmbgLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.cbMjestoLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.lbMjestoLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.btnOdustatiLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.btnSacuvatiLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.tbOpisPoslaLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.lbOpisPoslaLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.cbSefApotekeLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.lbSefApotekeLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.tbFarmaceutskoZvanjeLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.lbFarmaceutskoZvanjeLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.tbStrucnaSpremaLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.lbStrucnaSpremaLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.tbEmailLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.lbEmailLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.tbTelefonLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.lbTelefonLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.tbAdresaLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.lbAdresaLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.tbPrezimeLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.lbPrezimeLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.tbImeLista);
            this.gbPodaciZaposlenogLista.Controls.Add(this.lbImeLista);
            this.gbPodaciZaposlenogLista.Location = new System.Drawing.Point(505, 3);
            this.gbPodaciZaposlenogLista.Name = "gbPodaciZaposlenogLista";
            this.gbPodaciZaposlenogLista.Size = new System.Drawing.Size(314, 387);
            this.gbPodaciZaposlenogLista.TabIndex = 0;
            this.gbPodaciZaposlenogLista.TabStop = false;
            this.gbPodaciZaposlenogLista.Text = "Podaci o zaposlenom";
            // 
            // mtbJmbgLista
            // 
            this.mtbJmbgLista.Location = new System.Drawing.Point(116, 19);
            this.mtbJmbgLista.Mask = "0000000000000";
            this.mtbJmbgLista.Name = "mtbJmbgLista";
            this.mtbJmbgLista.Size = new System.Drawing.Size(87, 20);
            this.mtbJmbgLista.TabIndex = 0;
            // 
            // lbJmbgLista
            // 
            this.lbJmbgLista.AutoSize = true;
            this.lbJmbgLista.Location = new System.Drawing.Point(6, 22);
            this.lbJmbgLista.Name = "lbJmbgLista";
            this.lbJmbgLista.Size = new System.Drawing.Size(43, 13);
            this.lbJmbgLista.TabIndex = 0;
            this.lbJmbgLista.Text = "JMBG:*";
            // 
            // cbMjestoLista
            // 
            this.cbMjestoLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMjestoLista.FormattingEnabled = true;
            this.cbMjestoLista.Location = new System.Drawing.Point(116, 123);
            this.cbMjestoLista.Name = "cbMjestoLista";
            this.cbMjestoLista.Size = new System.Drawing.Size(187, 21);
            this.cbMjestoLista.TabIndex = 4;
            // 
            // lbMjestoLista
            // 
            this.lbMjestoLista.AutoSize = true;
            this.lbMjestoLista.Location = new System.Drawing.Point(6, 126);
            this.lbMjestoLista.Name = "lbMjestoLista";
            this.lbMjestoLista.Size = new System.Drawing.Size(45, 13);
            this.lbMjestoLista.TabIndex = 18;
            this.lbMjestoLista.Text = "Mjesto:*";
            // 
            // btnOdustatiLista
            // 
            this.btnOdustatiLista.Image = global::Apoteka.Properties.Resources.cancel;
            this.btnOdustatiLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustatiLista.Location = new System.Drawing.Point(216, 354);
            this.btnOdustatiLista.Name = "btnOdustatiLista";
            this.btnOdustatiLista.Size = new System.Drawing.Size(87, 27);
            this.btnOdustatiLista.TabIndex = 12;
            this.btnOdustatiLista.Text = "Odustati";
            this.btnOdustatiLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustatiLista.UseVisualStyleBackColor = true;
            this.btnOdustatiLista.Click += new System.EventHandler(this.btnOdustatiLista_Click);
            // 
            // btnSacuvatiLista
            // 
            this.btnSacuvatiLista.Image = ((System.Drawing.Image)(resources.GetObject("btnSacuvatiLista.Image")));
            this.btnSacuvatiLista.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSacuvatiLista.Location = new System.Drawing.Point(116, 354);
            this.btnSacuvatiLista.Name = "btnSacuvatiLista";
            this.btnSacuvatiLista.Size = new System.Drawing.Size(87, 27);
            this.btnSacuvatiLista.TabIndex = 11;
            this.btnSacuvatiLista.Text = "Sačuvati";
            this.btnSacuvatiLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSacuvatiLista.UseVisualStyleBackColor = true;
            this.btnSacuvatiLista.Click += new System.EventHandler(this.btnSacuvatiLista_Click);
            // 
            // tbOpisPoslaLista
            // 
            this.tbOpisPoslaLista.Location = new System.Drawing.Point(116, 275);
            this.tbOpisPoslaLista.MaxLength = 150;
            this.tbOpisPoslaLista.Multiline = true;
            this.tbOpisPoslaLista.Name = "tbOpisPoslaLista";
            this.tbOpisPoslaLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOpisPoslaLista.Size = new System.Drawing.Size(187, 53);
            this.tbOpisPoslaLista.TabIndex = 10;
            // 
            // lbOpisPoslaLista
            // 
            this.lbOpisPoslaLista.AutoSize = true;
            this.lbOpisPoslaLista.Location = new System.Drawing.Point(6, 278);
            this.lbOpisPoslaLista.Name = "lbOpisPoslaLista";
            this.lbOpisPoslaLista.Size = new System.Drawing.Size(59, 13);
            this.lbOpisPoslaLista.TabIndex = 17;
            this.lbOpisPoslaLista.Text = "Opis posla:";
            // 
            // cbSefApotekeLista
            // 
            this.cbSefApotekeLista.AutoSize = true;
            this.cbSefApotekeLista.Location = new System.Drawing.Point(116, 255);
            this.cbSefApotekeLista.Name = "cbSefApotekeLista";
            this.cbSefApotekeLista.Size = new System.Drawing.Size(15, 14);
            this.cbSefApotekeLista.TabIndex = 9;
            this.cbSefApotekeLista.UseVisualStyleBackColor = true;
            // 
            // lbSefApotekeLista
            // 
            this.lbSefApotekeLista.AutoSize = true;
            this.lbSefApotekeLista.Location = new System.Drawing.Point(6, 255);
            this.lbSefApotekeLista.Name = "lbSefApotekeLista";
            this.lbSefApotekeLista.Size = new System.Drawing.Size(68, 13);
            this.lbSefApotekeLista.TabIndex = 15;
            this.lbSefApotekeLista.Text = "Šef apoteke:";
            // 
            // tbFarmaceutskoZvanjeLista
            // 
            this.tbFarmaceutskoZvanjeLista.Location = new System.Drawing.Point(116, 229);
            this.tbFarmaceutskoZvanjeLista.MaxLength = 50;
            this.tbFarmaceutskoZvanjeLista.Name = "tbFarmaceutskoZvanjeLista";
            this.tbFarmaceutskoZvanjeLista.Size = new System.Drawing.Size(187, 20);
            this.tbFarmaceutskoZvanjeLista.TabIndex = 8;
            // 
            // lbFarmaceutskoZvanjeLista
            // 
            this.lbFarmaceutskoZvanjeLista.AutoSize = true;
            this.lbFarmaceutskoZvanjeLista.Location = new System.Drawing.Point(6, 232);
            this.lbFarmaceutskoZvanjeLista.Name = "lbFarmaceutskoZvanjeLista";
            this.lbFarmaceutskoZvanjeLista.Size = new System.Drawing.Size(111, 13);
            this.lbFarmaceutskoZvanjeLista.TabIndex = 13;
            this.lbFarmaceutskoZvanjeLista.Text = "Farmaceutsko zvanje:";
            // 
            // tbStrucnaSpremaLista
            // 
            this.tbStrucnaSpremaLista.Location = new System.Drawing.Point(116, 203);
            this.tbStrucnaSpremaLista.MaxLength = 40;
            this.tbStrucnaSpremaLista.Name = "tbStrucnaSpremaLista";
            this.tbStrucnaSpremaLista.Size = new System.Drawing.Size(187, 20);
            this.tbStrucnaSpremaLista.TabIndex = 7;
            // 
            // lbStrucnaSpremaLista
            // 
            this.lbStrucnaSpremaLista.AutoSize = true;
            this.lbStrucnaSpremaLista.Location = new System.Drawing.Point(6, 206);
            this.lbStrucnaSpremaLista.Name = "lbStrucnaSpremaLista";
            this.lbStrucnaSpremaLista.Size = new System.Drawing.Size(88, 13);
            this.lbStrucnaSpremaLista.TabIndex = 11;
            this.lbStrucnaSpremaLista.Text = "Stručna sprema:*";
            // 
            // tbEmailLista
            // 
            this.tbEmailLista.Location = new System.Drawing.Point(116, 177);
            this.tbEmailLista.MaxLength = 80;
            this.tbEmailLista.Name = "tbEmailLista";
            this.tbEmailLista.Size = new System.Drawing.Size(187, 20);
            this.tbEmailLista.TabIndex = 6;
            // 
            // lbEmailLista
            // 
            this.lbEmailLista.AutoSize = true;
            this.lbEmailLista.Location = new System.Drawing.Point(6, 180);
            this.lbEmailLista.Name = "lbEmailLista";
            this.lbEmailLista.Size = new System.Drawing.Size(35, 13);
            this.lbEmailLista.TabIndex = 8;
            this.lbEmailLista.Text = "Email:";
            // 
            // tbTelefonLista
            // 
            this.tbTelefonLista.Location = new System.Drawing.Point(116, 151);
            this.tbTelefonLista.MaxLength = 100;
            this.tbTelefonLista.Name = "tbTelefonLista";
            this.tbTelefonLista.Size = new System.Drawing.Size(187, 20);
            this.tbTelefonLista.TabIndex = 5;
            // 
            // lbTelefonLista
            // 
            this.lbTelefonLista.AutoSize = true;
            this.lbTelefonLista.Location = new System.Drawing.Point(6, 154);
            this.lbTelefonLista.Name = "lbTelefonLista";
            this.lbTelefonLista.Size = new System.Drawing.Size(46, 13);
            this.lbTelefonLista.TabIndex = 6;
            this.lbTelefonLista.Text = "Telefon:";
            // 
            // tbAdresaLista
            // 
            this.tbAdresaLista.Location = new System.Drawing.Point(116, 97);
            this.tbAdresaLista.MaxLength = 100;
            this.tbAdresaLista.Name = "tbAdresaLista";
            this.tbAdresaLista.Size = new System.Drawing.Size(187, 20);
            this.tbAdresaLista.TabIndex = 3;
            // 
            // lbAdresaLista
            // 
            this.lbAdresaLista.AutoSize = true;
            this.lbAdresaLista.Location = new System.Drawing.Point(6, 100);
            this.lbAdresaLista.Name = "lbAdresaLista";
            this.lbAdresaLista.Size = new System.Drawing.Size(47, 13);
            this.lbAdresaLista.TabIndex = 4;
            this.lbAdresaLista.Text = "Adresa:*";
            // 
            // tbPrezimeLista
            // 
            this.tbPrezimeLista.Location = new System.Drawing.Point(116, 71);
            this.tbPrezimeLista.MaxLength = 40;
            this.tbPrezimeLista.Name = "tbPrezimeLista";
            this.tbPrezimeLista.Size = new System.Drawing.Size(187, 20);
            this.tbPrezimeLista.TabIndex = 2;
            // 
            // lbPrezimeLista
            // 
            this.lbPrezimeLista.AutoSize = true;
            this.lbPrezimeLista.Location = new System.Drawing.Point(6, 74);
            this.lbPrezimeLista.Name = "lbPrezimeLista";
            this.lbPrezimeLista.Size = new System.Drawing.Size(51, 13);
            this.lbPrezimeLista.TabIndex = 2;
            this.lbPrezimeLista.Text = "Prezime:*";
            // 
            // tbImeLista
            // 
            this.tbImeLista.Location = new System.Drawing.Point(116, 45);
            this.tbImeLista.MaxLength = 40;
            this.tbImeLista.Name = "tbImeLista";
            this.tbImeLista.Size = new System.Drawing.Size(187, 20);
            this.tbImeLista.TabIndex = 1;
            // 
            // lbImeLista
            // 
            this.lbImeLista.AutoSize = true;
            this.lbImeLista.Location = new System.Drawing.Point(6, 48);
            this.lbImeLista.Name = "lbImeLista";
            this.lbImeLista.Size = new System.Drawing.Size(31, 13);
            this.lbImeLista.TabIndex = 0;
            this.lbImeLista.Text = "Ime:*";
            // 
            // pnlLijekovi
            // 
            this.pnlLijekovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.pnlLijekovi.Controls.Add(this.gbPretragaLijeka);
            this.pnlLijekovi.Controls.Add(this.gbPodaciOLijeku);
            this.pnlLijekovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLijekovi.Location = new System.Drawing.Point(0, 0);
            this.pnlLijekovi.Name = "pnlLijekovi";
            this.pnlLijekovi.Size = new System.Drawing.Size(831, 393);
            this.pnlLijekovi.TabIndex = 2;
            // 
            // gbPretragaLijeka
            // 
            this.gbPretragaLijeka.Controls.Add(this.dtpDozvolaVaziDoPretraga);
            this.gbPretragaLijeka.Controls.Add(this.dtpDozvolaVaziOdPretraga);
            this.gbPretragaLijeka.Controls.Add(this.dgvLijekovi);
            this.gbPretragaLijeka.Controls.Add(this.cbIzdavanjeNaReceptPretraga);
            this.gbPretragaLijeka.Controls.Add(this.tbNazivLijekaPretraga);
            this.gbPretragaLijeka.Controls.Add(this.btnOcistiPoljaPretrageLijekova);
            this.gbPretragaLijeka.Location = new System.Drawing.Point(12, 3);
            this.gbPretragaLijeka.Name = "gbPretragaLijeka";
            this.gbPretragaLijeka.Size = new System.Drawing.Size(487, 387);
            this.gbPretragaLijeka.TabIndex = 0;
            this.gbPretragaLijeka.TabStop = false;
            this.gbPretragaLijeka.Text = "Pretraga lijekova";
            // 
            // dtpDozvolaVaziDoPretraga
            // 
            this.dtpDozvolaVaziDoPretraga.CustomFormat = "dd.MM.yyyy";
            this.dtpDozvolaVaziDoPretraga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDozvolaVaziDoPretraga.Location = new System.Drawing.Point(279, 19);
            this.dtpDozvolaVaziDoPretraga.Name = "dtpDozvolaVaziDoPretraga";
            this.dtpDozvolaVaziDoPretraga.Size = new System.Drawing.Size(110, 20);
            this.dtpDozvolaVaziDoPretraga.TabIndex = 3;
            this.dtpDozvolaVaziDoPretraga.ValueChanged += new System.EventHandler(this.dtpDozvolaVaziDoPretraga_ValueChanged);
            // 
            // dtpDozvolaVaziOdPretraga
            // 
            this.dtpDozvolaVaziOdPretraga.CustomFormat = "dd.MM.yyyy";
            this.dtpDozvolaVaziOdPretraga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDozvolaVaziOdPretraga.Location = new System.Drawing.Point(163, 19);
            this.dtpDozvolaVaziOdPretraga.Name = "dtpDozvolaVaziOdPretraga";
            this.dtpDozvolaVaziOdPretraga.Size = new System.Drawing.Size(110, 20);
            this.dtpDozvolaVaziOdPretraga.TabIndex = 2;
            this.dtpDozvolaVaziOdPretraga.ValueChanged += new System.EventHandler(this.dtpDozvolaVaziOdPretraga_ValueChanged);
            // 
            // dgvLijekovi
            // 
            this.dgvLijekovi.AllowUserToAddRows = false;
            this.dgvLijekovi.AllowUserToDeleteRows = false;
            this.dgvLijekovi.AllowUserToOrderColumns = true;
            this.dgvLijekovi.AllowUserToResizeRows = false;
            this.dgvLijekovi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLijekovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLijekovi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivLijeka,
            this.dozvolaVaziOdLijek,
            this.dozvolaVaziDoLijek,
            this.naReceptLijek});
            this.dgvLijekovi.ContextMenuStrip = this.cmsTabelaLijekova;
            this.dgvLijekovi.GridColor = System.Drawing.SystemColors.Control;
            this.dgvLijekovi.Location = new System.Drawing.Point(6, 45);
            this.dgvLijekovi.MultiSelect = false;
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLijekovi.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLijekovi.RowHeadersWidth = 49;
            this.dgvLijekovi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLijekovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijekovi.Size = new System.Drawing.Size(475, 336);
            this.dgvLijekovi.TabIndex = 0;
            this.dgvLijekovi.TabStop = false;
            this.dgvLijekovi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLijekovi_CellMouseDoubleClick);
            this.dgvLijekovi.SelectionChanged += new System.EventHandler(this.dgvLijekovi_SelectionChanged);
            // 
            // nazivLijeka
            // 
            this.nazivLijeka.FillWeight = 118.8985F;
            this.nazivLijeka.HeaderText = "Naziv";
            this.nazivLijeka.Name = "nazivLijeka";
            this.nazivLijeka.ReadOnly = true;
            this.nazivLijeka.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dozvolaVaziOdLijek
            // 
            this.dozvolaVaziOdLijek.FillWeight = 118.8985F;
            this.dozvolaVaziOdLijek.HeaderText = "Dozvola važi od";
            this.dozvolaVaziOdLijek.Name = "dozvolaVaziOdLijek";
            this.dozvolaVaziOdLijek.ReadOnly = true;
            this.dozvolaVaziOdLijek.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dozvolaVaziDoLijek
            // 
            this.dozvolaVaziDoLijek.FillWeight = 120F;
            this.dozvolaVaziDoLijek.HeaderText = "Dozvola važi do";
            this.dozvolaVaziDoLijek.Name = "dozvolaVaziDoLijek";
            this.dozvolaVaziDoLijek.ReadOnly = true;
            this.dozvolaVaziDoLijek.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // naReceptLijek
            // 
            this.naReceptLijek.FillWeight = 95F;
            this.naReceptLijek.HeaderText = "Na recept";
            this.naReceptLijek.Name = "naReceptLijek";
            this.naReceptLijek.ReadOnly = true;
            this.naReceptLijek.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.naReceptLijek.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmsTabelaLijekova
            // 
            this.cmsTabelaLijekova.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIzmjenitiLijek,
            this.tsmiObrisatiLijek});
            this.cmsTabelaLijekova.Name = "cmsTabelaZaposleni";
            this.cmsTabelaLijekova.Size = new System.Drawing.Size(120, 48);
            // 
            // tsmiIzmjenitiLijek
            // 
            this.tsmiIzmjenitiLijek.Image = global::Apoteka.Properties.Resources.edit;
            this.tsmiIzmjenitiLijek.Name = "tsmiIzmjenitiLijek";
            this.tsmiIzmjenitiLijek.Size = new System.Drawing.Size(119, 22);
            this.tsmiIzmjenitiLijek.Text = "Izmjeniti";
            this.tsmiIzmjenitiLijek.Click += new System.EventHandler(this.tsmiIzmjenitiLijek_Click);
            // 
            // tsmiObrisatiLijek
            // 
            this.tsmiObrisatiLijek.Image = global::Apoteka.Properties.Resources.trash;
            this.tsmiObrisatiLijek.Name = "tsmiObrisatiLijek";
            this.tsmiObrisatiLijek.Size = new System.Drawing.Size(119, 22);
            this.tsmiObrisatiLijek.Text = "Obrisati";
            this.tsmiObrisatiLijek.Click += new System.EventHandler(this.tsmiObrisatiLijek_Click);
            // 
            // cbIzdavanjeNaReceptPretraga
            // 
            this.cbIzdavanjeNaReceptPretraga.AutoSize = true;
            this.cbIzdavanjeNaReceptPretraga.Location = new System.Drawing.Point(432, 22);
            this.cbIzdavanjeNaReceptPretraga.Name = "cbIzdavanjeNaReceptPretraga";
            this.cbIzdavanjeNaReceptPretraga.Size = new System.Drawing.Size(15, 14);
            this.cbIzdavanjeNaReceptPretraga.TabIndex = 4;
            this.cbIzdavanjeNaReceptPretraga.UseVisualStyleBackColor = true;
            this.cbIzdavanjeNaReceptPretraga.CheckedChanged += new System.EventHandler(this.cbIzdavanjeNaReceptPretraga_CheckedChanged);
            // 
            // tbNazivLijekaPretraga
            // 
            this.tbNazivLijekaPretraga.Location = new System.Drawing.Point(54, 19);
            this.tbNazivLijekaPretraga.Name = "tbNazivLijekaPretraga";
            this.tbNazivLijekaPretraga.Size = new System.Drawing.Size(106, 20);
            this.tbNazivLijekaPretraga.TabIndex = 1;
            this.tbNazivLijekaPretraga.TextChanged += new System.EventHandler(this.tbNazivLijekaPretraga_TextChanged);
            // 
            // btnOcistiPoljaPretrageLijekova
            // 
            this.btnOcistiPoljaPretrageLijekova.Image = global::Apoteka.Properties.Resources.eraser;
            this.btnOcistiPoljaPretrageLijekova.Location = new System.Drawing.Point(6, 16);
            this.btnOcistiPoljaPretrageLijekova.Name = "btnOcistiPoljaPretrageLijekova";
            this.btnOcistiPoljaPretrageLijekova.Size = new System.Drawing.Size(42, 25);
            this.btnOcistiPoljaPretrageLijekova.TabIndex = 4;
            this.btnOcistiPoljaPretrageLijekova.UseVisualStyleBackColor = true;
            this.btnOcistiPoljaPretrageLijekova.Click += new System.EventHandler(this.btnOcistiPoljaPretrageLijekova_Click);
            // 
            // gbPodaciOLijeku
            // 
            this.gbPodaciOLijeku.Controls.Add(this.tbNamjenaLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.lbNamjenaLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.dtpDozvolaVaziDoLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.lbDozvolaVaziDoLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.dtpDozvolaVaziOdLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.lbDozvolaVaziOdLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.lbKolicinaNaStanjuLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.nudKolicinaNaStanjuLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.cbIzdavanjeNaReceptLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.lbIzdavanjeNaReceptLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.tbPakovanjeLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.lbPakovanjeLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.tbProdajnaCijenaLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.lbProdajnaCijenaLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.tbNabavnaCijenaLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.lbNabavnaCijenaLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.tbNetoKolicinaLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.lbNetoKolicinaLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.tbProizvodjacLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.lbProizvodjacLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.tbNazivLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.lbNazivLijeka);
            this.gbPodaciOLijeku.Controls.Add(this.btnOdustatiLijek);
            this.gbPodaciOLijeku.Controls.Add(this.btnSacuvatiLijek);
            this.gbPodaciOLijeku.Location = new System.Drawing.Point(505, 3);
            this.gbPodaciOLijeku.Name = "gbPodaciOLijeku";
            this.gbPodaciOLijeku.Size = new System.Drawing.Size(314, 387);
            this.gbPodaciOLijeku.TabIndex = 0;
            this.gbPodaciOLijeku.TabStop = false;
            this.gbPodaciOLijeku.Text = "Podaci o lijeku";
            // 
            // tbNamjenaLijeka
            // 
            this.tbNamjenaLijeka.Location = new System.Drawing.Point(123, 295);
            this.tbNamjenaLijeka.MaxLength = 600;
            this.tbNamjenaLijeka.Multiline = true;
            this.tbNamjenaLijeka.Name = "tbNamjenaLijeka";
            this.tbNamjenaLijeka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNamjenaLijeka.Size = new System.Drawing.Size(180, 53);
            this.tbNamjenaLijeka.TabIndex = 10;
            // 
            // lbNamjenaLijeka
            // 
            this.lbNamjenaLijeka.AutoSize = true;
            this.lbNamjenaLijeka.Location = new System.Drawing.Point(9, 298);
            this.lbNamjenaLijeka.Name = "lbNamjenaLijeka";
            this.lbNamjenaLijeka.Size = new System.Drawing.Size(52, 13);
            this.lbNamjenaLijeka.TabIndex = 96;
            this.lbNamjenaLijeka.Text = "Namjena:";
            // 
            // dtpDozvolaVaziDoLijeka
            // 
            this.dtpDozvolaVaziDoLijeka.CustomFormat = "dd.MM.yyyy";
            this.dtpDozvolaVaziDoLijeka.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDozvolaVaziDoLijeka.Location = new System.Drawing.Point(123, 191);
            this.dtpDozvolaVaziDoLijeka.Name = "dtpDozvolaVaziDoLijeka";
            this.dtpDozvolaVaziDoLijeka.Size = new System.Drawing.Size(180, 20);
            this.dtpDozvolaVaziDoLijeka.TabIndex = 6;
            // 
            // lbDozvolaVaziDoLijeka
            // 
            this.lbDozvolaVaziDoLijeka.AutoSize = true;
            this.lbDozvolaVaziDoLijeka.Location = new System.Drawing.Point(8, 197);
            this.lbDozvolaVaziDoLijeka.Name = "lbDozvolaVaziDoLijeka";
            this.lbDozvolaVaziDoLijeka.Size = new System.Drawing.Size(90, 13);
            this.lbDozvolaVaziDoLijeka.TabIndex = 94;
            this.lbDozvolaVaziDoLijeka.Text = "Dozvola važi do:*";
            // 
            // dtpDozvolaVaziOdLijeka
            // 
            this.dtpDozvolaVaziOdLijeka.CustomFormat = "dd.MM.yyyy";
            this.dtpDozvolaVaziOdLijeka.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDozvolaVaziOdLijeka.Location = new System.Drawing.Point(123, 165);
            this.dtpDozvolaVaziOdLijeka.Name = "dtpDozvolaVaziOdLijeka";
            this.dtpDozvolaVaziOdLijeka.Size = new System.Drawing.Size(180, 20);
            this.dtpDozvolaVaziOdLijeka.TabIndex = 5;
            // 
            // lbDozvolaVaziOdLijeka
            // 
            this.lbDozvolaVaziOdLijeka.AutoSize = true;
            this.lbDozvolaVaziOdLijeka.Location = new System.Drawing.Point(8, 171);
            this.lbDozvolaVaziOdLijeka.Name = "lbDozvolaVaziOdLijeka";
            this.lbDozvolaVaziOdLijeka.Size = new System.Drawing.Size(90, 13);
            this.lbDozvolaVaziOdLijeka.TabIndex = 92;
            this.lbDozvolaVaziOdLijeka.Text = "Dozvola važi od:*";
            // 
            // lbKolicinaNaStanjuLijeka
            // 
            this.lbKolicinaNaStanjuLijeka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbKolicinaNaStanjuLijeka.AutoSize = true;
            this.lbKolicinaNaStanjuLijeka.Location = new System.Drawing.Point(8, 271);
            this.lbKolicinaNaStanjuLijeka.Name = "lbKolicinaNaStanjuLijeka";
            this.lbKolicinaNaStanjuLijeka.Size = new System.Drawing.Size(93, 13);
            this.lbKolicinaNaStanjuLijeka.TabIndex = 89;
            this.lbKolicinaNaStanjuLijeka.Text = "Količina na stanju:";
            // 
            // nudKolicinaNaStanjuLijeka
            // 
            this.nudKolicinaNaStanjuLijeka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nudKolicinaNaStanjuLijeka.Location = new System.Drawing.Point(123, 269);
            this.nudKolicinaNaStanjuLijeka.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudKolicinaNaStanjuLijeka.Name = "nudKolicinaNaStanjuLijeka";
            this.nudKolicinaNaStanjuLijeka.Size = new System.Drawing.Size(62, 20);
            this.nudKolicinaNaStanjuLijeka.TabIndex = 9;
            this.nudKolicinaNaStanjuLijeka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbIzdavanjeNaReceptLijeka
            // 
            this.cbIzdavanjeNaReceptLijeka.AutoSize = true;
            this.cbIzdavanjeNaReceptLijeka.Location = new System.Drawing.Point(123, 119);
            this.cbIzdavanjeNaReceptLijeka.Name = "cbIzdavanjeNaReceptLijeka";
            this.cbIzdavanjeNaReceptLijeka.Size = new System.Drawing.Size(15, 14);
            this.cbIzdavanjeNaReceptLijeka.TabIndex = 3;
            this.cbIzdavanjeNaReceptLijeka.UseVisualStyleBackColor = true;
            // 
            // lbIzdavanjeNaReceptLijeka
            // 
            this.lbIzdavanjeNaReceptLijeka.AutoSize = true;
            this.lbIzdavanjeNaReceptLijeka.Location = new System.Drawing.Point(8, 118);
            this.lbIzdavanjeNaReceptLijeka.Name = "lbIzdavanjeNaReceptLijeka";
            this.lbIzdavanjeNaReceptLijeka.Size = new System.Drawing.Size(108, 13);
            this.lbIzdavanjeNaReceptLijeka.TabIndex = 88;
            this.lbIzdavanjeNaReceptLijeka.Text = "Izdavanje na recept:*";
            // 
            // tbPakovanjeLijeka
            // 
            this.tbPakovanjeLijeka.Location = new System.Drawing.Point(123, 71);
            this.tbPakovanjeLijeka.MaxLength = 120;
            this.tbPakovanjeLijeka.Multiline = true;
            this.tbPakovanjeLijeka.Name = "tbPakovanjeLijeka";
            this.tbPakovanjeLijeka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPakovanjeLijeka.Size = new System.Drawing.Size(180, 42);
            this.tbPakovanjeLijeka.TabIndex = 2;
            // 
            // lbPakovanjeLijeka
            // 
            this.lbPakovanjeLijeka.AutoSize = true;
            this.lbPakovanjeLijeka.Location = new System.Drawing.Point(8, 74);
            this.lbPakovanjeLijeka.Name = "lbPakovanjeLijeka";
            this.lbPakovanjeLijeka.Size = new System.Drawing.Size(65, 13);
            this.lbPakovanjeLijeka.TabIndex = 86;
            this.lbPakovanjeLijeka.Text = "Pakovanje:*";
            // 
            // tbProdajnaCijenaLijeka
            // 
            this.tbProdajnaCijenaLijeka.Location = new System.Drawing.Point(123, 243);
            this.tbProdajnaCijenaLijeka.MaxLength = 100;
            this.tbProdajnaCijenaLijeka.Name = "tbProdajnaCijenaLijeka";
            this.tbProdajnaCijenaLijeka.Size = new System.Drawing.Size(180, 20);
            this.tbProdajnaCijenaLijeka.TabIndex = 8;
            // 
            // lbProdajnaCijenaLijeka
            // 
            this.lbProdajnaCijenaLijeka.AutoSize = true;
            this.lbProdajnaCijenaLijeka.Location = new System.Drawing.Point(8, 246);
            this.lbProdajnaCijenaLijeka.Name = "lbProdajnaCijenaLijeka";
            this.lbProdajnaCijenaLijeka.Size = new System.Drawing.Size(87, 13);
            this.lbProdajnaCijenaLijeka.TabIndex = 83;
            this.lbProdajnaCijenaLijeka.Text = "Prodajna cijena:*";
            // 
            // tbNabavnaCijenaLijeka
            // 
            this.tbNabavnaCijenaLijeka.Location = new System.Drawing.Point(123, 217);
            this.tbNabavnaCijenaLijeka.MaxLength = 100;
            this.tbNabavnaCijenaLijeka.Name = "tbNabavnaCijenaLijeka";
            this.tbNabavnaCijenaLijeka.Size = new System.Drawing.Size(180, 20);
            this.tbNabavnaCijenaLijeka.TabIndex = 7;
            // 
            // lbNabavnaCijenaLijeka
            // 
            this.lbNabavnaCijenaLijeka.AutoSize = true;
            this.lbNabavnaCijenaLijeka.Location = new System.Drawing.Point(8, 220);
            this.lbNabavnaCijenaLijeka.Name = "lbNabavnaCijenaLijeka";
            this.lbNabavnaCijenaLijeka.Size = new System.Drawing.Size(89, 13);
            this.lbNabavnaCijenaLijeka.TabIndex = 81;
            this.lbNabavnaCijenaLijeka.Text = "Nabavna cijena:*";
            // 
            // tbNetoKolicinaLijeka
            // 
            this.tbNetoKolicinaLijeka.Location = new System.Drawing.Point(123, 139);
            this.tbNetoKolicinaLijeka.MaxLength = 80;
            this.tbNetoKolicinaLijeka.Name = "tbNetoKolicinaLijeka";
            this.tbNetoKolicinaLijeka.Size = new System.Drawing.Size(180, 20);
            this.tbNetoKolicinaLijeka.TabIndex = 4;
            // 
            // lbNetoKolicinaLijeka
            // 
            this.lbNetoKolicinaLijeka.AutoSize = true;
            this.lbNetoKolicinaLijeka.Location = new System.Drawing.Point(8, 142);
            this.lbNetoKolicinaLijeka.Name = "lbNetoKolicinaLijeka";
            this.lbNetoKolicinaLijeka.Size = new System.Drawing.Size(76, 13);
            this.lbNetoKolicinaLijeka.TabIndex = 79;
            this.lbNetoKolicinaLijeka.Text = "Neto količina:*";
            // 
            // tbProizvodjacLijeka
            // 
            this.tbProizvodjacLijeka.Location = new System.Drawing.Point(123, 45);
            this.tbProizvodjacLijeka.MaxLength = 70;
            this.tbProizvodjacLijeka.Name = "tbProizvodjacLijeka";
            this.tbProizvodjacLijeka.Size = new System.Drawing.Size(180, 20);
            this.tbProizvodjacLijeka.TabIndex = 1;
            // 
            // lbProizvodjacLijeka
            // 
            this.lbProizvodjacLijeka.AutoSize = true;
            this.lbProizvodjacLijeka.Location = new System.Drawing.Point(8, 48);
            this.lbProizvodjacLijeka.Name = "lbProizvodjacLijeka";
            this.lbProizvodjacLijeka.Size = new System.Drawing.Size(68, 13);
            this.lbProizvodjacLijeka.TabIndex = 76;
            this.lbProizvodjacLijeka.Text = "Proizvođač:*";
            // 
            // tbNazivLijeka
            // 
            this.tbNazivLijeka.Location = new System.Drawing.Point(123, 19);
            this.tbNazivLijeka.MaxLength = 70;
            this.tbNazivLijeka.Name = "tbNazivLijeka";
            this.tbNazivLijeka.Size = new System.Drawing.Size(180, 20);
            this.tbNazivLijeka.TabIndex = 0;
            // 
            // lbNazivLijeka
            // 
            this.lbNazivLijeka.AutoSize = true;
            this.lbNazivLijeka.Location = new System.Drawing.Point(8, 22);
            this.lbNazivLijeka.Name = "lbNazivLijeka";
            this.lbNazivLijeka.Size = new System.Drawing.Size(41, 13);
            this.lbNazivLijeka.TabIndex = 75;
            this.lbNazivLijeka.Text = "Naziv:*";
            // 
            // btnOdustatiLijek
            // 
            this.btnOdustatiLijek.Image = global::Apoteka.Properties.Resources.cancel;
            this.btnOdustatiLijek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustatiLijek.Location = new System.Drawing.Point(227, 354);
            this.btnOdustatiLijek.Name = "btnOdustatiLijek";
            this.btnOdustatiLijek.Size = new System.Drawing.Size(87, 27);
            this.btnOdustatiLijek.TabIndex = 12;
            this.btnOdustatiLijek.Text = "Odustati";
            this.btnOdustatiLijek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustatiLijek.UseVisualStyleBackColor = true;
            this.btnOdustatiLijek.Click += new System.EventHandler(this.btnOdustatiLijek_Click);
            // 
            // btnSacuvatiLijek
            // 
            this.btnSacuvatiLijek.Image = ((System.Drawing.Image)(resources.GetObject("btnSacuvatiLijek.Image")));
            this.btnSacuvatiLijek.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSacuvatiLijek.Location = new System.Drawing.Point(123, 354);
            this.btnSacuvatiLijek.Name = "btnSacuvatiLijek";
            this.btnSacuvatiLijek.Size = new System.Drawing.Size(87, 27);
            this.btnSacuvatiLijek.TabIndex = 11;
            this.btnSacuvatiLijek.Text = "Sačuvati";
            this.btnSacuvatiLijek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSacuvatiLijek.UseVisualStyleBackColor = true;
            this.btnSacuvatiLijek.Click += new System.EventHandler(this.btnSacuvatiLijek_Click);
            // 
            // msMeni
            // 
            this.msMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(252)))), ((int)(((byte)(223)))));
            this.msMeni.Dock = System.Windows.Forms.DockStyle.None;
            this.msMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZaposleni,
            this.tsmiLijek,
            this.tsmiDobavljaci,
            this.tsmiUlazIzlaz,
            this.tsmiApoteka,
            this.tsmiMojNalog,
            this.oAplikacijiToolStripMenuItem});
            this.msMeni.Location = new System.Drawing.Point(0, 0);
            this.msMeni.Name = "msMeni";
            this.msMeni.Size = new System.Drawing.Size(831, 24);
            this.msMeni.TabIndex = 0;
            this.msMeni.MouseMove += new System.Windows.Forms.MouseEventHandler(this.msMeni_MouseMove);
            // 
            // tsmiZaposleni
            // 
            this.tsmiZaposleni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPregledatiZaposlene});
            this.tsmiZaposleni.Name = "tsmiZaposleni";
            this.tsmiZaposleni.Size = new System.Drawing.Size(70, 20);
            this.tsmiZaposleni.Text = "&Zaposleni";
            // 
            // tsmiPregledatiZaposlene
            // 
            this.tsmiPregledatiZaposlene.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaTabelom,
            this.tsmiSaListom});
            this.tsmiPregledatiZaposlene.Name = "tsmiPregledatiZaposlene";
            this.tsmiPregledatiZaposlene.Size = new System.Drawing.Size(127, 22);
            this.tsmiPregledatiZaposlene.Text = "&Pregledati";
            // 
            // tsmiSaTabelom
            // 
            this.tsmiSaTabelom.Image = global::Apoteka.Properties.Resources.table_view;
            this.tsmiSaTabelom.Name = "tsmiSaTabelom";
            this.tsmiSaTabelom.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F1)));
            this.tsmiSaTabelom.Size = new System.Drawing.Size(211, 22);
            this.tsmiSaTabelom.Text = "Sa &tabelom";
            this.tsmiSaTabelom.Click += new System.EventHandler(this.tsmiSaTabelom_Click);
            // 
            // tsmiSaListom
            // 
            this.tsmiSaListom.Image = global::Apoteka.Properties.Resources.list_view;
            this.tsmiSaListom.Name = "tsmiSaListom";
            this.tsmiSaListom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.tsmiSaListom.Size = new System.Drawing.Size(211, 22);
            this.tsmiSaListom.Text = "Sa &listom";
            this.tsmiSaListom.Click += new System.EventHandler(this.tsmiSaListom_Click);
            // 
            // tsmiLijek
            // 
            this.tsmiLijek.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPregledLijekova,
            this.tsmiDodatiLijek});
            this.tsmiLijek.Name = "tsmiLijek";
            this.tsmiLijek.Size = new System.Drawing.Size(59, 20);
            this.tsmiLijek.Text = "&Lijekovi";
            // 
            // tsmiPregledLijekova
            // 
            this.tsmiPregledLijekova.Name = "tsmiPregledLijekova";
            this.tsmiPregledLijekova.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F2)));
            this.tsmiPregledLijekova.Size = new System.Drawing.Size(205, 22);
            this.tsmiPregledLijekova.Text = "&Pregledati";
            this.tsmiPregledLijekova.Click += new System.EventHandler(this.tsmiPregledLijekova_Click);
            // 
            // tsmiDodatiLijek
            // 
            this.tsmiDodatiLijek.Image = global::Apoteka.Properties.Resources.add_medicine;
            this.tsmiDodatiLijek.Name = "tsmiDodatiLijek";
            this.tsmiDodatiLijek.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.tsmiDodatiLijek.Size = new System.Drawing.Size(205, 22);
            this.tsmiDodatiLijek.Text = "&Dodati";
            this.tsmiDodatiLijek.Click += new System.EventHandler(this.tsmiDodatiLijek_Click);
            // 
            // tsmiDobavljaci
            // 
            this.tsmiDobavljaci.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPregledDobavljaca,
            this.tsmiDodatiDobavljaca});
            this.tsmiDobavljaci.Name = "tsmiDobavljaci";
            this.tsmiDobavljaci.Size = new System.Drawing.Size(74, 20);
            this.tsmiDobavljaci.Text = "&Dobavljači";
            // 
            // tsmiPregledDobavljaca
            // 
            this.tsmiPregledDobavljaca.Name = "tsmiPregledDobavljaca";
            this.tsmiPregledDobavljaca.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F3)));
            this.tsmiPregledDobavljaca.Size = new System.Drawing.Size(205, 22);
            this.tsmiPregledDobavljaca.Text = "Pregledati";
            this.tsmiPregledDobavljaca.Click += new System.EventHandler(this.tsmiPregledDobavljaca_Click);
            // 
            // tsmiDodatiDobavljaca
            // 
            this.tsmiDodatiDobavljaca.Image = global::Apoteka.Properties.Resources.add_deliverer;
            this.tsmiDodatiDobavljaca.Name = "tsmiDodatiDobavljaca";
            this.tsmiDodatiDobavljaca.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.tsmiDodatiDobavljaca.Size = new System.Drawing.Size(205, 22);
            this.tsmiDodatiDobavljaca.Text = "Dodati";
            this.tsmiDodatiDobavljaca.Click += new System.EventHandler(this.tsmiDodatiDobavljaca_Click);
            // 
            // tsmiUlazIzlaz
            // 
            this.tsmiUlazIzlaz.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNarudzbeFakture,
            this.tsmiRacuni});
            this.tsmiUlazIzlaz.Name = "tsmiUlazIzlaz";
            this.tsmiUlazIzlaz.Size = new System.Drawing.Size(68, 20);
            this.tsmiUlazIzlaz.Text = "&Ulaz/Izlaz";
            // 
            // tsmiNarudzbeFakture
            // 
            this.tsmiNarudzbeFakture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPregledNarudzbaFaktura,
            this.tsmiKreiratiNarudzbu});
            this.tsmiNarudzbeFakture.Name = "tsmiNarudzbeFakture";
            this.tsmiNarudzbeFakture.Size = new System.Drawing.Size(169, 22);
            this.tsmiNarudzbeFakture.Text = "&Narudžbe/Fakture";
            // 
            // tsmiPregledNarudzbaFaktura
            // 
            this.tsmiPregledNarudzbaFaktura.Name = "tsmiPregledNarudzbaFaktura";
            this.tsmiPregledNarudzbaFaktura.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F4)));
            this.tsmiPregledNarudzbaFaktura.Size = new System.Drawing.Size(210, 22);
            this.tsmiPregledNarudzbaFaktura.Text = "&Pregledati";
            this.tsmiPregledNarudzbaFaktura.Click += new System.EventHandler(this.tsmiPregledNarudzbaFaktura_Click);
            // 
            // tsmiKreiratiNarudzbu
            // 
            this.tsmiKreiratiNarudzbu.Image = global::Apoteka.Properties.Resources.create_order_list;
            this.tsmiKreiratiNarudzbu.Name = "tsmiKreiratiNarudzbu";
            this.tsmiKreiratiNarudzbu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.tsmiKreiratiNarudzbu.Size = new System.Drawing.Size(210, 22);
            this.tsmiKreiratiNarudzbu.Text = "&Kreirati narudžbu";
            this.tsmiKreiratiNarudzbu.Click += new System.EventHandler(this.tsmiKreiratiNarudzbu_Click);
            // 
            // tsmiRacuni
            // 
            this.tsmiRacuni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPregledRacuna});
            this.tsmiRacuni.Name = "tsmiRacuni";
            this.tsmiRacuni.Size = new System.Drawing.Size(169, 22);
            this.tsmiRacuni.Text = "&Računi";
            // 
            // tsmiPregledRacuna
            // 
            this.tsmiPregledRacuna.Name = "tsmiPregledRacuna";
            this.tsmiPregledRacuna.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F5)));
            this.tsmiPregledRacuna.Size = new System.Drawing.Size(205, 22);
            this.tsmiPregledRacuna.Text = "&Pregledati";
            this.tsmiPregledRacuna.Click += new System.EventHandler(this.tsmiPregledRacuna_Click);
            // 
            // tsmiApoteka
            // 
            this.tsmiApoteka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInformacijeOApoteci});
            this.tsmiApoteka.Name = "tsmiApoteka";
            this.tsmiApoteka.Size = new System.Drawing.Size(63, 20);
            this.tsmiApoteka.Text = "&Apoteka";
            // 
            // tsmiInformacijeOApoteci
            // 
            this.tsmiInformacijeOApoteci.Image = global::Apoteka.Properties.Resources.info;
            this.tsmiInformacijeOApoteci.Name = "tsmiInformacijeOApoteci";
            this.tsmiInformacijeOApoteci.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tsmiInformacijeOApoteci.Size = new System.Drawing.Size(171, 22);
            this.tsmiInformacijeOApoteci.Text = "&Informacije";
            this.tsmiInformacijeOApoteci.Click += new System.EventHandler(this.tsmiInformacijeOApoteci_Click);
            // 
            // tsmiMojNalog
            // 
            this.tsmiMojNalog.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiMojNalog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPromjenitiLozinku,
            this.tsmiOdjava});
            this.tsmiMojNalog.Name = "tsmiMojNalog";
            this.tsmiMojNalog.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.tsmiMojNalog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsmiMojNalog.Size = new System.Drawing.Size(69, 20);
            this.tsmiMojNalog.Text = "Moj &nalog";
            // 
            // tsmiPromjenitiLozinku
            // 
            this.tsmiPromjenitiLozinku.Name = "tsmiPromjenitiLozinku";
            this.tsmiPromjenitiLozinku.Size = new System.Drawing.Size(170, 22);
            this.tsmiPromjenitiLozinku.Text = "&Promjeniti lozinku";
            this.tsmiPromjenitiLozinku.Click += new System.EventHandler(this.tsmiPromjenitiLozinku_Click);
            // 
            // tsmiOdjava
            // 
            this.tsmiOdjava.Image = global::Apoteka.Properties.Resources.logout;
            this.tsmiOdjava.Name = "tsmiOdjava";
            this.tsmiOdjava.Size = new System.Drawing.Size(170, 22);
            this.tsmiOdjava.Text = "&Odjava";
            this.tsmiOdjava.Click += new System.EventHandler(this.tsmiOdjava_Click);
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInformacijeOAplikaciji});
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.oAplikacijiToolStripMenuItem.Text = "&O aplikaciji";
            // 
            // tsmiInformacijeOAplikaciji
            // 
            this.tsmiInformacijeOAplikaciji.Image = global::Apoteka.Properties.Resources.info;
            this.tsmiInformacijeOAplikaciji.Name = "tsmiInformacijeOAplikaciji";
            this.tsmiInformacijeOAplikaciji.Size = new System.Drawing.Size(180, 22);
            this.tsmiInformacijeOAplikaciji.Text = "&Informacije";
            this.tsmiInformacijeOAplikaciji.Click += new System.EventHandler(this.tsmiInformacijeOAplikaciji_Click);
            // 
            // TimerTrenutnoVrijeme
            // 
            this.TimerTrenutnoVrijeme.Enabled = true;
            this.TimerTrenutnoVrijeme.Interval = 1000;
            this.TimerTrenutnoVrijeme.Tick += new System.EventHandler(this.TimerTrenutnoVrijeme_Tick);
            // 
            // MenadzerForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 441);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenadzerForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apoteka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenadzerForma_FormClosing);
            this.Load += new System.EventHandler(this.MenadzerForma_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ssStatusnaLinija.ResumeLayout(false);
            this.ssStatusnaLinija.PerformLayout();
            this.pnlDobavljaci.ResumeLayout(false);
            this.gbPretragaDobavljaca.ResumeLayout(false);
            this.gbPretragaDobavljaca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).EndInit();
            this.cmsTabelaDobavljaci.ResumeLayout(false);
            this.gbPodaciODobavljacu.ResumeLayout(false);
            this.gbPodaciODobavljacu.PerformLayout();
            this.pnlRacuni.ResumeLayout(false);
            this.gbPretragaRacuna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.cmsTabelaRacuna.ResumeLayout(false);
            this.gbStavkeRacuna.ResumeLayout(false);
            this.gbStavkeRacuna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            this.cmsTabelaStavkeRacuna.ResumeLayout(false);
            this.pnlZaposleniSaTabelom.ResumeLayout(false);
            this.gbPretragaZaposlenog.ResumeLayout(false);
            this.gbPretragaZaposlenog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            this.cmsTabelaZaposleni.ResumeLayout(false);
            this.gbPodaciZaposlenog.ResumeLayout(false);
            this.gbPodaciZaposlenog.PerformLayout();
            this.pnlNarudzbe.ResumeLayout(false);
            this.gbPodaciSaFakture.ResumeLayout(false);
            this.gbPodaciSaFakture.PerformLayout();
            this.gbPretragaNarudzbe.ResumeLayout(false);
            this.gbPretragaNarudzbe.PerformLayout();
            this.cmsListaNarudzbi.ResumeLayout(false);
            this.gbStavkeNarudzbe.ResumeLayout(false);
            this.gbStavkeNarudzbe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbe)).EndInit();
            this.pnlZaposleniSaListom.ResumeLayout(false);
            this.gbPretragaZaposlenogLista.ResumeLayout(false);
            this.gbPretragaZaposlenogLista.PerformLayout();
            this.cmsListaZaposleni.ResumeLayout(false);
            this.gbPodaciZaposlenogLista.ResumeLayout(false);
            this.gbPodaciZaposlenogLista.PerformLayout();
            this.pnlLijekovi.ResumeLayout(false);
            this.gbPretragaLijeka.ResumeLayout(false);
            this.gbPretragaLijeka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            this.cmsTabelaLijekova.ResumeLayout(false);
            this.gbPodaciOLijeku.ResumeLayout(false);
            this.gbPodaciOLijeku.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicinaNaStanjuLijeka)).EndInit();
            this.msMeni.ResumeLayout(false);
            this.msMeni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip ssStatusnaLinija;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusnaLabela;
        private System.Windows.Forms.ToolStripStatusLabel tsslPrijavljenZaposleni;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatumVrijeme;
        private System.Windows.Forms.MenuStrip msMeni;
        private System.Windows.Forms.ToolStripMenuItem tsmiZaposleni;
        private System.Windows.Forms.ToolStripMenuItem tsmiPregledatiZaposlene;
        private System.Windows.Forms.ToolStripMenuItem tsmiLijek;
        private System.Windows.Forms.ToolStripMenuItem tsmiPregledLijekova;
        private System.Windows.Forms.ToolStripMenuItem tsmiDodatiLijek;
        private System.Windows.Forms.ToolStripMenuItem tsmiApoteka;
        private System.Windows.Forms.ToolStripMenuItem tsmiInformacijeOApoteci;
        private System.Windows.Forms.ToolStripMenuItem tsmiMojNalog;
        private System.Windows.Forms.ToolStripMenuItem tsmiPromjenitiLozinku;
        private System.Windows.Forms.ToolStripMenuItem tsmiOdjava;
        private System.Windows.Forms.Timer TimerTrenutnoVrijeme;
        private System.Windows.Forms.Panel pnlZaposleniSaTabelom;
        private System.Windows.Forms.GroupBox gbPretragaZaposlenog;
        private System.Windows.Forms.DataGridView dgvZaposleni;
        private System.Windows.Forms.TextBox tbPrezimePretraga;
        private System.Windows.Forms.TextBox tbImePretraga;
        private System.Windows.Forms.TextBox tbJmbgPretraga;
        private System.Windows.Forms.Button btnOcistiPoljaPretrage;
        private System.Windows.Forms.GroupBox gbPodaciZaposlenog;
        private System.Windows.Forms.MaskedTextBox mtbJmbg;
        private System.Windows.Forms.Label lbJmbg;
        private System.Windows.Forms.ComboBox cbMjesto;
        private System.Windows.Forms.Label lbMjesto;
        private System.Windows.Forms.Button btnOdustati;
        private System.Windows.Forms.Button btnSacuvati;
        private System.Windows.Forms.TextBox tbOpisPosla;
        private System.Windows.Forms.Label lbOpisPosla;
        private System.Windows.Forms.CheckBox cbSefApoteke;
        private System.Windows.Forms.Label lbSefApoteke;
        private System.Windows.Forms.TextBox tbFarmaceutskoZvanje;
        private System.Windows.Forms.Label lbFarmaceutskoZvanje;
        private System.Windows.Forms.TextBox tbStrucnaSprema;
        private System.Windows.Forms.Label lbStrucnaSprema;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.ContextMenuStrip cmsTabelaZaposleni;
        private System.Windows.Forms.ToolStripMenuItem tsmiIzmjenitiZaposlenog;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaTabelom;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaListom;
        private System.Windows.Forms.TextBox tbStrucnaSpremaPretraga;
        private System.Windows.Forms.Panel pnlZaposleniSaListom;
        private System.Windows.Forms.GroupBox gbPretragaZaposlenogLista;
        private System.Windows.Forms.TextBox tbStrucnaSpremaPretragaLista;
        private System.Windows.Forms.TextBox tbPrezimePretragaLista;
        private System.Windows.Forms.TextBox tbImePretragaLista;
        private System.Windows.Forms.TextBox tbJmbgPretragaLista;
        private System.Windows.Forms.Button btnOcistiPoljaPretrageLista;
        private System.Windows.Forms.GroupBox gbPodaciZaposlenogLista;
        private System.Windows.Forms.MaskedTextBox mtbJmbgLista;
        private System.Windows.Forms.Label lbJmbgLista;
        private System.Windows.Forms.ComboBox cbMjestoLista;
        private System.Windows.Forms.Label lbMjestoLista;
        private System.Windows.Forms.Button btnOdustatiLista;
        private System.Windows.Forms.Button btnSacuvatiLista;
        private System.Windows.Forms.TextBox tbOpisPoslaLista;
        private System.Windows.Forms.Label lbOpisPoslaLista;
        private System.Windows.Forms.CheckBox cbSefApotekeLista;
        private System.Windows.Forms.Label lbSefApotekeLista;
        private System.Windows.Forms.TextBox tbFarmaceutskoZvanjeLista;
        private System.Windows.Forms.Label lbFarmaceutskoZvanjeLista;
        private System.Windows.Forms.TextBox tbStrucnaSpremaLista;
        private System.Windows.Forms.Label lbStrucnaSpremaLista;
        private System.Windows.Forms.TextBox tbEmailLista;
        private System.Windows.Forms.Label lbEmailLista;
        private System.Windows.Forms.TextBox tbTelefonLista;
        private System.Windows.Forms.Label lbTelefonLista;
        private System.Windows.Forms.TextBox tbAdresaLista;
        private System.Windows.Forms.Label lbAdresaLista;
        private System.Windows.Forms.TextBox tbPrezimeLista;
        private System.Windows.Forms.Label lbPrezimeLista;
        private System.Windows.Forms.TextBox tbImeLista;
        private System.Windows.Forms.Label lbImeLista;
        private System.Windows.Forms.ListView lvZaposleni;
        private System.Windows.Forms.ColumnHeader jmbgListaZaposleni;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmbgTabelaZaposleni;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeTabelaZaposleni;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeTabelaZaposleni;
        private System.Windows.Forms.DataGridViewTextBoxColumn strucnaSpremaTabelaZaposleni;
        private System.Windows.Forms.ColumnHeader imeListaZaposleni;
        private System.Windows.Forms.ColumnHeader prezimeListaZaposleni;
        private System.Windows.Forms.ColumnHeader strucnaSpremaListaZaposleni;
        private System.Windows.Forms.ContextMenuStrip cmsListaZaposleni;
        private System.Windows.Forms.ToolStripMenuItem tsmiIzmjenitiZaposlenogLista;
        private System.Windows.Forms.Panel pnlLijekovi;
        private System.Windows.Forms.GroupBox gbPretragaLijeka;
        private System.Windows.Forms.DataGridView dgvLijekovi;
        private System.Windows.Forms.CheckBox cbIzdavanjeNaReceptPretraga;
        private System.Windows.Forms.TextBox tbNazivLijekaPretraga;
        private System.Windows.Forms.Button btnOcistiPoljaPretrageLijekova;
        private System.Windows.Forms.GroupBox gbPodaciOLijeku;
        private System.Windows.Forms.Button btnOdustatiLijek;
        private System.Windows.Forms.Button btnSacuvatiLijek;
        private System.Windows.Forms.DateTimePicker dtpDozvolaVaziOdPretraga;
        private System.Windows.Forms.DateTimePicker dtpDozvolaVaziDoPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivLijeka;
        private System.Windows.Forms.DataGridViewTextBoxColumn dozvolaVaziOdLijek;
        private System.Windows.Forms.DataGridViewTextBoxColumn dozvolaVaziDoLijek;
        private System.Windows.Forms.DataGridViewCheckBoxColumn naReceptLijek;
        private System.Windows.Forms.ContextMenuStrip cmsTabelaLijekova;
        private System.Windows.Forms.ToolStripMenuItem tsmiIzmjenitiLijek;
        private System.Windows.Forms.ToolStripMenuItem tsmiObrisatiLijek;
        private System.Windows.Forms.DateTimePicker dtpDozvolaVaziDoLijeka;
        private System.Windows.Forms.Label lbDozvolaVaziDoLijeka;
        private System.Windows.Forms.DateTimePicker dtpDozvolaVaziOdLijeka;
        private System.Windows.Forms.Label lbDozvolaVaziOdLijeka;
        private System.Windows.Forms.Label lbKolicinaNaStanjuLijeka;
        private System.Windows.Forms.NumericUpDown nudKolicinaNaStanjuLijeka;
        private System.Windows.Forms.CheckBox cbIzdavanjeNaReceptLijeka;
        private System.Windows.Forms.Label lbIzdavanjeNaReceptLijeka;
        private System.Windows.Forms.TextBox tbPakovanjeLijeka;
        private System.Windows.Forms.Label lbPakovanjeLijeka;
        private System.Windows.Forms.TextBox tbProdajnaCijenaLijeka;
        private System.Windows.Forms.Label lbProdajnaCijenaLijeka;
        private System.Windows.Forms.TextBox tbNabavnaCijenaLijeka;
        private System.Windows.Forms.Label lbNabavnaCijenaLijeka;
        private System.Windows.Forms.TextBox tbNetoKolicinaLijeka;
        private System.Windows.Forms.Label lbNetoKolicinaLijeka;
        private System.Windows.Forms.TextBox tbProizvodjacLijeka;
        private System.Windows.Forms.Label lbProizvodjacLijeka;
        private System.Windows.Forms.TextBox tbNazivLijeka;
        private System.Windows.Forms.Label lbNazivLijeka;
        private System.Windows.Forms.TextBox tbNamjenaLijeka;
        private System.Windows.Forms.Label lbNamjenaLijeka;
        private System.Windows.Forms.ToolStripMenuItem tsmiDobavljaci;
        private System.Windows.Forms.ToolStripMenuItem tsmiPregledDobavljaca;
        private System.Windows.Forms.ToolStripMenuItem tsmiDodatiDobavljaca;
        private System.Windows.Forms.Panel pnlDobavljaci;
        private System.Windows.Forms.GroupBox gbPretragaDobavljaca;
        private System.Windows.Forms.DataGridView dgvDobavljaci;
        private System.Windows.Forms.TextBox tbNazivDobavljacaPretraga;
        private System.Windows.Forms.Button btnOcistiPoljaPretrageDobavljaca;
        private System.Windows.Forms.GroupBox gbPodaciODobavljacu;
        private System.Windows.Forms.Button btnOdustatiDobavljac;
        private System.Windows.Forms.Button btnSacuvatiDobavljaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDobavljaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDobavljaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDobavljaca;
        private System.Windows.Forms.TextBox tbWebSajtDobavljaca;
        private System.Windows.Forms.Label lbWebSajtDobavljaca;
        private System.Windows.Forms.TextBox tbEmailDobavljaca;
        private System.Windows.Forms.Label lbEmailDobavljaca;
        private System.Windows.Forms.Label lbAdresaDobavljaca;
        private System.Windows.Forms.ComboBox cbMjestoDobavljaca;
        private System.Windows.Forms.TextBox tbAdresaDobavljaca;
        private System.Windows.Forms.Label lbMjestoDobavljaca;
        private System.Windows.Forms.Label lbTelefonDobavljaca;
        private System.Windows.Forms.TextBox tbTelefonDobavljaca;
        private System.Windows.Forms.CheckBox cbRegistrovanKodALMS;
        private System.Windows.Forms.Label lbRegKodALMSDobavljac;
        private System.Windows.Forms.TextBox tbNazivDobavljaca;
        private System.Windows.Forms.Label lbNazivDobavljaca;
        private System.Windows.Forms.ContextMenuStrip cmsTabelaDobavljaci;
        private System.Windows.Forms.ToolStripMenuItem tsmiIzmjenitiDobavljaca;
        private System.Windows.Forms.ToolStripMenuItem tsmiObrisatiDobavljaca;
        private System.Windows.Forms.ToolStripMenuItem tsmiUlazIzlaz;
        private System.Windows.Forms.ToolStripMenuItem tsmiNarudzbeFakture;
        private System.Windows.Forms.ToolStripMenuItem tsmiPregledNarudzbaFaktura;
        private System.Windows.Forms.ToolStripMenuItem tsmiKreiratiNarudzbu;
        private System.Windows.Forms.ToolStripMenuItem tsmiRacuni;
        private System.Windows.Forms.ToolStripMenuItem tsmiPregledRacuna;
        private System.Windows.Forms.Panel pnlNarudzbe;
        private System.Windows.Forms.GroupBox gbPretragaNarudzbe;
        private System.Windows.Forms.ListView lvNarudzbe;
        private System.Windows.Forms.ColumnHeader brojNarudzbeKolona;
        private System.Windows.Forms.ColumnHeader datumKreiranjaKolona;
        private System.Windows.Forms.ColumnHeader dobavljacKolona;
        private System.Windows.Forms.TextBox tbDobavljacPretraga;
        private System.Windows.Forms.TextBox tbBrojNarudzbePretraga;
        private System.Windows.Forms.Button btnOcistiPoljaPretrageNarudzbe;
        private System.Windows.Forms.GroupBox gbStavkeNarudzbe;
        private System.Windows.Forms.DateTimePicker dtpKreiranaDoPretraga;
        private System.Windows.Forms.DateTimePicker dtpKreiranaOdPretraga;
        private System.Windows.Forms.DataGridView dgvStavkeNarudzbe;
        private System.Windows.Forms.Label lbKreiraoNarudzbuZaposleni;
        private System.Windows.Forms.Label lbKreiraoNarudzbu;
        private System.Windows.Forms.TextBox tbUkupanIznosNarudzba;
        private System.Windows.Forms.DataGridViewTextBoxColumn lijek;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos;
        private System.Windows.Forms.GroupBox gbPodaciSaFakture;
        private System.Windows.Forms.TextBox tbNacinPlacanjaFakture;
        private System.Windows.Forms.Label lbNacinPlacanja;
        private System.Windows.Forms.TextBox tbMjestoIzdavanjaFakture;
        private System.Windows.Forms.Label lbMjestoIzdavanja;
        private System.Windows.Forms.TextBox tbBrojFakture;
        private System.Windows.Forms.Label lbBrojFakture;
        private System.Windows.Forms.Label lbDatumIzdavanja;
        private System.Windows.Forms.DateTimePicker dtpDatumIzdavanjaFakture;
        private System.Windows.Forms.Button btnSacuvatiFaktura;
        private System.Windows.Forms.Button btnOdustatiFaktura;
        private System.Windows.Forms.ContextMenuStrip cmsListaNarudzbi;
        private System.Windows.Forms.ToolStripMenuItem tsmiZavrsitiNarudzbu;
        private System.Windows.Forms.ToolStripMenuItem tsmiObrisatiNarudzbu;
        private System.Windows.Forms.Label lbPrimioFakturuZaposleni;
        private System.Windows.Forms.Label lbPrimioFakturu;
        private System.Windows.Forms.Panel pnlRacuni;
        private System.Windows.Forms.GroupBox gbPretragaRacuna;
        private System.Windows.Forms.DateTimePicker dtpDatumKreiranjaRacunaDoPretraga;
        private System.Windows.Forms.DateTimePicker dtpDatumKreiranjaRacunaOdPretraga;
        private System.Windows.Forms.Button btnOcistiPoljaPretrageRacuna;
        private System.Windows.Forms.GroupBox gbStavkeRacuna;
        private System.Windows.Forms.TextBox tbUkupanIznosRacuna;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdvcNazivLijeka;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcKolicinaLijekaNaStavci;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIznosNaStavci;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDatumKreiranjaRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIzdatOd;
        private System.Windows.Forms.ContextMenuStrip cmsTabelaStavkeRacuna;
        private System.Windows.Forms.ToolStripMenuItem tsmiPregledatiRecept;
        private System.Windows.Forms.Button btnKreiratiPdfIzvjestaj;
        private System.Windows.Forms.ContextMenuStrip cmsTabelaRacuna;
        private System.Windows.Forms.ToolStripMenuItem tsmiObrisatiRacun;
        private System.Windows.Forms.ToolStripProgressBar tspbProgresBar;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInformacijeOAplikaciji;
    }
}