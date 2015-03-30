namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Korisnici
    {
    partial class frmRegistracija
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.cmbKorisnickaUloga = new System.Windows.Forms.ComboBox();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.btnVratiSe = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.btnSpasiNovogKorisnika = new System.Windows.Forms.Button();
            this.dB_PSS_PMDataSet = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSet();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisniciTableAdapter = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSetTableAdapters.KorisniciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PSS_PMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj Korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Korisničko Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Šifra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Korisnička Uloga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(26, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "*Ime Prezime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(26, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kontakt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(26, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 258);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 30);
            this.txtEmail.TabIndex = 8;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(150, 214);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(197, 30);
            this.txtKontakt.TabIndex = 9;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(150, 172);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(197, 30);
            this.txtImePrezime.TabIndex = 10;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(150, 87);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(197, 30);
            this.txtSifra.TabIndex = 11;
            this.txtSifra.UseSystemPasswordChar = true;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(150, 48);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(197, 30);
            this.txtKorisnickoIme.TabIndex = 12;
            // 
            // cmbKorisnickaUloga
            // 
            this.cmbKorisnickaUloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKorisnickaUloga.FormattingEnabled = true;
            this.cmbKorisnickaUloga.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Zaposlenik"});
            this.cmbKorisnickaUloga.Location = new System.Drawing.Point(150, 128);
            this.cmbKorisnickaUloga.Name = "cmbKorisnickaUloga";
            this.cmbKorisnickaUloga.Size = new System.Drawing.Size(197, 31);
            this.cmbKorisnickaUloga.TabIndex = 13;
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.BackColor = System.Drawing.Color.Khaki;
            this.btnIzaberi.Location = new System.Drawing.Point(15, 377);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(131, 31);
            this.btnIzaberi.TabIndex = 14;
            this.btnIzaberi.Text = "Izaberi korisnika";
            this.btnIzaberi.UseVisualStyleBackColor = false;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // btnVratiSe
            // 
            this.btnVratiSe.BackColor = System.Drawing.Color.IndianRed;
            this.btnVratiSe.Location = new System.Drawing.Point(15, 322);
            this.btnVratiSe.Name = "btnVratiSe";
            this.btnVratiSe.Size = new System.Drawing.Size(75, 31);
            this.btnVratiSe.TabIndex = 15;
            this.btnVratiSe.Text = "Vrati se";
            this.btnVratiSe.UseVisualStyleBackColor = false;
            this.btnVratiSe.Click += new System.EventHandler(this.btnVratiSe_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.IndianRed;
            this.btnObrisi.Location = new System.Drawing.Point(191, 377);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 31);
            this.btnObrisi.TabIndex = 16;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.BackColor = System.Drawing.Color.LightGreen;
            this.btnSpasi.Location = new System.Drawing.Point(272, 377);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 31);
            this.btnSpasi.TabIndex = 17;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = false;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // btnSpasiNovogKorisnika
            // 
            this.btnSpasiNovogKorisnika.BackColor = System.Drawing.Color.LightGreen;
            this.btnSpasiNovogKorisnika.Location = new System.Drawing.Point(150, 322);
            this.btnSpasiNovogKorisnika.Name = "btnSpasiNovogKorisnika";
            this.btnSpasiNovogKorisnika.Size = new System.Drawing.Size(197, 31);
            this.btnSpasiNovogKorisnika.TabIndex = 18;
            this.btnSpasiNovogKorisnika.Text = "Spasi kao novog korisnika";
            this.btnSpasiNovogKorisnika.UseVisualStyleBackColor = false;
            this.btnSpasiNovogKorisnika.Click += new System.EventHandler(this.btnSpasiNovogKorisnika_Click);
            // 
            // dB_PSS_PMDataSet
            // 
            this.dB_PSS_PMDataSet.DataSetName = "DB_PSS_PMDataSet";
            this.dB_PSS_PMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataMember = "Korisnici";
            this.korisniciBindingSource.DataSource = this.dB_PSS_PMDataSet;
            // 
            // korisniciTableAdapter
            // 
            this.korisniciTableAdapter.ClearBeforeFill = true;
            // 
            // frmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prodaja_i_skladiste_sistem___Mobiteli.Properties.Resources._86718;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 438);
            this.ControlBox = false;
            this.Controls.Add(this.btnSpasiNovogKorisnika);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnVratiSe);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.cmbKorisnickaUloga);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRegistracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_PSS_PMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.Button btnVratiSe;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Button btnSpasiNovogKorisnika;
        private DB_PSS_PMDataSet dB_PSS_PMDataSet;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private DB_PSS_PMDataSetTableAdapters.KorisniciTableAdapter korisniciTableAdapter;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtKontakt;
        public System.Windows.Forms.TextBox txtImePrezime;
        public System.Windows.Forms.TextBox txtSifra;
        public System.Windows.Forms.TextBox txtKorisnickoIme;
        public System.Windows.Forms.ComboBox cmbKorisnickaUloga;
        }
    }