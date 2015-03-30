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
using System.IO;

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Proizvodi
    {
    public partial class frmProizvod : Form
        {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";

        private Form formaVratise { get; set; }

        public frmProizvod(Form forma)
            {
            InitializeComponent();
            this.formaVratise = forma;
            PrikaziPodatke();
            }

        private void PrikaziPodatke()
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "SELECT Proizvod.ProizvodID, Proizvod.ImeProizvoda, Kategorija.ImeKategorije, Proizvod.KategorijaID, Kompanija.ImeKompanije, Proizvod.KompanijaID, Proizvod.Cijena, Proizvod.Odlike, Proizvod.Slika" +
                    " FROM ((Proizvod INNER JOIN Kategorija ON Proizvod.KategorijaID = Kategorija.KategorijaID)" 
                    + " INNER JOIN Kompanija ON Proizvod.KompanijaID = Kompanija.KompanijaID)";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojaKonekcija.Open();
                        OleDbDataAdapter adapter = new OleDbDataAdapter(mojUpit);
                        DataSet rezultati = new DataSet();
                        adapter.Fill(rezultati, "Proizvod");
                        dataGridView1.DataSource = rezultati.Tables["Proizvod"].DefaultView;
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

        private void btnIzvjestaj_Click(object sender, EventArgs e)
            {

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

        private void txtPretraga_TextChanged(object sender, EventArgs e)
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "SELECT Proizvod.ProizvodID, Proizvod.ImeProizvoda, Kategorija.ImeKategorije, Proizvod.KategorijaID, Kompanija.ImeKompanije, Proizvod.KompanijaID, Proizvod.Cijena, Proizvod.Odlike, Proizvod.Slika" +
                    " FROM ((Proizvod INNER JOIN Kategorija ON Proizvod.KategorijaID = Kategorija.KategorijaID)"
                    + " INNER JOIN Kompanija ON Proizvod.KompanijaID = Kompanija.KompanijaID)"
                    + " WHERE Proizvod.ImeProizvoda LIKE @pretraga";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojaKonekcija.Open();
                        OleDbParameter pretraga = new OleDbParameter("@pretraga", OleDbType.VarChar);
                        pretraga.Value = txtPretraga.Text;
                        mojUpit.Parameters.Add(pretraga);
                        OleDbDataAdapter adapter = new OleDbDataAdapter(mojUpit);
                        DataSet rezultati = new DataSet();
                        adapter.Fill(rezultati, "Proizvod");
                        dataGridView1.DataSource = "none";
                        dataGridView1.DataSource = rezultati.Tables["Proizvod"].DefaultView;
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
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
            int proizvodID = (int)podaci.Cells[0].Value;
            frmDodajProizvod forma = new frmDodajProizvod(false, true, true, true, proizvodID);
            forma.txtImeProizvoda.Text = podaci.Cells[1].Value.ToString();

            
            forma.cmbKategorija.Text = podaci.Cells[2].Value.ToString();
            forma.cmbKategorija.Tag = podaci.Cells[3].Value;

            forma.cmbKompanija.Text = podaci.Cells[4].Value.ToString();
            forma.cmbKompanija.Tag = podaci.Cells[5].Value.ToString();

            forma.numCijena.Value = (decimal)podaci.Cells[6].Value;
            forma.txtOdlike.Text = podaci.Cells[7].Value.ToString();
            byte[] podaciSlika = (byte[])podaci.Cells[8].Value;
            using (MemoryStream ms = new MemoryStream(podaciSlika))
                {
                forma.pcbSlika.Image = Image.FromStream(ms);
            }
            forma.Show();
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

                for (i = 0; i <= 8 - 1; i++)
                    {
                    radnja.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                    }
                for (g = 0; g <= dataGridView1.RowCount - 1; g++)
                    {
                    for (j = 0; j <= 8 - 1; j++)
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
        }

    }
