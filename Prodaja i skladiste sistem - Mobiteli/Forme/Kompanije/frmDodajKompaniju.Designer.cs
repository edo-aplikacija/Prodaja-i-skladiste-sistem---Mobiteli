namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Kompanije
    {
    partial class frmDodajKompaniju
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
            this.txtImeKompanije = new System.Windows.Forms.TextBox();
            this.btnSpasiNovuKompaniju = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.btnVratiSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime Kompanije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dodaj Kompaniju";
            // 
            // txtImeKompanije
            // 
            this.txtImeKompanije.Location = new System.Drawing.Point(216, 56);
            this.txtImeKompanije.Name = "txtImeKompanije";
            this.txtImeKompanije.Size = new System.Drawing.Size(211, 30);
            this.txtImeKompanije.TabIndex = 2;
            // 
            // btnSpasiNovuKompaniju
            // 
            this.btnSpasiNovuKompaniju.BackColor = System.Drawing.Color.LightGreen;
            this.btnSpasiNovuKompaniju.Location = new System.Drawing.Point(216, 128);
            this.btnSpasiNovuKompaniju.Name = "btnSpasiNovuKompaniju";
            this.btnSpasiNovuKompaniju.Size = new System.Drawing.Size(211, 30);
            this.btnSpasiNovuKompaniju.TabIndex = 3;
            this.btnSpasiNovuKompaniju.Text = "Spasi kao novu kompaniju";
            this.btnSpasiNovuKompaniju.UseVisualStyleBackColor = false;
            this.btnSpasiNovuKompaniju.Click += new System.EventHandler(this.btnSpasiNovuKompaniju_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.IndianRed;
            this.btnObrisi.Location = new System.Drawing.Point(216, 187);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(86, 30);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.BackColor = System.Drawing.Color.Khaki;
            this.btnIzaberi.Location = new System.Drawing.Point(43, 187);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(145, 30);
            this.btnIzaberi.TabIndex = 5;
            this.btnIzaberi.Text = "Izaberi Kompaniju";
            this.btnIzaberi.UseVisualStyleBackColor = false;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.BackColor = System.Drawing.Color.LightGreen;
            this.btnSpasi.Location = new System.Drawing.Point(331, 187);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(96, 30);
            this.btnSpasi.TabIndex = 6;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = false;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // btnVratiSe
            // 
            this.btnVratiSe.BackColor = System.Drawing.Color.IndianRed;
            this.btnVratiSe.Location = new System.Drawing.Point(43, 128);
            this.btnVratiSe.Name = "btnVratiSe";
            this.btnVratiSe.Size = new System.Drawing.Size(93, 30);
            this.btnVratiSe.TabIndex = 7;
            this.btnVratiSe.Text = "Vrati se";
            this.btnVratiSe.UseVisualStyleBackColor = false;
            this.btnVratiSe.Click += new System.EventHandler(this.btnVratiSe_Click);
            // 
            // frmDodajKompaniju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prodaja_i_skladiste_sistem___Mobiteli.Properties.Resources._86718;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 248);
            this.ControlBox = false;
            this.Controls.Add(this.btnVratiSe);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSpasiNovuKompaniju);
            this.Controls.Add(this.txtImeKompanije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDodajKompaniju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSpasiNovuKompaniju;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Button btnVratiSe;
        public System.Windows.Forms.TextBox txtImeKompanije;
        }
    }