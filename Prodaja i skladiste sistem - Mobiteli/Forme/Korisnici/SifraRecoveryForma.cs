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
using System.Net.Mail;

namespace Prodaja_i_skladiste_sistem___Mobiteli.Forme.Korisnici
    {
    public partial class SifraRecoveryForma : Form
        {
        String konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB_PSS_PM.accdb;";

        public SifraRecoveryForma()
            {
            InitializeComponent();
            txtKorisnickoIme.Text = "";
            txtKorisnickoIme.Focus();
            }

        private void btnPosalji_Click(object sender, EventArgs e)
            {
            if (txtKorisnickoIme.Text == "")
                {
                MessageBox.Show("Molim vas da popunite polje Korisničko Ime", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
                {
                this.Cursor = Cursors.WaitCursor;
                using (OleDbConnection mojaKonekcija = new OleDbConnection(konekcija))
                    {
                    string komanda = "SELECT * FROM Korisnici WHERE KorisnickoIme = @korisnickoIme";
                    using (OleDbCommand mojUpit = new OleDbCommand(komanda, mojaKonekcija))
                        {
                        OleDbParameter korisnickoIme = new OleDbParameter("@korisnickoIme", OleDbType.VarChar);
                        korisnickoIme.Value = txtKorisnickoIme.Text;
                        mojUpit.Parameters.Add(korisnickoIme);
                        mojUpit.Connection.Open();
                        using (OleDbDataReader mojReader = mojUpit.ExecuteReader(CommandBehavior.CloseConnection))
                            {
                            if (mojReader.Read() == true)
                                {
                                DataSet upitRezultati = new DataSet();
                                mojReader.Close();
                                OleDbDataAdapter adapter = new OleDbDataAdapter(mojUpit);
                                adapter.Fill(upitRezultati);
                                PosaljiEmail(upitRezultati);
                                PrijavaForma prijava = new PrijavaForma();
                                prijava.Show();
                                this.Close();
                                }
                            else
                                {
                                MessageBox.Show("Korisnicko Ime ne postoji.", "Greška",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                                }
                            }
                        }
                    }
            }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            }

        private void PosaljiEmail(DataSet upitRezultat)
            {
            using (MailMessage poruka = new MailMessage())
                {
                poruka.From = new MailAddress("unesisvojmail@gmail.com");
                poruka.To.Add(Convert.ToString(upitRezultat.Tables[0].Rows[0]["Email"]));
                poruka.Subject = "Šifra Recovery";
                poruka.Body = "Vaša šifra je: " + Convert.ToString(upitRezultat.Tables[0].Rows[0]["Sifra"]);
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                    {                  
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("unesisvojmail@gmail.com", "UnesiSifru");
                    smtp.EnableSsl = true;
                    try
                        {
                        smtp.Send(poruka);
                        MessageBox.Show("Poruka je poslana. Provjerite vaš Email.", "Poslan email",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    }
                
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
