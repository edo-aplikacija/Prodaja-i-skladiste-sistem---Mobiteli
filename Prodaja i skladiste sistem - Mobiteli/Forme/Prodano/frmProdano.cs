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

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Prodano
    {
    public partial class frmProdano : Form
        {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";

        public frmProdano()
            {
            InitializeComponent();
            PrikaziPodatke();
            }

        private void PrikaziPodatke()
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "SELECT A.ProdanoProizvodaID, A.FakturaID, A.ProizvodID," 
                + " B.ImeProizvoda, A.Kolicina, A.Cijena, A.UkupnaCijena" 
                + " FROM ProdanoProizvoda AS A INNER JOIN Proizvod AS B ON A.ProizvodID = B.ProizvodID";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojaKonekcija.Open();
                        OleDbDataAdapter adapter = new OleDbDataAdapter(mojUpit);
                        DataSet rezultati = new DataSet();
                        adapter.Fill(rezultati, "ProdanoProizvoda");
                        dataGridView1.DataSource = rezultati.Tables["ProdanoProizvoda"].DefaultView;
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
                }
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

        private void btnVratiSe_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
            {

            }
        }
    }
