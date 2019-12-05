namespace Apoteka.Forme
{
    partial class MjestoForma
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
            this.lbNazivMjesta = new System.Windows.Forms.Label();
            this.tbNazivMjesta = new System.Windows.Forms.TextBox();
            this.tbDrzava = new System.Windows.Forms.TextBox();
            this.lbDrzava = new System.Windows.Forms.Label();
            this.lbPostanskiBroj = new System.Windows.Forms.Label();
            this.mtbPostanskiBroj = new System.Windows.Forms.MaskedTextBox();
            this.btnSacuvati = new System.Windows.Forms.Button();
            this.btnOdustati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNazivMjesta
            // 
            this.lbNazivMjesta.AutoSize = true;
            this.lbNazivMjesta.Location = new System.Drawing.Point(12, 18);
            this.lbNazivMjesta.Name = "lbNazivMjesta";
            this.lbNazivMjesta.Size = new System.Drawing.Size(41, 13);
            this.lbNazivMjesta.TabIndex = 0;
            this.lbNazivMjesta.Text = "Naziv:*";
            // 
            // tbNazivMjesta
            // 
            this.tbNazivMjesta.Location = new System.Drawing.Point(98, 15);
            this.tbNazivMjesta.MaxLength = 40;
            this.tbNazivMjesta.Name = "tbNazivMjesta";
            this.tbNazivMjesta.Size = new System.Drawing.Size(177, 20);
            this.tbNazivMjesta.TabIndex = 1;
            // 
            // tbDrzava
            // 
            this.tbDrzava.Location = new System.Drawing.Point(98, 41);
            this.tbDrzava.MaxLength = 40;
            this.tbDrzava.Name = "tbDrzava";
            this.tbDrzava.Size = new System.Drawing.Size(177, 20);
            this.tbDrzava.TabIndex = 2;
            // 
            // lbDrzava
            // 
            this.lbDrzava.AutoSize = true;
            this.lbDrzava.Location = new System.Drawing.Point(12, 44);
            this.lbDrzava.Name = "lbDrzava";
            this.lbDrzava.Size = new System.Drawing.Size(48, 13);
            this.lbDrzava.TabIndex = 2;
            this.lbDrzava.Text = "Država:*";
            // 
            // lbPostanskiBroj
            // 
            this.lbPostanskiBroj.AutoSize = true;
            this.lbPostanskiBroj.Location = new System.Drawing.Point(12, 70);
            this.lbPostanskiBroj.Name = "lbPostanskiBroj";
            this.lbPostanskiBroj.Size = new System.Drawing.Size(80, 13);
            this.lbPostanskiBroj.TabIndex = 4;
            this.lbPostanskiBroj.Text = "Poštanski broj:*";
            // 
            // mtbPostanskiBroj
            // 
            this.mtbPostanskiBroj.Location = new System.Drawing.Point(98, 67);
            this.mtbPostanskiBroj.Mask = "00000";
            this.mtbPostanskiBroj.Name = "mtbPostanskiBroj";
            this.mtbPostanskiBroj.Size = new System.Drawing.Size(44, 20);
            this.mtbPostanskiBroj.TabIndex = 3;
            this.mtbPostanskiBroj.ValidatingType = typeof(int);
            // 
            // btnSacuvati
            // 
            this.btnSacuvati.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSacuvati.Image = global::Apoteka.Properties.Resources.save;
            this.btnSacuvati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvati.Location = new System.Drawing.Point(98, 102);
            this.btnSacuvati.Name = "btnSacuvati";
            this.btnSacuvati.Size = new System.Drawing.Size(87, 27);
            this.btnSacuvati.TabIndex = 5;
            this.btnSacuvati.Text = "Sačuvati";
            this.btnSacuvati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSacuvati.UseVisualStyleBackColor = true;
            this.btnSacuvati.Click += new System.EventHandler(this.btnSacuvati_Click);
            // 
            // btnOdustati
            // 
            this.btnOdustati.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustati.Image = global::Apoteka.Properties.Resources.cancel;
            this.btnOdustati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustati.Location = new System.Drawing.Point(188, 102);
            this.btnOdustati.Name = "btnOdustati";
            this.btnOdustati.Size = new System.Drawing.Size(87, 27);
            this.btnOdustati.TabIndex = 6;
            this.btnOdustati.Text = "Odustati";
            this.btnOdustati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustati.UseVisualStyleBackColor = true;
            // 
            // MjestoForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.CancelButton = this.btnOdustati;
            this.ClientSize = new System.Drawing.Size(287, 141);
            this.Controls.Add(this.btnOdustati);
            this.Controls.Add(this.btnSacuvati);
            this.Controls.Add(this.mtbPostanskiBroj);
            this.Controls.Add(this.lbPostanskiBroj);
            this.Controls.Add(this.tbDrzava);
            this.Controls.Add(this.lbDrzava);
            this.Controls.Add(this.tbNazivMjesta);
            this.Controls.Add(this.lbNazivMjesta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MjestoForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos mjesta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DodavanjeMjestaForma_FormClosing);
            this.Load += new System.EventHandler(this.MjestoForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNazivMjesta;
        private System.Windows.Forms.TextBox tbNazivMjesta;
        private System.Windows.Forms.TextBox tbDrzava;
        private System.Windows.Forms.Label lbDrzava;
        private System.Windows.Forms.Label lbPostanskiBroj;
        private System.Windows.Forms.MaskedTextBox mtbPostanskiBroj;
        private System.Windows.Forms.Button btnSacuvati;
        private System.Windows.Forms.Button btnOdustati;
    }
}