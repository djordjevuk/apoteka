namespace Apoteka.Forme
{
    partial class PregledMjestaForma
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
            this.dgvMjesta = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPoste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTabelaMjesta = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiIzmjenitiMjesto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiObrisatiMjesto = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjesta)).BeginInit();
            this.cmsTabelaMjesta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMjesta
            // 
            this.dgvMjesta.AllowUserToAddRows = false;
            this.dgvMjesta.AllowUserToDeleteRows = false;
            this.dgvMjesta.AllowUserToOrderColumns = true;
            this.dgvMjesta.AllowUserToResizeRows = false;
            this.dgvMjesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMjesta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMjesta.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMjesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMjesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.brojPoste,
            this.drzava});
            this.dgvMjesta.ContextMenuStrip = this.cmsTabelaMjesta;
            this.dgvMjesta.GridColor = System.Drawing.SystemColors.Control;
            this.dgvMjesta.Location = new System.Drawing.Point(12, 12);
            this.dgvMjesta.MultiSelect = false;
            this.dgvMjesta.Name = "dgvMjesta";
            this.dgvMjesta.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMjesta.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMjesta.RowHeadersWidth = 49;
            this.dgvMjesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMjesta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMjesta.Size = new System.Drawing.Size(405, 198);
            this.dgvMjesta.TabIndex = 1;
            this.dgvMjesta.SelectionChanged += new System.EventHandler(this.dgvMjesta_SelectionChanged);
            // 
            // naziv
            // 
            this.naziv.FillWeight = 118.8985F;
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            this.naziv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // brojPoste
            // 
            this.brojPoste.FillWeight = 118.8985F;
            this.brojPoste.HeaderText = "Broj pošte";
            this.brojPoste.Name = "brojPoste";
            this.brojPoste.ReadOnly = true;
            this.brojPoste.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // drzava
            // 
            this.drzava.FillWeight = 118.8985F;
            this.drzava.HeaderText = "Država";
            this.drzava.Name = "drzava";
            this.drzava.ReadOnly = true;
            this.drzava.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cmsTabelaMjesta
            // 
            this.cmsTabelaMjesta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIzmjenitiMjesto,
            this.tsmiObrisatiMjesto});
            this.cmsTabelaMjesta.Name = "cmsTabelaMjesta";
            this.cmsTabelaMjesta.Size = new System.Drawing.Size(120, 48);
            // 
            // tsmiIzmjenitiMjesto
            // 
            this.tsmiIzmjenitiMjesto.Image = global::Apoteka.Properties.Resources.edit;
            this.tsmiIzmjenitiMjesto.Name = "tsmiIzmjenitiMjesto";
            this.tsmiIzmjenitiMjesto.Size = new System.Drawing.Size(119, 22);
            this.tsmiIzmjenitiMjesto.Text = "Izmjeniti";
            this.tsmiIzmjenitiMjesto.Click += new System.EventHandler(this.tsmiIzmjenitiMjesto_Click);
            // 
            // tsmiObrisatiMjesto
            // 
            this.tsmiObrisatiMjesto.Image = global::Apoteka.Properties.Resources.trash;
            this.tsmiObrisatiMjesto.Name = "tsmiObrisatiMjesto";
            this.tsmiObrisatiMjesto.Size = new System.Drawing.Size(119, 22);
            this.tsmiObrisatiMjesto.Text = "Obrisati";
            this.tsmiObrisatiMjesto.Click += new System.EventHandler(this.tsmiObrisatiMjesto_Click);
            // 
            // PregledMjestaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(429, 222);
            this.Controls.Add(this.dgvMjesta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PregledMjestaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mjesta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PregledMjestaForma_FormClosing);
            this.Load += new System.EventHandler(this.PregledMjestaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjesta)).EndInit();
            this.cmsTabelaMjesta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojPoste;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzava;
        private System.Windows.Forms.ContextMenuStrip cmsTabelaMjesta;
        private System.Windows.Forms.ToolStripMenuItem tsmiIzmjenitiMjesto;
        private System.Windows.Forms.ToolStripMenuItem tsmiObrisatiMjesto;
    }
}