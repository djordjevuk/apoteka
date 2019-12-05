namespace Apoteka
{
    partial class LoginForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForma));
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.lbPrijavitiSeKao = new System.Windows.Forms.Label();
            this.cbPrijavitiSeKao = new System.Windows.Forms.ComboBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(238, 36);
            this.tbKorisnickoIme.MaxLength = 45;
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(160, 20);
            this.tbKorisnickoIme.TabIndex = 1;
            this.tbKorisnickoIme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKorisnickoIme_KeyDown);
            // 
            // lbKorisnickoIme
            // 
            this.lbKorisnickoIme.AutoSize = true;
            this.lbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbKorisnickoIme.Location = new System.Drawing.Point(150, 39);
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            this.lbKorisnickoIme.Size = new System.Drawing.Size(82, 13);
            this.lbKorisnickoIme.TabIndex = 2;
            this.lbKorisnickoIme.Text = "Korisničko ime:*";
            // 
            // lbLozinka
            // 
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLozinka.Location = new System.Drawing.Point(150, 65);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(51, 13);
            this.lbLozinka.TabIndex = 4;
            this.lbLozinka.Text = "Lozinka:*";
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(238, 62);
            this.tbLozinka.MaxLength = 64;
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.PasswordChar = '*';
            this.tbLozinka.Size = new System.Drawing.Size(160, 20);
            this.tbLozinka.TabIndex = 2;
            this.tbLozinka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLozinka_KeyDown);
            // 
            // btnPrijava
            // 
            this.btnPrijava.Image = global::Apoteka.Properties.Resources.login;
            this.btnPrijava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrijava.Location = new System.Drawing.Point(311, 114);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(87, 27);
            this.btnPrijava.TabIndex = 3;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // lbPrijavitiSeKao
            // 
            this.lbPrijavitiSeKao.AutoSize = true;
            this.lbPrijavitiSeKao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPrijavitiSeKao.Location = new System.Drawing.Point(150, 12);
            this.lbPrijavitiSeKao.Name = "lbPrijavitiSeKao";
            this.lbPrijavitiSeKao.Size = new System.Drawing.Size(78, 13);
            this.lbPrijavitiSeKao.TabIndex = 5;
            this.lbPrijavitiSeKao.Text = "Prijaviti se kao:";
            // 
            // cbPrijavitiSeKao
            // 
            this.cbPrijavitiSeKao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrijavitiSeKao.FormattingEnabled = true;
            this.cbPrijavitiSeKao.Items.AddRange(new object[] {
            "farmaceut",
            "menadžer",
            "administrator"});
            this.cbPrijavitiSeKao.Location = new System.Drawing.Point(238, 9);
            this.cbPrijavitiSeKao.Name = "cbPrijavitiSeKao";
            this.cbPrijavitiSeKao.Size = new System.Drawing.Size(160, 21);
            this.cbPrijavitiSeKao.TabIndex = 0;
            this.cbPrijavitiSeKao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPrijavitiSeKao_KeyDown);
            // 
            // pbLogin
            // 
            this.pbLogin.Image = global::Apoteka.Properties.Resources.loginLock;
            this.pbLogin.InitialImage = null;
            this.pbLogin.Location = new System.Drawing.Point(12, 12);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(122, 131);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 0;
            this.pbLogin.TabStop = false;
            // 
            // LoginForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(410, 153);
            this.Controls.Add(this.cbPrijavitiSeKao);
            this.Controls.Add(this.lbPrijavitiSeKao);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.lbLozinka);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.lbKorisnickoIme);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.pbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apoteka - Prijava";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForma_FormClosing);
            this.Load += new System.EventHandler(this.LoginForma_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForma_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.Label lbKorisnickoIme;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label lbPrijavitiSeKao;
        private System.Windows.Forms.ComboBox cbPrijavitiSeKao;
    }
}