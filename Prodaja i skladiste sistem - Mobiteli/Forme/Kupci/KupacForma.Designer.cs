namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Kupci
    {
    partial class KupacForma
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPrikaziIzvjestaj = new System.Windows.Forms.Button();
            this.btnVratiSe = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(534, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kupci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pretraži kupce";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(126, 62);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(240, 30);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Khaki;
            this.btnExcel.Location = new System.Drawing.Point(583, 62);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(159, 30);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Izvesti u Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPrikaziIzvjestaj
            // 
            this.btnPrikaziIzvjestaj.BackColor = System.Drawing.Color.Khaki;
            this.btnPrikaziIzvjestaj.Location = new System.Drawing.Point(748, 62);
            this.btnPrikaziIzvjestaj.Name = "btnPrikaziIzvjestaj";
            this.btnPrikaziIzvjestaj.Size = new System.Drawing.Size(155, 30);
            this.btnPrikaziIzvjestaj.TabIndex = 4;
            this.btnPrikaziIzvjestaj.Text = "Prikaži Izvještaj";
            this.btnPrikaziIzvjestaj.UseVisualStyleBackColor = false;
            this.btnPrikaziIzvjestaj.Click += new System.EventHandler(this.btnPrikaziIzvjestaj_Click);
            // 
            // btnVratiSe
            // 
            this.btnVratiSe.BackColor = System.Drawing.Color.IndianRed;
            this.btnVratiSe.Location = new System.Drawing.Point(999, 62);
            this.btnVratiSe.Name = "btnVratiSe";
            this.btnVratiSe.Size = new System.Drawing.Size(165, 30);
            this.btnVratiSe.TabIndex = 5;
            this.btnVratiSe.Text = "Vrati se";
            this.btnVratiSe.UseVisualStyleBackColor = false;
            this.btnVratiSe.Click += new System.EventHandler(this.btnVratiSe_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 519);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // KupacForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prodaja_i_skladiste_sistem___Mobiteli.Properties.Resources._86718;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 640);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVratiSe);
            this.Controls.Add(this.btnPrikaziIzvjestaj);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KupacForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPrikaziIzvjestaj;
        private System.Windows.Forms.Button btnVratiSe;
        private System.Windows.Forms.DataGridView dataGridView1;
        }
    }