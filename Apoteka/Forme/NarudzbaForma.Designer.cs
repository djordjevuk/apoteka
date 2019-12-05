namespace Apoteka.Forme
{
    partial class NarudzbaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NarudzbaForma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlNarudzbaKreiranje = new System.Windows.Forms.Panel();
            this.lbFokus = new System.Windows.Forms.Label();
            this.gbNarudzba = new System.Windows.Forms.GroupBox();
            this.btnKreiratiNarudzbu = new System.Windows.Forms.Button();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.lbDobavljac = new System.Windows.Forms.Label();
            this.btnPonistitiNarudzbu = new System.Windows.Forms.Button();
            this.tbUkupanIznos = new System.Windows.Forms.TextBox();
            this.btnZakljucitiNarudzbu = new System.Windows.Forms.Button();
            this.dgvNarudzba = new System.Windows.Forms.DataGridView();
            this.lijek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTabelaNarudzba = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiIzmjenitiStavkuNarudzbe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiObrisatiStavkuNarudzbe = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPodaciStavkeNarudzbe = new System.Windows.Forms.GroupBox();
            this.btnOdustati = new System.Windows.Forms.Button();
            this.btnDodatiStavkuNarudzbe = new System.Windows.Forms.Button();
            this.lbKolicinaNaStavciNarudzbe = new System.Windows.Forms.Label();
            this.nudKolicinaNaStavciNarudzbe = new System.Windows.Forms.NumericUpDown();
            this.gbPretragaLijeka = new System.Windows.Forms.GroupBox();
            this.tbKolicinaNaStanjuPretraga = new System.Windows.Forms.TextBox();
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaNaStanju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodjac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pakovanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTabelaLijekovi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLijekDetaljno = new System.Windows.Forms.ToolStripMenuItem();
            this.tbNazivPretraga = new System.Windows.Forms.TextBox();
            this.btnOcistiPoljaPretrage = new System.Windows.Forms.Button();
            this.pnlNarudzbaKreiranje.SuspendLayout();
            this.gbNarudzba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzba)).BeginInit();
            this.cmsTabelaNarudzba.SuspendLayout();
            this.gbPodaciStavkeNarudzbe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicinaNaStavciNarudzbe)).BeginInit();
            this.gbPretragaLijeka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            this.cmsTabelaLijekovi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNarudzbaKreiranje
            // 
            this.pnlNarudzbaKreiranje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.pnlNarudzbaKreiranje.Controls.Add(this.lbFokus);
            this.pnlNarudzbaKreiranje.Controls.Add(this.gbNarudzba);
            this.pnlNarudzbaKreiranje.Controls.Add(this.gbPodaciStavkeNarudzbe);
            this.pnlNarudzbaKreiranje.Controls.Add(this.gbPretragaLijeka);
            this.pnlNarudzbaKreiranje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNarudzbaKreiranje.Location = new System.Drawing.Point(0, 0);
            this.pnlNarudzbaKreiranje.Name = "pnlNarudzbaKreiranje";
            this.pnlNarudzbaKreiranje.Size = new System.Drawing.Size(1119, 406);
            this.pnlNarudzbaKreiranje.TabIndex = 2;
            // 
            // lbFokus
            // 
            this.lbFokus.AutoSize = true;
            this.lbFokus.Location = new System.Drawing.Point(0, 0);
            this.lbFokus.Name = "lbFokus";
            this.lbFokus.Size = new System.Drawing.Size(0, 13);
            this.lbFokus.TabIndex = 6;
            // 
            // gbNarudzba
            // 
            this.gbNarudzba.Controls.Add(this.btnKreiratiNarudzbu);
            this.gbNarudzba.Controls.Add(this.cbDobavljac);
            this.gbNarudzba.Controls.Add(this.lbDobavljac);
            this.gbNarudzba.Controls.Add(this.btnPonistitiNarudzbu);
            this.gbNarudzba.Controls.Add(this.tbUkupanIznos);
            this.gbNarudzba.Controls.Add(this.btnZakljucitiNarudzbu);
            this.gbNarudzba.Controls.Add(this.dgvNarudzba);
            this.gbNarudzba.Location = new System.Drawing.Point(666, 12);
            this.gbNarudzba.Name = "gbNarudzba";
            this.gbNarudzba.Size = new System.Drawing.Size(442, 382);
            this.gbNarudzba.TabIndex = 0;
            this.gbNarudzba.TabStop = false;
            this.gbNarudzba.Text = "Narudžba";
            // 
            // btnKreiratiNarudzbu
            // 
            this.btnKreiratiNarudzbu.Image = ((System.Drawing.Image)(resources.GetObject("btnKreiratiNarudzbu.Image")));
            this.btnKreiratiNarudzbu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKreiratiNarudzbu.Location = new System.Drawing.Point(9, 43);
            this.btnKreiratiNarudzbu.Name = "btnKreiratiNarudzbu";
            this.btnKreiratiNarudzbu.Size = new System.Drawing.Size(122, 27);
            this.btnKreiratiNarudzbu.TabIndex = 23;
            this.btnKreiratiNarudzbu.Text = "Kreirati narudžbu";
            this.btnKreiratiNarudzbu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKreiratiNarudzbu.UseVisualStyleBackColor = true;
            this.btnKreiratiNarudzbu.Click += new System.EventHandler(this.btnKreiratiNarudzbu_Click);
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(74, 12);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(185, 21);
            this.cbDobavljac.TabIndex = 0;
            // 
            // lbDobavljac
            // 
            this.lbDobavljac.AutoSize = true;
            this.lbDobavljac.Location = new System.Drawing.Point(6, 16);
            this.lbDobavljac.Name = "lbDobavljac";
            this.lbDobavljac.Size = new System.Drawing.Size(62, 13);
            this.lbDobavljac.TabIndex = 22;
            this.lbDobavljac.Text = "Dobavljač:*";
            // 
            // btnPonistitiNarudzbu
            // 
            this.btnPonistitiNarudzbu.Image = global::Apoteka.Properties.Resources.trash;
            this.btnPonistitiNarudzbu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPonistitiNarudzbu.Location = new System.Drawing.Point(137, 76);
            this.btnPonistitiNarudzbu.Name = "btnPonistitiNarudzbu";
            this.btnPonistitiNarudzbu.Size = new System.Drawing.Size(122, 27);
            this.btnPonistitiNarudzbu.TabIndex = 2;
            this.btnPonistitiNarudzbu.Text = "Poništiti narudžbu";
            this.btnPonistitiNarudzbu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPonistitiNarudzbu.UseVisualStyleBackColor = true;
            this.btnPonistitiNarudzbu.Click += new System.EventHandler(this.btnPonistitiNarudzbu_Click);
            // 
            // tbUkupanIznos
            // 
            this.tbUkupanIznos.Enabled = false;
            this.tbUkupanIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUkupanIznos.Location = new System.Drawing.Point(330, 76);
            this.tbUkupanIznos.Multiline = true;
            this.tbUkupanIznos.Name = "tbUkupanIznos";
            this.tbUkupanIznos.Size = new System.Drawing.Size(106, 27);
            this.tbUkupanIznos.TabIndex = 19;
            this.tbUkupanIznos.Text = "0.00";
            this.tbUkupanIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnZakljucitiNarudzbu
            // 
            this.btnZakljucitiNarudzbu.Image = global::Apoteka.Properties.Resources.lock_receipt;
            this.btnZakljucitiNarudzbu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZakljucitiNarudzbu.Location = new System.Drawing.Point(9, 76);
            this.btnZakljucitiNarudzbu.Name = "btnZakljucitiNarudzbu";
            this.btnZakljucitiNarudzbu.Size = new System.Drawing.Size(122, 27);
            this.btnZakljucitiNarudzbu.TabIndex = 1;
            this.btnZakljucitiNarudzbu.Text = "Zaključiti narudžbu";
            this.btnZakljucitiNarudzbu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZakljucitiNarudzbu.UseVisualStyleBackColor = true;
            this.btnZakljucitiNarudzbu.Click += new System.EventHandler(this.btnZakljucitiNarudzbu_Click);
            // 
            // dgvNarudzba
            // 
            this.dgvNarudzba.AllowUserToAddRows = false;
            this.dgvNarudzba.AllowUserToDeleteRows = false;
            this.dgvNarudzba.AllowUserToOrderColumns = true;
            this.dgvNarudzba.AllowUserToResizeRows = false;
            this.dgvNarudzba.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNarudzba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzba.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNarudzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lijek,
            this.cijena,
            this.kolicina,
            this.iznos});
            this.dgvNarudzba.ContextMenuStrip = this.cmsTabelaNarudzba;
            this.dgvNarudzba.GridColor = System.Drawing.SystemColors.Control;
            this.dgvNarudzba.Location = new System.Drawing.Point(6, 109);
            this.dgvNarudzba.MultiSelect = false;
            this.dgvNarudzba.Name = "dgvNarudzba";
            this.dgvNarudzba.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzba.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNarudzba.RowHeadersWidth = 49;
            this.dgvNarudzba.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNarudzba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzba.Size = new System.Drawing.Size(430, 267);
            this.dgvNarudzba.TabIndex = 1;
            this.dgvNarudzba.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNarudzba_CellMouseDoubleClick);
            this.dgvNarudzba.SelectionChanged += new System.EventHandler(this.dgvNarudzba_SelectionChanged);
            // 
            // lijek
            // 
            this.lijek.FillWeight = 105.8985F;
            this.lijek.HeaderText = "Lijek";
            this.lijek.Name = "lijek";
            this.lijek.ReadOnly = true;
            this.lijek.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cijena
            // 
            this.cijena.HeaderText = "Cijena";
            this.cijena.Name = "cijena";
            this.cijena.ReadOnly = true;
            this.cijena.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kolicina
            // 
            this.kolicina.FillWeight = 60.8985F;
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            this.kolicina.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // iznos
            // 
            this.iznos.FillWeight = 100.8985F;
            this.iznos.HeaderText = "Iznos";
            this.iznos.Name = "iznos";
            this.iznos.ReadOnly = true;
            this.iznos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cmsTabelaNarudzba
            // 
            this.cmsTabelaNarudzba.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIzmjenitiStavkuNarudzbe,
            this.tsmiObrisatiStavkuNarudzbe});
            this.cmsTabelaNarudzba.Name = "cmsTabelaRacun";
            this.cmsTabelaNarudzba.Size = new System.Drawing.Size(120, 48);
            this.cmsTabelaNarudzba.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTabelaNarudzba_Opening);
            // 
            // tsmiIzmjenitiStavkuNarudzbe
            // 
            this.tsmiIzmjenitiStavkuNarudzbe.Image = global::Apoteka.Properties.Resources.edit;
            this.tsmiIzmjenitiStavkuNarudzbe.Name = "tsmiIzmjenitiStavkuNarudzbe";
            this.tsmiIzmjenitiStavkuNarudzbe.Size = new System.Drawing.Size(119, 22);
            this.tsmiIzmjenitiStavkuNarudzbe.Text = "Izmjeniti";
            this.tsmiIzmjenitiStavkuNarudzbe.Click += new System.EventHandler(this.tsmiIzmjenitiStavkuNarudzbe_Click);
            // 
            // tsmiObrisatiStavkuNarudzbe
            // 
            this.tsmiObrisatiStavkuNarudzbe.Image = global::Apoteka.Properties.Resources.trash;
            this.tsmiObrisatiStavkuNarudzbe.Name = "tsmiObrisatiStavkuNarudzbe";
            this.tsmiObrisatiStavkuNarudzbe.Size = new System.Drawing.Size(119, 22);
            this.tsmiObrisatiStavkuNarudzbe.Text = "Obrisati";
            this.tsmiObrisatiStavkuNarudzbe.Click += new System.EventHandler(this.tsmiObrisatiStavkuNarudzbe_Click);
            // 
            // gbPodaciStavkeNarudzbe
            // 
            this.gbPodaciStavkeNarudzbe.Controls.Add(this.btnOdustati);
            this.gbPodaciStavkeNarudzbe.Controls.Add(this.btnDodatiStavkuNarudzbe);
            this.gbPodaciStavkeNarudzbe.Controls.Add(this.lbKolicinaNaStavciNarudzbe);
            this.gbPodaciStavkeNarudzbe.Controls.Add(this.nudKolicinaNaStavciNarudzbe);
            this.gbPodaciStavkeNarudzbe.Location = new System.Drawing.Point(12, 12);
            this.gbPodaciStavkeNarudzbe.Name = "gbPodaciStavkeNarudzbe";
            this.gbPodaciStavkeNarudzbe.Size = new System.Drawing.Size(648, 55);
            this.gbPodaciStavkeNarudzbe.TabIndex = 2;
            this.gbPodaciStavkeNarudzbe.TabStop = false;
            this.gbPodaciStavkeNarudzbe.Text = "Stavka narudžbe";
            // 
            // btnOdustati
            // 
            this.btnOdustati.Image = global::Apoteka.Properties.Resources.cancel;
            this.btnOdustati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustati.Location = new System.Drawing.Point(555, 16);
            this.btnOdustati.Name = "btnOdustati";
            this.btnOdustati.Size = new System.Drawing.Size(87, 27);
            this.btnOdustati.TabIndex = 3;
            this.btnOdustati.Text = "Odustati";
            this.btnOdustati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustati.UseVisualStyleBackColor = true;
            this.btnOdustati.Click += new System.EventHandler(this.btnOdustati_Click);
            // 
            // btnDodatiStavkuNarudzbe
            // 
            this.btnDodatiStavkuNarudzbe.Image = global::Apoteka.Properties.Resources.add_receipt_item;
            this.btnDodatiStavkuNarudzbe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodatiStavkuNarudzbe.Location = new System.Drawing.Point(462, 16);
            this.btnDodatiStavkuNarudzbe.Name = "btnDodatiStavkuNarudzbe";
            this.btnDodatiStavkuNarudzbe.Size = new System.Drawing.Size(87, 27);
            this.btnDodatiStavkuNarudzbe.TabIndex = 2;
            this.btnDodatiStavkuNarudzbe.Text = "Dodati";
            this.btnDodatiStavkuNarudzbe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodatiStavkuNarudzbe.UseVisualStyleBackColor = true;
            this.btnDodatiStavkuNarudzbe.Click += new System.EventHandler(this.btnDodatiStavkuNarudzbe_Click);
            // 
            // lbKolicinaNaStavciNarudzbe
            // 
            this.lbKolicinaNaStavciNarudzbe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbKolicinaNaStavciNarudzbe.AutoSize = true;
            this.lbKolicinaNaStavciNarudzbe.Location = new System.Drawing.Point(6, 23);
            this.lbKolicinaNaStavciNarudzbe.Name = "lbKolicinaNaStavciNarudzbe";
            this.lbKolicinaNaStavciNarudzbe.Size = new System.Drawing.Size(97, 13);
            this.lbKolicinaNaStavciNarudzbe.TabIndex = 12;
            this.lbKolicinaNaStavciNarudzbe.Text = "Količina na stavci:*";
            // 
            // nudKolicinaNaStavciNarudzbe
            // 
            this.nudKolicinaNaStavciNarudzbe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nudKolicinaNaStavciNarudzbe.Location = new System.Drawing.Point(115, 21);
            this.nudKolicinaNaStavciNarudzbe.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudKolicinaNaStavciNarudzbe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolicinaNaStavciNarudzbe.Name = "nudKolicinaNaStavciNarudzbe";
            this.nudKolicinaNaStavciNarudzbe.Size = new System.Drawing.Size(63, 20);
            this.nudKolicinaNaStavciNarudzbe.TabIndex = 0;
            this.nudKolicinaNaStavciNarudzbe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudKolicinaNaStavciNarudzbe.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbPretragaLijeka
            // 
            this.gbPretragaLijeka.Controls.Add(this.tbKolicinaNaStanjuPretraga);
            this.gbPretragaLijeka.Controls.Add(this.dgvLijekovi);
            this.gbPretragaLijeka.Controls.Add(this.tbNazivPretraga);
            this.gbPretragaLijeka.Controls.Add(this.btnOcistiPoljaPretrage);
            this.gbPretragaLijeka.Location = new System.Drawing.Point(12, 73);
            this.gbPretragaLijeka.Name = "gbPretragaLijeka";
            this.gbPretragaLijeka.Size = new System.Drawing.Size(648, 321);
            this.gbPretragaLijeka.TabIndex = 1;
            this.gbPretragaLijeka.TabStop = false;
            this.gbPretragaLijeka.Text = "Pretraga lijekova";
            // 
            // tbKolicinaNaStanjuPretraga
            // 
            this.tbKolicinaNaStanjuPretraga.Location = new System.Drawing.Point(202, 22);
            this.tbKolicinaNaStanjuPretraga.Name = "tbKolicinaNaStanjuPretraga";
            this.tbKolicinaNaStanjuPretraga.Size = new System.Drawing.Size(142, 20);
            this.tbKolicinaNaStanjuPretraga.TabIndex = 1;
            this.tbKolicinaNaStanjuPretraga.TextChanged += new System.EventHandler(this.tbKolicinaNaStanjuPretraga_TextChanged);
            // 
            // dgvLijekovi
            // 
            this.dgvLijekovi.AllowUserToAddRows = false;
            this.dgvLijekovi.AllowUserToDeleteRows = false;
            this.dgvLijekovi.AllowUserToOrderColumns = true;
            this.dgvLijekovi.AllowUserToResizeRows = false;
            this.dgvLijekovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLijekovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLijekovi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.kolicinaNaStanju,
            this.proizvodjac,
            this.pakovanje});
            this.dgvLijekovi.ContextMenuStrip = this.cmsTabelaLijekovi;
            this.dgvLijekovi.GridColor = System.Drawing.SystemColors.Control;
            this.dgvLijekovi.Location = new System.Drawing.Point(6, 48);
            this.dgvLijekovi.MultiSelect = false;
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLijekovi.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLijekovi.RowHeadersWidth = 49;
            this.dgvLijekovi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLijekovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijekovi.Size = new System.Drawing.Size(636, 267);
            this.dgvLijekovi.TabIndex = 0;
            this.dgvLijekovi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLijekovi_CellMouseDoubleClick);
            this.dgvLijekovi.SelectionChanged += new System.EventHandler(this.dgvLijekovi_SelectionChanged);
            // 
            // naziv
            // 
            this.naziv.FillWeight = 95F;
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            this.naziv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kolicinaNaStanju
            // 
            this.kolicinaNaStanju.FillWeight = 85F;
            this.kolicinaNaStanju.HeaderText = "Količina na stanju";
            this.kolicinaNaStanju.Name = "kolicinaNaStanju";
            this.kolicinaNaStanju.ReadOnly = true;
            this.kolicinaNaStanju.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // proizvodjac
            // 
            this.proizvodjac.FillWeight = 79.07265F;
            this.proizvodjac.HeaderText = "Proizvođač";
            this.proizvodjac.Name = "proizvodjac";
            this.proizvodjac.ReadOnly = true;
            this.proizvodjac.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pakovanje
            // 
            this.pakovanje.FillWeight = 130F;
            this.pakovanje.HeaderText = "Pakovanje";
            this.pakovanje.Name = "pakovanje";
            this.pakovanje.ReadOnly = true;
            this.pakovanje.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cmsTabelaLijekovi
            // 
            this.cmsTabelaLijekovi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLijekDetaljno});
            this.cmsTabelaLijekovi.Name = "cmsTabelaZaposleni";
            this.cmsTabelaLijekovi.Size = new System.Drawing.Size(119, 26);
            // 
            // tsmiLijekDetaljno
            // 
            this.tsmiLijekDetaljno.Name = "tsmiLijekDetaljno";
            this.tsmiLijekDetaljno.Size = new System.Drawing.Size(118, 22);
            this.tsmiLijekDetaljno.Text = "Detaljno";
            this.tsmiLijekDetaljno.Click += new System.EventHandler(this.tsmiLijekDetaljno_Click);
            // 
            // tbNazivPretraga
            // 
            this.tbNazivPretraga.Location = new System.Drawing.Point(54, 22);
            this.tbNazivPretraga.Name = "tbNazivPretraga";
            this.tbNazivPretraga.Size = new System.Drawing.Size(142, 20);
            this.tbNazivPretraga.TabIndex = 0;
            this.tbNazivPretraga.TextChanged += new System.EventHandler(this.tbNazivPretraga_TextChanged);
            // 
            // btnOcistiPoljaPretrage
            // 
            this.btnOcistiPoljaPretrage.Image = global::Apoteka.Properties.Resources.eraser;
            this.btnOcistiPoljaPretrage.Location = new System.Drawing.Point(6, 19);
            this.btnOcistiPoljaPretrage.Name = "btnOcistiPoljaPretrage";
            this.btnOcistiPoljaPretrage.Size = new System.Drawing.Size(42, 25);
            this.btnOcistiPoljaPretrage.TabIndex = 2;
            this.btnOcistiPoljaPretrage.UseVisualStyleBackColor = true;
            this.btnOcistiPoljaPretrage.Click += new System.EventHandler(this.btnOcistiPoljaPretrage_Click);
            // 
            // NarudzbaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 406);
            this.Controls.Add(this.pnlNarudzbaKreiranje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NarudzbaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje narudžbe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NarudzbaForma_FormClosing);
            this.Load += new System.EventHandler(this.NarudzbaForma_Load);
            this.pnlNarudzbaKreiranje.ResumeLayout(false);
            this.pnlNarudzbaKreiranje.PerformLayout();
            this.gbNarudzba.ResumeLayout(false);
            this.gbNarudzba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzba)).EndInit();
            this.cmsTabelaNarudzba.ResumeLayout(false);
            this.gbPodaciStavkeNarudzbe.ResumeLayout(false);
            this.gbPodaciStavkeNarudzbe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicinaNaStavciNarudzbe)).EndInit();
            this.gbPretragaLijeka.ResumeLayout(false);
            this.gbPretragaLijeka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            this.cmsTabelaLijekovi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNarudzbaKreiranje;
        private System.Windows.Forms.Label lbFokus;
        private System.Windows.Forms.GroupBox gbNarudzba;
        private System.Windows.Forms.Button btnPonistitiNarudzbu;
        private System.Windows.Forms.TextBox tbUkupanIznos;
        private System.Windows.Forms.Button btnZakljucitiNarudzbu;
        private System.Windows.Forms.DataGridView dgvNarudzba;
        private System.Windows.Forms.DataGridViewTextBoxColumn lijek;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos;
        private System.Windows.Forms.GroupBox gbPodaciStavkeNarudzbe;
        private System.Windows.Forms.Button btnOdustati;
        private System.Windows.Forms.Button btnDodatiStavkuNarudzbe;
        private System.Windows.Forms.Label lbKolicinaNaStavciNarudzbe;
        private System.Windows.Forms.NumericUpDown nudKolicinaNaStavciNarudzbe;
        private System.Windows.Forms.GroupBox gbPretragaLijeka;
        private System.Windows.Forms.DataGridView dgvLijekovi;
        private System.Windows.Forms.TextBox tbNazivPretraga;
        private System.Windows.Forms.Button btnOcistiPoljaPretrage;
        private System.Windows.Forms.TextBox tbKolicinaNaStanjuPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaNaStanju;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodjac;
        private System.Windows.Forms.DataGridViewTextBoxColumn pakovanje;
        private System.Windows.Forms.ContextMenuStrip cmsTabelaNarudzba;
        private System.Windows.Forms.ToolStripMenuItem tsmiIzmjenitiStavkuNarudzbe;
        private System.Windows.Forms.ToolStripMenuItem tsmiObrisatiStavkuNarudzbe;
        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.Label lbDobavljac;
        private System.Windows.Forms.ContextMenuStrip cmsTabelaLijekovi;
        private System.Windows.Forms.ToolStripMenuItem tsmiLijekDetaljno;
        private System.Windows.Forms.Button btnKreiratiNarudzbu;
    }
}