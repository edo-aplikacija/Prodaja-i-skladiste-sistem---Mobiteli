using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Kompanije
    {
    public partial class frmKompanija : Form
        {
        public frmKompanija()
            {
            InitializeComponent();
            }

        private void frmKompanija_Load(object sender, EventArgs e)
            {
            // TODO: This line of code loads data into the 'dB_PSS_PMDataSet.Kompanija' table. You can move, or remove it, as needed.
            this.kompanijaTableAdapter.Fill(this.dB_PSS_PMDataSet.Kompanija);

            }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
            {
            try
                {
                this.kompanijaTableAdapter.FillBy(this.dB_PSS_PMDataSet.Kompanija);
                }
            catch (System.Exception ex)
                {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }

        private void btnVratiSe_Click(object sender, EventArgs e)
            {
            frmDodajKompaniju forma = new frmDodajKompaniju(true, true, false, false);
            forma.Show();
            this.Close();
            }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
            try
                {
                DataGridViewRow podaci = dataGridView1.SelectedRows[0];
                int kompanijaID = (int)podaci.Cells[0].Value;
                frmDodajKompaniju forma = new frmDodajKompaniju(false, true, true ,true, kompanijaID);
                forma.txtImeKompanije.Text = podaci.Cells[1].Value.ToString();
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
