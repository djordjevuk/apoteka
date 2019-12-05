namespace Apoteka.Forme
{
    partial class DobavljacForma
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
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.lbNaziv = new System.Windows.Forms.Label();
            this.cbRegistrovanKodALMS = new System.Windows.Forms.CheckBox();
            this.lbRegKodALMS = new System.Windows.Forms.Label();
            this.btnOdustati = new System.Windows.Forms.Button();
            this.btnSacuvati = new System.Windows.Forms.Button();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.cbMjesto = new System.Windows.Forms.ComboBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.lbMjesto = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbWebSajt = new System.Windows.Forms.TextBox();
            this.lbWebSajt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(127, 12);
            this.tbNaziv.MaxLength = 60;
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(199, 20);
            this.tbNaziv.TabIndex = 0;
            // 
            // lbNaziv
            // 
            this.lbNaziv.AutoSize = true;
            this.lbNaziv.Location = new System.Drawing.Point(12, 15);
            this.lbNaziv.Name = "lbNaziv";
            this.lbNaziv.Size = new System.Drawing.Size(41, 13);
            this.lbNaziv.TabIndex = 42;
            this.lbNaziv.Text = "Naziv:*";
            // 
            // cbRegistrovanKodALMS
            // 
            this.cbRegistrovanKodALMS.AutoSize = true;
            this.cbRegistrovanKodALMS.Location = new System.Drawing.Point(127, 169);
            this.cbRegistrovanKodALMS.Name = "cbRegistrovanKodALMS";
            this.cbRegistrovanKodALMS.Size = new System.Drawing.Size(15, 14);
            this.cbRegistrovanKodALMS.TabIndex = 64;
            this.cbRegistrovanKodALMS.UseVisualStyleBackColor = true;
            // 
            // lbRegKodALMS
            // 
            this.lbRegKodALMS.AutoSize = true;
            this.lbRegKodALMS.Location = new System.Drawing.Point(12, 169);
            this.lbRegKodALMS.Name = "lbRegKodALMS";
            this.lbRegKodALMS.Size = new System.Drawing.Size(108, 13);
            this.lbRegKodALMS.TabIndex = 65;
            this.lbRegKodALMS.Text = "Registrovan u ALMS:";
            // 
            // btnOdustati
            // 
            this.btnOdustati.Image = global::Apoteka.Properties.Resources.cancel;
            this.btnOdustati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustati.Location = new System.Drawing.Point(239, 189);
            this.btnOdustati.Name = "btnOdustati";
            this.btnOdustati.Size = new System.Drawing.Size(87, 27);
            this.btnOdustati.TabIndex = 7;
            this.btnOdustati.Text = "Odustati";
            this.btnOdustati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustati.UseVisualStyleBackColor = true;
            this.btnOdustati.Click += new System.EventHandler(this.btnOdustati_Click);
            // 
            // btnSacuvati
            // 
            this.btnSacuvati.Image = global::Apoteka.Properties.Resources.save;
            this.btnSacuvati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvati.Location = new System.Drawing.Point(127, 189);
            this.btnSacuvati.Name = "btnSacuvati";
            this.btnSacuvati.Size = new System.Drawing.Size(87, 27);
            this.btnSacuvati.TabIndex = 6;
            this.btnSacuvati.Text = "Sačuvati";
            this.btnSacuvati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSacuvati.UseVisualStyleBackColor = true;
            this.btnSacuvati.Click += new System.EventHandler(this.btnSacuvati_Click);
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Location = new System.Drawing.Point(12, 41);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(47, 13);
            this.lbAdresa.TabIndex = 84;
            this.lbAdresa.Text = "Adresa:*";
            // 
            // cbMjesto
            // 
            this.cbMjesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMjesto.FormattingEnabled = true;
            this.cbMjesto.Location = new System.Drawing.Point(127, 64);
            this.cbMjesto.Name = "cbMjesto";
            this.cbMjesto.Size = new System.Drawing.Size(199, 21);
            this.cbMjesto.TabIndex = 2;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(127, 38);
            this.tbAdresa.MaxLength = 100;
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(199, 20);
            this.tbAdresa.TabIndex = 1;
            // 
            // lbMjesto
            // 
            this.lbMjesto.AutoSize = true;
            this.lbMjesto.Location = new System.Drawing.Point(12, 67);
            this.lbMjesto.Name = "lbMjesto";
            this.lbMjesto.Size = new System.Drawing.Size(45, 13);
            this.lbMjesto.TabIndex = 86;
            this.lbMjesto.Text = "Mjesto:*";
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(12, 94);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(46, 13);
            this.lbTelefon.TabIndex = 85;
            this.lbTelefon.Text = "Telefon:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(127, 91);
            this.tbTelefon.MaxLength = 100;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(199, 20);
            this.tbTelefon.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(127, 117);
            this.tbEmail.MaxLength = 80;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(199, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(12, 120);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 88;
            this.lbEmail.Text = "Email:";
            // 
            // tbWebSajt
            // 
            this.tbWebSajt.Location = new System.Drawing.Point(127, 143);
            this.tbWebSajt.MaxLength = 80;
            this.tbWebSajt.Name = "tbWebSajt";
            this.tbWebSajt.Size = new System.Drawing.Size(199, 20);
            this.tbWebSajt.TabIndex = 5;
            // 
            // lbWebSajt
            // 
            this.lbWebSajt.AutoSize = true;
            this.lbWebSajt.Location = new System.Drawing.Point(12, 146);
            this.lbWebSajt.Name = "lbWebSajt";
            this.lbWebSajt.Size = new System.Drawing.Size(52, 13);
            this.lbWebSajt.TabIndex = 90;
            this.lbWebSajt.Text = "Web sajt:";
            // 
            // DobavljacForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(343, 227);
            this.Controls.Add(this.tbWebSajt);
            this.Controls.Add(this.lbWebSajt);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbAdresa);
            this.Controls.Add(this.cbMjesto);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.lbMjesto);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.btnOdustati);
            this.Controls.Add(this.btnSacuvati);
            this.Controls.Add(this.cbRegistrovanKodALMS);
            this.Controls.Add(this.lbRegKodALMS);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.lbNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DobavljacForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dobavljač";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DobavljacForma_FormClosing);
            this.Load += new System.EventHandler(this.DobavljacForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label lbNaziv;
        private System.Windows.Forms.CheckBox cbRegistrovanKodALMS;
        private System.Windows.Forms.Label lbRegKodALMS;
        private System.Windows.Forms.Button btnOdustati;
        private System.Windows.Forms.Button btnSacuvati;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.ComboBox cbMjesto;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label lbMjesto;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbWebSajt;
        private System.Windows.Forms.Label lbWebSajt;
    }
}