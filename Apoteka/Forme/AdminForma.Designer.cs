namespace Apoteka
{
    partial class AdminForma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForma));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ssStatusnaLinija = new System.Windows.Forms.StatusStrip();
            this.tsslStatusnaLabela = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPrijavljenZaposleni = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDatumVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlZaposleni = new System.Windows.Forms.Panel();
            this.gbPretragaZaposlenog = new System.Windows.Forms.GroupBox();
            this.dgvZaposleni = new System.Windows.Forms.DataGridView();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsTabelaZaposleni = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiIzmjenitiZaposlenog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAktiviratiDeaktiviratiZaposlenog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiObrisatiZaposlenog = new System.Windows.Forms.ToolStripMenuItem();
            this.cbAktivanPretraga = new System.Windows.Forms.CheckBox();
            this.tbPrezimePretraga = new System.Windows.Forms.TextBox();
            this.tbImePretraga = new System.Windows.Forms.TextBox();
            this.tbKorisnickoImePretraga = new System.Windows.Forms.TextBox();
            this.btnOcistiPoljaPretrage = new System.Windows.Forms.Button();
            this.gbPodaciZaposlenog = new System.Windows.Forms.GroupBox();
            this.lbUloga = new System.Windows.Forms.Label();
            this.cbUloga = new System.Windows.Forms.ComboBox();
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
            this.msMeni = new System.Windows.Forms.MenuStrip();
            this.tsmiZaposleni = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDodatiZaposlenog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMjesta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPregledMjesta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDodatiMjesto = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pnlZaposleni.SuspendLayout();
            this.gbPretragaZaposlenog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            this.cmsTabelaZaposleni.SuspendLayout();
            this.gbPodaciZaposlenog.SuspendLayout();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlZaposleni);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(831, 400);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(831, 448);
            this.toolStripContainer1.TabIndex = 0;
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
            this.tsslStatusnaLabela.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslStatusnaLabela.Name = "tsslStatusnaLabela";
            this.tsslStatusnaLabela.Size = new System.Drawing.Size(623, 19);
            this.tsslStatusnaLabela.Spring = true;
            this.tsslStatusnaLabela.Text = "Aplikacija je spremna";
            this.tsslStatusnaLabela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslPrijavljenZaposleni
            // 
            this.tsslPrijavljenZaposleni.Name = "tsslPrijavljenZaposleni";
            this.tsslPrijavljenZaposleni.Size = new System.Drawing.Size(106, 19);
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
            // pnlZaposleni
            // 
            this.pnlZaposleni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.pnlZaposleni.Controls.Add(this.gbPretragaZaposlenog);
            this.pnlZaposleni.Controls.Add(this.gbPodaciZaposlenog);
            this.pnlZaposleni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlZaposleni.Location = new System.Drawing.Point(0, 0);
            this.pnlZaposleni.Name = "pnlZaposleni";
            this.pnlZaposleni.Size = new System.Drawing.Size(831, 400);
            this.pnlZaposleni.TabIndex = 1;
            // 
            // gbPretragaZaposlenog
            // 
            this.gbPretragaZaposlenog.Controls.Add(this.dgvZaposleni);
            this.gbPretragaZaposlenog.Controls.Add(this.cbAktivanPretraga);
            this.gbPretragaZaposlenog.Controls.Add(this.tbPrezimePretraga);
            this.gbPretragaZaposlenog.Controls.Add(this.tbImePretraga);
            this.gbPretragaZaposlenog.Controls.Add(this.tbKorisnickoImePretraga);
            this.gbPretragaZaposlenog.Controls.Add(this.btnOcistiPoljaPretrage);
            this.gbPretragaZaposlenog.Location = new System.Drawing.Point(12, 3);
            this.gbPretragaZaposlenog.Name = "gbPretragaZaposlenog";
            this.gbPretragaZaposlenog.Size = new System.Drawing.Size(487, 394);
            this.gbPretragaZaposlenog.TabIndex = 0;
            this.gbPretragaZaposlenog.TabStop = false;
            this.gbPretragaZaposlenog.Text = "Pretraga zaposlenih";
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
            this.ime,
            this.prezime,
            this.korisnickoIme,
            this.aktivan});
            this.dgvZaposleni.ContextMenuStrip = this.cmsTabelaZaposleni;
            this.dgvZaposleni.GridColor = System.Drawing.SystemColors.Control;
            this.dgvZaposleni.Location = new System.Drawing.Point(6, 45);
            this.dgvZaposleni.MultiSelect = false;
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZaposleni.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZaposleni.RowHeadersWidth = 49;
            this.dgvZaposleni.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvZaposleni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposleni.Size = new System.Drawing.Size(475, 343);
            this.dgvZaposleni.TabIndex = 0;
            this.dgvZaposleni.TabStop = false;
            this.dgvZaposleni.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvZaposleni_CellMouseDoubleClick);
            this.dgvZaposleni.SelectionChanged += new System.EventHandler(this.dgvZaposleni_SelectionChanged);
            // 
            // ime
            // 
            this.ime.FillWeight = 118.8985F;
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            this.ime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // prezime
            // 
            this.prezime.FillWeight = 118.8985F;
            this.prezime.HeaderText = "Prezime";
            this.prezime.Name = "prezime";
            this.prezime.ReadOnly = true;
            this.prezime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // korisnickoIme
            // 
            this.korisnickoIme.FillWeight = 118.8985F;
            this.korisnickoIme.HeaderText = "Korisničko ime";
            this.korisnickoIme.Name = "korisnickoIme";
            this.korisnickoIme.ReadOnly = true;
            this.korisnickoIme.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // aktivan
            // 
            this.aktivan.HeaderText = "Aktivan";
            this.aktivan.Name = "aktivan";
            this.aktivan.ReadOnly = true;
            this.aktivan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aktivan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmsTabelaZaposleni
            // 
            this.cmsTabelaZaposleni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIzmjenitiZaposlenog,
            this.tsmiAktiviratiDeaktiviratiZaposlenog,
            this.tsmiObrisatiZaposlenog});
            this.cmsTabelaZaposleni.Name = "cmsTabelaZaposleni";
            this.cmsTabelaZaposleni.Size = new System.Drawing.Size(186, 70);
            this.cmsTabelaZaposleni.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTabelaZaposleni_Opening);
            // 
            // tsmiIzmjenitiZaposlenog
            // 
            this.tsmiIzmjenitiZaposlenog.Image = global::Apoteka.Properties.Resources.edit;
            this.tsmiIzmjenitiZaposlenog.Name = "tsmiIzmjenitiZaposlenog";
            this.tsmiIzmjenitiZaposlenog.Size = new System.Drawing.Size(185, 22);
            this.tsmiIzmjenitiZaposlenog.Text = "Izmjeniti";
            this.tsmiIzmjenitiZaposlenog.Click += new System.EventHandler(this.tsmiIzmjenitiZaposlenog_Click);
            // 
            // tsmiAktiviratiDeaktiviratiZaposlenog
            // 
            this.tsmiAktiviratiDeaktiviratiZaposlenog.Image = global::Apoteka.Properties.Resources.change;
            this.tsmiAktiviratiDeaktiviratiZaposlenog.Name = "tsmiAktiviratiDeaktiviratiZaposlenog";
            this.tsmiAktiviratiDeaktiviratiZaposlenog.Size = new System.Drawing.Size(185, 22);
            this.tsmiAktiviratiDeaktiviratiZaposlenog.Text = "Aktivirati/Deaktivirati";
            this.tsmiAktiviratiDeaktiviratiZaposlenog.Click += new System.EventHandler(this.tsmiAktiviratiDeaktiviratiZaposlenog_Click);
            // 
            // tsmiObrisatiZaposlenog
            // 
            this.tsmiObrisatiZaposlenog.Image = ((System.Drawing.Image)(resources.GetObject("tsmiObrisatiZaposlenog.Image")));
            this.tsmiObrisatiZaposlenog.Name = "tsmiObrisatiZaposlenog";
            this.tsmiObrisatiZaposlenog.Size = new System.Drawing.Size(185, 22);
            this.tsmiObrisatiZaposlenog.Text = "Obrisati";
            this.tsmiObrisatiZaposlenog.Click += new System.EventHandler(this.tsmiObrisatiZaposlenog_Click);
            // 
            // cbAktivanPretraga
            // 
            this.cbAktivanPretraga.AutoSize = true;
            this.cbAktivanPretraga.Location = new System.Drawing.Point(432, 22);
            this.cbAktivanPretraga.Name = "cbAktivanPretraga";
            this.cbAktivanPretraga.Size = new System.Drawing.Size(15, 14);
            this.cbAktivanPretraga.TabIndex = 4;
            this.cbAktivanPretraga.UseVisualStyleBackColor = true;
            this.cbAktivanPretraga.CheckedChanged += new System.EventHandler(this.cbAktivanPretraga_CheckedChanged);
            // 
            // tbPrezimePretraga
            // 
            this.tbPrezimePretraga.Location = new System.Drawing.Point(166, 19);
            this.tbPrezimePretraga.Name = "tbPrezimePretraga";
            this.tbPrezimePretraga.Size = new System.Drawing.Size(106, 20);
            this.tbPrezimePretraga.TabIndex = 2;
            this.tbPrezimePretraga.TextChanged += new System.EventHandler(this.tbPrezimePretraga_TextChanged);
            // 
            // tbImePretraga
            // 
            this.tbImePretraga.Location = new System.Drawing.Point(54, 19);
            this.tbImePretraga.Name = "tbImePretraga";
            this.tbImePretraga.Size = new System.Drawing.Size(106, 20);
            this.tbImePretraga.TabIndex = 1;
            this.tbImePretraga.TextChanged += new System.EventHandler(this.tbImePretraga_TextChanged);
            // 
            // tbKorisnickoImePretraga
            // 
            this.tbKorisnickoImePretraga.Location = new System.Drawing.Point(278, 19);
            this.tbKorisnickoImePretraga.Name = "tbKorisnickoImePretraga";
            this.tbKorisnickoImePretraga.Size = new System.Drawing.Size(106, 20);
            this.tbKorisnickoImePretraga.TabIndex = 3;
            this.tbKorisnickoImePretraga.TextChanged += new System.EventHandler(this.tbKorisnickoImePretraga_TextChanged);
            // 
            // btnOcistiPoljaPretrage
            // 
            this.btnOcistiPoljaPretrage.Image = global::Apoteka.Properties.Resources.eraser;
            this.btnOcistiPoljaPretrage.Location = new System.Drawing.Point(6, 16);
            this.btnOcistiPoljaPretrage.Name = "btnOcistiPoljaPretrage";
            this.btnOcistiPoljaPretrage.Size = new System.Drawing.Size(42, 25);
            this.btnOcistiPoljaPretrage.TabIndex = 5;
            this.btnOcistiPoljaPretrage.UseVisualStyleBackColor = true;
            this.btnOcistiPoljaPretrage.Click += new System.EventHandler(this.btnOcistiPoljaPretrage_Click);
            // 
            // gbPodaciZaposlenog
            // 
            this.gbPodaciZaposlenog.Controls.Add(this.lbUloga);
            this.gbPodaciZaposlenog.Controls.Add(this.cbUloga);
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
            this.gbPodaciZaposlenog.Size = new System.Drawing.Size(314, 394);
            this.gbPodaciZaposlenog.TabIndex = 0;
            this.gbPodaciZaposlenog.TabStop = false;
            this.gbPodaciZaposlenog.Text = "Podaci o zaposlenom";
            // 
            // lbUloga
            // 
            this.lbUloga.AutoSize = true;
            this.lbUloga.Location = new System.Drawing.Point(6, 278);
            this.lbUloga.Name = "lbUloga";
            this.lbUloga.Size = new System.Drawing.Size(42, 13);
            this.lbUloga.TabIndex = 53;
            this.lbUloga.Text = "Uloga:*";
            // 
            // cbUloga
            // 
            this.cbUloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUloga.FormattingEnabled = true;
            this.cbUloga.Items.AddRange(new object[] {
            "farmaceut",
            "menadzer"});
            this.cbUloga.Location = new System.Drawing.Point(116, 275);
            this.cbUloga.Name = "cbUloga";
            this.cbUloga.Size = new System.Drawing.Size(187, 21);
            this.cbUloga.TabIndex = 10;
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
            this.btnOdustati.Location = new System.Drawing.Point(216, 361);
            this.btnOdustati.Name = "btnOdustati";
            this.btnOdustati.Size = new System.Drawing.Size(87, 27);
            this.btnOdustati.TabIndex = 13;
            this.btnOdustati.Text = "Odustati";
            this.btnOdustati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustati.UseVisualStyleBackColor = true;
            this.btnOdustati.Click += new System.EventHandler(this.btnOdustati_Click);
            // 
            // btnSacuvati
            // 
            this.btnSacuvati.Image = ((System.Drawing.Image)(resources.GetObject("btnSacuvati.Image")));
            this.btnSacuvati.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSacuvati.Location = new System.Drawing.Point(116, 361);
            this.btnSacuvati.Name = "btnSacuvati";
            this.btnSacuvati.Size = new System.Drawing.Size(87, 27);
            this.btnSacuvati.TabIndex = 12;
            this.btnSacuvati.Text = "Sačuvati";
            this.btnSacuvati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSacuvati.UseVisualStyleBackColor = true;
            this.btnSacuvati.Click += new System.EventHandler(this.btnSacuvati_Click);
            // 
            // tbOpisPosla
            // 
            this.tbOpisPosla.Location = new System.Drawing.Point(116, 302);
            this.tbOpisPosla.MaxLength = 150;
            this.tbOpisPosla.Multiline = true;
            this.tbOpisPosla.Name = "tbOpisPosla";
            this.tbOpisPosla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOpisPosla.Size = new System.Drawing.Size(187, 53);
            this.tbOpisPosla.TabIndex = 11;
            // 
            // lbOpisPosla
            // 
            this.lbOpisPosla.AutoSize = true;
            this.lbOpisPosla.Location = new System.Drawing.Point(6, 305);
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
            this.tbEmail.MaxLength = 50;
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
            this.tbTelefon.MaxLength = 30;
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
            this.tbAdresa.MaxLength = 50;
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
            // msMeni
            // 
            this.msMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(252)))), ((int)(((byte)(223)))));
            this.msMeni.Dock = System.Windows.Forms.DockStyle.None;
            this.msMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZaposleni,
            this.tsmiMjesta,
            this.tsmiApoteka,
            this.tsmiMojNalog,
            this.oAplikacijiToolStripMenuItem});
            this.msMeni.Location = new System.Drawing.Point(0, 0);
            this.msMeni.Name = "msMeni";
            this.msMeni.Size = new System.Drawing.Size(831, 24);
            this.msMeni.TabIndex = 0;
            // 
            // tsmiZaposleni
            // 
            this.tsmiZaposleni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDodatiZaposlenog});
            this.tsmiZaposleni.Name = "tsmiZaposleni";
            this.tsmiZaposleni.Size = new System.Drawing.Size(70, 20);
            this.tsmiZaposleni.Text = "&Zaposleni";
            // 
            // tsmiDodatiZaposlenog
            // 
            this.tsmiDodatiZaposlenog.Image = global::Apoteka.Properties.Resources.add_employee;
            this.tsmiDodatiZaposlenog.Name = "tsmiDodatiZaposlenog";
            this.tsmiDodatiZaposlenog.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.tsmiDodatiZaposlenog.Size = new System.Drawing.Size(155, 22);
            this.tsmiDodatiZaposlenog.Text = "&Dodati";
            this.tsmiDodatiZaposlenog.Click += new System.EventHandler(this.tsmiDodatiZaposlenog_Click);
            // 
            // tsmiMjesta
            // 
            this.tsmiMjesta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPregledMjesta,
            this.tsmiDodatiMjesto});
            this.tsmiMjesta.Name = "tsmiMjesta";
            this.tsmiMjesta.Size = new System.Drawing.Size(54, 20);
            this.tsmiMjesta.Text = "&Mjesta";
            // 
            // tsmiPregledMjesta
            // 
            this.tsmiPregledMjesta.Name = "tsmiPregledMjesta";
            this.tsmiPregledMjesta.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F2)));
            this.tsmiPregledMjesta.Size = new System.Drawing.Size(205, 22);
            this.tsmiPregledMjesta.Text = "&Pregledati";
            this.tsmiPregledMjesta.Click += new System.EventHandler(this.tsmiPregledMjesta_Click);
            // 
            // tsmiDodatiMjesto
            // 
            this.tsmiDodatiMjesto.Image = global::Apoteka.Properties.Resources.add_place;
            this.tsmiDodatiMjesto.Name = "tsmiDodatiMjesto";
            this.tsmiDodatiMjesto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.tsmiDodatiMjesto.Size = new System.Drawing.Size(205, 22);
            this.tsmiDodatiMjesto.Text = "&Dodati";
            this.tsmiDodatiMjesto.Click += new System.EventHandler(this.tsmiDodatiMjesto_Click);
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
            // AdminForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 448);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMeni;
            this.MaximizeBox = false;
            this.Name = "AdminForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apoteka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForma_FormClosing);
            this.Load += new System.EventHandler(this.AdminForma_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ssStatusnaLinija.ResumeLayout(false);
            this.ssStatusnaLinija.PerformLayout();
            this.pnlZaposleni.ResumeLayout(false);
            this.gbPretragaZaposlenog.ResumeLayout(false);
            this.gbPretragaZaposlenog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            this.cmsTabelaZaposleni.ResumeLayout(false);
            this.gbPodaciZaposlenog.ResumeLayout(false);
            this.gbPodaciZaposlenog.PerformLayout();
            this.msMeni.ResumeLayout(false);
            this.msMeni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip ssStatusnaLinija;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusnaLabela;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatumVrijeme;
        private System.Windows.Forms.Timer TimerTrenutnoVrijeme;
        private System.Windows.Forms.ToolStripStatusLabel tsslPrijavljenZaposleni;
        private System.Windows.Forms.MenuStrip msMeni;
        private System.Windows.Forms.ToolStripMenuItem tsmiZaposleni;
        private System.Windows.Forms.ToolStripMenuItem tsmiDodatiZaposlenog;
        private System.Windows.Forms.DataGridView dgvZaposleni;
        private System.Windows.Forms.Panel pnlZaposleni;
        private System.Windows.Forms.GroupBox gbPodaciZaposlenog;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.TextBox tbFarmaceutskoZvanje;
        private System.Windows.Forms.Label lbFarmaceutskoZvanje;
        private System.Windows.Forms.TextBox tbStrucnaSprema;
        private System.Windows.Forms.Label lbStrucnaSprema;
        private System.Windows.Forms.TextBox tbOpisPosla;
        private System.Windows.Forms.Label lbOpisPosla;
        private System.Windows.Forms.CheckBox cbSefApoteke;
        private System.Windows.Forms.Label lbSefApoteke;
        private System.Windows.Forms.Button btnOdustati;
        private System.Windows.Forms.Button btnSacuvati;
        private System.Windows.Forms.TextBox tbImePretraga;
        private System.Windows.Forms.TextBox tbPrezimePretraga;
        private System.Windows.Forms.TextBox tbKorisnickoImePretraga;
        private System.Windows.Forms.CheckBox cbAktivanPretraga;
        private System.Windows.Forms.Button btnOcistiPoljaPretrage;
        private System.Windows.Forms.GroupBox gbPretragaZaposlenog;
        private System.Windows.Forms.ContextMenuStrip cmsTabelaZaposleni;
        private System.Windows.Forms.ToolStripMenuItem tsmiIzmjenitiZaposlenog;
        private System.Windows.Forms.ToolStripMenuItem tsmiAktiviratiDeaktiviratiZaposlenog;
        private System.Windows.Forms.ToolStripMenuItem tsmiObrisatiZaposlenog;
        private System.Windows.Forms.ComboBox cbMjesto;
        private System.Windows.Forms.Label lbMjesto;
        private System.Windows.Forms.Label lbJmbg;
        private System.Windows.Forms.MaskedTextBox mtbJmbg;
        private System.Windows.Forms.ToolStripMenuItem tsmiMjesta;
        private System.Windows.Forms.ToolStripMenuItem tsmiPregledMjesta;
        private System.Windows.Forms.ToolStripMenuItem tsmiDodatiMjesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoIme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivan;
        private System.Windows.Forms.ToolStripMenuItem tsmiApoteka;
        private System.Windows.Forms.ToolStripMenuItem tsmiInformacijeOApoteci;
        private System.Windows.Forms.ToolStripMenuItem tsmiMojNalog;
        private System.Windows.Forms.ToolStripMenuItem tsmiPromjenitiLozinku;
        private System.Windows.Forms.ToolStripMenuItem tsmiOdjava;
        private System.Windows.Forms.Label lbUloga;
        private System.Windows.Forms.ComboBox cbUloga;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInformacijeOAplikaciji;
    }
}

