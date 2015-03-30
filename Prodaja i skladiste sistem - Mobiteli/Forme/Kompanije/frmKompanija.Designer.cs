namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Kompanije
    {
    partial class frmKompanija
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kompanijaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeKompanijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kompanijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PSS_PMDataSet = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSet();
            this.btnVratiSe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kompanijaTableAdapter = new Prodaja_i_skladiste_sistem___Mobiteli.DB_PSS_PMDataSetTableAdapters.KompanijaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompanijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PSS_PMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kompanijaIDDataGridViewTextBoxColumn,
            this.imeKompanijeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kompanijaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // kompanijaIDDataGridViewTextBoxColumn
            // 
            this.kompanijaIDDataGridViewTextBoxColumn.DataPropertyName = "KompanijaID";
            this.kompanijaIDDataGridViewTextBoxColumn.HeaderText = "KompanijaID";
            this.kompanijaIDDataGridViewTextBoxColumn.Name = "kompanijaIDDataGridViewTextBoxColumn";
            // 
            // imeKompanijeDataGridViewTextBoxColumn
            // 
            this.imeKompanijeDataGridViewTextBoxColumn.DataPropertyName = "ImeKompanije";
            this.imeKompanijeDataGridViewTextBoxColumn.HeaderText = "ImeKompanije";
            this.imeKompanijeDataGridViewTextBoxColumn.Name = "imeKompanijeDataGridViewTextBoxColumn";
            // 
            // kompanijaBindingSource
            // 
            this.kompanijaBindingSource.DataMember = "Kompanija";
            this.kompanijaBindingSource.DataSource = this.dB_PSS_PMDataSet;
            // 
            // dB_PSS_PMDataSet
            // 
            this.dB_PSS_PMDataSet.DataSetName = "DB_PSS_PMDataSet";
            this.dB_PSS_PMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVratiSe
            // 
            this.btnVratiSe.BackColor = System.Drawing.Color.IndianRed;
            this.btnVratiSe.Location = new System.Drawing.Point(263, 12);
            this.btnVratiSe.Name = "btnVratiSe";
            this.btnVratiSe.Size = new System.Drawing.Size(104, 31);
            this.btnVratiSe.TabIndex = 1;
            this.btnVratiSe.Text = "Vrati se";
            this.btnVratiSe.UseVisualStyleBackColor = false;
            this.btnVratiSe.Click += new System.EventHandler(this.btnVratiSe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kompanija";
            // 
            // kompanijaTableAdapter
            // 
            this.kompanijaTableAdapter.ClearBeforeFill = true;
            // 
            // frmKompanija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(379, 462);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVratiSe);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKompanija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmKompanija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompanijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PSS_PMDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_PSS_PMDataSet dB_PSS_PMDataSet;
        private System.Windows.Forms.BindingSource kompanijaBindingSource;
        private DB_PSS_PMDataSetTableAdapters.KompanijaTableAdapter kompanijaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kompanijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeKompanijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnVratiSe;
        private System.Windows.Forms.Label label1;
        }
    }