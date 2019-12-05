namespace Apoteka.Forme
{
    partial class PromjenaLozinkeForma
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
            this.btnOdustati = new System.Windows.Forms.Button();
            this.btnSacuvati = new System.Windows.Forms.Button();
            this.lbPonovljenaLozinka = new System.Windows.Forms.Label();
            this.tbPonovljenaLozinka = new System.Windows.Forms.TextBox();
            this.lbNovaLozinka = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.lbStaraLozinka = new System.Windows.Forms.Label();
            this.tbStaraLozinka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOdustati
            // 
            this.btnOdustati.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustati.Image = global::Apoteka.Properties.Resources.cancel;
            this.btnOdustati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustati.Location = new System.Drawing.Point(204, 103);
            this.btnOdustati.Name = "btnOdustati";
            this.btnOdustati.Size = new System.Drawing.Size(87, 27);
            this.btnOdustati.TabIndex = 4;
            this.btnOdustati.Text = "Odustati";
            this.btnOdustati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustati.UseVisualStyleBackColor = true;
            this.btnOdustati.Click += new System.EventHandler(this.btnOdustati_Click);
            // 
            // btnSacuvati
            // 
            this.btnSacuvati.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSacuvati.Image = global::Apoteka.Properties.Resources.save;
            this.btnSacuvati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvati.Location = new System.Drawing.Point(104, 103);
            this.btnSacuvati.Name = "btnSacuvati";
            this.btnSacuvati.Size = new System.Drawing.Size(87, 27);
            this.btnSacuvati.TabIndex = 3;
            this.btnSacuvati.Text = "Sačuvati";
            this.btnSacuvati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSacuvati.UseVisualStyleBackColor = true;
            this.btnSacuvati.Click += new System.EventHandler(this.btnSacuvati_Click);
            // 
            // lbPonovljenaLozinka
            // 
            this.lbPonovljenaLozinka.AutoSize = true;
            this.lbPonovljenaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPonovljenaLozinka.Location = new System.Drawing.Point(12, 67);
            this.lbPonovljenaLozinka.Name = "lbPonovljenaLozinka";
            this.lbPonovljenaLozinka.Size = new System.Drawing.Size(88, 13);
            this.lbPonovljenaLozinka.TabIndex = 53;
            this.lbPonovljenaLozinka.Text = "Ponoviti lozinku:*";
            // 
            // tbPonovljenaLozinka
            // 
            this.tbPonovljenaLozinka.Location = new System.Drawing.Point(104, 64);
            this.tbPonovljenaLozinka.MaxLength = 64;
            this.tbPonovljenaLozinka.Name = "tbPonovljenaLozinka";
            this.tbPonovljenaLozinka.PasswordChar = '*';
            this.tbPonovljenaLozinka.Size = new System.Drawing.Size(187, 20);
            this.tbPonovljenaLozinka.TabIndex = 2;
            // 
            // lbNovaLozinka
            // 
            this.lbNovaLozinka.AutoSize = true;
            this.lbNovaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNovaLozinka.Location = new System.Drawing.Point(12, 41);
            this.lbNovaLozinka.Name = "lbNovaLozinka";
            this.lbNovaLozinka.Size = new System.Drawing.Size(76, 13);
            this.lbNovaLozinka.TabIndex = 51;
            this.lbNovaLozinka.Text = "Nova lozinka:*";
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(104, 38);
            this.tbLozinka.MaxLength = 64;
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.PasswordChar = '*';
            this.tbLozinka.Size = new System.Drawing.Size(187, 20);
            this.tbLozinka.TabIndex = 1;
            // 
            // lbStaraLozinka
            // 
            this.lbStaraLozinka.AutoSize = true;
            this.lbStaraLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStaraLozinka.Location = new System.Drawing.Point(12, 15);
            this.lbStaraLozinka.Name = "lbStaraLozinka";
            this.lbStaraLozinka.Size = new System.Drawing.Size(75, 13);
            this.lbStaraLozinka.TabIndex = 57;
            this.lbStaraLozinka.Text = "Stara lozinka:*";
            // 
            // tbStaraLozinka
            // 
            this.tbStaraLozinka.Location = new System.Drawing.Point(104, 12);
            this.tbStaraLozinka.MaxLength = 64;
            this.tbStaraLozinka.Name = "tbStaraLozinka";
            this.tbStaraLozinka.PasswordChar = '*';
            this.tbStaraLozinka.Size = new System.Drawing.Size(187, 20);
            this.tbStaraLozinka.TabIndex = 0;
            // 
            // PromjenaLozinkeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(307, 140);
            this.Controls.Add(this.lbStaraLozinka);
            this.Controls.Add(this.tbStaraLozinka);
            this.Controls.Add(this.btnOdustati);
            this.Controls.Add(this.btnSacuvati);
            this.Controls.Add(this.lbPonovljenaLozinka);
            this.Controls.Add(this.tbPonovljenaLozinka);
            this.Controls.Add(this.lbNovaLozinka);
            this.Controls.Add(this.tbLozinka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PromjenaLozinkeForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Promjena lozinke";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PromjenaLozinkeForma_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustati;
        private System.Windows.Forms.Button btnSacuvati;
        private System.Windows.Forms.Label lbPonovljenaLozinka;
        private System.Windows.Forms.TextBox tbPonovljenaLozinka;
        private System.Windows.Forms.Label lbNovaLozinka;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Label lbStaraLozinka;
        private System.Windows.Forms.TextBox tbStaraLozinka;
    }
}