using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Korisnici
    {
    public partial class frmKorisnici : Form
        {       
        private Form formaVratise { get; set; }

        public frmKorisnici(Form forma)
            {
            InitializeComponent();
            this.formaVratise = forma;
            }

        private void btnVratiSe_Click(object sender, EventArgs e)
            {
            formaVratise.Show();
            this.Close();
            }

        private void frmKorisnici_Load(object sender, EventArgs e)
            {
            this.korisniciTableAdapter.Fill(this.dB_PSS_PMDataSet.Korisnici);

            }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
            try
                {
                DataGridViewRow podaci = dataGridView1.SelectedRows[0];
                PopuniFormu(podaci);
                this.Close();
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            }

        private void PopuniFormu(DataGridViewRow podaci)
            {
            int korisnikID = (int)podaci.Cells[0].Value;
            frmRegistracija forma = new frmRegistracija(false, true, true, true, korisnikID);
            forma.txtKorisnickoIme.Text = podaci.Cells[1].Value.ToString();
            forma.txtSifra.Text = podaci.Cells[2].Value.ToString();

            forma.cmbKorisnickaUloga.Text = podaci.Cells[3].Value.ToString();

            forma.txtImePrezime.Text = podaci.Cells[4].Value.ToString();
            forma.txtKontakt.Text = podaci.Cells[5].Value.ToString();
            forma.txtEmail.Text = podaci.Cells[6].Value.ToString();
            forma.Show();
            }
        }
    }
