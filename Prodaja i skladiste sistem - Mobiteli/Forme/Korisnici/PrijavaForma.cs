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
    public partial class PrijavaForma : Form
    {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";

        public PrijavaForma()
        {
            InitializeComponent();
            txbKorisnickoIme.Text = "";
            txbSifra.Text = "";
            txbKorisnickoIme.Focus();
        }

        private void btnPrijavi_Click(object sender, EventArgs e)
            {
            if (cmbUloga.Text == "")
                {
                MessageBox.Show("Molim vas izaberite Korisniču Ulogu.", "Prazno polje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUloga.Focus();
                return;
                }
            if (txbKorisnickoIme.Text == "")
                {
                MessageBox.Show("Molim vas popunite Korisničko Ime", "Prazno Polje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbKorisnickoIme.Focus();
                return;
                }
            if (txbSifra.Text == "")
                {
                MessageBox.Show("Molim vas popunite Šifru", "Prazno polje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSifra.Focus();
                return;
                }
            using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                {
                string komanda = "SELECT KorisnickaUloga, KorisnickoIme, Sifra FROM Korisnici WHERE KorisnickaUloga = @korisnickaUloga AND KorisnickoIme = @korisnickoIme AND Sifra = @sifra";
                using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                    {
                    try
                        {
                        List<OleDbParameter> parametri = DodajParametre();
                        foreach (var parametar in parametri)
                            mojUpit.Parameters.Add(parametar);
                        mojaKonekcija.Open();

                        OleDbDataReader mojReader = mojUpit.ExecuteReader(CommandBehavior.CloseConnection);

                        if (mojReader.Read() == true)
                            {
                            this.Hide();
                            GlavnaForma glavnaForma = new GlavnaForma(cmbUloga.Text, txbKorisnickoIme.Text);
                            glavnaForma.Show();
                            }
                        else
                            MessageBox.Show("Prijava nije prošla, provjerite Korisničku Ulogu, Korisničko Ime i Šifru",
                                "Prijava nije uspjela", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                
                
        }

        private List<OleDbParameter> DodajParametre()
            {
            List<OleDbParameter> parametri = new List<OleDbParameter>();

            OleDbParameter korisnickaUloga = new OleDbParameter("@korisnickaUloga", OleDbType.VarChar);
            OleDbParameter korisnickoIme = new OleDbParameter("@korisnickoIme", OleDbType.VarChar);
            OleDbParameter korisnickaSifra = new OleDbParameter("@sifra", OleDbType.VarChar);

            korisnickaUloga.Value = cmbUloga.Text;
            korisnickoIme.Value = txbKorisnickoIme.Text;
            korisnickaSifra.Value = txbSifra.Text;

            parametri.Add(korisnickaUloga);
            parametri.Add(korisnickoIme);
            parametri.Add(korisnickaSifra);

            return parametri;
            }

        private void btnOdustani_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        private void lnkPromijeniSifru_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            PromijeniSifruForma promjenaSifreForma = new PromijeniSifruForma();
            promjenaSifreForma.Show();
            this.Close();
            }

        private void lnkSifraRecovery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            SifraRecoveryForma sifraRecoveryForma = new SifraRecoveryForma();
            sifraRecoveryForma.Show();
            this.Close();
            }

         
    }
}
