namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Korisnici
{
    partial class PrijavaForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.txbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txbSifra = new System.Windows.Forms.TextBox();
            this.btnPrijavi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lnkPromijeniSifru = new System.Windows.Forms.LinkLabel();
            this.lnkSifraRecovery = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prijava";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(126, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisnička Uloga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(126, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Korisničko Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(126, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Šifra";
            // 
            // cmbUloga
            // 
            this.cmbUloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Zaposlenik"});
            this.cmbUloga.Location = new System.Drawing.Point(323, 69);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(200, 31);
            this.cmbUloga.TabIndex = 4;
            // 
            // txbKorisnickoIme
            // 
            this.txbKorisnickoIme.Location = new System.Drawing.Point(323, 106);
            this.txbKorisnickoIme.Name = "txbKorisnickoIme";
            this.txbKorisnickoIme.Size = new System.Drawing.Size(200, 30);
            this.txbKorisnickoIme.TabIndex = 5;
            // 
            // txbSifra
            // 
            this.txbSifra.Location = new System.Drawing.Point(323, 145);
            this.txbSifra.Name = "txbSifra";
            this.txbSifra.Size = new System.Drawing.Size(200, 30);
            this.txbSifra.TabIndex = 6;
            this.txbSifra.UseSystemPasswordChar = true;
            // 
            // btnPrijavi
            // 
            this.btnPrijavi.BackColor = System.Drawing.Color.LightGreen;
            this.btnPrijavi.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijavi.Location = new System.Drawing.Point(130, 199);
            this.btnPrijavi.Name = "btnPrijavi";
            this.btnPrijavi.Size = new System.Drawing.Size(198, 39);
            this.btnPrijavi.TabIndex = 7;
            this.btnPrijavi.Text = "Prijavi";
            this.btnPrijavi.UseVisualStyleBackColor = false;
            this.btnPrijavi.Click += new System.EventHandler(this.btnPrijavi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.IndianRed;
            this.btnOdustani.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Location = new System.Drawing.Point(426, 199);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(97, 39);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lnkPromijeniSifru
            // 
            this.lnkPromijeniSifru.AutoSize = true;
            this.lnkPromijeniSifru.BackColor = System.Drawing.Color.Transparent;
            this.lnkPromijeniSifru.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnkPromijeniSifru.LinkColor = System.Drawing.Color.White;
            this.lnkPromijeniSifru.Location = new System.Drawing.Point(125, 289);
            this.lnkPromijeniSifru.Name = "lnkPromijeniSifru";
            this.lnkPromijeniSifru.Size = new System.Drawing.Size(135, 28);
            this.lnkPromijeniSifru.TabIndex = 9;
            this.lnkPromijeniSifru.TabStop = true;
            this.lnkPromijeniSifru.Text = "Promijeni Šifru";
            this.lnkPromijeniSifru.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPromijeniSifru_LinkClicked);
            // 
            // lnkSifraRecovery
            // 
            this.lnkSifraRecovery.AutoSize = true;
            this.lnkSifraRecovery.BackColor = System.Drawing.Color.Transparent;
            this.lnkSifraRecovery.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnkSifraRecovery.LinkColor = System.Drawing.Color.White;
            this.lnkSifraRecovery.Location = new System.Drawing.Point(421, 289);
            this.lnkSifraRecovery.Name = "lnkSifraRecovery";
            this.lnkSifraRecovery.Size = new System.Drawing.Size(127, 28);
            this.lnkSifraRecovery.TabIndex = 10;
            this.lnkSifraRecovery.TabStop = true;
            this.lnkSifraRecovery.Text = "Šifra Recovery";
            this.lnkSifraRecovery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSifraRecovery_LinkClicked);
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prodaja_i_skladiste_sistem___Mobiteli.Properties.Resources._39660432;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 330);
            this.ControlBox = false;
            this.Controls.Add(this.lnkSifraRecovery);
            this.Controls.Add(this.lnkPromijeniSifru);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrijavi);
            this.Controls.Add(this.txbSifra);
            this.Controls.Add(this.txbKorisnickoIme);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrijavaForma";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.TextBox txbKorisnickoIme;
        private System.Windows.Forms.TextBox txbSifra;
        private System.Windows.Forms.Button btnPrijavi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.LinkLabel lnkPromijeniSifru;
        private System.Windows.Forms.LinkLabel lnkSifraRecovery;
    }
}