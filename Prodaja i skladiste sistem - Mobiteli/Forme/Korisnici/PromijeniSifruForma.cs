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
    public partial class PromijeniSifruForma : Form
        {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";
        public PromijeniSifruForma()
            {
            InitializeComponent();
            txbKorisnickoIme.Text = "";
            txbStaraSifra.Text = "";
            txbNovaSifra.Text = "";
            txbPotvdiSifru.Text = "";
            txbKorisnickoIme.Focus();
            }

        private void btnPromijeniSifru_Click(object sender, EventArgs e)
            {
            try
                {
                if (txbKorisnickoIme.Text == "" || txbStaraSifra.Text == "" || txbNovaSifra.Text == "" || txbPotvdiSifru.Text == "")
                    {
                    MessageBox.Show("Sva polja moraju biti popunjena", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    }
                if (txbNovaSifra.Text.Length < 5)
                    {
                    MessageBox.Show("Nova šifra mora imati najmanje 5 slova/karaktera.", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    }
                if (txbStaraSifra.Text == txbNovaSifra.Text)
                    {
                    MessageBox.Show("Stara Šifra i Nova Šifra nemogu biti iste. Unesite Ponovo Novu Šifru.",
                        "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbNovaSifra.Text = "";
                    txbPotvdiSifru.Text = "";
                    txbNovaSifra.Focus();
                    return;
                    }
                if (txbNovaSifra.Text != txbPotvdiSifru.Text)
                    {
                    MessageBox.Show("Polja Nova Šifra i Potvrdi Šifru se ne slažu", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbNovaSifra.Text = "";
                    txbPotvdiSifru.Text = "";
                    txbNovaSifra.Focus();
                    return;
                    }
                OleDbConnection mojaKonekcija = new OleDbConnection(konekcija);
                OleDbCommand mojUpit = new OleDbCommand("UPDATE Korisnici SET Sifra = '" + txbPotvdiSifru.Text + "' WHERE KorisnickoIme = '" + txbKorisnickoIme.Text + "' AND Sifra = '" + txbStaraSifra.Text + "'",
                    mojaKonekcija);
                mojUpit.Connection.Open();
                if (mojUpit.ExecuteNonQuery() > 0)
                    {
                    MessageBox.Show("Šifra je uspješno promijenjena", "Šifra promijenjena",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
   
                    PrijavaForma prijava = new PrijavaForma();
                    prijava.Show();
                    mojaKonekcija.Close();
                    this.Close();
                    
                }
                else
                    {
                    MessageBox.Show("Pogrešno Korisničko Ime ili Stara Šifra", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.InitializeComponent();
                    mojaKonekcija.Close();
                    return;
                }                
            }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void btnOdustani_Click(object sender, EventArgs e)
            {
            PrijavaForma prijava = new PrijavaForma();
            prijava.Show();
            this.Close();
            }
        }
    }
