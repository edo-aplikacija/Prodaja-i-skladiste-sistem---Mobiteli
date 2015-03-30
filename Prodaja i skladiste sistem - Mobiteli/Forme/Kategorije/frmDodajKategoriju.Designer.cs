namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Kategorije
    {
    partial class frmDodajKategoriju
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
            this.txtImeKategorije = new System.Windows.Forms.TextBox();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.btnSpasiNovuKategoriju = new System.Windows.Forms.Button();
            this.btnVratiSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj Kategoriju";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime Kategorije";
            // 
            // txtImeKategorije
            // 
            this.txtImeKategorije.Location = new System.Drawing.Point(210, 65);
            this.txtImeKategorije.Name = "txtImeKategorije";
            this.txtImeKategorije.Size = new System.Drawing.Size(214, 30);
            this.txtImeKategorije.TabIndex = 2;
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.BackColor = System.Drawing.Color.Khaki;
            this.btnIzaberi.Location = new System.Drawing.Point(42, 194);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(140, 32);
            this.btnIzaberi.TabIndex = 3;
            this.btnIzaberi.Text = "Izaberi kategoriju";
            this.btnIzaberi.UseVisualStyleBackColor = false;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.IndianRed;
            this.btnObrisi.Location = new System.Drawing.Point(210, 194);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(94, 32);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.BackColor = System.Drawing.Color.LightGreen;
            this.btnSpasi.Location = new System.Drawing.Point(328, 194);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(96, 32);
            this.btnSpasi.TabIndex = 5;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = false;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // btnSpasiNovuKategoriju
            // 
            this.btnSpasiNovuKategoriju.BackColor = System.Drawing.Color.LightGreen;
            this.btnSpasiNovuKategoriju.Location = new System.Drawing.Point(210, 134);
            this.btnSpasiNovuKategoriju.Name = "btnSpasiNovuKategoriju";
            this.btnSpasiNovuKategoriju.Size = new System.Drawing.Size(214, 32);
            this.btnSpasiNovuKategoriju.TabIndex = 6;
            this.btnSpasiNovuKategoriju.Text = "Spasi kao novu kategoriju";
            this.btnSpasiNovuKategoriju.UseVisualStyleBackColor = false;
            this.btnSpasiNovuKategoriju.Click += new System.EventHandler(this.btnSpasiNovuKategoriju_Click);
            // 
            // btnVratiSe
            // 
            this.btnVratiSe.BackColor = System.Drawing.Color.IndianRed;
            this.btnVratiSe.Location = new System.Drawing.Point(42, 134);
            this.btnVratiSe.Name = "btnVratiSe";
            this.btnVratiSe.Size = new System.Drawing.Size(81, 32);
            this.btnVratiSe.TabIndex = 7;
            this.btnVratiSe.Text = "Vrati se";
            this.btnVratiSe.UseVisualStyleBackColor = false;
            this.btnVratiSe.Click += new System.EventHandler(this.btnVratiSe_Click);
            // 
            // frmDodajKategoriju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prodaja_i_skladiste_sistem___Mobiteli.Properties.Resources._86718;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 266);
            this.ControlBox = false;
            this.Controls.Add(this.btnVratiSe);
            this.Controls.Add(this.btnSpasiNovuKategoriju);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.txtImeKategorije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDodajKategoriju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Button btnSpasiNovuKategoriju;
        private System.Windows.Forms.Button btnVratiSe;
        public System.Windows.Forms.TextBox txtImeKategorije;
        }
    }