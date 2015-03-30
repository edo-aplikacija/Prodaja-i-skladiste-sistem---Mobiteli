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

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Korisnici
    {
    public partial class frmRegistracija : Form
        {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";

        private OleDbParameter korisnikID { get; set; }
        public frmRegistracija(bool spasiNovogKorisnika, bool izmijeni, bool spasi, bool obrisi)
            {
            InitializeComponent();
            btnSpasiNovogKorisnika.Enabled = spasiNovogKorisnika;
            btnIzaberi.Enabled = izmijeni;
            btnSpasi.Enabled = spasi;
            btnObrisi.Enabled = obrisi;
            }

        public frmRegistracija(bool spasiNovogKorisnika, bool izmijeni, bool spasi, bool obrisi, int korisnikID)
            {
            InitializeComponent();
            btnSpasiNovogKorisnika.Enabled = spasiNovogKorisnika;
            btnIzaberi.Enabled = izmijeni;
            btnSpasi.Enabled = spasi;
            btnObrisi.Enabled = obrisi;
            this.korisnikID = new OleDbParameter("@korisnikID", OleDbType.Integer);
            this.korisnikID.Value = korisnikID;
            }

        private void frmRegistracija_Load(object sender, EventArgs e)
            {
            
            this.korisniciTableAdapter.Fill(this.dB_PSS_PMDataSet.Korisnici);

            }

        private List<OleDbParameter> DodajParametre()
            {
            List<OleDbParameter> parametri = new List<OleDbParameter>();

            OleDbParameter korisnickoIme = new OleDbParameter("@korisnickoIme", OleDbType.VarChar);
            OleDbParameter sifra = new OleDbParameter("@sifra", OleDbType.Integer);
            OleDbParameter korisnickaUloga = new OleDbParameter("@korisnickaUloga", OleDbType.Integer);
            OleDbParameter imePrezime = new OleDbParameter("@imePrezime", OleDbType.VarChar);
            OleDbParameter kontakt = new OleDbParameter("@kontakt", OleDbType.VarChar);
            OleDbParameter email = new OleDbParameter("@email", OleDbType.VarBinary);
            OleDbParameter datumRegistracije = new OleDbParameter("@datumRegistracije", OleDbType.VarBinary);

            korisnickoIme.Value = txtKorisnickoIme.Text;
            sifra.Value = txtSifra.Text;
            korisnickaUloga.Value = cmbKorisnickaUloga.Tag;
            imePrezime.Value = txtImePrezime.Text;
            kontakt.Value = txtKontakt.Text;
            email.Value = txtEmail.Text;
            datumRegistracije.Value = System.DateTime.Now;
         
            parametri.Add(korisnickoIme);
            parametri.Add(sifra);
            parametri.Add(korisnickaUloga);
            parametri.Add(imePrezime);
            parametri.Add(kontakt);
            parametri.Add(email);
            parametri.Add(datumRegistracije);

            return parametri;
            }

        private void btnSpasiNovogKorisnika_Click(object sender, EventArgs e)
            {
            if (txtImePrezime.Text == "" | txtSifra.Text == "" | txtKorisnickoIme.Text == "" | cmbKorisnickaUloga.Text == "")
                {
                MessageBox.Show("Polja sa * su obavezna!", "Greška", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
                }
                
            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "INSERT INTO Korisnici(KorisnickoIme, Sifra, KorisnickaUloga, ImePrezime, Kontakt, Email, DatumRegistracije)"
                        + " VALUES (@korisnickoIme, @sifra, @korisnickaUloga, @imePrezime, @kontakt, @email, @datumRegistracije)";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            List<OleDbParameter> parametri = DodajParametre();
                            foreach (var parametar in parametri)
                                mojUpit.Parameters.Add(parametar);
                            mojaKonekcija.Open();
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno spašen novi korisnik", "Korisnik",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmRegistracija forma = new frmRegistracija(true, true, false, false);
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
            }

        private void btnSpasi_Click(object sender, EventArgs e)
            {
            if (txtImePrezime.Text == "" | txtSifra.Text == "" | txtKorisnickoIme.Text == "" | cmbKorisnickaUloga.Text == "")
                {
                MessageBox.Show("Polja sa * su obavezna!", "Greška", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
                }

            else
                {
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "UPDATE Korisnici SET KorisnickoIme = @korisnickoIme, Sifra = @sifra, " +
                        "KorisnickaUloga = @korisnickaUloga, ImePrezime = @imePrezime, Kontakt = @kontakt, Email = @email, DatumRegistracije = @datumRegistracije " +
                        "WHERE ProizvodID = @proizvodID";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        try
                            {
                            List<OleDbParameter> parametri = DodajParametre();
                            foreach (var parametar in parametri)
                                mojUpit.Parameters.Add(parametar);
                            mojaKonekcija.Open();
                            mojUpit.ExecuteReader();
                            MessageBox.Show("Uspješno spašen novi korisnik", "Korisnik",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmRegistracija forma = new frmRegistracija(true, true, false, false);
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
            }

        private void btnObrisi_Click(object sender, EventArgs e)
            {
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "DELETE FROM Korisnici WHERE KorisnikID = @korisnikID";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        List<OleDbParameter> parametri = DodajParametre();
                        mojUpit.Parameters.Add(korisnikID);
                        mojaKonekcija.Open();
                        mojUpit.ExecuteReader();
                        MessageBox.Show("Uspješno obrisan korisnik", "Korisnik",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmRegistracija forma = new frmRegistracija(true, true, false, false);
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

        private void btnIzaberi_Click(object sender, EventArgs e)
            {
            frmKorisnici forma = new frmKorisnici(this);
            forma.Show();
            this.Hide();
            }

        private void btnVratiSe_Click(object sender, EventArgs e)
            {
            this.Close();
            }
        }
    }
