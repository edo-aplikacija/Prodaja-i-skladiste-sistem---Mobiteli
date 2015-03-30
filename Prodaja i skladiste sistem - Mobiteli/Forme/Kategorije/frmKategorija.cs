using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Kategorije
    {
    public partial class frmKategorija : Form
        {
        public frmKategorija()
            {
            InitializeComponent();
            }

        private void frmKategorija_Load(object sender, EventArgs e)
            {
            // TODO: This line of code loads data into the 'dB_PSS_PMDataSet.Kategorija' table. You can move, or remove it, as needed.
            this.kategorijaTableAdapter.Fill(this.dB_PSS_PMDataSet.Kategorija);
            // TODO: This line of code loads data into the 'dB_PSS_PMDataSet.Kategorija' table. You can move, or remove it, as needed.
            this.kategorijaTableAdapter.Fill(this.dB_PSS_PMDataSet.Kategorija);

            }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
            {
            try
                {
                this.kategorijaTableAdapter.FillBy(this.dB_PSS_PMDataSet.Kategorija);
                }
            catch (System.Exception ex)
                {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
            {
            try
                {
                this.kategorijaTableAdapter.FillBy1(this.dB_PSS_PMDataSet.Kategorija);
                }
            catch (System.Exception ex)
                {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }

        private void btnVratise_Click(object sender, EventArgs e)
            {
            frmDodajKategoriju formaDodajKategoriju = new frmDodajKategoriju(true, true, false, false);
            formaDodajKategoriju.Show();
            this.Close();
            }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
            try
                {
                DataGridViewRow podaci = dataGridView1.SelectedRows[0];
                int kategorijaID = (int)podaci.Cells[0].Value;
                frmDodajKategoriju forma = new frmDodajKategoriju(false, true, true, true, kategorijaID);
                forma.txtImeKategorije.Text = podaci.Cells[1].Value.ToString();
                forma.Show();
                this.Close();
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            }
        }
    }
