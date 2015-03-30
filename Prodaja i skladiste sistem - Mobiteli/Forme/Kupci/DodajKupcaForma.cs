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

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Kupci
    {
    public partial class DodajKupcaForma : Form
        {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";

        private OleDbParameter kupacID { get; set; }



        public DodajKupcaForma(bool spasiNovogKupca, bool obrisi, bool spasi, bool izmijeni)
            {
            InitializeComponent();          
            btnSpasiNovogKupca.Visible = spasiNovogKupca;
            btnObriši.Visible = obrisi;
            btnSpasi.Visible = spasi;
            btnIzmijeni.Visible = izmijeni;
            }

        public DodajKupcaForma(bool spasiNovogKupca, bool obrisi, bool spasi, bool izmijeni, int kupacID)
            {
            InitializeComponent();
            btnSpasiNovogKupca.Visible = spasiNovogKupca;
            btnObriši.Visible = obrisi;
            btnSpasi.Visible = spasi;
            btnIzmijeni.Visible = izmijeni;
            this.kupacID = new OleDbParameter("@kupacID", OleDbType.Integer);
            this.kupacID.Value = kupacID;

            }

        private void btnSpasiNovogKupca_Click(object sender, EventArgs e)
            {
            if (ProvjeraPraznihPolja())
                return;
            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "INSERT INTO Kupac(ImePrezime, Drzava, Grad, Adresa, Telefon, Mobitel, Fax, Email, Zabiljeske)"
                        + " VALUES (@imePrezime, @drzava, @grad, @adresa, @telefon, @mobitel, @fax, @email, @zabiljeske)";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            List<OleDbParameter> parametri = DodajParametre();
                            foreach (var parametar in parametri)
                                mojUpit.Parameters.Add(parametar);                           
                            mojaKonekcija.Open();
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno spašen novi kupac", "Kupac",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetForme();
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
            if (ProvjeraPraznihPolja())
                return;
            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    mojaKonekcija.Open();
                    string komanda = "UPDATE Kupac SET ImePrezime = @imePrezime, Drzava = @drzava, " + 
                        "Grad = @grad, Adresa = @adresa, Telefon = @telefon, Mobitel = @mobitel, " + 
                        "Fax = @fax, Email= @email, Zabiljeske = @zabiljeske WHERE KupacID = @kupacID";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            List<OleDbParameter> parametri = DodajParametre();
                            foreach (var parametar in parametri)
                                mojUpit.Parameters.Add(parametar);
                            mojUpit.Parameters.Add(kupacID);                           
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno spašene promjene", "Kupac",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetForme();
                            btnObriši.Enabled = false;
                            btnSpasi.Enabled = false;
                            btnSpasiNovogKupca.Enabled = true;
                            btnIzmijeni.Enabled = true;
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

        private void btnObriši_Click(object sender, EventArgs e)
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                mojaKonekcija.Open();
                string komanda = "DELETE FROM Kupac WHERE KupacID = @kupacID";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        mojUpit.Parameters.Add(kupacID);
                        mojUpit.ExecuteReader();
                        MessageBox.Show("Uspješno obrisan kupac", "Kupac", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetForme();
                        btnObriši.Enabled = false;
                        btnSpasi.Enabled = false;
                        btnSpasiNovogKupca.Enabled = true;
                        btnIzmijeni.Enabled = true;
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
                }
            }

        private void btnIzmijeni_Click(object sender, EventArgs e)
            {
            Forme.Kupci.KupacForma kupacForma = new KupacForma(this);
            kupacForma.Show();
            this.Hide();
            }

        private bool ProvjeraPraznihPolja()
            {
            if (txtImePrezime.Text == "" || txtDrzava.Text == "" || txtGrad.Text == "" || txtMobitel.Text == "")
                {
                MessageBox.Show("Polja sa * moraju biti popunjena!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
                }
            else
                return false;
            }

        private List<OleDbParameter> DodajParametre()
            {
            List<OleDbParameter> parametri = new List<OleDbParameter>();

            OleDbParameter imePrezime = new OleDbParameter("@imePrezime", OleDbType.VarChar);
                OleDbParameter drzava = new OleDbParameter("@drzava", OleDbType.VarChar);
                OleDbParameter grad = new OleDbParameter("@grad", OleDbType.VarChar);
                OleDbParameter adresa = new OleDbParameter("@adresa", OleDbType.VarChar);
                OleDbParameter telefon = new OleDbParameter("@telefon", OleDbType.VarChar);
                OleDbParameter mobitel = new OleDbParameter("@mobitel", OleDbType.VarChar);
                OleDbParameter fax = new OleDbParameter("@fax", OleDbType.VarChar);
                OleDbParameter email = new OleDbParameter("@email", OleDbType.VarChar);
                OleDbParameter zabiljeske = new OleDbParameter("@zabiljeske", OleDbType.VarChar);

                imePrezime.Value = txtImePrezime.Text;
                drzava.Value = txtDrzava.Text;
                grad.Value = txtGrad.Text;
                if (txtAdresa.Text == "")
                    adresa.Value = "nije popunjeno";
                else
                    adresa.Value = txtAdresa.Text;
                if (txtTelefon.Text == "")
                    telefon.Value = "nije popunjeno";
                else
                    telefon.Value = txtTelefon.Text;
                mobitel.Value = txtMobitel.Text;
                if (txtFax.Text == "")
                    fax.Value = "nije popunjeno";
                else
                    fax.Value = txtFax.Text;
                if (txtEmail.Text == "")
                    email.Value = "nije popunjeno";
                else
                    email.Value = txtEmail.Text;
                if (txtZabiljeske.Text == "")
                    zabiljeske.Value = "nije popunjeno";
                else
                    zabiljeske.Value = txtZabiljeske.Text;

                parametri.Add(imePrezime);
                parametri.Add(drzava);
                parametri.Add(grad);
                parametri.Add(adresa);
                parametri.Add(telefon);
                parametri.Add(mobitel);
                parametri.Add(fax);
                parametri.Add(email);
                parametri.Add(zabiljeske);

                return parametri;
                
            }

        private void btnVratiSe_Click(object sender, EventArgs e)
            {            
            this.Close();
            }

        private void ResetForme()
            {
            txtImePrezime.Text = "";
            txtDrzava.Text = "";
            txtGrad.Text = "";
            txtAdresa.Text = "";
            txtTelefon.Text = "";
            txtMobitel.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtZabiljeske.Text = "";
            }
        }
    }
