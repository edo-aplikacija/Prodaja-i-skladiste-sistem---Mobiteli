namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Fakture
    {
    partial class frmNapraviFakturu
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Dug = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUkupnoBezPDV = new System.Windows.Forms.TextBox();
            this.txtProizvodUkupno = new System.Windows.Forms.TextBox();
            this.txtDostupnaKolicina = new System.Windows.Forms.TextBox();
            this.txtProizvodCijena = new System.Windows.Forms.TextBox();
            this.txtUkupnoSaPDV = new System.Windows.Forms.TextBox();
            this.txtPDVProcenat = new System.Windows.Forms.TextBox();
            this.txtDug = new System.Windows.Forms.TextBox();
            this.txtZabiljeske = new System.Windows.Forms.TextBox();
            this.dB_PSS_PMDataSet = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSet();
            this.kupacTableAdapter = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSetTableAdapters.KupacTableAdapter();
            this.dBPSSPMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.numPlatio = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVratiSe = new System.Windows.Forms.Button();
            this.btnNapraviFakturu = new System.Windows.Forms.Button();
            this.proizvodTableAdapter = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSetTableAdapters.ProizvodTableAdapter();
            this.txtKupacIme = new System.Windows.Forms.TextBox();
            this.txtProizvodIme = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDodajUKorpu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PSS_PMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPSSPMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kupac";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(315, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Količina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(315, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dostupna količina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(35, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proizvod sa zalihe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cijena Bez PDV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ukupno sa PDV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(3, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ukupno Bez DPV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(3, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ukupno Bez PDV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(23, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "PDV procenat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(77, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Platio";
            // 
            // Dug
            // 
            this.Dug.AutoSize = true;
            this.Dug.BackColor = System.Drawing.Color.Transparent;
            this.Dug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dug.Location = new System.Drawing.Point(12, 406);
            this.Dug.Name = "Dug";
            this.Dug.Size = new System.Drawing.Size(116, 23);
            this.Dug.TabIndex = 10;
            this.Dug.Text = "Dug - Pretplata";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(317, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Zabilješke";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(248, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "Faktura";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(286, 468);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 23);
            this.label13.TabIndex = 13;
            this.label13.Text = "Korpa";
            // 
            // txtUkupnoBezPDV
            // 
            this.txtUkupnoBezPDV.Location = new System.Drawing.Point(131, 257);
            this.txtUkupnoBezPDV.Name = "txtUkupnoBezPDV";
            this.txtUkupnoBezPDV.ReadOnly = true;
            this.txtUkupnoBezPDV.Size = new System.Drawing.Size(180, 30);
            this.txtUkupnoBezPDV.TabIndex = 16;
            // 
            // txtProizvodUkupno
            // 
            this.txtProizvodUkupno.Location = new System.Drawing.Point(131, 183);
            this.txtProizvodUkupno.Name = "txtProizvodUkupno";
            this.txtProizvodUkupno.ReadOnly = true;
            this.txtProizvodUkupno.Size = new System.Drawing.Size(178, 30);
            this.txtProizvodUkupno.TabIndex = 17;
            // 
            // txtDostupnaKolicina
            // 
            this.txtDostupnaKolicina.Location = new System.Drawing.Point(440, 147);
            this.txtDostupnaKolicina.Name = "txtDostupnaKolicina";
            this.txtDostupnaKolicina.ReadOnly = true;
            this.txtDostupnaKolicina.Size = new System.Drawing.Size(117, 30);
            this.txtDostupnaKolicina.TabIndex = 18;
            // 
            // txtProizvodCijena
            // 
            this.txtProizvodCijena.Location = new System.Drawing.Point(131, 147);
            this.txtProizvodCijena.Name = "txtProizvodCijena";
            this.txtProizvodCijena.ReadOnly = true;
            this.txtProizvodCijena.Size = new System.Drawing.Size(178, 30);
            this.txtProizvodCijena.TabIndex = 19;
            // 
            // txtUkupnoSaPDV
            // 
            this.txtUkupnoSaPDV.Location = new System.Drawing.Point(131, 329);
            this.txtUkupnoSaPDV.Name = "txtUkupnoSaPDV";
            this.txtUkupnoSaPDV.ReadOnly = true;
            this.txtUkupnoSaPDV.Size = new System.Drawing.Size(180, 30);
            this.txtUkupnoSaPDV.TabIndex = 20;
            // 
            // txtPDVProcenat
            // 
            this.txtPDVProcenat.Location = new System.Drawing.Point(131, 293);
            this.txtPDVProcenat.Name = "txtPDVProcenat";
            this.txtPDVProcenat.ReadOnly = true;
            this.txtPDVProcenat.Size = new System.Drawing.Size(180, 30);
            this.txtPDVProcenat.TabIndex = 21;
            // 
            // txtDug
            // 
            this.txtDug.Location = new System.Drawing.Point(131, 403);
            this.txtDug.Name = "txtDug";
            this.txtDug.ReadOnly = true;
            this.txtDug.Size = new System.Drawing.Size(180, 30);
            this.txtDug.TabIndex = 22;
            // 
            // txtZabiljeske
            // 
            this.txtZabiljeske.Location = new System.Drawing.Point(321, 283);
            this.txtZabiljeske.Multiline = true;
            this.txtZabiljeske.Name = "txtZabiljeske";
            this.txtZabiljeske.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtZabiljeske.Size = new System.Drawing.Size(236, 150);
            this.txtZabiljeske.TabIndex = 23;
            // 
            // dB_PSS_PMDataSet
            // 
            this.dB_PSS_PMDataSet.DataSetName = "DB_PSS_PMDataSet";
            this.dB_PSS_PMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
            // 
            // dBPSSPMDataSetBindingSource
            // 
            this.dBPSSPMDataSetBindingSource.DataSource = this.dB_PSS_PMDataSet;
            this.dBPSSPMDataSetBindingSource.Position = 0;
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(384, 184);
            this.numKolicina.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(173, 30);
            this.numKolicina.TabIndex = 24;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numKolicina_KeyUp);
            // 
            // numPlatio
            // 
            this.numPlatio.DecimalPlaces = 2;
            this.numPlatio.Location = new System.Drawing.Point(131, 367);
            this.numPlatio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPlatio.Name = "numPlatio";
            this.numPlatio.Size = new System.Drawing.Size(180, 30);
            this.numPlatio.TabIndex = 25;
            this.numPlatio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numPlatio_KeyUp);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(16, 494);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(604, 254);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ZalihaID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProizvodID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime Proizvoda";
            this.columnHeader2.Width = 194;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cijena Bez PDV";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Količina";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ukupno Bez PDV";
            this.columnHeader5.Width = 141;
            // 
            // btnVratiSe
            // 
            this.btnVratiSe.BackColor = System.Drawing.Color.IndianRed;
            this.btnVratiSe.Location = new System.Drawing.Point(440, 450);
            this.btnVratiSe.Name = "btnVratiSe";
            this.btnVratiSe.Size = new System.Drawing.Size(117, 38);
            this.btnVratiSe.TabIndex = 27;
            this.btnVratiSe.Text = "Vrati se";
            this.btnVratiSe.UseVisualStyleBackColor = false;
            this.btnVratiSe.Click += new System.EventHandler(this.btnVratiSe_Click);
            // 
            // btnNapraviFakturu
            // 
            this.btnNapraviFakturu.BackColor = System.Drawing.Color.LightGreen;
            this.btnNapraviFakturu.Location = new System.Drawing.Point(16, 449);
            this.btnNapraviFakturu.Name = "btnNapraviFakturu";
            this.btnNapraviFakturu.Size = new System.Drawing.Size(191, 39);
            this.btnNapraviFakturu.TabIndex = 28;
            this.btnNapraviFakturu.Text = "Napravi Fakturu";
            this.btnNapraviFakturu.UseVisualStyleBackColor = false;
            this.btnNapraviFakturu.Click += new System.EventHandler(this.btnNapraviFakturu_Click);
            // 
            // proizvodTableAdapter
            // 
            this.proizvodTableAdapter.ClearBeforeFill = true;
            // 
            // txtKupacIme
            // 
            this.txtKupacIme.Location = new System.Drawing.Point(200, 45);
            this.txtKupacIme.Name = "txtKupacIme";
            this.txtKupacIme.ReadOnly = true;
            this.txtKupacIme.Size = new System.Drawing.Size(178, 30);
            this.txtKupacIme.TabIndex = 29;
            // 
            // txtProizvodIme
            // 
            this.txtProizvodIme.Location = new System.Drawing.Point(200, 81);
            this.txtProizvodIme.Name = "txtProizvodIme";
            this.txtProizvodIme.ReadOnly = true;
            this.txtProizvodIme.Size = new System.Drawing.Size(178, 30);
            this.txtProizvodIme.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(236, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 23);
            this.label14.TabIndex = 31;
            this.label14.Text = "Proizvod Detalji";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(563, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 50);
            this.label15.TabIndex = 32;
            this.label15.Text = "Izaberi Proizvod";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(578, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 66);
            this.label16.TabIndex = 33;
            this.label16.Text = "Izaberi Kupca";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(643, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 314);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(643, 329);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(524, 419);
            this.dataGridView2.TabIndex = 35;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // btnDodajUKorpu
            // 
            this.btnDodajUKorpu.BackColor = System.Drawing.Color.Khaki;
            this.btnDodajUKorpu.Location = new System.Drawing.Point(405, 81);
            this.btnDodajUKorpu.Name = "btnDodajUKorpu";
            this.btnDodajUKorpu.Size = new System.Drawing.Size(215, 30);
            this.btnDodajUKorpu.TabIndex = 36;
            this.btnDodajUKorpu.Text = "Dodaj u korpu";
            this.btnDodajUKorpu.UseVisualStyleBackColor = false;
            this.btnDodajUKorpu.Click += new System.EventHandler(this.btnDodajUKorpu_Click);
            // 
            // frmNapraviFakturu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prodaja_i_skladiste_sistem___Mobiteli.Properties.Resources._86718;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 760);
            this.ControlBox = false;
            this.Controls.Add(this.btnDodajUKorpu);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtProizvodIme);
            this.Controls.Add(this.txtKupacIme);
            this.Controls.Add(this.btnNapraviFakturu);
            this.Controls.Add(this.btnVratiSe);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.numPlatio);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.txtZabiljeske);
            this.Controls.Add(this.txtDug);
            this.Controls.Add(this.txtPDVProcenat);
            this.Controls.Add(this.txtUkupnoSaPDV);
            this.Controls.Add(this.txtProizvodCijena);
            this.Controls.Add(this.txtDostupnaKolicina);
            this.Controls.Add(this.txtProizvodUkupno);
            this.Controls.Add(this.txtUkupnoBezPDV);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Dug);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
            this.Name = "frmNapraviFakturu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dB_PSS_PMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPSSPMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Dug;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUkupnoBezPDV;
        private System.Windows.Forms.TextBox txtUkupnoSaPDV;
        private System.Windows.Forms.TextBox txtPDVProcenat;
        private System.Windows.Forms.TextBox txtDug;
        private System.Windows.Forms.TextBox txtZabiljeske;
        private DB_PSS_PMDataSet dB_PSS_PMDataSet;
        private DB_PSS_PMDataSetTableAdapters.KupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.BindingSource dBPSSPMDataSetBindingSource;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.NumericUpDown numPlatio;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnVratiSe;
        private System.Windows.Forms.Button btnNapraviFakturu;
        private DB_PSS_PMDataSetTableAdapters.ProizvodTableAdapter proizvodTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDodajUKorpu;
        private System.Windows.Forms.TextBox txtKupacIme;
        private System.Windows.Forms.TextBox txtProizvodIme;
        private System.Windows.Forms.TextBox txtProizvodUkupno;
        private System.Windows.Forms.TextBox txtDostupnaKolicina;
        private System.Windows.Forms.TextBox txtProizvodCijena;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        }
    }