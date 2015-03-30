namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme
{
    partial class PocetnaForma
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
            this.pgbPocetna = new System.Windows.Forms.ProgressBar();
            this.timerPocetna = new System.Windows.Forms.Timer(this.components);
            this.lbUcitavanje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prodaja i skadište managment sistem- Prodavnica mobitela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(254, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verzija 1.0";
            // 
            // pgbPocetna
            // 
            this.pgbPocetna.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.pgbPocetna.Location = new System.Drawing.Point(12, 309);
            this.pgbPocetna.Name = "pgbPocetna";
            this.pgbPocetna.Size = new System.Drawing.Size(563, 10);
            this.pgbPocetna.TabIndex = 0;
            // 
            // timerPocetna
            // 
            this.timerPocetna.Enabled = true;
            this.timerPocetna.Tick += new System.EventHandler(this.timerPocetna_Tick);
            // 
            // lbUcitavanje
            // 
            this.lbUcitavanje.AutoSize = true;
            this.lbUcitavanje.BackColor = System.Drawing.Color.Transparent;
            this.lbUcitavanje.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUcitavanje.Location = new System.Drawing.Point(12, 287);
            this.lbUcitavanje.Name = "lbUcitavanje";
            this.lbUcitavanje.Size = new System.Drawing.Size(0, 19);
            this.lbUcitavanje.TabIndex = 2;
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prodaja_i_skladiste_sistem___Mobiteli.Properties.Resources.mobileshopping21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 322);
            this.ControlBox = false;
            this.Controls.Add(this.lbUcitavanje);
            this.Controls.Add(this.pgbPocetna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PocetnaForma";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pgbPocetna;
        private System.Windows.Forms.Timer timerPocetna;
        private System.Windows.Forms.Label lbUcitavanje;
    }
}