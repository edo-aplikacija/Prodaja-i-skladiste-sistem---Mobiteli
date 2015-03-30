namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Zaliha
    {
    partial class frmDodajZalihu
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProizvod = new System.Windows.Forms.ComboBox();
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PSS_PMDataSet = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSet();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.proizvodTableAdapter = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSetTableAdapters.ProizvodTableAdapter();
            this.btnVratiSe = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.btnDodajUZalihu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zalihaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zalihaTableAdapter = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSetTableAdapters.ZalihaTableAdapter();
            this.btnOcistiFormu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PSS_PMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zalihaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proizvod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(34, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Količina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(119, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Popuni Zalihu";
            // 
            // cmbProizvod
            // 
            this.cmbProizvod.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.proizvodBindingSource, "ProizvodID", true));
            this.cmbProizvod.DataSource = this.proizvodBindingSource;
            this.cmbProizvod.DisplayMember = "ImeProizvoda";
            this.cmbProizvod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProizvod.FormattingEnabled = true;
            this.cmbProizvod.Location = new System.Drawing.Point(147, 59);
            this.cmbProizvod.Name = "cmbProizvod";
            this.cmbProizvod.Size = new System.Drawing.Size(195, 31);
            this.cmbProizvod.TabIndex = 5;
            this.cmbProizvod.SelectedIndexChanged += new System.EventHandler(this.cmbProizvod_SelectedIndexChanged);
            // 
            // proizvodBindingSource
            // 
            this.proizvodBindingSource.DataMember = "Proizvod";
            this.proizvodBindingSource.DataSource = this.dB_PSS_PMDataSet;
            // 
            // dB_PSS_PMDataSet
            // 
            this.dB_PSS_PMDataSet.DataSetName = "DB_PSS_PMDataSet";
            this.dB_PSS_PMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(148, 112);
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(194, 30);
            this.numKolicina.TabIndex = 6;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.ValueChanged += new System.EventHandler(this.numKolicina_ValueChanged);
            this.numKolicina.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numKolicina_KeyUp);
            // 
            // txtCijena
            // 
            this.txtCijena.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCijena.Location = new System.Drawing.Point(148, 167);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(194, 30);
            this.txtCijena.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(34, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ukupna Cijena";
            // 
            // proizvodTableAdapter
            // 
            this.proizvodTableAdapter.ClearBeforeFill = true;
            // 
            // btnVratiSe
            // 
            this.btnVratiSe.BackColor = System.Drawing.Color.IndianRed;
            this.btnVratiSe.Location = new System.Drawing.Point(26, 348);
            this.btnVratiSe.Name = "btnVratiSe";
            this.btnVratiSe.Size = new System.Drawing.Size(75, 32);
            this.btnVratiSe.TabIndex = 10;
            this.btnVratiSe.Text = "Vrati Se";
            this.btnVratiSe.UseVisualStyleBackColor = false;
            this.btnVratiSe.Click += new System.EventHandler(this.btnVratiSe_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.IndianRed;
            this.btnObrisi.Location = new System.Drawing.Point(147, 348);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 32);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.BackColor = System.Drawing.Color.LightGreen;
            this.btnSpasi.Location = new System.Drawing.Point(267, 348);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 32);
            this.btnSpasi.TabIndex = 12;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = false;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // btnDodajUZalihu
            // 
            this.btnDodajUZalihu.BackColor = System.Drawing.Color.LightGreen;
            this.btnDodajUZalihu.Location = new System.Drawing.Point(148, 281);
            this.btnDodajUZalihu.Name = "btnDodajUZalihu";
            this.btnDodajUZalihu.Size = new System.Drawing.Size(195, 32);
            this.btnDodajUZalihu.TabIndex = 13;
            this.btnDodajUZalihu.Text = "Dodaj u zalihu";
            this.btnDodajUZalihu.UseVisualStyleBackColor = false;
            this.btnDodajUZalihu.Click += new System.EventHandler(this.btnDodajUZalihu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(34, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cijena bez PDV";
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Location = new System.Drawing.Point(148, 224);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.ReadOnly = true;
            this.txtUkupnaCijena.Size = new System.Drawing.Size(194, 30);
            this.txtUkupnaCijena.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(382, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 409);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // zalihaBindingSource
            // 
            this.zalihaBindingSource.DataMember = "Zaliha";
            this.zalihaBindingSource.DataSource = this.dB_PSS_PMDataSet;
            // 
            // zalihaTableAdapter
            // 
            this.zalihaTableAdapter.ClearBeforeFill = true;
            // 
            // btnOcistiFormu
            // 
            this.btnOcistiFormu.BackColor = System.Drawing.Color.Khaki;
            this.btnOcistiFormu.Location = new System.Drawing.Point(26, 281);
            this.btnOcistiFormu.Name = "btnOcistiFormu";
            this.btnOcistiFormu.Size = new System.Drawing.Size(115, 32);
            this.btnOcistiFormu.TabIndex = 17;
            this.btnOcistiFormu.Text = "Očisti formu";
            this.btnOcistiFormu.UseVisualStyleBackColor = false;
            this.btnOcistiFormu.Click += new System.EventHandler(this.btnOcistiFormu_Click);
            // 
            // frmDodajZalihu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prodaja_i_skladiste_sistem___Mobiteli.Properties.Resources._86718;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 409);
            this.ControlBox = false;
            this.Controls.Add(this.btnOcistiFormu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUkupnaCijena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodajUZalihu);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnVratiSe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.cmbProizvod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDodajZalihu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDodajZalihu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PSS_PMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zalihaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProizvod;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label3;
        private DB_PSS_PMDataSet dB_PSS_PMDataSet;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private DB_PSS_PMDataSetTableAdapters.ProizvodTableAdapter proizvodTableAdapter;
        private System.Windows.Forms.Button btnVratiSe;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Button btnDodajUZalihu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zalihaBindingSource;
        private DB_PSS_PMDataSetTableAdapters.ZalihaTableAdapter zalihaTableAdapter;
        private System.Windows.Forms.Button btnOcistiFormu;
        }
    }