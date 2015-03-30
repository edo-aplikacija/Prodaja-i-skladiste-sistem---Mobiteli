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

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Kategorije
    {
    public partial class frmDodajKategoriju : Form
        {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";

        private OleDbParameter kategorijaID { get; set; }

        public frmDodajKategoriju(bool spasiNovuKategoriju, bool izaberi, bool spasi, bool obrisi)
            {
            InitializeComponent();
            btnSpasiNovuKategoriju.Enabled = spasiNovuKategoriju;
            btnIzaberi.Enabled = izaberi;
            btnSpasi.Enabled = spasi;
            btnObrisi.Enabled = obrisi;
            }

        public frmDodajKategoriju(bool spasiNovuKategoriju, bool izaberi, bool spasi, bool obrisi, int kategorijaID)
            {
            InitializeComponent();
            btnSpasiNovuKategoriju.Enabled = spasiNovuKategoriju;
            btnIzaberi.Enabled = izaberi;
            btnSpasi.Enabled = spasi;
            btnObrisi.Enabled = obrisi;
            this.kategorijaID = new OleDbParameter("@kategorijaID", OleDbType.Integer);
            this.kategorijaID.Value = kategorijaID;
            }

        private void btnSpasiNovuKategoriju_Click(object sender, EventArgs e)
            {
            if (txtImeKategorije.Text == "") 
                {
                MessageBox.Show("Morate popuniti polje Ime Kategorije", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }              
            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "INSERT INTO Kategorija(ImeKategorije) VALUES (@kategorijaIme)";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            OleDbParameter kategorijaIme = new OleDbParameter("@kategorijaIme", OleDbType.VarChar);
                            kategorijaIme.Value = txtImeKategorije.Text;
                            mojUpit.Parameters.Add(kategorijaIme);
                            mojaKonekcija.Open();
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno spašen nova kategorija", "Kategorija",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtImeKategorije.Text = "";
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

        private void btnSpasi_Click(object sender, EventArgs e)
            {
            if (txtImeKategorije.Text == "")
                {
                MessageBox.Show("Morate popuniti polje Ime Kategorije", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                } 
            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    mojaKonekcija.Open();
                    string komanda = "UPDATE Kategorija SET ImeKategorije = @imeKategorije WHERE KategorijaID = @kategorijaID";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            OleDbParameter kategorijaIme = new OleDbParameter("@kategorijaIme", OleDbType.VarChar);
                            kategorijaIme.Value = txtImeKategorije.Text;
                            mojUpit.Parameters.Add(kategorijaIme);
                            mojUpit.Parameters.Add(kategorijaID);
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno spašene promjene", "Kategorija",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtImeKategorije.Text = "";
                            btnSpasiNovuKategoriju.Enabled = true;
                            btnSpasi.Enabled = false;
                            btnObrisi.Enabled = false;
                            btnIzaberi.Enabled = true;
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

        private void btnObrisi_Click(object sender, EventArgs e)
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                mojaKonekcija.Open();
                string komanda = "DELETE FROM Kategorija WHERE KategorijaID = @kategorijaID";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojUpit.Parameters.Add(kategorijaID);
                        mojUpit.ExecuteReader();
                        MessageBox.Show("Uspješno obrisana kategorija", "Kategorija", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        txtImeKategorije.Text = "";
                        btnSpasiNovuKategoriju.Enabled = true;
                        btnSpasi.Enabled = false;
                        btnObrisi.Enabled = false;
                        btnIzaberi.Enabled = true;
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
                }
            }

        private void btnIzaberi_Click(object sender, EventArgs e)
            {
            frmKategorija kategorijaForma = new frmKategorija();
            kategorijaForma.Show();
            this.Close();
            }

        private void btnVratiSe_Click(object sender, EventArgs e)
            {
            this.Close();
            }
        }
    }
