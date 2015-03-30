using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Kupci
    {
    public partial class KupacForma : Form
        {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";

        private Form formaVratise { get; set; }

        public KupacForma(Form forma)
            {
            InitializeComponent();
            this.formaVratise = forma;
            PrikaziPodatke();
            }

        private void PrikaziPodatke()
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "SELECT * FROM Kupac ORDER BY ImePrezime";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojaKonekcija.Open();
                        OleDbDataAdapter adapter = new OleDbDataAdapter(mojUpit);
                        DataSet rezultati = new DataSet();
                        adapter.Fill(rezultati, "Kupac");
                        dataGridView1.DataSource = rezultati.Tables["Kupac"].DefaultView;
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
                }
            }

        private void btnVratiSe_Click(object sender, EventArgs e)
            {
            formaVratise.Show();
            this.Close();
            }

        private void btnExcel_Click(object sender, EventArgs e)
            {
            if (dataGridView1.DataSource == null)
                {
                MessageBox.Show("Nema podataka za izvesti u Excel", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            UbaciPodatkeUExcel();
            }

        private void UbaciPodatkeUExcel()
            {
            Excel.Application excelApp;
            Excel.Workbook excelWorkBook;
            Excel.Worksheet excelWorkSheet;

            try
                {
                int i, j, g;

                excelApp = new Excel.Application();
                excelWorkBook = excelApp.Workbooks.Add();
                excelWorkSheet = (Excel.Worksheet)excelWorkBook.Worksheets[1];
                excelApp.Visible = true;
                var radnja = excelWorkSheet;

                radnja.Cells.Select();
                radnja.Cells.Delete();

                for (i = 0; i <= dataGridView1.Columns.Count - 1; i++)
                    {
                    radnja.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                    }
                for (g = 0; g <= dataGridView1.RowCount - 1; g++)
                    {
                    for (j = 0; j <= dataGridView1.Columns.Count - 1; j++)
                        {
                        radnja.Cells[g + 2, j + 1].value = dataGridView1.Rows[g].Cells[j].Value;
                        }
                    }
                radnja.Rows["1:1"].Font.FontStyle = "Bold";
                radnja.Rows["1:1"].Font.Size = 12;

                radnja.Cells.Columns.AutoFit();
                radnja.Cells.Select();
                radnja.Cells.EntireColumn.AutoFit();
                radnja.Cells[1, 1].Select();
                }

            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            finally
                {
                excelApp = null;
                }
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
            int kupacID = (int)podaci.Cells[0].Value;
            Forme.Kupci.DodajKupcaForma forma = new DodajKupcaForma(false, true, true, true, kupacID);
            forma.txtImePrezime.Text = podaci.Cells[1].Value.ToString();
            forma.txtDrzava.Text = podaci.Cells[2].Value.ToString();
            forma.txtGrad.Text = podaci.Cells[3].Value.ToString();
            forma.txtAdresa.Text = podaci.Cells[4].Value.ToString();
            forma.txtTelefon.Text = podaci.Cells[5].Value.ToString();
            forma.txtMobitel.Text = podaci.Cells[6].Value.ToString();
            forma.txtFax.Text = podaci.Cells[7].Value.ToString();
            forma.txtEmail.Text = podaci.Cells[8].Value.ToString();
            forma.txtZabiljeske.Text = podaci.Cells[9].Value.ToString();
            forma.Show();
            }

        private void btnPrikaziIzvjestaj_Click(object sender, EventArgs e)
            {
            
            }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "SELECT * FROM Kupac WHERE ImePrezime LIKE @pretraga ORDER BY ImePrezime";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojaKonekcija.Open();
                        OleDbParameter pretragaPar = new OleDbParameter("@pretraga", OleDbType.VarChar);
                        pretragaPar.Value = txtPretraga.Text;
                        mojUpit.Parameters.Add(pretragaPar);
                        OleDbDataAdapter adapter = new OleDbDataAdapter(mojUpit);
                        DataSet rezultati = new DataSet();
                        adapter.Fill(rezultati, "Kupac");
                        dataGridView1.DataSource = rezultati.Tables["Kupac"].DefaultView;
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
                }
            }

        }
    }
