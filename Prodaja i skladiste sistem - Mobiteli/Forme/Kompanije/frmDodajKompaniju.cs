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

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Kompanije
    {
    public partial class frmDodajKompaniju : Form
        {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";

        private OleDbParameter kompanijaID { get; set; }

        public frmDodajKompaniju(bool spasiNovuKompaniju, bool izaberi, bool spasi, bool obrisi)
            {
            InitializeComponent();
            btnSpasiNovuKompaniju.Enabled = spasiNovuKompaniju;
            btnIzaberi.Enabled = izaberi;
            btnSpasi.Enabled = spasi;
            btnObrisi.Enabled = obrisi;
            }

        public frmDodajKompaniju(bool spasiNovuKompaniju, bool izaberi, bool spasi, bool obrisi, int kompanijaID)
            {
            InitializeComponent();
            btnSpasiNovuKompaniju.Enabled = spasiNovuKompaniju;
            btnIzaberi.Enabled = izaberi;
            btnSpasi.Enabled = spasi;
            btnObrisi.Enabled = obrisi;
            this.kompanijaID = new OleDbParameter("@kompanijaID", OleDbType.Integer);
            this.kompanijaID.Value = kompanijaID;
            }

        private void btnSpasiNovuKompaniju_Click(object sender, EventArgs e)
            {
            if (txtImeKompanije.Text == "")
                {
                MessageBox.Show("Morate popuniti polje Ime Kompanije", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "INSERT INTO Kompanija(ImeKompanije) VALUES (@imeKompanije)";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            OleDbParameter kompanijaIme = new OleDbParameter("@imeKompanije", OleDbType.VarChar);
                            kompanijaIme.Value = txtImeKompanije.Text;
                            mojUpit.Parameters.Add(kompanijaIme);
                            mojaKonekcija.Open();
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno spašena nova kompanija", "Kompanija",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtImeKompanije.Text = "";
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
            if (txtImeKompanije.Text == "")
                {
                MessageBox.Show("Morate popuniti polje Ime Kompanije", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    mojaKonekcija.Open();
                    string komanda = "UPDATE Kompanija SET ImeKompanije = @imeKompanije WHERE KompanijaID = @kompanijaID";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            OleDbParameter imeKompanije = new OleDbParameter("@imeKompanije", OleDbType.VarChar);
                            imeKompanije.Value = txtImeKompanije.Text;
                            mojUpit.Parameters.Add(imeKompanije);
                            mojUpit.Parameters.Add(kompanijaID);
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno spašene promjene", "Kompanija",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtImeKompanije.Text = "";
                            btnSpasiNovuKompaniju.Enabled = true;
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
                string komanda = "DELETE FROM Kompanija WHERE KompanijaID = @kompanijaID";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojUpit.Parameters.Add(kompanijaID);
                        mojUpit.ExecuteReader();
                        MessageBox.Show("Uspješno obrisana kompanija", "Kompanija", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        txtImeKompanije.Text = "";
                        btnSpasiNovuKompaniju.Enabled = true;
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
            frmKompanija forma = new frmKompanija();
            forma.Show();
            this.Close();
            }

        private void btnVratiSe_Click(object sender, EventArgs e)
            {
            this.Close();
            }
        }
    }
