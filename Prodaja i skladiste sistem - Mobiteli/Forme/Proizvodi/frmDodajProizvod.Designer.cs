namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Proizvodi
    {
    partial class frmDodajProizvod
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
            this.lblImeProizvoda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImeProizvoda = new System.Windows.Forms.TextBox();
            this.txtOdlike = new System.Windows.Forms.TextBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PSS_PMDataSet = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSet();
            this.cmbKompanija = new System.Windows.Forms.ComboBox();
            this.kompanijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numCijena = new System.Windows.Forms.NumericUpDown();
            this.pcbSlika = new System.Windows.Forms.PictureBox();
            this.btnIzaberiSliku = new System.Windows.Forms.Button();
            this.btnSpasiNoviProizvod = new System.Windows.Forms.Button();
            this.btnIzaberiProizvod = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnVratiSe = new System.Windows.Forms.Button();
            this.kategorijaTableAdapter = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSetTableAdapters.KategorijaTableAdapter();
            this.kompanijaTableAdapter = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSetTableAdapters.KompanijaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PSS_PMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompanijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(225, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj Proizvod";
            // 
            // lblImeProizvoda
            // 
            this.lblImeProizvoda.AutoSize = true;
            this.lblImeProizvoda.BackColor = System.Drawing.Color.Transparent;
            this.lblImeProizvoda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblImeProizvoda.Location = new System.Drawing.Point(61, 78);
            this.lblImeProizvoda.Name = "lblImeProizvoda";
            this.lblImeProizvoda.Size = new System.Drawing.Size(111, 23);
            this.lblImeProizvoda.TabIndex = 1;
            this.lblImeProizvoda.Text = "*Ime Proizvoda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(61, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Kategorija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(61, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Kompanija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(61, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "*Cijena Bez PDV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(61, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Odlike";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(61, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Slika";
            // 
            // txtImeProizvoda
            // 
            this.txtImeProizvoda.Location = new System.Drawing.Point(231, 75);
            this.txtImeProizvoda.Name = "txtImeProizvoda";
            this.txtImeProizvoda.Size = new System.Drawing.Size(300, 30);
            this.txtImeProizvoda.TabIndex = 7;
            // 
            // txtOdlike
            // 
            this.txtOdlike.Location = new System.Drawing.Point(231, 277);
            this.txtOdlike.Multiline = true;
            this.txtOdlike.Name = "txtOdlike";
            this.txtOdlike.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOdlike.Size = new System.Drawing.Size(300, 140);
            this.txtOdlike.TabIndex = 8;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.kategorijaBindingSource, "KategorijaID", true));
            this.cmbKategorija.DataSource = this.kategorijaBindingSource;
            this.cmbKategorija.DisplayMember = "ImeKategorije";
            this.cmbKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(231, 121);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(300, 31);
            this.cmbKategorija.TabIndex = 9;
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataMember = "Kategorija";
            this.kategorijaBindingSource.DataSource = this.dB_PSS_PMDataSet;
            // 
            // dB_PSS_PMDataSet
            // 
            this.dB_PSS_PMDataSet.DataSetName = "DB_PSS_PMDataSet";
            this.dB_PSS_PMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKompanija
            // 
            this.cmbKompanija.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.kompanijaBindingSource, "KompanijaID", true));
            this.cmbKompanija.DataSource = this.kompanijaBindingSource;
            this.cmbKompanija.DisplayMember = "ImeKompanije";
            this.cmbKompanija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKompanija.FormattingEnabled = true;
            this.cmbKompanija.Location = new System.Drawing.Point(231, 171);
            this.cmbKompanija.Name = "cmbKompanija";
            this.cmbKompanija.Size = new System.Drawing.Size(300, 31);
            this.cmbKompanija.TabIndex = 10;
            // 
            // kompanijaBindingSource
            // 
            this.kompanijaBindingSource.DataMember = "Kompanija";
            this.kompanijaBindingSource.DataSource = this.dB_PSS_PMDataSet;
            // 
            // numCijena
            // 
            this.numCijena.DecimalPlaces = 2;
            this.numCijena.Location = new System.Drawing.Point(231, 220);
            this.numCijena.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCijena.Name = "numCijena";
            this.numCijena.Size = new System.Drawing.Size(300, 30);
            this.numCijena.TabIndex = 11;
            // 
            // pcbSlika
            // 
            this.pcbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbSlika.Image = global::Prodaja_i_skladiste_sistem___Mobiteli.Properties.Resources.no_image_featured_image;
            this.pcbSlika.Location = new System.Drawing.Point(231, 442);
            this.pcbSlika.Name = "pcbSlika";
            this.pcbSlika.Size = new System.Drawing.Size(300, 173);
            this.pcbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSlika.TabIndex = 12;
            this.pcbSlika.TabStop = false;
            // 
            // btnIzaberiSliku
            // 
            this.btnIzaberiSliku.BackColor = System.Drawing.Color.Khaki;
            this.btnIzaberiSliku.Location = new System.Drawing.Point(64, 490);
            this.btnIzaberiSliku.Name = "btnIzaberiSliku";
            this.btnIzaberiSliku.Size = new System.Drawing.Size(134, 30);
            this.btnIzaberiSliku.TabIndex = 13;
            this.btnIzaberiSliku.Text = "Izaberi Sliku";
            this.btnIzaberiSliku.UseVisualStyleBackColor = false;
            this.btnIzaberiSliku.Click += new System.EventHandler(this.btnIzaberiSliku_Click);
            // 
            // btnSpasiNoviProizvod
            // 
            this.btnSpasiNoviProizvod.BackColor = System.Drawing.Color.LightGreen;
            this.btnSpasiNoviProizvod.Location = new System.Drawing.Point(275, 650);
            this.btnSpasiNoviProizvod.Name = "btnSpasiNoviProizvod";
            this.btnSpasiNoviProizvod.Size = new System.Drawing.Size(256, 33);
            this.btnSpasiNoviProizvod.TabIndex = 14;
            this.btnSpasiNoviProizvod.Text = "Spasi kao novi proizvod";
            this.btnSpasiNoviProizvod.UseVisualStyleBackColor = false;
            this.btnSpasiNoviProizvod.Click += new System.EventHandler(this.btnSpasiNoviProizvod_Click);
            // 
            // btnIzaberiProizvod
            // 
            this.btnIzaberiProizvod.BackColor = System.Drawing.Color.Khaki;
            this.btnIzaberiProizvod.Location = new System.Drawing.Point(65, 707);
            this.btnIzaberiProizvod.Name = "btnIzaberiProizvod";
            this.btnIzaberiProizvod.Size = new System.Drawing.Size(179, 33);
            this.btnIzaberiProizvod.TabIndex = 15;
            this.btnIzaberiProizvod.Text = "Izaberi proizvod";
            this.btnIzaberiProizvod.UseVisualStyleBackColor = false;
            this.btnIzaberiProizvod.Click += new System.EventHandler(this.btnIzaberiProizvod_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.BackColor = System.Drawing.Color.IndianRed;
            this.btnObriši.Location = new System.Drawing.Point(275, 707);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(112, 33);
            this.btnObriši.TabIndex = 16;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = false;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.BackColor = System.Drawing.Color.LightGreen;
            this.btnSpasi.Location = new System.Drawing.Point(419, 707);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(112, 33);
            this.btnSpasi.TabIndex = 17;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = false;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnVratiSe
            // 
            this.btnVratiSe.BackColor = System.Drawing.Color.IndianRed;
            this.btnVratiSe.Location = new System.Drawing.Point(65, 650);
            this.btnVratiSe.Name = "btnVratiSe";
            this.btnVratiSe.Size = new System.Drawing.Size(133, 33);
            this.btnVratiSe.TabIndex = 18;
            this.btnVratiSe.Text = "Vrati Se";
            this.btnVratiSe.UseVisualStyleBackColor = false;
            this.btnVratiSe.Click += new System.EventHandler(this.btnVratiSe_Click);
            // 
            // kategorijaTableAdapter
            // 
            this.kategorijaTableAdapter.ClearBeforeFill = true;
            // 
            // kompanijaTableAdapter
            // 
            this.kompanijaTableAdapter.ClearBeforeFill = true;
            // 
            // frmDodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prodaja_i_skladiste_sistem___Mobiteli.Properties.Resources._86718;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 777);
            this.ControlBox = false;
            this.Controls.Add(this.btnVratiSe);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnIzaberiProizvod);
            this.Controls.Add(this.btnSpasiNoviProizvod);
            this.Controls.Add(this.btnIzaberiSliku);
            this.Controls.Add(this.pcbSlika);
            this.Controls.Add(this.numCijena);
            this.Controls.Add(this.cmbKompanija);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.txtOdlike);
            this.Controls.Add(this.txtImeProizvoda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblImeProizvoda);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDodajProizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PSS_PMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompanijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImeProizvoda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIzaberiSliku;
        private System.Windows.Forms.Button btnSpasiNoviProizvod;
        private System.Windows.Forms.Button btnIzaberiProizvod;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnVratiSe;
        private DB_PSS_PMDataSet dB_PSS_PMDataSet;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private DB_PSS_PMDataSetTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
        private System.Windows.Forms.BindingSource kompanijaBindingSource;
        private DB_PSS_PMDataSetTableAdapters.KompanijaTableAdapter kompanijaTableAdapter;
        public System.Windows.Forms.TextBox txtImeProizvoda;
        public System.Windows.Forms.TextBox txtOdlike;
        public System.Windows.Forms.ComboBox cmbKategorija;
        public System.Windows.Forms.ComboBox cmbKompanija;
        public System.Windows.Forms.NumericUpDown numCijena;
        public System.Windows.Forms.PictureBox pcbSlika;
        }
    }